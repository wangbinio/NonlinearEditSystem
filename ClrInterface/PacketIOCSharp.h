#pragma once

#include "PacketIO.h"
#include "BaseDefine.h"
#include <vcclr.h>

#using "ClrDataTypeChange.dll"
//#using "D:/szwb/Projects/NonlinearEditSystem/Bin/x64/Debug/ClrDataTypeChange.dll"

using namespace System;
using namespace ClrDataTypeChange;

//#define _MAGICODE_MP4FILESMUX_

namespace ClrInterfaceDll
{

	/// <summary>
	/// 类说明：打包综合类
	/// 日期：2017-07-20 15:02:11
	/// 作者：szwb
	/// </summary>
	public ref class PacketIOCSharp
	{
	public:

		PacketIOCSharp();

		//获取素材信息接口
		//参数：
		//1、fileName ---- 输入参数，素材文件名
		//2、fileInfo ---- 输出参数，素材信息
		//返回值：
		// >=0 成功 ; <0 失败
		int GetClipInfo(String^ fileName, tagClipInfoCLR^% fileInfo);

		//返回打包完成百分比（打包完成进度），如完成50%，则返回0.5等等。
		double GetProgress();

		///////////////////////////////////////////////////////////////
		//素材音视频分离接口   -- 开始

		//加载素材列表进行音视频分离
		//参数：
		//1、ClipList ---- 输入参数，需要分离的素材列表
		//返回值：
		// >=0 成功 ; <0 失败
		//注意：只能加载高清MP4或H264音视频素材
		//该函数一直等到音视频分离完成或者强制退出时才返回！即返回成功，表明分离已经完成
		int DemuxClips(DemuxClipInfoList^ ClipList);

		//停止分离
		void StopDemux();

		//素材音视频分离接口   -- 结束
		///////////////////////////////////////////////////////////////

		///////////////////////////////////////////////////////////////
		//解码、字幕叠加、编码等打包接口   -- 开始
		int PacketingInitial(ZimuMixInfoList^ ZimuList);//打包初始化，必须在打包前调用一次，且仅调用一次！

							   //打包
							   //返回值：
							   // >=0 成功 ; <0 失败
		int PacketStart();

		//停止打包
		void PacketStop();

		//判断打包是否完成
		bool PacketIsFinish();

		//解码、字幕叠加、编码等打包接口   -- 结束
		///////////////////////////////////////////////////////////////

		///////////////////////////////////////////////////////////////
		//音视频文件混合接口   -- 开始
		//将编码生成的音视频文件进行混合
		//参数：
		//szOutputFilename ---- 输入参数，混合后保存文件名（包括路径和文件名）
		//返回值：
		// >=0 成功 ; <0 失败
		//注意：
		//1、只能加载已经压缩的高清MP4或H264音视频源文件；
		//2、返回成功，混合不一定结束。是否结束需要调用MuxerFinished函数判断
		//3、必须在编码完成后才可以进行混合！
		int MuxerStart(String^ szOutputFilename);

		//停止混合
		void MuxerStop();

		//判断混合是否完成
		bool MuxerIsFinish();

		//音视频文件混合接口   -- 结束
		///////////////////////////////////////////////////////////////

		///////////////////////////////////////////////////////////////
		//字幕叠加接口   -- 开始

		//加载叠加的字幕
		//参数：
		//1、ZimuList ---- 输入参数，需要叠加的字幕列表
		//返回值：
		// >=0 成功 ; <0 失败
		// int MixZimu(ZimuMixInfoList^ ZimuList);

		//字幕叠加接口   -- 结束
		///////////////////////////////////////////////////////////////

		//tagClipInfoCLR ConvertTotagClipInfoCLR(ClipInfo cClipInfo);

		ClipInfo ConvertToClipInfo(tagClipInfoCLR^ ctagClipInfoCLR);

		DemuxClipInfo ConvertToDemuxClipInfo(tagDemuxClipInfoCLR^ ctagDemuxClipInfoCLR);

		ZimuMixInfo ConvertToZimuMixInfo(tagZimuMixInfoCLR^ ctagZimuMixInfo);


	private:
		CPacketIO* m_CPacketIO;

	};
}