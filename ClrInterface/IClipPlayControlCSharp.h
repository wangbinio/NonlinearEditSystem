#pragma once

#include "ClipPlayControlIO.h"
#include <vcclr.h>

using namespace System;

#define _MAGICODE_CLIPPLAYCONTROL_

namespace ClrInterfaceDll
{
	/// <summary>
	/// 类说明：视频播放控件托管类
	/// 日期：2017-04-19
	/// 作者：szwb
	/// 修改：
	/// </summary>
	public ref class IClipPlayControlCSharp
	{
	public:
		IClipPlayControlCSharp();

		//void Release();

		int SetClip(String^ strFileName, IntPtr hWnd);

		int Play();

		int Pause();

		int Continue();

		int Stop();

		int GetCurState();

		long long GetDuration();

		long long GetPosition();

		int SetPosition(long long rtPos, long long rtEndPos);

	public:
		CClipPlayControlIO* m_IClipPlayControl;
	};
}