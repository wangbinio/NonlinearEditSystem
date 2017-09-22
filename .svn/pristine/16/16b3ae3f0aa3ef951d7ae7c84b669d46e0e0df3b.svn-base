#include <tchar.h>
#include <atltypes.h>
#ifndef MAGICODE_ZIMUBASEDEFINE
#define	MAGICODE_ZIMUBASEDEFINE

//#define TEST_LENGTH 720*576

//#define BURST_NO 576
//#define BURST_LENGTH 720

//定义高清帧幅
#define HDFRAME_WIDTH  1920
#define HDFRAME_HEIGHT 1080
#define HDFRAME_SIZE   2073600  //高清帧像素数(1920*1080)
#define HDFRAME_BYTES  8294400  //高清帧字节数(1920*1080*4)

#define STORE_FRAME_NO	4

#define	TIMER_ID  1
#define	TIMER_INTERVAL 20
//#define	PICTURE_WIDTH 720
//#define PICTURE_MAX_ROW ( 576*3 )

//#define	CAPTION_X_RANGE  600
//#define	CAPTION_Y_RANGE  500

//#define	CAPTION_SIZE     (720*288)
#define	STATION_CAPTION_X ( 56 )
#define	STATION_CAPTION_Y ( 50 )
#define	STATION_CAPTION_W ( 120 )
#define	STATION_CAPTION_H ( 180 )

#define	VOLUMN_RANGE 256
#define	KEY_DELAY_RANGE 256
#define LINE_PHASE_RANGE 256
#define FIELD_PHASE_RANGE 256
#define CONTRAST_RANGE 256
#define LIGHT_RANGE 256
#define HUE_RANGE 256
#define SATUATION_RANGE 256
#define SUBCARRIER_RANGE 256


#define COLORITEM_ZERO_WHITE    0XFFFFFFFF
#define COLORITEM_ZERO_YELLOW   0XFFFFFF00
#define COLORITEM_ZERO_CYAN     0XFF00FFFF
#define COLORITEM_ZERO_GREEN    0XFF00FF00
#define COLORITEM_ZERO_PINK     0XFFFF00FF
#define COLORITEM_ZERO_RED      0XFFFF0000
#define COLORITEM_ZERO_BLUE     0XFF0000FF
#define COLORITEM_ZERO_BLACK    0XFF000000

#define COLORITEM_25_WHITE    0XFFFFFFFF
#define COLORITEM_25_YELLOW   0XFFFFFF40
#define COLORITEM_25_CYAN     0XFF40FFFF
#define COLORITEM_25_GREEN    0XFF40FF40
#define COLORITEM_25_PINK     0XFFFF40FF
#define COLORITEM_25_RED      0XFFFF4040
#define COLORITEM_25_BLUE     0XFF4040FF
#define COLORITEM_25_BLACK    0XFF000000

#define COLORITEM_75_WHITE    0XFFFFFFFF
#define COLORITEM_75_YELLOW   0XFFC0C000
#define COLORITEM_75_CYAN     0XFF00C0C0
#define COLORITEM_75_GREEN    0XFF00C000
#define COLORITEM_75_PINK     0XFFC000C0
#define COLORITEM_75_RED      0XFFC00000
#define COLORITEM_75_BLUE     0XFF0000C0
#define COLORITEM_75_BLACK    0XFF000000

#define WM_ETONE_INT_NOTIFY		WM_USER + 201

//#define _GRAPHICS_W		720
//#define _GRAPHICS_H		576

//与RGBQUAD相对的结构
typedef struct tagQUADRGB 
{
	BYTE    rgbReserved; 
	BYTE    rgbRed; 
	BYTE    rgbGreen; 
	BYTE    rgbBlue; 
}QUADRGB; 

//#define NUMBER          10//左飞或上滚等播出项目的个数
//#define MAXITEMS        4*NUMBER+2//最多播出项目个数
//#define MAX_MEM_SIZE	0xA00000// 最大内存块大小，10M

//#define SZHEIGHT 48
//#define SZWIDTH 32
//#define SZDISTANCE 20

///////////////// 资源释放宏定义 begin ////////////////////////////
#ifndef SAFE_RELEASE
#define SAFE_RELEASE( x )  \
    if( NULL != (x) )       \
    {                      \
        (x)->Release( );     \
        (x) = NULL;          \
    }
#endif

#ifndef SAFE_DELETE
#define SAFE_DELETE( x )	\
    if( NULL != (x) )		\
    {						\
        delete (x);			\
        (x) = NULL;			\
    }
#endif

#ifndef SAFE_ARRAYDELETE
#define SAFE_ARRAYDELETE( x )	\
    if( NULL != (x) )		\
    {						\
        delete[] (x);			\
        (x) = NULL;			\
    }
#endif

