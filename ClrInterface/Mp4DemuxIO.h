#pragma once

/*///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//说明：类CMp4DemuxIO是MP4类素材的音视频分离器，提供了音视频分离的接口。为了避免DLL调用程序包含无关头文件，把所有demux的操作封装在CDemuxOper类中。
//      因此，DLL调用程序只需包含头文件“Mp4DemuxIO.h”，而不需包含其它头文件！
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// */


class CDemuxOper;//声明CDemuxOper类，然后定义类对象指针，避免包含头文件

#ifdef _MAGICODE_MP4DEMUX_
class _declspec(dllexport) CMp4DemuxIO  //导出类CMp4DemuxIO
#else
class _declspec(dllimport) CMp4DemuxIO  //导入类CMp4DemuxIO
#endif
{
public:
	CMp4DemuxIO();
	~CMp4DemuxIO();

public:

	//加载素材进行音视频分离
	//参数：
	//1、szDemuxVideoFile ---- 输出参数，分离的视频流保存文件，文件名为：当前运行目录\\_当前时刻.v
	//2、szDemuxAudioFile ---- 输出参数，分离的音频流保存文件，文件名为：当前运行目录\\_当前时刻.a
	//3、szClipFileName ---- 输入参数，素材文件全名（包括路径和文件名）
	//4、rtPos ---- 入点，如果入点为素材开始，则不用设置，直接使用缺省值0。单位：ms
	//5、rtEndPos --- 出点，如果出点为素材末尾，则不用设置，直接使用缺省值0。单位：ms
	//返回值：
	// >=0 成功 ; <0 失败
	//注意：只能加载高清MP4或H264音视频素材
	//该函数一直等到音视频分离完成或者强制退出时才返回！即返回成功，表明分离已经完成
	int AddClip(OUT TCHAR *szDemuxVideoFile, OUT TCHAR *szDemuxAudioFile,IN TCHAR *szClipFileName, IN LONGLONG rtPos = 0, IN LONGLONG rtEndPos = 0);

	//停止分离
	void Stop();

private:

	CDemuxOper             *m_pDemuxOperObj; //定义CDemuxOper类对象指针，避免包含头文件
};

