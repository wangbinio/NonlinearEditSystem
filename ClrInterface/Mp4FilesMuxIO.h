#pragma once

/*///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//说明：类CMp4FilesMuxIO是MP4/AVC/AAC音视频文件混合插件，提供了已经压缩的MP4/AVC/AAC音视频文件的混合接口。为了避免DLL调用程序包含无关头文件，把所有Muxer的操作封装在CMuxerOper类中。
//      因此，DLL调用程序只需包含头文件“Mp4EncoderIO.h”，而不需包含其它头文件！
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// */

#include <vector>
using namespace std;

class CMuxerOper;//声明CMuxerOper类，然后定义类对象指针，避免包含头文件

#ifdef _MAGICODE_MP4FILESMUX_
class _declspec(dllexport) CMp4FilesMuxIO  //导出类CMp4FilesMuxIO
#else
class _declspec(dllimport) CMp4FilesMuxIO  //导入类CMp4FilesMuxIO
#endif
{
public:
	CMp4FilesMuxIO();
	~CMp4FilesMuxIO();

public:

	////加载待混合的音视频文件进行混合
	////参数：
	////1、input_streams ---- 输入参数，待混合的音视频文件个数，最多支持MAX_INPUT_FILES个音视频文件
	////2、input_filenames ---- 输入参数，待混合的音视频文件全名（包括路径和文件名）
	////3、output_filename ---- 输入参数，混合后保存文件名（包括路径和文件名）
	////返回值：
	//// >=0 成功 ; <0 失败
	////注意：只能加载已经压缩的高清MP4或H264音视频源文件
	//int StartMuxer(int input_streams,IN TCHAR(*input_filenames)[MAX_PATH], IN TCHAR *output_filename);

	//加载待混合的音视频文件进行混合
	//参数：
	//1、szInH264FileList ---- 输入参数，待混合的音视频文件名列表（文件名包括路径和文件名）。
	//2、output_filename ---- 输入参数，混合后保存文件名（包括路径和文件名）
	//返回值：
	// >=0 成功 ; <0 失败
	//注意：
	//1、只能加载已经压缩的高清MP4或H264音视频源文件；
	//2、待混合的音视频文件个数，最多支持MAX_INPUT_FILES个音视频文件
	//3、返回成功，混合不一定结束。是否结束需要调用MuxerFinished函数判断
	int StartMuxer(IN vector<TCHAR *> szInH264FileList, IN TCHAR *output_filename);

	//停止混合
	void StopMuxer();

	BOOL MuxerFinished();//混合是否已经结束

private:

	CMuxerOper             *m_pMuxerOperObj; //定义CMuxerOper类对象指针，避免包含头文件
};