#ifndef SAFE_CLOSEHANDLE
#define SAFE_CLOSEHANDLE( h )       \
	if( NULL != (h) )                 \
    {                               \
        CloseHandle( (h) );           \
        (h) = NULL;                   \
    }
#endif //SAFE_CLOSEHANDLE
///////////////// 资源释放宏定义 end //////////////////////////////

/////////////////////////////////////////////
#define FIXINT(a,b) ((short)(((LONG)(a)+(LONG) ( (DWORD)(a)& ( 0xffff>>(b) )  ) )>>(16-(b))))
#define MAX_BUFFERS		16384
#define MAX_FONT_POINT  16384 //8192
#define MAXLINES 50
//#define MAX_FRAME_SIZE 414720L   /*720*576*/
//#define ONE_PAGE_SIZE  1658880L	/*720*576*4*/


//定义着色类型
#define FILL_TYPE_SINGLE		0x01 //单色
#define FILL_TYPE_TRANSITION	0x02 //渐变	
#define FILL_TYPE_MATERIAL		0x04 //材质
#define FILL_TYPE_VIRTUAL		0x10 //虚化
#define FILL_TYPE_TEXTURE		0x20 //纹理
#define FILE_TYPE_LIGHT			0x40 //光感

//定义变形
#define MORPH_TYPE_ON			0x80 //变形

//定义边框类型
#define EDGE_TYPE_RECT			0x01 //方形
#define EDGE_TYPE_CIRCLE		0x02 //圆形
#define EDGE_TYPE_RHOMBUS		0x04 //菱形

//定义立体类型
#define STEREO_TYPE_0			0x01 //左下
#define STEREO_TYPE_1			0x02 //右下
#define STEREO_TYPE_2			0x04 //左上
#define STEREO_TYPE_3			0x08 //右上
#define STEREO_TYPE_4			0x10 //下
#define STEREO_TYPE_5			0x20 //左
#define STEREO_TYPE_6			0x40 //上
#define STEREO_TYPE_7			0x80 //右

//定义阴影类型
#define SHADE_TYPE_NORMAL		0x01 //普通
#define SHADE_TYPE_INVERT		0x02 //倒影
#define SHADE_TYPE_WATER		0x04 //水波

//定义渐变方式
#define TRANSITION_TYPE_SYMMETRY 0x40	//对称			
#define TRANSITION_TYPE_INVERT	 0x80	//反向

//定义纹理及光感对象
#define MAP_TYPE_COLOR			 0x100

//定义胶片大小
#define BMPLDC_WIDTH  80   //w:h must be 5:4
#define BMPLDC_HEIGHT 64    //

//图形工具结构
typedef struct {
	int m_GraphTool;   //工具号
	WORD m_LineWidth;   //线宽
	WORD m_Round;		//圆角
	WORD m_NodeNum;		//节点数
	WORD m_Effect;		//效果
	BYTE m_LineType;	//线型
	BYTE m_EffectType;	//
	BYTE m_NodeType;	//节点类型
}GRAPHTOOL;


//字库文字节点
typedef struct {
	POINT   pValue;
	BYTE	pType;
}FONTPOINT;

//边缘标志
typedef union {
	int key;        //？
	struct {
		short flag; //
		short value;//
		}x; 
}EDGEFLAG;

typedef EDGEFLAG PEDGEFLAG[MAXLINES];

//HSL坐标系image struct
typedef struct tagHSLQUAD{
	BYTE hue;		//色调
	BYTE saturation;//饱和度
	BYTE luminosity;//亮度
	BYTE reserved;	//保留：alpha
} HSLQUAD;

//font libray attributes
typedef struct {
	LOGFONT Lf;
	LONG AveCharWidth;
	LONG MaxCharWidth;
} LOG_FONT_METRIC;

//渐变色结构
typedef struct tagCOLORRECORDER
{
	BYTE Color_Num;                                //关键点数（max=10)  
												   //note:left click add,right click sub
	BYTE Color_Type;                               //color transition type：0--8
	BYTE Color_Mode;                               //0：非对称，1：对称（中心辅射）
	BYTE Color_Invert;                             //1：正向，0：反向
	RGBQUAD Color_Data[10];                        //关键点颜色值
	int Color_Pos[10];                             //关键点位置所占比例(百分比）
}COLORRECORDER;

//填充模式结构
//Note: there are three fill mode:single color,material,transition
typedef union tagFILLMODE {
	RGBQUAD CurrentColor;		   //表面当前颜色
	LONG	MaterialNo;		       //表面材质号
	COLORRECORDER TransitionColor; //表面渐变颜色
}FILLMODE;

