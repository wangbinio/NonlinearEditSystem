#pragma once

#include "Mp4DemuxIO.h"
#include <vcclr.h>

using namespace System;

//#define  _MAGICODE_MP4DEMUX_

namespace ClrInterfaceDll
{

	/// <summary>
	/// 类说明：音视频分离类
	/// 日期：2017-06-06 11:48:06
	/// 作者：szwb
	/// </summary>
	public ref class Mp4DemuxIOCSharp
	{
	public:

		Mp4DemuxIOCSharp();


		//加载素材进行音视频分离
		//参数：
		//1、strDemuxVideoFile ---- 输出参数，分离的视频流保存文件，文件名为：当前运行目录\\_当前时刻.v
		//2、strDemuxAudioFile ---- 输出参数，分离的音频流保存文件，文件名为：当前运行目录\\_当前时刻.a
		//3、strClipFileName ---- 输入参数，素材文件全名（包括路径和文件名）
		//4、rtPos ---- 入点，如果入点为素材开始，则不用设置，直接使用缺省值0。单位：ms
		//5、rtEndPos --- 出点，如果出点为素材末尾，则不用设置，直接使用缺省值0。单位：ms
		//返回值：
		// >=0 成功 ; <0 失败
		//注意：只能加载高清MP4或H264音视频素材
		//该函数一直等到音视频分离完成或者强制退出时才返回！即返回成功，表明分离已经完成
		int AddClip(String^% strDemuxVideoFile, String^% strDemuxAudioFile, String^ strClipFileName, long long  rtPos, long long  rtEndPos);


		//停止分离
		void Stop();

	private:
		CMp4DemuxIO* m_CMp4DemuxIO;
	};
}