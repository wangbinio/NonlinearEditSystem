#pragma once
#include <vector>
//#include "BaseDefine.h"
using namespace std;

//预览字幕信息结构定义  --- 开始
//说明：
//该结构用于非线性编辑过程中素材预览时的字幕叠加
//注意：预览素材只有一个，但字幕允许有多个，且字幕可能是本预览素材独有字幕，也可能是延续字幕（即上一个预览素材未播完延续到本预览素材的字幕，或者本预览素材播不完需要延续到下一个预览素材的字幕）等。
//字段说明：
//1、rtStartPos和rtStopPos是字幕在本预览素材中的开始和结束时间，它们的参考时间为：本预览素材入点时间为0！需要根据播出需要正确设置其值，保证：rtStopPos >= rtStartPos >= 0；  
//2、duration是字幕总播出时长，start是字幕在本预览素材中的开始时刻，start必须是duration范围内某个时间。这两个字段是延续字幕叠加播出需要的字段。
//typedef struct tagZimuPreviewInfo
//{
//	TCHAR       szZimuFile[MAX_PATH];//字幕文件名
//
//
//	LONGLONG    rtStartPos;//在预览素材中的开始时间（单位：ms）
//	LONGLONG    rtStopPos;//在预览素材中的结束时间（单位：ms）
//
//	LONGLONG    duration;//字幕总播出时长（单位：ms）
//	LONGLONG    start;//字幕在预览素材中的开始时刻（单位：ms）
//
//	unsigned int Level;//字幕层次，当多层字幕时，上一层字幕将遮挡下一层字幕；数字越小表示层次越高，即0表示最顶层；1表示第二//层，以此类推。
//}ZimuPreviewInfo;
//预览字幕信息结构定义  --- 结束

typedef struct tagZimuMixInfo
{
	TCHAR       szZimuFile[MAX_PATH];//字幕文件名
	LONGLONG    rtStartPos;//开始时间（单位：ms）
	LONGLONG    rtStopPos;//结束时间（单位：ms）

						  //unsigned int Type;//字幕类型，0 = 静态字幕；1=左飞；2=上滚
	unsigned int Level;//字幕层次，当多层字幕时，上一层字幕将遮挡下一层字幕；数字越小表示层次越高，即0表示最顶层；1表示第二层，以此类推。
}ZimuMixInfo;

/*///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//说明：类CClipPlayControlIO是播控插件导出类，提供了所有播控接口。为了避免DLL调用程序包含无关头文件，把所有Graph的操作封装在CGraphOper类中。
//      即CGraphOper封装了DirectShow的Graph所有操作。
//      因此，DLL调用程序只需包含头文件“ClipPlayControlIO.h”，而不需包含DirectShow有关头文件！
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// */

class CGraphOper;//声明CGraphOper类，然后定义类对象指针，避免包含头文件

#ifdef _MAGICODE_CLIPPLAYCONTROL_
class _declspec(dllexport) CClipPlayControlIO  //导出类CClipPlayControlIO
#else
class _declspec(dllimport) CClipPlayControlIO  //导入类CClipPlayControlIO
#endif
{
public:
	CClipPlayControlIO();
	~CClipPlayControlIO();

public:	
	
	//加载播控素材
	//参数：
	//1、szClipFileName ---- 输入参数，素材文件全名（包括路径和文件名）
	//2、ZimuList ---- 输入参数，需要叠加的字幕列表
	//3、hWnd ---- 输入参数，素材预览窗口句柄
	//返回值：
	// S_OK ----- 加载成功；否则加载失败
	//注意：
	//1、只能加载高清MP4或H264音视频素材
	//2、CClipPlayControlIO提供的其它所有接口都是在SetClip成功返回后才有效的！
	HRESULT SetClip(IN TCHAR *szClipFileName, vector<ZimuMixInfo> &ZimuList, IN HWND hWnd);


	/////////////////////////////////////////////////////
	//素材播控接口
	//播放
	//返回值：S_OK = 成功；否则 失败
	HRESULT Play();

	//暂停
	//返回值：S_OK = 成功；否则 失败
	HRESULT Pause();

	//从暂停恢复播放
	//返回值：S_OK = 成功；否则 失败
	HRESULT Continue();

	//停止
	//返回值：S_OK = 成功；否则 失败
	HRESULT Stop() ;

	//拖动素材到指定位置
	//参数：
	//  rtPos ---- 输入参数，指定位置的时间，单位：100ns
	HRESULT SetGivenPosition(LONGLONG rtPos);
	/////////////////////////////////////////////////////


	/////////////////////////////////////////////////////
	//播控状态接口

	//获取当前播放状态
	//返回值：
	//	0 = 正在运行；1=暂停；2=停止；3=关闭；
	// 返回-1时，表示出错了！
	int GetCurState();

	//获取素材时长
	//返回值：素材时长，单位：100ns;
	// 返回-1时，表示出错了！
	LONGLONG GetDuration();

	//获取当前播放位置
	//返回值：当前播放位置，单位：100ns
	// 返回-1时，表示出错了！
	LONGLONG	GetPosition();

	//设置入点、出点或当前播出位置
	//参数：
	//  rtPos ---- 入点或当前播出位置，单位：100ns
	//  rtEndPos --- 出点，如果出点为素材末尾，则不用设置，直接使用缺省值0，单位：100ns
	//返回值：S_OK = 成功；否则 失败
	HRESULT SetPosition(LONGLONG rtPos, LONGLONG rtEndPos = 0);

	/////////////////////////////////////////////////////

	//保存指定帧图像为BMP文件
	//参数：
	//1、szBmpFileName ---- 输入参数，Bmp图像文件全名（包括路径和文件名）
	//2、rtPos ---- 输入参数，待保存的帧图像所在时刻，单位：100ns
	//说明：保存的图片为24位1920*1080大小的BMP图
	void SaveGivenFrameToBmp(TCHAR *szBmpFileName, LONGLONG rtPos = 0);

private:

	CGraphOper             *m_pGraphOperObj; //定义CGraphOper类对象指针，避免包含头文件
};

