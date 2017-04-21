#pragma once

#include "ClipPlayControlIO.h"
#include <vcclr.h>

using namespace System;

#define _MAGICODE_CLIPPLAYCONTROL_

namespace ClrInterfaceDll
{
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