#pragma once

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
	//2、hWnd ---- 输入参数，素材预览窗口句柄
	//返回值：
	// S_OK ----- 加载成功；否则加载失败
	//注意：只能加载高清MP4或H264音视频素材
	HRESULT SetClip(IN TCHAR *szClipFileName, IN HWND hWnd);


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



private:

	CGraphOper             *m_pGraphOperObj; //定义CGraphOper类对象指针，避免包含头文件
};

