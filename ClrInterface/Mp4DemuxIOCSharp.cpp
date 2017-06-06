#include "stdafx.h"
#include <msclr\marshal.h>
#include <string>
#include "Mp4DemuxIOCSharp.h"

using namespace msclr::interop;
using namespace System::Runtime::InteropServices;
using namespace ClrInterfaceDll;


Mp4DemuxIOCSharp::Mp4DemuxIOCSharp()
{
	m_CMp4DemuxIO = new CMp4DemuxIO();
}


int Mp4DemuxIOCSharp::AddClip(String^ strDemuxVideoFile, String^ strDemuxAudioFile, String^ strClipFileName, long long rtPos, long long rtEndPos)
{
	TCHAR *szrClipFileName = (TCHAR*)(Marshal::StringToHGlobalUni(strClipFileName)).ToPointer();
	TCHAR *szDemuxVideoFile = new TCHAR[MAX_PATH];
	TCHAR *szDemuxAudioFile = new TCHAR[MAX_PATH];

	int res = m_CMp4DemuxIO->AddClip(szDemuxVideoFile, szDemuxAudioFile, szrClipFileName, rtPos, rtEndPos);

	strDemuxVideoFile = (String^)(Marshal::PtrToStringUni((IntPtr)szDemuxVideoFile));
	strDemuxAudioFile = (String^)(Marshal::PtrToStringUni((IntPtr)szDemuxAudioFile));

	return res;
}


void Mp4DemuxIOCSharp::Stop()
{
	return m_CMp4DemuxIO->Stop();
}