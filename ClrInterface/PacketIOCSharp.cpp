#include "stdafx.h"
#include <msclr\marshal.h>
#include <string>
#include "PacketIOCSharp.h"

using namespace System;
using namespace msclr::interop;
using namespace System::Runtime::InteropServices;
using namespace ClrInterfaceDll;
using namespace ClrDataTypeChange;


PacketIOCSharp::PacketIOCSharp()
{
	m_CPacketIO = new CPacketIO();
}


int PacketIOCSharp::GetClipInfo(String^ fileName, tagClipInfoCLR^% fileInfo)
{
	TCHAR *szfileName = (TCHAR*)(Marshal::StringToHGlobalUni(fileName)).ToPointer();
	ClipInfo cClipInfo;
	ZeroMemory(&cClipInfo, sizeof(cClipInfo));

	int res = m_CPacketIO->GetClipInfo(szfileName, cClipInfo);

	fileInfo->szClipFile = (String^)(Marshal::PtrToStringUni((IntPtr)cClipInfo.szClipFile));

	fileInfo->streamcount = cClipInfo.streamcount;
	fileInfo->Vsamplecount = cClipInfo.Vsamplecount;
	fileInfo->Vduration = cClipInfo.Vduration;
	fileInfo->Vwidth = cClipInfo.Vwidth;
	fileInfo->Vheight = cClipInfo.Vheight;
	fileInfo->Vmajortype = cClipInfo.Vmajortype;
	fileInfo->Vmediatype = cClipInfo.Vmediatype;
	fileInfo->Asamplecount = cClipInfo.Asamplecount;
	fileInfo->Aduration = cClipInfo.Aduration;
	fileInfo->Amajortype = cClipInfo.Amajortype;
	fileInfo->Amediatype = cClipInfo.Amediatype;

	return res;
}


double PacketIOCSharp::GetProgress()
{
	return m_CPacketIO->GetProgress();
}


int PacketIOCSharp::DemuxClips(DemuxClipInfoList^ ClipList)
{
	vector<DemuxClipInfo> vDemuxClipInfo;

	int nCount = ClipList->Count;

	for (int i = 0; i < nCount; i++)
	{
		vDemuxClipInfo.push_back(ConvertToDemuxClipInfo(ClipList[i]));
	}

	return m_CPacketIO->DemuxClips(vDemuxClipInfo);
}


void PacketIOCSharp::StopDemux() 
{
	return m_CPacketIO->StopDemux();
}


int PacketIOCSharp::PacketingInitial(ZimuMixInfoList^ ZimuList)
{
	vector<ZimuMixInfo> vZimuList;

	int nCount = ZimuList->Count;

	for (int i = 0; i < nCount; i++)
	{
		vZimuList.push_back(ConvertToZimuMixInfo(ZimuList[i]));
	}

	//return m_CPacketIO->MixZimu(vZimuList);

	return m_CPacketIO->PacketingInitial(vZimuList);
}


int PacketIOCSharp::PacketStart()
{
	return m_CPacketIO->PacketStart();
}


void PacketIOCSharp::PacketStop()
{
	return m_CPacketIO->PacketStop();
}


bool PacketIOCSharp::PacketIsFinish()
{
	return m_CPacketIO->PacketIsFinish();
}


int PacketIOCSharp::MuxerStart(String^ szOutputFilename)
{
	TCHAR *szfileName = (TCHAR*)(Marshal::StringToHGlobalUni(szOutputFilename)).ToPointer();
	return m_CPacketIO->MuxerStart(szfileName);
}


void PacketIOCSharp::MuxerStop()
{
	return m_CPacketIO->MuxerStop();
}


bool PacketIOCSharp::MuxerIsFinish()
{
	return m_CPacketIO->MuxerIsFinish();

}

/*
int PacketIOCSharp::MixZimu(ZimuMixInfoList^ ZimuList)
{
	vector<ZimuMixInfo> vZimuList;

	int nCount = ZimuList->Count;

	for (int i=0; i<nCount; i++)
	{
		vZimuList.push_back(ConvertToZimuMixInfo(ZimuList[i]));
	}

	return m_CPacketIO->MixZimu(vZimuList);
}
*/


