#pragma once

/*///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//说明：类CPacketIO是高清素材分离、解码、字幕叠加、编码、混合等打包全过程的接口。
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// */

#include <vector>
using namespace std;
#include "BaseDefine.h"

class CMp4DemuxIO;
class CH264CodecIO;
class CMp4FilesMuxIO;


#ifdef _MAGICODE_H264PACKET_
class _declspec(dllexport) CPacketIO  //导出类CPacketIO
#else
class _declspec(dllimport) CPacketIO  //导入类CPacketIO
#endif
{
public:
	CPacketIO();
	~CPacketIO();

public:
	//获取素材信息接口
	//参数：
	//1、fileName ---- 输入参数，素材文件名
	//2、fileInfo ---- 输出参数，素材信息
	//返回值：
	// >=0 成功 ; <0 失败
	int GetClipInfo(IN TCHAR *fileName, OUT ClipInfo &fileInfo);

	//返回打包完成百分比（打包完成进度），如完成50%，则返回0.5等等。
	double GetProgress();

	///////////////////////////////////////////////////////////////
	//素材音视频分离接口   -- 开始

	//加载素材列表进行音视频分离
	//参数：
	//1、ClipList ---- 输入参数，需要分离的素材列表
	//返回值：
	// >=0 成功 ; <0 失败
	//注意：只能加载高清MP4或H264音视频素材
	//该函数一直等到音视频分离完成或者强制退出时才返回！即返回成功，表明分离已经完成
	int DemuxClips(IN vector<DemuxClipInfo> ClipList);

	//停止分离
	void StopDemux();

	//素材音视频分离接口   -- 结束
	///////////////////////////////////////////////////////////////

	///////////////////////////////////////////////////////////////
	//解码、字幕叠加、编码等打包接口   -- 开始
	//打包初始化，必须在打包前调用一次，且仅调用一次！
	//注意：在初始化时加载叠加的字幕，保证编码前可以生成字幕帧数据
	//参数：
	//ZimuList ---- 输入参数，需要叠加的字幕列表
	//返回值：
	// >=0 成功 ; <0 失败
	int PacketingInitial(IN vector<ZimuMixInfo> &ZimuList);

	//设置打包音视频参数，必须在打包开始前调用该接口（即调用PacketStart接口前调用）！如果不需设置参数，直接以参数指针NULL传入即可
	//参数：pVp ---- 视频参数指针，输入参数
	//      pAp ---- 音频参数指针，输入参数 
	void SetVideoAudioParameters(VideoParameters *pVp = NULL, AudioParameters *pAp = NULL);

	//打包
	//返回值：
	// >=0 成功 ; <0 失败
	int PacketStart();

	//停止打包
	void PacketStop();

	//判断打包是否完成
	BOOL PacketIsFinish();

	//解码、字幕叠加、编码等打包接口   -- 结束
	///////////////////////////////////////////////////////////////

	///////////////////////////////////////////////////////////////
	//音视频文件混合接口   -- 开始
	//将编码生成的音视频文件进行混合
	//参数：
	//szOutputFilename ---- 输入参数，混合后保存文件名（包括路径和文件名）
	//返回值：
	// >=0 成功 ; <0 失败
	//注意：
	//1、只能加载已经压缩的高清MP4或H264音视频源文件；
	//2、返回成功，混合不一定结束。是否结束需要调用MuxerFinished函数判断
	//3、必须在编码完成后才可以进行混合！
	int MuxerStart(IN TCHAR *szOutputFilename);

	//停止混合
	void MuxerStop();

	//判断混合是否完成
	BOOL MuxerIsFinish();
 				
   //音视频文件混合接口   -- 结束
   ///////////////////////////////////////////////////////////////

   ///////////////////////////////////////////////////////////////
   //字幕叠加接口   -- 开始

   //加载叠加的字幕
   //参数：
   //1、ZimuList ---- 输入参数，需要叠加的字幕列表
   //返回值：
   // >=0 成功 ; <0 失败
	//int MixZimu(IN vector<ZimuMixInfo> &ZimuList);

    //字幕叠加接口   -- 结束
  ///////////////////////////////////////////////////////////////

private:
	vector<DemuxClipInfo>   m_ClipList;//保存打包素材信息列表

	CMp4DemuxIO             *m_pDemuxOperObj; 
	CH264CodecIO            *m_pH264CodecObj; 
	CMp4FilesMuxIO          *m_pMp4FilesMuxObj;

	TCHAR                   m_szEncodedVFile[MAX_PATH];//编码生成的视频文件
	TCHAR                   m_szEncodedAFile[MAX_PATH];//编码生成的音频文件

	double                  m_dTotalDuration;//待打包素材总时长
};