//填充属性结构
typedef struct tagFILLATTRIB {
	LONG FillScope;				//填充区域
	BYTE FaceType;				//表面类型
	BYTE EdgeType;				//边框类型
	BYTE LitiType;				//立体类型
	BYTE ShadeType;				//阴影类型
	WORD FaceFillType;			//表面着色类型
	WORD EdgeFillType;			//边框着色类型
	WORD LitiFillType;			//边框着色类型
	WORD ShadeFillType;			//阴影着色类型
	WORD EdgeWidth;				//边框宽度
	WORD LitiWidth;				//立体宽度
	LONG ShadeHoffset;			//阴影水平偏距
	LONG ShadeVoffset;			//阴影垂直偏距
	FILLMODE FaceFillMode;		//表面填充模式
	FILLMODE EdgeFillMode;		//边框填充模式
	FILLMODE LitiFillMode;		//立体填充模式
	FILLMODE ShadeFillMode;		//阴影填充模式
	LONG	FaceTexture;		//表面纹理号
	LONG	EdgeTexture;		//边框纹理号
	LONG	LitiTexture;		//立体纹理号
	LONG	ShadeTexture;		//阴影纹理号
	LONG	FaceLight;			//表面光感号
	LONG	EdgeLight;			//边框光感号
	LONG	LitiLight;			//立体光感号
	LONG	ShadeLight;			//阴影光感号
	LONG	Reserved;			//保留
}FILLATTRIB;

//文字属性结构
typedef struct tagWORDATTRIB {
	LOG_FONT_METRIC  ChineseFont;	//中文字体
	LOG_FONT_METRIC  EnglishFont;	//英文字体
	LOG_FONT_METRIC  SymbolFont;    //图形符号类
	BOOL IsSymbol;					//TRUE:Symbol,False:text
	WORD WordWidth;					//字宽
	WORD WordHeight;				//字高
	short WordColum;				//字间距
	short WordRow;					//行间距
	short WordRotate;				//字旋转角	
	short WordSlant;				//字倾斜角
	BYTE WordAlign;					//字排列方式
	BYTE WordTab;					//字对齐方式
	WORD MorphType;					//变形
	POINT StartPoint;				//起始点
	POINT WordCurve[4];				//曲线路径
	POINT *MorphKeyPoint;			//变形关键点
} WORDATTRIB;


////页面播出类型结构
//typedef	struct _BroadType {
//	//BYTE bBroadPageType;//PageType:0单帧，1上滚，2左滚,....
//	//CString bBroadKeyWords; //内容关键词；
//	BYTE bBroadCutInType;//划入类型：0，图元；1：切入；2：淡入；3：飞入；4-100：划入；120-127：卷入
//	BYTE bBroadCutOutType;//划出类型：0，保留；1：图元；
//	BYTE bBroadMode;//播出标志：0：循序播出；1：多线程播出;2:定时播出；3：键控播出
//	BYTE bBroadSpeed;//播出速度
//	LONG nBroadBegingTime;//入屏时间
//	LONG nBroadPersisteTime;//出屏时间
//	RECT rBroadActiveZone;//播出区域：0:全屏播出；else:区域播出
//	WORD nBroadFlashWidth;//闪烁宽度
//	WORD nBroadShiningTime;//飞光时间
//	RGBQUAD nBroadFlashColor;//闪烁色
//	union {
//			struct {
//				WORD nBackType;  //背景类型：无，单色，渐变
//				WORD nBlankLength;//
//				RGBQUAD BackColor;//background color
//				COLORRECORDER BackTransition;//back transition color
//				} Scroll;
//			DWORD nReserved[16];//播出参数
//			} BroadParams;
//	BOOL bKalaok;
//} BROADCAST;

typedef enum
{
	TYPE_NONE = 0,  //无类型
	TYPE_TB = 1,    //台标
	TYPE_SZ,        //时钟
	TYPE_JB,        //角标
	TYPE_DH,        //动画
	TYPE_ZF,        //左飞
	TYPE_SG,        //上滚
	TYPE_BJ         //全屏背景
} ZIMU_TYPES;

typedef struct tagZIMUEXTRAATTRIB
{
	ZIMU_TYPES zmType;            //字幕类型

	RECT  rect;                   //播出范围

    //字幕背景图或颜色定义
	BYTE BackColorType;          //背景颜色类型：0=没有背景；1=单色背景；2=渐变色；3=背景图形
	RGBQUAD BackSingleColor;     //当BackColorType==1时保存的背景颜色
	COLORRECORDER BackTransition;//当BackColorType==2时保存的背景渐变色
	TCHAR Backname[MAX_PATH];    //当BackColorType==3时保存的背景图形

	UINT uSpan;                   //字幕间距。仅对单行左飞、单行上滚有效，表示连续两个字幕的播出间隔	
	UINT uSpeed;                  //播出速度，对动画序列或天气预报表示切换时间,单位为：毫秒(ms)
	BYTE Alpha;                   //透明度(0-255)，计算时按照百分比：Alpha/255

	tagZIMUEXTRAATTRIB()
	{
		zmType = ZIMU_TYPES::TYPE_NONE;
		ZeroMemory(&rect, sizeof(rect));
		BackColorType = 0;
		ZeroMemory(&BackSingleColor, sizeof(BackSingleColor));
		ZeroMemory(&BackTransition, sizeof(BackTransition));
		ZeroMemory(Backname, sizeof(Backname));
		uSpan = 0;
		uSpeed = 0;
		Alpha = 255;
	}
}ZIMUEXTRAATTRIB;

