using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace clrZiMuModel
{

    /// <summary>
    /// 字幕数据
    /// </summary>
    public class ZIMU
    {
        public UInt64 width;

        public UInt64 height;

        public List<RGBA> RGBAList;

        public ZIMU()
        {
            width = 0;
            height = 0;
            RGBAList = new List<RGBA>();
        }



        //获取图片
        public Bitmap GetBitmap()
        {
            Bitmap res = new Bitmap((int)width, (int)height);
            for (int x = 0; x < (int)width; x++)
            {
                for (int y = 0; y < (int)height; y++)
                {
                    int Index = x + (int)width * y;
                    Color color = RGBAList[Index].CoverTo();
                    res.SetPixel(x, y, color);
                }
            }

            return res;
        }
    }

    /// <summary>
    /// RGB像素点
    /// </summary>
    public class RGBA
    {
        public RGBA()
        {
            rgbBlue = 0;
            rgbGreen = 0;
            rgbRed = 0;
            rgbReserved = 0;
        }
        public UInt16 rgbBlue;
        public UInt16 rgbGreen;
        public UInt16 rgbRed;
        public UInt16 rgbReserved;

        public Color CoverTo()
        {
            Color res = Color.FromArgb(rgbReserved, rgbRed, rgbGreen, rgbBlue);
            return res;
        }

        static public RGBA Color2RGBA(Color color)
        {
            RGBA cRGBA = new RGBA();
            cRGBA.rgbBlue = color.B;
            cRGBA.rgbGreen = color.G;
            cRGBA.rgbRed = color.R;
            cRGBA.rgbReserved = color.A;
            return cRGBA;

        }
    }

    /// <summary>
    /// 填充属性
    /// </summary>
    public class FILLATTRIBclr
    {

        public FILLATTRIBclr()
        {
            FaceFillMode = new tagFILLMODEclr();      //表面填充模式
            EdgeFillMode = new tagFILLMODEclr();      //边框填充模式
            LitiFillMode = new tagFILLMODEclr();      //立体填充模式
            ShadeFillMode = new tagFILLMODEclr();     //阴影填充模式
        }

        //填充区域
        public Int64 FillScope = 0;
        //表面类型
        public Int16 FaceType = 0;

        public Int16 EdgeType = 0;              //边框类型
        public Int16 LitiType = 0;              //立体类型
        public Int16 ShadeType = 0;             //阴影类型
        public UInt16 FaceFillType = 0;          //表面着色类型
        public UInt16 EdgeFillType = 0;          //边框着色类型
        public UInt16 LitiFillType = 0;          //边框着色类型
        public UInt16 ShadeFillType = 0;         //阴影着色类型
        public UInt16 EdgeWidth = 0;             //边框宽度
        public UInt16 LitiWidth = 0;             //立体宽度
        public Int64 ShadeHoffset = 0;          //阴影水平偏距
        public Int64 ShadeVoffset = 0;          //阴影垂直偏距

        public tagFILLMODEclr FaceFillMode;      //表面填充模式
        public tagFILLMODEclr EdgeFillMode;      //边框填充模式
        public tagFILLMODEclr LitiFillMode;      //立体填充模式
        public tagFILLMODEclr ShadeFillMode;     //阴影填充模式

        public Int64 FaceTexture = 0;      //表面纹理号
        public Int64 EdgeTexture = 0;      //边框纹理号
        public Int64 LitiTexture = 0;      //立体纹理号
        public Int64 ShadeTexture = 0;     //阴影纹理号
        public Int64 FaceLight = 0;       //表面光感号
        public Int64 EdgeLight = 0;        //边框光感号
        public Int64 LitiLight = 0;        //立体光感号
        public Int64 ShadeLight = 0;       //阴影光感号
        public Int64 Reserved = 0;		//保留

    }

    /// <summary>
    /// 模式
    /// </summary>
    public class tagFILLMODEclr
    {
        public tagFILLMODEclr()
        {
            CurrentColor = new RGBA();
            this.TransitionColor = new COLORRECORDERclr();
            this.MaterialNo = 0;
        }

        public RGBA CurrentColor;          //表面当前颜色
        public Int64 MaterialNo;               //表面材质号
        public COLORRECORDERclr TransitionColor; //表面渐变颜色
    }

    /// <summary>
    /// //渐变色结构
    /// </summary>
    public class COLORRECORDERclr
    {
        public COLORRECORDERclr()
        {
            Color_Data = new List<RGBA>();
            Color_Pos = new List<int>();
            Color_Num = 0;
            Color_Type = 0;
            Color_Invert = 0;
        }

        public Int16 Color_Num;                                //关键点数（max=10)  
                                                               //note:left click add,right click sub
        public Int16 Color_Type;                               //color transition type：0--8
        public Int16 Color_Mode;                               //0：非对称，1：对称（中心辅射）
        public Int16 Color_Invert;                             //1：正向，0：反向
        public List<RGBA> Color_Data;                                //关键点颜色值(最多10)
        public List<int> Color_Pos;                                  //关键点位置所占比例(百分比）(最多10)
    }

    /// <summary>
    /// 字体
    /// </summary>
    public class WORDATTRIBclr
    {
        public WORDATTRIBclr()
        {
            ChineseFont = new LOG_FONT_METRICclr();
            EnglishFont = new LOG_FONT_METRICclr();
            SymbolFont = new LOG_FONT_METRICclr();
            StartPoint = new POINTclr();
            WordCurve = new List<POINTclr>();
            MorphKeyPoint = new POINTclr();
        }
        public LOG_FONT_METRICclr ChineseFont;    //中文字体
        public LOG_FONT_METRICclr EnglishFont;    //英文字体
        public LOG_FONT_METRICclr SymbolFont;    //图形符号类
        public bool IsSymbol = false;                  //TRUE:Symbol,False:text
        public UInt16 WordWidth = 0;                 //字宽
        public UInt16 WordHeight = 0;                //字高
        public Int16 WordColum = 0;                //字间距
        public Int16 WordRow = 0;                  //行间距
        public Int16 WordRotate = 0;               //字旋转角	
        public Int16 WordSlant = 0;                //字倾斜角
        public Int16 WordAlign = 0;                 //字排列方式
        public Int16 WordTab = 0;                   //字对齐方式
        public UInt16 MorphType = 0;                 //变形
        public POINTclr StartPoint;               //起始点
        public List<POINTclr> WordCurve;             //曲线路径4个
        public POINTclr MorphKeyPoint;			//变形关键点
    }

    public class POINTclr
    {
        public Int64 x;
        public Int64 y;
    }

    /// <summary>
    /// 字体
    /// </summary>
    public class LOG_FONT_METRICclr
    {
        public LOG_FONT_METRICclr()
        {
            Lf = new LOGFONTclr();
        }
        public LOGFONTclr Lf;
        public Int64 AveCharWidth = 0; //平均
        public Int64 MaxCharWidth = 0; //最大

        //public Font coverToFont()
        //{
        //    LOGFONT cLOGFONT;
        //    Font.FromLogFont();
        //}
    }

    public class LOGFONTclr
    {

        public LOGFONTclr()
        {
            lfFaceName = String.Empty;
        }
        public Int64 lfHeight = 0;
        public Int64 lfWidth = 0;
        public Int64 lfEscapement = 0;
        public Int64 lfOrientation = 0;
        public Int64 lfWeight = 0;
        public Int16 lfItalic = 0;
        public Int16 lfUnderline = 0;
        public Int16 lfStrikeOut = 0;
        public Int16 lfCharSet = 0;
        public Int16 lfOutPrecision = 0;
        public Int16 lfClipPrecision = 0;
        public Int16 lfQuality = 0;
        public Int16 lfPitchAndFamily = 0;
        public String lfFaceName;
    }

    /// <summary>
    /// 字幕类型
    /// </summary>
    public enum ZIMU_TYPESclr
    {
        TYPE_NONE = 0,  //无类型
        TYPE_TB = 1,    //台标
        TYPE_SZ,        //时钟
        TYPE_JB,        //角标
        TYPE_DH,        //动画
        TYPE_ZF,        //左飞
        TYPE_SG,        //上滚
        TYPE_BJ         //全屏背景
    }

    /// <summary>
    /// 矩形
    /// </summary>
    public class RECTclr
    {
        public Int64 left;
        public Int64 top;
        public Int64 right;
        public Int64 bottom;

        public RECTclr()
        {
            left = 0;
            top = 0;
            right = 0;
            bottom = 0;
        }
    }

    public class ZIMUEXTRAATTRIBclr
    {
        public ZIMU_TYPESclr zmType;            //字幕类型

        public RECTclr rect;                   //播出范围

        ////字幕背景图或颜色定义
        public int BackColorType;          //背景颜色类型：0=没有背景；1=单色背景；2=渐变色；3=背景图形
        public RGBA BackSingleColor;     //当BackColorType==1时保存的背景颜色
        public COLORRECORDERclr BackTransition;//当BackColorType==2时保存的背景渐变色
        public string Backname;    //当BackColorType==3时保存的背景图形

        public uint uSpan;                   //字幕间距。仅对单行左飞、单行上滚有效，表示连续两个字幕的播出间隔	
        public uint uSpeed;                  //播出速度，对动画序列或天气预报表示切换时间,单位为：毫秒(ms)
        public uint Alpha;                   //透明度(0-255)，计算时按照百分比：Alpha/255

        public ZIMUEXTRAATTRIBclr()
        {
            zmType = ZIMU_TYPESclr.TYPE_NONE;
            rect = new RECTclr();
            BackColorType = 0;
            BackSingleColor = new RGBA();
            BackTransition = new COLORRECORDERclr();
            Backname = string.Empty;
            uSpan = 0;
            uSpeed = 0;
            Alpha = 0;
        }
    }



    public class SYSTEMTIMECtr
    {
        public ushort wYear;
        public ushort wMonth;
        public ushort wDayOfWeek;
        public ushort wDay;
        public ushort wHour;
        public ushort wMinute;
        public ushort wSecond;
        public ushort wMilliseconds;
    }


    /// <summary>
    /// 编辑头信息
    /// </summary>
    public class tagZIMUFILEHEADclr
    {
        public string szFlag;//文件标识，固定为20字节，值为：SzintelZm，用于判断文件是否是我们生成的字幕文件

        //版本号：用主版本、小版本两个整数表示，如1.0等
        public Int32 iMainVer;       //主版本
        public Int32 iMinVer;        //小版本

        public Int32 iFramesNum;     //帧数，一个高清帧大小为1920*1080*4字节

        //字幕帧与视频帧叠加时需要的几个参数：
        public ZIMU_TYPESclr zmType;      //字幕类型
        public RECTclr rect;             //有效播出范围

        public SYSTEMTIMECtr time;        //保存时间
        public string author;       //作者
        public List<Int16> reserved; //保留字节，便于将来扩充

        /// <summary>
        /// 字幕编辑
        /// </summary>
        public tagZIMUFILEHEADclr()
        {
            reserved = new List<short>();
            time = new SYSTEMTIMECtr();
            rect = new RECTclr();
            szFlag = "SzintelZm";
            zmType = ZIMU_TYPESclr.TYPE_NONE;
            author = "szzh";
        }



    }


}
