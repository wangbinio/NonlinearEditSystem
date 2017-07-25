#ifndef MAGICODE_PACKETED_BASEDEFINE
#define	MAGICODE_PACKETED_BASEDEFINE

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

//字幕轨字幕信息结构
typedef struct tagZimuMixInfo
{
	TCHAR       szZimuFile[MAX_PATH];//字幕文件名
	LONGLONG    rtStartPos;//开始时间（单位：ms）
	LONGLONG    rtStopPos;//结束时间（单位：ms）

	unsigned int Type;//字幕类型，0 = 静态字幕；1=左飞；2=上滚
	unsigned int Level;//字幕层次，当多层字幕时，上一层字幕将遮挡下一层字幕；数字越小表示层次越高，即0表示最顶层；1表示第二层，以此类推。
}ZimuMixInfo;

#endif