//字幕文件头结构，总共512字节
typedef struct tagZIMUFILEHEAD
{
	TCHAR  szFlag[10];//文件标识，固定为20字节，值为：SzintelZm，用于判断文件是否是我们生成的字幕文件

	//版本号：用主版本、小版本两个整数表示，如1.0等
	__int32 iMainVer;       //主版本
	__int32 iMinVer;        //小版本

	__int32 iFramesNum;     //帧数，一个高清帧大小为1920*1080*4字节

	//字幕帧与视频帧叠加时需要的几个参数：
	ZIMU_TYPES zmType;      //字幕类型
	RECT  rect;             //有效播出范围

	SYSTEMTIME time;        //保存时间
	TCHAR author[32];       //作者
	__int8 reserved[380];   //保留字节，便于将来扩充

	tagZIMUFILEHEAD()
	{
		_stprintf_s(szFlag, _T("%s"), _T("SzintelZm"));
		szFlag[9] = _T('\0');
		iMainVer = 0;
		iMinVer = 0;
		iFramesNum = 0;
		zmType = TYPE_NONE;
		memset(&rect, 0, sizeof(rect));
		GetLocalTime(&time);
		memset(author, 0, sizeof(author));
		memset(reserved, 0, sizeof(reserved));
	}
}ZIMUFILEHEAD;

//生成的字幕数据信息
typedef struct tagZIMUBUFFINFO
{
	ULONG *pBuff;
	ULONG size;
	ULONG width;
	ULONG height;
}ZIMUBUFFINFO;


//扩展的BITMAP 文件
typedef struct _BITMAPEXT {
	int m_OriginX;
	int m_OriginY; //image left_top point
	DWORD m_Width;
	DWORD m_Height;//image size
	BYTE m_BitmapBits;//32 with alpha,24 without alpha
	BYTE m_Alpha;   //aplha ,extended part
	PBYTE m_pBuff;//image buffer
} BITMAPEXT;

//动画播出信息
typedef struct tagIMAGEBUFF
{
	ULONG *pBuff;//图形buff
	LONG   bmWidth;//图形宽
    LONG   bmHeight;//图形高
}IMAGEBUFF;
typedef struct tagDHBROADINFO
{
	int iFrame;//帧数

	TCHAR filename[256];//图形文件名

	IMAGEBUFF buff[1000];//最多1000帧

	CPoint start;//播出起点
	LONG   maxWidth;//图形最大宽度
    LONG   maxHeight;//图形最大高度

	HANDLE hStopEvent;//停止播放事件
	HANDLE hThread;//播放线程句柄
}DHBROADINFO;

//default transition template
static COLORRECORDER default_template[15]={
	{3,0,0,0,{{0,255,0,255},{255,0,0,255},{255,255,255,255}},{0,34,100}},
	{3,1,0,0,{{0,0,0,255},{0,255,0,128},{255,0,255,255}},{0,50,100}},
	{3,2,0,0,{{0,0,0,255},{0,255,0,128},{255,0,255,255}},{0,50,100}},
	{3,3,0,0,{{0,0,0,255},{0,255,0,128},{255,0,255,255}},{0,50,100}},
	{3,4,0,0,{{0,0,0,255},{0,255,0,128},{255,0,255,255}},{0,50,100}},
	{3,5,0,0,{{0,0,0,255},{0,255,0,128},{255,0,255,255}},{0,50,100}},
	{3,6,0,0,{{0,0,0,255},{0,255,0,128},{255,0,255,255}},{0,50,100}},
	{3,7,0,0,{{0,0,0,255},{0,255,0,128},{255,0,255,255}},{0,50,100}},
	{3,8,0,0,{{0,0,0,255},{0,255,0,128},{255,0,255,255}},{0,50,100}},
	{3,4,1,0,{{0,0,0,255},{0,255,0,128},{255,0,255,255}},{0,50,100}},
	{3,4,0,1,{{0,0,0,255},{0,255,0,128},{255,0,255,255}},{0,50,100}},
	{3,3,0,0,{{0,0,0,255},{0,255,0,128},{255,0,255,255}},{0,50,100}},
	{3,6,0,0,{{0,0,0,255},{0,255,0,128},{255,0,255,255}},{0,50,100}},
	{3,8,0,0,{{0,0,0,255},{0,255,0,128},{255,0,255,255}},{0,50,100}},
	{3,8,0,0,{{0,0,0,255},{0,255,0,128},{255,0,255,255}},{0,50,100}}
};

