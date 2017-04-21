#include "stdafx.h"
#include <msclr\marshal.h>
#include <string>
#include "IClipPlayControlCSharp.h"

using namespace msclr::interop;
using namespace System::Runtime::InteropServices;
using namespace ClrInterfaceDll;


IClipPlayControlCSharp::IClipPlayControlCSharp()
{
	m_IClipPlayControl = new CClipPlayControlIO();
}

//void IClipPlayControlCSharp::Release()
//{
//	return m_IClipPlayControl->Release();
//}

int IClipPlayControlCSharp::SetClip(String^ strFileName, IntPtr hWnd)
{
	//void * phWnd = hWnd->ToPointer();

	//HWND iHwnd = (HWND)(hWnd.ToPointer());
	HWND iHwnd = (HWND)hWnd.ToPointer();
	//std::string FileName = marshal_as<std::string>(strFileName);

	TCHAR *szFileName = (TCHAR*)(Marshal::StringToHGlobalUni(strFileName)).ToPointer();

	return m_IClipPlayControl->SetClip(szFileName, iHwnd);
}

int IClipPlayControlCSharp::Play()
{
	return m_IClipPlayControl->Play();
}

int IClipPlayControlCSharp::Pause()
{
	return m_IClipPlayControl->Pause();
}

int IClipPlayControlCSharp::Continue()
{
	return m_IClipPlayControl->Continue();
}

int IClipPlayControlCSharp::Stop()
{
	return m_IClipPlayControl->Stop();
}

int IClipPlayControlCSharp::GetCurState()
{
	return m_IClipPlayControl->GetCurState();
}

long long IClipPlayControlCSharp::GetDuration()
{
	return m_IClipPlayControl->GetDuration();
}

long long IClipPlayControlCSharp::GetPosition()
{
	return m_IClipPlayControl->GetPosition();
}

int IClipPlayControlCSharp::SetPosition(long long rtPos, long long rtEndPos)
{
	return m_IClipPlayControl->SetPosition(rtPos, rtEndPos);
}