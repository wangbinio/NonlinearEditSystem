#include "stdafx.h"
#include <msclr\marshal.h>
#include <string>
#include "H264CodecIOCSharp.h"

using namespace msclr::interop;
using namespace System::Runtime::InteropServices;
using namespace ClrInterfaceDll;


H264CodecIOCSharp::H264CodecIOCSharp()
{
	m_H264CodecIOCSharp = new CH264CodecIO();
}


int H264CodecIOCSharp::Start(System::Collections::Generic::List<String^> strInH264VideoFileList, String^ strOutH264FileName)
{
	std::vector<TCHAR*> szInH264VideoFileList;
	for each (String^ str in strInH264VideoFileList)
	{
		TCHAR *sz = (TCHAR*)(Marshal::StringToHGlobalUni(str)).ToPointer();
		szInH264VideoFileList.push_back(sz);
	}

	TCHAR *szOutH264FileName = (TCHAR*)(Marshal::StringToHGlobalUni(strOutH264FileName)).ToPointer();

	int res = m_H264CodecIOCSharp->Start(&szInH264VideoFileList, szOutH264FileName);

	return res;
}


int H264CodecIOCSharp::StartAACDecEncoder(System::Collections::Generic::List<String^> strInAacFileList, String^ strOutAacFileName)
{
	std::vector<TCHAR*> szInAacFileList;
	for each (String^ str in strInAacFileList)
	{
		TCHAR *sz = (TCHAR*)(Marshal::StringToHGlobalUni(str)).ToPointer();
		szInAacFileList.push_back(sz);
	}

	TCHAR *szOutAacFileName = (TCHAR*)(Marshal::StringToHGlobalUni(strOutAacFileName)).ToPointer();

	int res = m_H264CodecIOCSharp->StartAACDecEncoder(&szInAacFileList, szOutAacFileName);

	return res;
}


void H264CodecIOCSharp::Stop()
{
	return m_H264CodecIOCSharp->Stop();
}


bool H264CodecIOCSharp::isFinish()
{
	bool res = m_H264CodecIOCSharp->isFinish();
	return res;
}

