#pragma once

#include "ClipPlayControlIO.h"
#include <vcclr.h>

using namespace System;

//#define _MAGICODE_CLIPPLAYCONTROL_

namespace ClrInterfaceDll
{
	/// <summary>
	/// 类说明：视频播放控件托管类
	/// 日期：2017-04-19
	/// 作者：szwb
	/// 修改：2017-05-19		添加注释
	/// </summary>
	public ref class ClipPlayControlCSharp
	{
	public:
		ClipPlayControlCSharp();

		//void Release();

		//加载播控素材
		//参数：
		//1、szClipFileName ---- 输入参数，素材文件全名（包括路径和文件名）
		//2、hWnd ---- 输入参数，素材预览窗口句柄
		//返回值：
		// S_OK ----- 加载成功；否则加载失败
		//注意：只能加载高清MP4或H264音视频素材
		int SetClip(String^ strFileName, IntPtr hWnd);

		// 返回set的素材
		String^ GetClip();

		/////////////////////////////////////////////////////
		//素材播控接口
		//播放
		//返回值：S_OK = 成功；否则 失败
		int Play();

		//暂停
		//返回值：S_OK = 成功；否则 失败
		int Pause();

		//从暂停恢复播放
		//返回值：S_OK = 成功；否则 失败
		int Continue();

		//停止
		//返回值：S_OK = 成功；否则 失败
		int Stop();
		/////////////////////////////////////////////////////

		//获取当前播放状态
		//返回值：
		//	0 = 正在运行；1=暂停；2=停止；3=关闭；
		// 返回-1时，表示出错了！
		int GetCurState();

		//获取素材时长
		//返回值：素材时长，单位：100ns;
		// 返回-1时，表示出错了！
		long long GetDuration();

		//获取当前播放位置
		//返回值：当前播放位置，单位：100ns
		// 返回-1时，表示出错了！
		long long GetPosition();

		//设置入点、出点或当前播出位置
		//参数：
		//  rtPos ---- 入点或当前播出位置，单位：100ns
		//  rtEndPos --- 出点，如果出点为素材末尾，则不用设置，直接使用缺省值0，单位：100ns
		//返回值：S_OK = 成功；否则 失败
		int SetPosition(long long rtPos, long long rtEndPos);

	private:
		CClipPlayControlIO* m_IClipPlayControl;

		String^ _strFileName;
	};
}