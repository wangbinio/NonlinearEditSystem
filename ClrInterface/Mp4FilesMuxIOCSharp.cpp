#include "stdafx.h"
#include <msclr\marshal.h>
#include <string>
#include "Mp4FilesMuxIOCSharp.h"

using namespace msclr::interop;
using namespace System::Runtime::InteropServices;
using namespace ClrInterfaceDll;



Mp4FilesMuxIOCSharp::Mp4FilesMuxIOCSharp()
{
	m_CMp4FilesMuxIO = new CMp4FilesMuxIO();
}


int Mp4FilesMuxIOCSharp::StartMuxer(System::Collections::Generic::List<String^> strInH264FileList, String^ stroutput_filename)
{
	std::vector<TCHAR*> szInH264FileList;
	for each (String^ str in strInH264FileList)
	{
		TCHAR *sz = (TCHAR*)(Marshal::StringToHGlobalUni(str)).ToPointer();
		szInH264FileList.push_back(sz);
	}

	TCHAR *szoutput_filename = (TCHAR*)(Marshal::StringToHGlobalUni(stroutput_filename)).ToPointer();

	int res = m_CMp4FilesMuxIO->StartMuxer(szInH264FileList, szoutput_filename);

	return res;
}


void Mp4FilesMuxIOCSharp::StopMuxer()
{
	return m_CMp4FilesMuxIO->StopMuxer();
}


bool Mp4FilesMuxIOCSharp::MuxerFinished()
{
	bool res = m_CMp4FilesMuxIO->MuxerFinished();
	return res;
}