static COLORRECORDER custome_template[15]={
	{2,0,0,0,{{0,0,0,0},{0,0,0,0}},{0,50,100}},
	{2,0,0,0,{{0,0,0,0},{0,0,0,0}},{0,50,100}},
	{2,0,0,0,{{0,0,0,0},{0,0,0,0}},{0,50,100}},
	{2,0,0,0,{{0,0,0,0},{0,0,0,0}},{0,50,100}},
	{2,0,0,0,{{0,0,0,0},{0,0,0,0}},{0,50,100}},
	{2,0,0,0,{{0,0,0,0},{0,0,0,0}},{0,50,100}},
	{2,0,0,0,{{0,0,0,0},{0,0,0,0}},{0,50,100}},
	{2,0,0,0,{{0,0,0,0},{0,0,0,0}},{0,50,100}},
	{2,0,0,0,{{0,0,0,0},{0,0,0,0}},{0,50,100}},
	{2,0,0,0,{{0,0,0,0},{0,0,0,0}},{0,50,100}},
	{2,0,0,0,{{0,0,0,0},{0,0,0,0}},{0,50,100}},
	{2,0,0,0,{{0,0,0,0},{0,0,0,0}},{0,50,100}},
	{2,0,0,0,{{0,0,0,0},{0,0,0,0}},{0,50,100}},
	{2,0,0,0,{{0,0,0,0},{0,0,0,0}},{0,50,100}},
	{2,0,0,0,{{0,0,0,0},{0,0,0,0}},{0,50,100}}
};

static RGBQUAD TransParent={0,0,0,0};
static RGBQUAD default_color[48]={
	{255,255,255,255},{128,255,255,255},{128,255,128,255},{128,255,0,255},
	{255,255,128,255},{255,128,0,255},{192,128,255,255},{255,128,255,255},//0
	{0,0,255,255},{0,255,255,255},{0,255,128,255},{64,255,0,255},
	{255,255,0,255},{192,128,0,255},{192,128,128,255},{255,0,255,255},//1
	{64,64,128,255},{64,128,255,255},{0,255,0,255},{128,128,0,255},
	{128,64,0,255},{255,128,128,255},{64,0,128,255},{128,0,255,255},//2
	{0,0,128,255},{0,128,255,255},{0,128,0,255},{64,128,0,255},
	{255,0,0,255},{160,0,0,255},{128,0,128,255},{255,0,128,255},//3
	{0,0,64,255},{0,64,128,255},{0,64,0,255},{64,64,0,255},
	{128,0,0,255},{64,0,0,255},{64,0,64,255},{128,0,64,255},//4
	{0,0,0,255},{0,128,128,255},{64,128,128,255},{128,128,128,255},
	{128,128,64,255},{192,192,192,255},{64,0,64,255},{255,255,255,255}
};

//convert RGB to HSL value
static void RGB_To_HSL(RGBQUAD &rgb,HSLQUAD &hsl)
{
	
	int max,min;
	min=max=rgb.rgbRed;
	if (max<rgb.rgbGreen)
		max=rgb.rgbGreen;
	else if (min>rgb.rgbGreen)
		min=rgb.rgbGreen;
	if (max<rgb.rgbBlue) 
		max=rgb.rgbBlue;
	else if (min>rgb.rgbBlue)
		min=rgb.rgbBlue;
	hsl.luminosity=(max+min)*24/51;
	if (min==max) 
		hsl.saturation=0;
	else
	{
		int dm,am,rc,gc,bc;
		dm=max-min;
		am=max+min;
		rc=(int)rgb.rgbGreen-(int)rgb.rgbBlue;
		gc=(int)rgb.rgbBlue-(int)rgb.rgbRed;
		bc=(int)rgb.rgbRed-(int)rgb.rgbGreen;
		if (hsl.luminosity<=120)
			hsl.saturation=(unsigned char)(dm*240/am);
		else 
			hsl.saturation=(unsigned char)((dm*240)/(510-am));
		if (rgb.rgbRed==(unsigned char)max) max=rc*40/dm;
		else if (rgb.rgbGreen==(unsigned char)max) 
			max=80+(gc*40/dm);
		else max=160+(bc*40/dm);
		if (max<0)
			hsl.hue=(unsigned char)(240+max);
		else
			hsl.hue=(unsigned char)max;
	}

	hsl.reserved=rgb.rgbReserved;
	
}

