#pragma once

#include "Mp4FilesMuxIO.h"
#include <vcclr.h>

#using "ClrDataTypeChange.dll"

using namespace System;
using namespace ClrDataTypeChange;

//#define _MAGICODE_MP4FILESMUX_

namespace ClrInterfaceDll
{

	/// <summary>
	/// 类说明：音视频混合类
	/// 日期：2017-06-06 15:02:11
	/// 作者：szwb
	/// </summary>
	public ref class Mp4FilesMuxIOCSharp
	{
	public:

		Mp4FilesMuxIOCSharp();


		//加载待混合的音视频文件进行混合
		//参数：
		//1、strInH264FileList ---- 输入参数，待混合的音视频文件名列表（文件名包括路径和文件名）。
		//2、stroutput_filename ---- 输入参数，混合后保存文件名（包括路径和文件名）
		//返回值：
		// >=0 成功 ; <0 失败
		//注意：
		//1、只能加载已经压缩的高清MP4或H264音视频源文件；
		//2、待混合的音视频文件个数，最多支持MAX_INPUT_FILES个音视频文件
		//3、返回成功，混合不一定结束。是否结束需要调用MuxerFinished函数判断
		//int StartMuxer(System::Collections::Generic::List<String^> strInH264FileList, String^% stroutput_filename);
		int StartMuxer(StringList^ strInH264FileList, String^ stroutput_filename);


		//停止混合
		void StopMuxer();


		//混合是否已经结束
		bool MuxerFinished();

	private:
		CMp4FilesMuxIO* m_CMp4FilesMuxIO;
	};
}