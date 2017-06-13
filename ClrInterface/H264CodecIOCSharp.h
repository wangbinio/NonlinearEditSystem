#pragma once

#include "H264CodecIO.h"
#include <vcclr.h>

#using "ClrDataTypeChange.dll"

using namespace System;
using namespace ClrDataTypeChange;


//#define _MAGICODE_H264CODEC_

namespace ClrInterfaceDll
{

	/// <summary>
	/// 类说明：视频编解码类
	/// 日期：2017-06-06 10:50:33
	/// 作者：szwb
	/// </summary>
	public ref class H264CodecIOCSharp
	{
	public:
		H264CodecIOCSharp();

		//启动打包：加载分离的h264视频，解码，字幕叠加，编码，输出编码后的h264视频
		//参数：
		//2、szInH264VideoFileList ---- 输入参数，分离的h264视频文件全名（包括路径和文件名）列表
		//3、szOutH264FileName ---- 输入参数，编码后的h264视频文件名（包括路径和文件名）
		//返回值：
		// >=0 成功 ; <0 失败
		//int Start(System::Collections::Generic::List<String^> strInH264VideoFileList, String^% strOutH264FileName);
		int Start(StringList^ strInH264VideoFileList, String^% strOutH264FileName);


		//启动音频解码编码：加载分离的AAC音频，解码，编码，输出编码后的AAC音频
		//参数：
		//1、szInH264VideoFileList ---- 输入参数，分离的h264视频文件全名（包括路径和文件名）列表
		//2、szOutH264FileName ---- 输入参数，编码后的h264视频文件名（包括路径和文件名）
		//返回值：
		// >=0 成功 ; <0 失败
		//int StartAACDecEncoder(System::Collections::Generic::List<String^> strInAacFileList, String^% strOutAacFileName);
		int StartAACDecEncoder(StringList^ strInAacFileList, String^% strOutAacFileName);


		//停止打包
		void Stop();


		//打包是否完成
		bool isFinish();


	private:
		CH264CodecIO* m_H264CodecIOCSharp;
	};
}