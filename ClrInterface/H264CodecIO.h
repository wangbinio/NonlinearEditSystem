#pragma once

#include <vector>
using namespace std;

/*///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//说明：类CH264CodecIO实现基于共享内存的MP4/AVC高清视频解码、字幕叠加、编码功能

//      为了避免DLL调用程序包含无关头文件，把所有Decoder、Encoder操作封装在CDecoderOper、CEncoderOper类中。
//      因此，DLL调用程序只需包含头文件“H264CodecIO.h”，而不需包含其它头文件！
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// */


class CDecoderOper;//声明CDecoderOper类，然后定义类对象指针，避免包含头文件
class CEncoderOper;//声明CEncoderOper类，然后定义类对象指针，避免包含头文件

class CAacDecOper;//声明CAacDecOper类，然后定义类对象指针，避免包含头文件
class CAacEncOper;//声明CAacEncOper类，然后定义类对象指针，避免包含头文件

#ifdef _MAGICODE_H264CODEC_
class _declspec(dllexport) CH264CodecIO  //导出类CH264CodecIO
#else
class _declspec(dllimport) CH264CodecIO  //导入类CH264CodecIO
#endif
{
public:
	CH264CodecIO();
	~CH264CodecIO();

public:

	//启动打包：加载分离的h264视频，解码，字幕叠加，编码，输出编码后的h264视频
	//参数：
	//2、szInH264VideoFileList ---- 输入参数，分离的h264视频文件全名（包括路径和文件名）列表
	//3、szOutH264FileName ---- 输入参数，编码后的h264视频文件名（包括路径和文件名）
	//返回值：
	// >=0 成功 ; <0 失败
	int Start(IN vector<TCHAR *> *szInH264VideoFileList, IN TCHAR *szOutH264FileName);


	//启动音频解码编码：加载分离的AAC音频，解码，编码，输出编码后的AAC音频
	//参数：
	//1、szInH264VideoFileList ---- 输入参数，分离的h264视频文件全名（包括路径和文件名）列表
	//2、szOutH264FileName ---- 输入参数，编码后的h264视频文件名（包括路径和文件名）
	//返回值：
	// >=0 成功 ; <0 失败
	int StartAACDecEncoder(IN vector<TCHAR *> *szInAacFileList, IN TCHAR *szOutAacFileName);


	//停止打包
	void Stop();

	//打包是否完成
	BOOL isFinish();

private:

	CDecoderOper             *m_pDecoderOperObj; //定义CDecoderOper类对象指针，避免包含头文件

	CEncoderOper             *m_pEncoderOperObj; //定义CEncoderOper类对象指针，避免包含头文件

	CAacDecOper              *m_pAacDecoderOperObj; //定义CAacDecOper类对象指针，避免包含头文件

	CAacEncOper              *m_pAacEncoderOperObj; //定义CAacEncOper类对象指针，避免包含头文件

};