ClipInfo PacketIOCSharp::ConvertToClipInfo(tagClipInfoCLR^ ctagClipInfoCLR)
{
	ClipInfo cClipInfo;
	ZeroMemory(&cClipInfo, sizeof(cClipInfo));

	TCHAR *szClipFile = (TCHAR*)(Marshal::StringToHGlobalUni(ctagClipInfoCLR->szClipFile)).ToPointer();

	memcpy(cClipInfo.szClipFile, szClipFile, sizeof(cClipInfo.szClipFile));
	
	cClipInfo.streamcount = ctagClipInfoCLR->streamcount;
	cClipInfo.Vsamplecount = ctagClipInfoCLR->Vsamplecount;
	cClipInfo.Vduration = ctagClipInfoCLR->Vduration;
	cClipInfo.Vwidth = ctagClipInfoCLR->Vwidth;
	cClipInfo.Vheight = ctagClipInfoCLR->Vheight;
	cClipInfo.Vmajortype = ctagClipInfoCLR->Vmajortype;
	cClipInfo.Vmediatype = ctagClipInfoCLR->Vmediatype;
	cClipInfo.Asamplecount = ctagClipInfoCLR->Asamplecount;
	cClipInfo.Aduration = ctagClipInfoCLR->Aduration;
	cClipInfo.Amajortype = ctagClipInfoCLR->Amajortype;
	cClipInfo.Amediatype = ctagClipInfoCLR->Amediatype;

	return cClipInfo;
}


DemuxClipInfo PacketIOCSharp::ConvertToDemuxClipInfo(tagDemuxClipInfoCLR^ ctagDemuxClipInfoCLR)
{
	DemuxClipInfo cDemuxClipInfo;
	ZeroMemory(&cDemuxClipInfo, sizeof(cDemuxClipInfo));

	TCHAR *szClipFile = (TCHAR*)(Marshal::StringToHGlobalUni(ctagDemuxClipInfoCLR->szClipFile)).ToPointer();
	TCHAR *szDemuxedVFile = (TCHAR*)(Marshal::StringToHGlobalUni(ctagDemuxClipInfoCLR->szClipFile)).ToPointer();
	TCHAR *szDemuxedAFile = (TCHAR*)(Marshal::StringToHGlobalUni(ctagDemuxClipInfoCLR->szClipFile)).ToPointer();

	memcpy(cDemuxClipInfo.szClipFile, szClipFile, sizeof(cDemuxClipInfo.szClipFile));
	memcpy(cDemuxClipInfo.szDemuxedVFile, szDemuxedVFile, sizeof(cDemuxClipInfo.szDemuxedVFile));
	memcpy(cDemuxClipInfo.szDemuxedAFile, szDemuxedAFile, sizeof(cDemuxClipInfo.szDemuxedAFile));

	cDemuxClipInfo.rtPos = ctagDemuxClipInfoCLR->rtPos;
	cDemuxClipInfo.rtEndPos = ctagDemuxClipInfoCLR->rtEndPos;
	cDemuxClipInfo.duration = ctagDemuxClipInfoCLR->duration;

	return cDemuxClipInfo;
}


ZimuMixInfo PacketIOCSharp::ConvertToZimuMixInfo(tagZimuMixInfoCLR^ ctagZimuMixInfo)
{
	ZimuMixInfo cZimuMixInfo;
	ZeroMemory(&cZimuMixInfo, sizeof(cZimuMixInfo));

	TCHAR *szZimuFile = (TCHAR*)(Marshal::StringToHGlobalUni(ctagZimuMixInfo->szZimuFile)).ToPointer();

	memcpy(cZimuMixInfo.szZimuFile, szZimuFile, sizeof(cZimuMixInfo.szZimuFile));

	cZimuMixInfo.rtStartPos = ctagZimuMixInfo->rtStartPos;
	cZimuMixInfo.rtStopPos = ctagZimuMixInfo->rtStopPos;
	//cZimuMixInfo.Type = ctagZimuMixInfo->Type;
	cZimuMixInfo.Level = ctagZimuMixInfo->Level;

	return cZimuMixInfo;
};