#pragma once

/*///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//说明：类CZimuCreateIO是字幕生成DLL，提供了字幕生成接口。为了避免DLL调用程序包含无关头文件，把所有字幕生成操作封装在CZimuCreateOper类中。
//      因此，DLL调用程序只需包含头文件“ZimuCreateIO.h”，而不需包含其它头文件！
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// */

class CZimuCreateOper;//声明CZimuCreateOper类，然后定义类对象指针，避免包含头文件

class CDirectWordObject;

#include <vector>
using namespace std;

#ifdef _MAGICODE_ZIMUCREATE_
class _declspec(dllexport) CZimuCreateIO  //导出类CZimuCreateIO
#else
class _declspec(dllimport) CZimuCreateIO  //导入类CZimuCreateIO
#endif
{
public:
	CZimuCreateIO();
	~CZimuCreateIO();

public:
	
	//---- 图片字幕接口 Begin -----//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	//功能：生成图片字幕，即从图片文件生成字幕
	//参数：
	//1、csPicFile --- 输入参数，图片文件名，支持的图片文件格式包括：*.bmp;*.gif;*.jpg;*.jpeg;*.png;*.ico;*.tif;*.tiff;*.tga;*.pcx;*.wbmp;*.wmf;*.emf;*.j2k;*.jp2;*.jbg;*.j2c;*.jpc;*.pgx;*.pnm;*.pgm;*.ppm;*.ras;*.mng;*.jng;*.ska;*.nef;*.crw;*.cr2;*.mrw;*.raf;*.erf;*.3fr;*.dcr;*.raw;*.dng;*.pef;*.x3f;*.arw;*.sr2;*.mef;*.orf;*.psd等
	//2、pPicture --- 生成的字幕数据块，由调用程序管理数据块内存，包括分配和释放内存
	//3、bmw  --- 输出参数，生成字幕的宽度
	//4、bmh --- 输出参数，生成字幕的高度
	//返回值：成功返回 >= 0整数；失败返回<0整数
	//函数调用说明：生成图片字幕需要连续2次调用本函数，第一次pPicture传入NULL，获取bmw、bmh值；然后new出pPicture，第二次调用该函数，生成字幕数据
	int PictureZimuIO(IN const TCHAR *csPicFile, OUT ULONG *pPicture, OUT ULONG &bmw, OUT ULONG &bmh);

	//功能：原始图片旋转，即旋转原始图片后生成字幕
	//参数：
	//1、csOrigPicFile --- 输入参数，原始图片文件名，支持的图片文件格式包括：*.bmp;*.gif;*.jpg;*.jpeg;*.png;*.ico;*.tif;*.tiff;*.tga;*.pcx;*.wbmp;*.wmf;*.emf;*.j2k;*.jp2;*.jbg;*.j2c;*.jpc;*.pgx;*.pnm;*.pgm;*.ppm;*.ras;*.mng;*.jng;*.ska;*.nef;*.crw;*.cr2;*.mrw;*.raf;*.erf;*.3fr;*.dcr;*.raw;*.dng;*.pef;*.x3f;*.arw;*.sr2;*.mef;*.orf;*.psd等
	//2、angle --- 输入参数，旋转角度（单位：度），可以为正负数，负数表示逆时针旋转
	//3、pPicture --- 生成的字幕数据块，由调用程序管理数据块内存，包括分配和释放内存
	//4、bmw  --- 输出参数，生成字幕的宽度
	//5、bmh --- 输出参数，生成字幕的高度
	//返回值：成功返回 >= 0整数；失败返回<0整数
	//函数调用说明：生成图片字幕需要连续2次调用本函数，第一次pPicture传入NULL，获取bmw、bmh值；然后new出pPicture，第二次调用该函数，生成字幕数据
	int ZimuFromPicRotateIO(IN const TCHAR *csOrigPicFile, IN float angle, OUT ULONG *pPicture, OUT ULONG &bmw, OUT ULONG &bmh);

	//功能：原始图片缩放，即将原始图片缩放后生成字幕
	//参数：
	//1、csOrigPicFile --- 输入参数，原始图片文件名，支持的图片文件格式包括：*.bmp;*.gif;*.jpg;*.jpeg;*.png;*.ico;*.tif;*.tiff;*.tga;*.pcx;*.wbmp;*.wmf;*.emf;*.j2k;*.jp2;*.jbg;*.j2c;*.jpc;*.pgx;*.pnm;*.pgm;*.ppm;*.ras;*.mng;*.jng;*.ska;*.nef;*.crw;*.cr2;*.mrw;*.raf;*.erf;*.3fr;*.dcr;*.raw;*.dng;*.pef;*.x3f;*.arw;*.sr2;*.mef;*.orf;*.psd等
	//2、factorX --- 输入参数，宽度缩放系数（即水平方向缩放系数，不能为负值和0！）
	//3、factorY --- 输入参数，高度缩放系数（即垂直方向缩放系数，不能为负值和0！）
	//4、pPicture --- 生成的字幕数据块，由调用程序管理数据块内存，包括分配和释放内存
	//5、bmw  --- 输出参数，生成字幕的宽度
	//6、bmh --- 输出参数，生成字幕的高度
	//返回值：成功返回 >= 0整数；失败返回<0整数
	//函数调用说明：生成图片字幕需要连续2次调用本函数，第一次pPicture传入NULL，获取bmw、bmh值；然后new出pPicture，第二次调用该函数，生成字幕数据
	int ZimuFromPicZoomIO(IN const TCHAR *csOrigPicFile, IN float factorX, IN float factorY, OUT ULONG *pPicture, OUT ULONG &bmw, OUT ULONG &bmh);

	//功能：原始图片镜像，即将原始图片镜像后生成字幕
	//参数：
	//1、csOrigPicFile --- 输入参数，原始图片文件名，支持的图片文件格式包括：*.bmp;*.gif;*.jpg;*.jpeg;*.png;*.ico;*.tif;*.tiff;*.tga;*.pcx;*.wbmp;*.wmf;*.emf;*.j2k;*.jp2;*.jbg;*.j2c;*.jpc;*.pgx;*.pnm;*.pgm;*.ppm;*.ras;*.mng;*.jng;*.ska;*.nef;*.crw;*.cr2;*.mrw;*.raf;*.erf;*.3fr;*.dcr;*.raw;*.dng;*.pef;*.x3f;*.arw;*.sr2;*.mef;*.orf;*.psd等
	//2、pPicture --- 生成的字幕数据块，由调用程序管理数据块内存，包括分配和释放内存
	//3、bmw  --- 输出参数，生成字幕的宽度
	//4、bmh --- 输出参数，生成字幕的高度
	//返回值：成功返回 >= 0整数；失败返回<0整数
	//函数调用说明：生成图片字幕需要连续2次调用本函数，第一次pPicture传入NULL，获取bmw、bmh值；然后new出pPicture，第二次调用该函数，生成字幕数据
	int ZimuFromPicMirrorIO(IN const TCHAR *csOrigPicFile, OUT ULONG *pPicture, OUT ULONG &bmw, OUT ULONG &bmh);


	//功能：原始图片裁剪，即截取原始图片中给定区域后生成字幕
	//参数：
	//1、csOrigPicFile --- 输入参数，原始图片文件名，支持的图片文件格式包括：*.bmp;*.gif;*.jpg;*.jpeg;*.png;*.ico;*.tif;*.tiff;*.tga;*.pcx;*.wbmp;*.wmf;*.emf;*.j2k;*.jp2;*.jbg;*.j2c;*.jpc;*.pgx;*.pnm;*.pgm;*.ppm;*.ras;*.mng;*.jng;*.ska;*.nef;*.crw;*.cr2;*.mrw;*.raf;*.erf;*.3fr;*.dcr;*.raw;*.dng;*.pef;*.x3f;*.arw;*.sr2;*.mef;*.orf;*.psd等
	//2、area --- 输入参数，裁剪区域，注意：不能超过原始图片大小
	//3、pPicture --- 生成的字幕数据块，由调用程序管理数据块内存，包括分配和释放内存
	//4、bmw  --- 输出参数，生成字幕的宽度
	//5、bmh --- 输出参数，生成字幕的高度
	//返回值：成功返回 >= 0整数；失败返回<0整数
	//函数调用说明：生成图片字幕需要连续2次调用本函数，第一次pPicture传入NULL，获取bmw、bmh值；然后new出pPicture，第二次调用该函数，生成字幕数据
	int ZimuFromPicCropIO(IN const TCHAR *csOrigPicFile, IN RECT &area, OUT ULONG *pPicture, OUT ULONG &bmw, OUT ULONG &bmh);
	//---- 图片字幕接口 End -----////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


	//---- 文本字幕基本接口 Begin -----//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	//说明：
	//1、以下三个接口实现从文本生成字幕功能：将给定的文本内容（csContent）和文本属性（FillAttrib，WordAttrib）生成静态纯文本字幕，即不包含背景、运动（如左飞、上滚、特效等）
	//2、接口调用三步骤：第一步，首先调用StartTxtZimuIO接口启动字幕；第二步，第一步成功返回后再调用GetTxtZimuSizeIO接口获取字幕宽（uWidth）、高（uHeight）；
	//   第三步，第二步成功返回后，调用者生成uWidth*uHeight*4字节的内存块（注意：该内存块的释放也由调用者负责！），然后调用GetTxtZimuBuffIO接口获取字幕数据，返回的字幕数据格式为RGBQUAD。

	//接口1：启动字幕接口
	//功能：启动文本字幕生成，返回字幕生成类对象指针(CDirectWordObject对象指针)
	//参数：
	//1、pFillAttrib --- 输入参数，字幕填充类属性值，必须是FILLATTRIB结构体数据块！
	//2、pWordAttrib --- 输入参数，字幕字体类属性值，必须是WORDATTRIB结构体数据块！
	//3、csContent  --- 输入参数，待生成字幕的文本串
	//4、uDis  --- 输入参数，相邻两个字幕之间的间距
	//5、iFlag  --- 输入参数，字幕类型标志，取值为： 0 = 左飞字幕、1=上滚字幕、2=其它字幕等
	//返回值：成功返回CDirectWordObject对象指针；失败返回NULL
	CDirectWordObject *StartTxtZimuIO(IN BYTE *pFillAttrib, IN BYTE *pWordAttrib, IN TCHAR *csContent, IN ULONG uDis = 0, IN int iFlag = 0);

	//接口2：获取生成字幕尺寸接口
	//功能：获取已经生成的字幕缓存大小
	//返回值：>=0：成功; <0：失败
	//参数：
	// 1、pZimuObj ---- 输入参数，字幕对象指针，必须是StartTxtZimuIO接口返回指针！
	// 2、uWidth ---- 输出参数,生成的字幕宽度
	// 3、uHeight ----- 输出参数,生成的字幕高度
	int GetTxtZimuSizeIO(IN CDirectWordObject *pZimuObj, OUT ULONG &uWidth, OUT ULONG &uHeight);

	//接口3：获取生成字幕数据接口
	//功能：获取已经生成的字幕数据
	//返回值：>=0：成功; <0：失败
	//参数：
	// 1、pZimuObj ---- 输入参数，字幕对象指针，必须是StartTxtZimuIO接口返回指针！
	// 2、pBuff ---- 输出参数,生成字幕缓存，需要调用者分配和释放内存
	int GetTxtZimuBuffIO(IN CDirectWordObject *pZimuObj, OUT RGBQUAD *pBuff);
	//---- 文本字幕基本接口 End -----////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


	//---- 字幕扩展接口 Begin -----//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	//功能：将给定的文本生成字幕，保存到给定文件中
	//参数：
	//1、csContentStr  --- 输入参数，待生成字幕的文本串
	//2、pFillAttrib --- 输入参数，字幕填充类属性值，必须是FILLATTRIB结构体数据块！
	//3、pWordAttrib --- 输入参数，字幕字体类属性值，必须是WORDATTRIB结构体数据块！
	//4、pZimuAttrib --- 输入参数，字幕扩展属性值，必须是ZIMUEXTRAATTRIB结构体数据块！
	//5、szSavedFile  --- 输入参数，生成字幕的保存文件全名称
	//6、iMode  --- 输入参数，szSavedFile文件创建方式：0 = 新建；1=追加，打开已有文件，并把新字幕追加到该文件
	//返回值：>=0：成功; <0：失败
	int CreateZimuFileIO(IN const TCHAR *csContentStr, IN BYTE *pFillAttrib, IN BYTE *pWordAttrib, IN BYTE *pZimuAttrib, IN TCHAR *szSavedFile, IN int iMode = 0);

	//功能：将给定的图片生成字幕，保存到给定文件中
	//参数：
	//1、csPicFileName  --- 输入参数，待生成字幕的图片文件
	//2、pZimuAttrib --- 输入参数，字幕扩展属性值，必须是ZIMUEXTRAATTRIB结构体数据块！注意：该属性中只有播出类型、播出范围等参数有效，其它参数无意义
	//3、szSavedFile  --- 输入参数，生成字幕的保存文件全名称
	//4、iMode  --- 输入参数，szSavedFile文件创建方式：0 = 新建；1=追加，打开已有文件，并把新字幕追加到该文件
	//返回值：>=0：成功; <0：失败
	int CreateZimuFileFromPicIO(IN const TCHAR *csPicFileName, IN BYTE *pZimuAttrib, IN TCHAR *szSavedFile, IN int iMode = 0);

	//功能：打开字幕文件，输出文件头信息和帧数据
	//参数：
	//1、ZimuFileName  --- 输入参数，待打开的字幕文件
	//2、phead --- 输出参数，字幕文件头信息，必须是ZIMUFILEHEAD结构体数据块！
	//3、pFrameArr --- 输出参数，字幕文件中所有帧数据列表（一帧一个节点的帧数据列表！）
	//返回值：>=0：成功; <0：失败
	//注意：该函数调用完成后必须调用ReleaseMemoryIO（）释放资源，否则将导致内存泄漏！
	int OpenZimuFileIO(IN const TCHAR *ZimuFileName, OUT BYTE *phead, OUT std::vector<RGBQUAD *> *pFrameArr);

	//功能：释放OpenZimuFileIO（）接口中使用的资源，必须在OpenZimuFileIO（）调用结束后调用本接口释放资源！
	//参数：OpenZimuFileIO（）接口中输出的帧数据列表
	void ReleaseMemoryIO(IN std::vector<RGBQUAD *> *pFrameArr);
	//---- 字幕扩展接口 End -----////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	
private:

	CZimuCreateOper             *m_pZimuCreateOperObj; //定义CZimuCreateOper类对象指针，避免包含头文件
};