//calcalate the value of hue
static unsigned char VALUE(int n1,int n2,int hue)
{
	if (hue>240)
		hue-=240;
	else if(hue<0) 
		hue+=240;
	if (hue<40)
		return ((n1+(n2-n1)*hue/40));
	else if (hue<120) 
		return (n2);
	else if (hue<160)
		return ((n1+(n2-n1)*(160-hue)/40));
	else
		return (n1);
}

//convert HSL value to RGB value
static void HSL_To_RGB(HSLQUAD &hsl,RGBQUAD &rgb)
{
	if (hsl.saturation==0)
		rgb.rgbRed=rgb.rgbGreen=rgb.rgbBlue=(int)hsl.luminosity*51/48;
	else
	{
		int m1,m2;
		if (hsl.luminosity<=120)
			m2=((int)hsl.luminosity+((int)hsl.luminosity*(int)hsl.saturation)/240)*51/48;
		else
			m2=((int)hsl.luminosity+(int)hsl.saturation-((int)hsl.luminosity*(int)hsl.saturation)/240)*51/48;
		m1=((int)hsl.luminosity*51/24)-m2;
		rgb.rgbRed=VALUE(m1,m2,(int)hsl.hue+80);
		rgb.rgbGreen=VALUE(m1,m2,(int)hsl.hue);
		rgb.rgbBlue=VALUE(m1,m2,(int)hsl.hue-80);
	}
	rgb.rgbReserved=hsl.reserved;
}

//define function insert
inline void insert(EDGEFLAG *px,short flag,short x)
{
	int i=0,j;
	while (px[i].key)
	{
		if (px[i].x.value>x)
		{
			j=i+1;
			while(px[j].key) j++;
			while(j-->i)
				px[j+1].key=px[j].key;
			break;
		}
		else i++;
	}
	px[i].x.flag=flag;
	px[i].x.value=x;
}

//define fiunction combine
inline void combine(EDGEFLAG *px,short x1,short x2)
{
	int i=0,j;
	while (px[i].key)
	{
		if (px[i].x.value>=x1)
		{
			if (x2>=px[i].x.flag&&x2<=px[i].x.value)
			{
				if (px[i].x.flag>x1) px[i].x.flag=x1;
				return;
			}
			else if (x2<px[i].x.flag)
			{
				j=i+1;
				while(px[j].key) j++;
				while(j-->i)
					px[j+1].key=px[j].key;
					break;
			}
			else if (x2>px[i].x.value)
			{
				if (x1>px[i].x.flag) x1=px[i].x.flag;
				j=i+1;
				do{
					px[j-1].key=px[j].key;
				} while(px[j++].key);
			}
		}
	
		else i++;
	}
	px[i].x.flag=x1;
	px[i].x.value=x2;
}

