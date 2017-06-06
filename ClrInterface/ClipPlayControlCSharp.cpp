#include "stdafx.h"
#include <msclr\marshal.h>
#include <string>
#include "ClipPlayControlCSharp.h"

using namespace msclr::interop;
using namespace System::Runtime::InteropServices;
using namespace ClrInterfaceDll;


ClipPlayControlCSharp::ClipPlayControlCSharp()
{
	m_IClipPlayControl = new CClipPlayControlIO();
}

//void IClipPlayControlCSharp::Release()
//{
//	return m_IClipPlayControl->Release();
//}

int ClipPlayControlCSharp::SetClip(String^ strFileName, IntPtr hWnd)
{
	//void * phWnd = hWnd->ToPointer();

	//HWND iHwnd = (HWND)(hWnd.ToPointer());
	HWND iHwnd = (HWND)hWnd.ToPointer();
	//std::string FileName = marshal_as<std::string>(strFileName);

	TCHAR *szFileName = (TCHAR*)(Marshal::StringToHGlobalUni(strFileName)).ToPointer();

	return m_IClipPlayControl->SetClip(szFileName, iHwnd);
}


int ClipPlayControlCSharp::Play()
{
	return m_IClipPlayControl->Play();
}


int ClipPlayControlCSharp::Pause()
{
	return m_IClipPlayControl->Pause();
}


int ClipPlayControlCSharp::Continue()
{
	return m_IClipPlayControl->Continue();
}


int ClipPlayControlCSharp::Stop()
{
	return m_IClipPlayControl->Stop();
}


int ClipPlayControlCSharp::GetCurState()
{
	return m_IClipPlayControl->GetCurState();
}


long long ClipPlayControlCSharp::GetDuration()
{
	return m_IClipPlayControl->GetDuration();
}


long long ClipPlayControlCSharp::GetPosition()
{
	return m_IClipPlayControl->GetPosition();
}


int ClipPlayControlCSharp::SetPosition(long long rtPos, long long rtEndPos)
{
	return m_IClipPlayControl->SetPosition(rtPos, rtEndPos);
}