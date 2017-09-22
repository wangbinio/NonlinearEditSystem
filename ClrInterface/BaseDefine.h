#pragma once

#include <vector>
using namespace std;

class COptex
{
public:
	COptex() { InitializeCriticalSection(&cs); }
	~COptex() { DeleteCriticalSection(&cs); }
public:
	void Enter() { EnterCriticalSection(&cs); }
	void Leave() { LeaveCriticalSection(&cs); }
private:
	CRITICAL_SECTION cs;
};

class CObjectLock
{
public:
	CObjectLock(COptex& lock) : m_lock(lock) { m_lock.Enter(); }
	~CObjectLock() { m_lock.Leave(); }
private:
	COptex& m_lock;
};

//素材信息结构
typedef struct tagClipInfo
{
	TCHAR         szClipFile[MAX_PATH];//素材文件名
	unsigned int  streamcount;//包含的流数量

	//视频流信息
	unsigned int  Vsamplecount; //帧数
	double        Vduration;    //时长（单位：s）
	unsigned int  Vwidth;       //宽度
	unsigned int  Vheight;      //高度
	int/*majortypes_t*/  Vmajortype;   //主类型，值参见mcmediatypes.h中mcmajortypes_t定义
	int/*mediatypes_t*/  Vmediatype;   //媒体类型，值参见mcmediatypes.h中mcmediatypes_t定义

	//音频流信息
	unsigned int  Asamplecount; //帧数
	double        Aduration;    //时长（单位：s）
	int/*majortypes_t*/  Amajortype;   //主类型，值参见mcmediatypes.h中mcmajortypes_t定义
	int/*mediatypes_t*/  Amediatype;   //媒体类型，值参见mcmediatypes.h中mcmediatypes_t定义
}ClipInfo;


//音视频分离原始素材信息结构
typedef struct tagDemuxClipInfo
{
	//以下三个为输入参数
	TCHAR       szClipFile[MAX_PATH];//素材文件名
	LONGLONG    rtPos;//入点（单位：ms），如果不设置，则赋值0
	LONGLONG    rtEndPos;//出点（单位：ms），如果不设置，则赋值0

	//以下三个为输出参数，不需要赋值，接口AddClip执行完成后返回值
	TCHAR       szDemuxedVFile[MAX_PATH];//分离的视频文件名
	TCHAR       szDemuxedAFile[MAX_PATH];//分离的音频文件名
	double      duration;//时长（单位：s）
} DemuxClipInfo;



//字幕信息结构
//说明：
//1、开始时间rtStartPos和结束时间rtStopPos用于控制字幕何时播放和何时停止，因此需要根据播出需要正确设置其值，保证：rtStopPos >= rtStartPos >= 0；  
//  注意：rtStartPos和rtStopPos是以素材开始播放时刻为起点（即此刻为0ms）的相对时间。举例：如从多个素材列表中的第二个素材10秒处开始播放，字幕起止时间以第二个素材10秒处为0时刻计算!!!
//2、如果字幕需要重复播出，则需要重复设置字幕。因为在一个播出时间内，即从rtStartPos到rtStopPos，字幕只能播出一次，即：对单帧字幕，则一帧字幕占用全部播出时间；对多帧字幕，则字幕所有帧平均分配播出时间。
//   比如上滚、左飞、动画、唱词等动态字幕，根据其播出速度生成多帧字幕，字幕所有帧平均分配全部播出时间（举例：N帧左飞字幕，播出时长为Len = rtStopPos - rtStartPos，则每帧播出时长为：Len/N）。
//说明：按照2的算法导致动态字幕不平稳，因此改为：在一个播出时间内逐帧播出，全部播放完成后从头开始循环重复播出!  --- 2018.8.18改
//3、字幕类型参数Type不需要，因为所有类型字幕最终生成的是字幕帧数据，直接可以播出。即播出时不需要考虑字幕类型了！
typedef struct tagZimuMixInfo
{
	TCHAR       szZimuFile[MAX_PATH];//字幕文件名
	LONGLONG    rtStartPos;//开始时间（单位：ms）
	LONGLONG    rtStopPos;//结束时间（单位：ms）

						  //unsigned int Type;//字幕类型，0 = 静态字幕；1=左飞；2=上滚
	unsigned int Level;//字幕层次，当多层字幕时，上一层字幕将遮挡下一层字幕；数字越小表示层次越高，即0表示最顶层；1表示第二层，以此类推。

	tagZimuMixInfo()
	{
		ZeroMemory(szZimuFile, MAX_PATH);
		rtStartPos = 0;
		rtStopPos = 0;
		Level = 0;
	}
}ZimuMixInfo;



// 音视频素材信息结构
typedef struct tagAVClipInfo
{
	TCHAR       szFile[MAX_PATH];//音视频素材文件名
	LONGLONG    rtInputPos;//入点（单位：ms）
	LONGLONG    rtOutputPos;//出点（单位：ms）

	tagAVClipInfo()
	{
		ZeroMemory(szFile, MAX_PATH);
		rtInputPos = 0;
		rtOutputPos = 0;
	}
}AVClipInfo;



//打包视频参数  --- 指可由用户设置的视频参数
typedef struct tagVideoParameters
{
	int     bit_rate;//比特率，单位：kbits/sec；缺省值：6000 (kbits/sec)
}VideoParameters;


//打包音频参数 --- 指可由用户设置的音频参数
typedef struct tagAudioParameters
{
	double    sample_rate;//音频采样频率，单位：kHz；常用音频采样频率有8kHz、11.025kHz、22.05kHz、16kHz、37.8kHz、44.1kHz、48kHz等，缺省值：44.1(kHz)

	int       bit_rate;//码率，单位：kbits/sec；可选的值有：0, 6, 7, 8, 10, 12, 14, 16, 20, 24, 28, 32, 40, 48, 56, 64, 80, 96, 112, 128, 160, 192, 224, 256, 320, 384, 448, 512, 640, 768, 896, 1024等，缺省值：160(kbits/sec)
}AudioParameters;