//填充字库轮廓
static void FillFont(int numpoints,FONTPOINT *p,PEDGEFLAG *px)
{
	
	POINT p0,p1,pz;
	int minx,maxx;
	int i;
	int oldx,j,jj;
	int flag,pflag,hflag,s1;
	int x, y,deltax,deltay,s2,interchange,f,savex,savex0,save;
	int tempflag;
	
	for (i=0;i<numpoints;i++)
	{
		if ((p[i].pType&PT_MOVETO)==PT_MOVETO)
		{
			savex0=oldx=minx=maxx=p[i].pValue.x;
			flag=pflag=hflag=jj=0;
			p0=pz=p[i].pValue;
		}
		if ((p[i].pType&PT_CLOSEFIGURE)==PT_CLOSEFIGURE)
			p1=pz;
		else
			p1=p[i+1].pValue;
		if (p0.y!=p1.y)
		{
			if (hflag)
			{
				insert(px[p0.y],10,minx);
				insert(px[p0.y],-10,maxx);
			}
			if (p1.y>p0.y) tempflag=1;
			else tempflag=-1;
			if(p0.x==p1.x)
			{
				savex=save=p0.x;
				for (j=p0.y+tempflag;j!=p1.y;j+=tempflag)
					insert(px[j],tempflag,save);
			}
			else
			{
				if (tempflag>0) deltay=p1.y-p0.y;
				else deltay=p0.y-p1.y;
				if (p1.x>p0.x) {s1=1;deltax=p1.x-p0.x;}
				else {s1=-1;deltax=p0.x-p1.x;}
				if (tempflag==s1) {s2=1;save=p0.x;}
				else {s2=0;savex=p1.x;}
				if (deltay>deltax)
				{
					deltax^=deltay; deltay^=deltax; deltax^=deltay;
					interchange=1;
				}
				else
					interchange=0;
				deltay<<=1;
				f=deltay-deltax;
				deltax<<=1;
				deltax-=deltay;
				x=p0.x;y=p0.y;
				if (s2)
				{
					s2=p1.y-tempflag;
					while (y!=s2)
					{
						if(f>=0)
						{
							x+=s1;y+=tempflag;
							insert(px[y],tempflag,x);
							f-=deltax;
						}
						else
						{
							if (interchange)
							{
								y+=tempflag;
								insert(px[y],tempflag,x);
							}
							else x+=s1;
								f+=deltay;
						}
					}
					while (1)
					{
						if(f>=0)
						{
							x+=s1;
							break;
						}
						else
						{
							if (interchange) break;
							else x+=s1;
							f+=deltay;
						}
					}
					savex=x;
				}
				else
				{
					while (y==p0.y)
					{
						if(f>=0)
						{
							save=x;
							x+=s1;y+=tempflag;
							f-=deltax;
						}
						else
						{
							if (interchange)
							{
								save=x;
								y+=tempflag;
							}
							else  x+=s1;
								f+=deltay;
						}
					}
					while (y!=p1.y)
					{
						if(f>=0)
						{
							insert(px[y],tempflag,x);
							x+=s1;y+=tempflag;
							f-=deltax;
						}
						else
						{
							if (interchange)
							{
								insert(px[y],tempflag,x);
								y+=tempflag;
							}
							else  x+=s1;
							f+=deltay;
						}
					}
				}
				p0.x=p1.x;
			}
			if (jj)
			{
				if (flag==tempflag)
					insert(px[p0.y],tempflag,((flag>0)?(min(oldx,save)):(max(oldx,save))));
				else if (!hflag)
				{
					insert(px[p0.y],flag,oldx);
					flag=-flag;
					insert(px[p0.y],flag,save);
				}
				else flag=tempflag;
			}
			else {savex0=save;pflag=flag=tempflag;jj=1;}
			oldx=savex;
			hflag=0;
			p0.y=p1.y;
		}
		else 
		{
			if (!hflag)
			{
				minx=min(p1.x,p0.x);
				maxx=max(p1.x,p0.x);
				hflag=1;
			}
			else
			{
				if (minx>p1.x) minx=p1.x;
				else if (maxx<p1.x) maxx=p1.x;
			}
			p0.x=p1.x;
		}

		if ((p[i].pType&PT_CLOSEFIGURE)==PT_CLOSEFIGURE)
		{
			if (hflag)
			{
				insert(px[p0.y],10,minx);
				insert(px[p0.y],-10,maxx);
			}
			if (jj)
			{
				if (pflag==flag)
					insert(px[p0.y],flag,((flag>0)?(min(oldx,savex0)):(max(oldx,savex0))));
				else if (!hflag)
				{
					insert(px[p0.y],pflag,savex0);
					insert(px[p0.y],flag,oldx);
				}
			}
		}
	}
}

//calcaulate bezier 
static void Cal_Bezier2(POINT *p,FONTPOINT *point,int& n,BYTE b)
{
	POINT q[3];
	q[0].x=FIXINT(p[0].x,b);
	q[0].y=FIXINT(p[0].y,b);
	q[2].x=FIXINT(p[2].x,b)-q[0].x;
	q[2].y=FIXINT(p[2].y,b)-q[0].y;
	q[1].x=FIXINT(p[1].x,b)-q[0].x;
	q[1].y=FIXINT(p[1].y,b)-q[0].y;
	q[1].x=q[1].x*q[2].y-q[1].y*q[2].x;
	if (q[1].x)
	{
		q[0]=p[0];
		q[1].x=(p[0].x+p[1].x)>>1;
		q[1].y=(p[0].y+p[1].y)>>1;
		p[1].x=(p[1].x+p[2].x)>>1;
		p[1].y=(p[1].y+p[2].y)>>1;
		q[2].x=p[0].x=(q[1].x+p[1].x)>>1;
		q[2].y=p[0].y=(q[1].y+p[1].y)>>1;
		if (((p[0].x!=q[0].x)||(p[0].y!=q[0].y))&&((p[0].x!=p[2].x)||(p[0].y!=p[2].y)))	
		{
			Cal_Bezier2(q,point,n,b);
			Cal_Bezier2(p,point,n,b);
		}
		else
		{
			point[n].pValue=p[2];
			point[n++].pType=PT_LINETO;
		}
	}
	else
	{
		if (q[2].x||q[2].y)
		{
			point[n].pValue=p[2];
			point[n++].pType=PT_LINETO;
		}
		else
		{
			q[1].x=(p[1].x+((p[0].x+p[2].x)>>1))>>1;
			q[1].y=(p[1].y+((p[0].y+p[2].y)>>1))>>1;
			if ((FIXINT(q[1].x,b)!=q[0].x)||(FIXINT(q[1].y,b)!=q[0].y))
			{
				point[n].pValue=q[1];
				point[n++].pType=PT_LINETO;
				point[n].pValue=p[2];
				point[n++].pType=PT_LINETO;
			}
		}
	}
}

