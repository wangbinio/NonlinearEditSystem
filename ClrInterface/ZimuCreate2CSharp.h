#pragma once
#include"ZimuCreateIO.h"
using namespace System;
#using "..\Bin\x64\Debug\clrZiMuModel.dll"
#include "CommDef.h"


namespace ClrInterfaceDll
{
	public ref class ZimuCreate2CSharp
	{
	public:
		//构造函数
		ZimuCreate2CSharp();

		//生成字幕数据
		int PictureZimu(String^ strFileName, clrZiMuModel::ZIMU ^mZiMu);

		//生成字幕
		int TextZimu(String^ strTextName, clrZiMuModel::FILLATTRIBclr ^cFILLATTRIBclr, clrZiMuModel::WORDATTRIBclr^cWORDATTRIBclr, clrZiMuModel::ZIMU ^mZiMu);

		//原始图片旋转
		int ZimuFromPicRotateIO(String^ strFileName, clrZiMuModel::ZIMU ^mZiMu, float angle);

		//功能：原始图片缩放，即将原始图片缩放后生成字幕
		//2、factorX --- 输入参数，宽度缩放系数（即水平方向缩放系数，不能为负值和0！）
		//3、factorY --- 输入参数，高度缩放系数（即垂直方向缩放系数，不能为负值和0！）
		int ZimuFromPicZoomIO(String^ strFileName, clrZiMuModel::ZIMU ^mZiMu, float factorX, float factorY);

		//图片镜像
		int ZimuFromPicMirrorIO(String^ strFileName, clrZiMuModel::ZIMU ^mZiMu);





		//将给定的文本生成字幕，保存到给定文件中
		//1、strTextName--- 输入参数，待生成字幕的文本串
		//2、cFILLATTRIBclr --- 输入参数，字幕填充类属性值，必须是FILLATTRIB结构体数据块！
		//3、cWORDATTRIBclr--- 输入参数，字幕字体类属性值，必须是WORDATTRIB结构体数据块！
		//4、cZIMUEXTRAATTRIBclr --- 输入参数，字幕扩展属性值，必须是ZIMUEXTRAATTRIB结构体数据块！
		//5、szSavedFile --- 输入参数，生成字幕的保存文件全名称
		//6、iMode  --- 输入参数，szSavedFile文件创建方式：0 = 新建；1=追加，打开已有文件，并把新字幕追加到该文件
		//返回值：>=0：成功; <0：失败
		int CreateZimuFileIO(String^ strTextName, clrZiMuModel::FILLATTRIBclr ^cFILLATTRIBclr, clrZiMuModel::WORDATTRIBclr^cWORDATTRIBclr,clrZiMuModel::ZIMUEXTRAATTRIBclr^cZIMUEXTRAATTRIBclr,System::String^SavedFile,int imode);

		////功能：将给定的图片生成字幕，保存到给定文件中
		////参数：
		////1、csPicFileName  --- 输入参数，待生成字幕的图片文件
		////2、pZimuAttrib --- 输入参数，字幕扩展属性值，必须是ZIMUEXTRAATTRIB结构体数据块！注意：该属性中只有播出类型、播出范围等参数有效，其它参数无意义
		////3、szSavedFile  --- 输入参数，生成字幕的保存文件全名称
		////4、iMode  --- 输入参数，szSavedFile文件创建方式：0 = 新建；1=追加，打开已有文件，并把新字幕追加到该文件
		////返回值：>=0：成功; <0：失败
		int CreateZimuFileFromPicIO(String^ strTextName, clrZiMuModel::ZIMUEXTRAATTRIBclr^cZIMUEXTRAATTRIBclr, System::String^SavedFile, int imode);


		int OpenZimuFileIO(String^ strTextName, clrZiMuModel::tagZIMUFILEHEADclr^head, System::Collections::Generic::List<clrZiMuModel::ZIMU^>^ListZimu);




	private:

		clrZiMuModel::tagZIMUFILEHEADclr^ CoverTotagZIMUFILEHEADclr(ZIMUFILEHEAD head);

		clrZiMuModel::SYSTEMTIMECtr^   CoverToSYSTEMTIMECtr(SYSTEMTIME time);

		RECT CoverToRECT(clrZiMuModel::RECTclr ^cRECTclr);

		ZIMUEXTRAATTRIB  CoverToZIMUEXTRAATTRIB(clrZiMuModel::ZIMUEXTRAATTRIBclr^cZIMUEXTRAATTRIBclr);
		FILLATTRIB CoverToFILLATTRIB(clrZiMuModel::FILLATTRIBclr ^cFILLATTRIBclr);

		WORDATTRIB CoverToWORDATTRIB(clrZiMuModel::WORDATTRIBclr^cWORDATTRIBclr);

		FILLMODE CoverToFILLMODE(clrZiMuModel::tagFILLMODEclr ^ctagFILLMODEclr);

		COLORRECORDER CoverToCOLORRECORDER(clrZiMuModel::COLORRECORDERclr ^cCOLORRECORDERclr);

		RGBQUAD CoverToRGBQUAD(clrZiMuModel::RGBA^cRGBA);

		LOG_FONT_METRIC CoverToLOG_FONT_METRIC(clrZiMuModel::LOG_FONT_METRICclr ^cLOG_FONT_METRICclr);

		LOGFONT CoverToLOGFONT(clrZiMuModel::LOGFONTclr ^LOGFONTclr);

		POINT CoverToPOINT(clrZiMuModel::POINTclr ^POINTclr);

		CZimuCreateIO *p_CZimuCreateIO;
	};

}
