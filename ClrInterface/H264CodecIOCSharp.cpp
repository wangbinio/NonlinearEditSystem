#include "stdafx.h"
#include "tchar.h"
#include "time.h"
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


//int H264CodecIOCSharp::Start(System::Collections::Generic::List<String^> strInH264VideoFileList, String^% strOutH264FileName)
int H264CodecIOCSharp::Start(StringList^ strInH264VideoFileList, String^% strOutH264FileName)
{
	std::vector<TCHAR*> szInH264VideoFileList;
	for each (String^ str in strInH264VideoFileList)
	{
		TCHAR *sz = (TCHAR*)(Marshal::StringToHGlobalUni(str)).ToPointer();
		szInH264VideoFileList.push_back(sz);
	}

	//TCHAR *szOutH264FileName = (TCHAR*)(Marshal::StringToHGlobalUni(strOutH264FileName)).ToPointer();

	TCHAR *szOutH264FileName = new TCHAR[MAX_PATH];
	ZeroMemory(szOutH264FileName, MAX_PATH);

	///////////////////////////////////////////////////////////
	//生成编码后的视频文件和编码后的音频文件
	TCHAR szTime[MAX_PATH] = { 0 };
	time_t t = time(0);
	struct tm newtime;
	localtime_s(&newtime, &t);
	_tcsftime(szTime, MAX_PATH, _T("%Y%m%d%H%M%S"), &newtime);
	TCHAR szFilePath[MAX_PATH] = { 0 };
	GetModuleFileName(NULL, szFilePath, MAX_PATH);
	(_tcsrchr(szFilePath, _T('\\')))[1] = 0;
	_stprintf_s(szOutH264FileName, MAX_PATH, _T("%s_%s.avc"), szFilePath, szTime);
	///////////////////////////////////////////////////////////

	int res = m_H264CodecIOCSharp->Start(&szInH264VideoFileList, szOutH264FileName);

	strOutH264FileName = (String^)(Marshal::PtrToStringUni((IntPtr)szOutH264FileName));


	return res;
}


//int H264CodecIOCSharp::StartAACDecEncoder(System::Collections::Generic::List<String^> strInAacFileList, String^% strOutAacFileName)
int H264CodecIOCSharp::StartAACDecEncoder(StringList^ strInAacFileList, String^% strOutAacFileName)
{
	std::vector<TCHAR*> szInAacFileList;
	for each (String^ str in strInAacFileList)
	{
		TCHAR *sz = (TCHAR*)(Marshal::StringToHGlobalUni(str)).ToPointer();
		szInAacFileList.push_back(sz);
	}

	//TCHAR *szOutAacFileName = (TCHAR*)(Marshal::StringToHGlobalUni(strOutAacFileName)).ToPointer();

	TCHAR *szOutAacFileName = new TCHAR[MAX_PATH];
	ZeroMemory(szOutAacFileName, MAX_PATH);


	///////////////////////////////////////////////////////////
	//生成编码后的视频文件和编码后的音频文件
	TCHAR szTime[MAX_PATH] = { 0 };
	time_t t = time(0);
	struct tm newtime;
	localtime_s(&newtime, &t);
	_tcsftime(szTime, MAX_PATH, _T("%Y%m%d%H%M%S"), &newtime);
	TCHAR szFilePath[MAX_PATH] = { 0 };
	GetModuleFileName(NULL, szFilePath, MAX_PATH);
	(_tcsrchr(szFilePath, _T('\\')))[1] = 0;
	_stprintf_s(szOutAacFileName, MAX_PATH, _T("%s_%s.aac"), szFilePath, szTime);
	///////////////////////////////////////////////////////////



	int res = m_H264CodecIOCSharp->StartAACDecEncoder(&szInAacFileList, szOutAacFileName);

	strOutAacFileName = (String^)(Marshal::PtrToStringUni((IntPtr)szOutAacFileName));

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