static void Cal_Bezier3(POINT *p,FONTPOINT *point,int& n,BYTE b)
{
	POINT q[4];
	q[0].x=FIXINT(p[0].x,b);
	q[0].y=FIXINT(p[0].y,b);
	//
	q[1].x=FIXINT(p[1].x,b)-q[0].x;
	q[1].y=FIXINT(p[1].y,b)-q[0].y;
	q[3].x=FIXINT(p[2].x,b)-q[0].x;
	q[3].y=FIXINT(p[2].y,b)-q[0].y;
	q[2].x=FIXINT(p[3].x,b)-q[0].x;
	q[2].y=FIXINT(p[3].y,b)-q[0].y;
	//
	q[1].x=q[1].x*q[2].y-q[1].y*q[2].x;
	q[3].x=q[3].x*q[2].y-q[3].y*q[2].x;
	
	if (q[1].x||q[3].x)
	{
		q[0]=p[0];
		q[1].x=(p[0].x+p[1].x)>>1;
		q[1].y=(p[0].y+p[1].y)>>1;
		q[3].x=(p[1].x+p[2].x)>>1;
		q[3].y=(p[1].y+p[2].y)>>1;
		q[2].x=(q[1].x+q[3].x)>>1;
		q[2].y=(q[1].y+q[3].y)>>1;
		p[2].x=(p[2].x+p[3].x)>>1;
		p[2].y=(p[2].y+p[3].y)>>1;
		p[1].x=(p[2].x+q[3].x)>>1;
		p[1].y=(p[2].y+q[3].y)>>1;
		p[0].x=q[3].x=(q[2].x+p[1].x)>>1;
		p[0].y=q[3].y=(q[2].y+p[1].y)>>1;
		if (((p[0].x!=q[0].x)||(p[0].y!=q[0].y))&&((p[0].x!=p[3].x)||(p[0].y!=p[3].y)))	
		{
			Cal_Bezier3(q,point,n,b);
			Cal_Bezier3(p,point,n,b);
		}
		else
		{
			point[n].pValue=p[3];
			point[n++].pType=PT_LINETO;
		}
	}
	else
	{
		if (q[2].x||q[2].y)
		{
			point[n].pValue=p[3];
			point[n++].pType=PT_LINETO;
		}
		else
		{
			q[1].x=(((p[0].x+p[1].x+p[2].x)<<1)+p[1].x+p[2].x)>>3;
			q[1].y=(((p[0].y+p[1].y+p[2].y)<<1)+p[1].y+p[2].y)>>3;
			if ((FIXINT(q[1].x,b)!=q[0].x)||(FIXINT(q[1].y,b)!=q[0].y))
			{
				point[n].pValue=q[1];
				point[n++].pType=PT_LINETO;
				point[n].pValue=p[3];
				point[n++].pType=PT_LINETO;
			}
		}
	}
}


//bezier convert into line
static void Bezier2_To_Line(POINT *p1,int m,FONTPOINT *point,int &n,BYTE b)
{
/*if (m==1)
{
point[n].pValue=p1[0];
point[n++].pType=PT_LINETO;
return;
}*/
	int i;
	POINT p[3];
	for (i=-1;i<=m-3;i++)
	{
		if (i<0)
			p[0]=point[n-1].pValue;
		else
			p[0]=p[2];
		p[1]=p1[i+1];
		if (i==m-3)
			p[2]=p1[m-1];
		else
		{
			p[2].x=(p1[i+2].x+p1[i+1].x)>>1;
			p[2].y=(p1[i+2].y+p1[i+1].y)>>1;
		}
		Cal_Bezier2(p,point,n,b);
	}
}

//bezier to line
static void Bezier3_To_Line(POINT *p1,int m,FONTPOINT *point,int &n,BYTE b)
{
	if (m==1)
	{
		point[n].pValue=p1[0];
		point[n++].pType=PT_LINETO;
		return;
	}
	else if (m==2)
	{
		Bezier2_To_Line(p1,m,point,n,b);
		return;
	}
	int i,ii;
	int nn=(m-1)>>1;
	BOOL flag=(m&1)?TRUE:FALSE;
	POINT p[4];
	for (i=0,ii=0;i<nn;i++,ii+=2)
	{
		if (i==0)
			p[0]=point[n-1].pValue;
		else
			p[0]=p[3];
		p[1]=p1[ii];
		p[2]=p1[ii+1];
		if ((i==nn-1)&&flag)
			p[3]=p1[m-1];
		else
		{
			p[3].x=(p1[ii+1].x+p1[ii+2].x)>>1;
			p[3].y=(p1[ii+1].y+p1[ii+2].y)>>1;
		}
		Cal_Bezier3(p,point,n,b);
	}
	if (!flag)
	{
		p[0]=p[3];
		p[1]=p1[m-2];
		p[2]=p1[m-1];
		Cal_Bezier2(p,point,n,b);
	}
	return;
}

#endif