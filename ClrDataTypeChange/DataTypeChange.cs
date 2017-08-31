using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClrDataTypeChange
{
    public class DataTypeChange
    {

        
    }

    public class StringList : List<String>
    {

    }


    //素材信息结构
    public class tagClipInfoCLR
    {
        public string szClipFile;//素材文件名
        public int streamcount;//包含的流数量

        //视频流信息
        public int Vsamplecount; //帧数
        public double Vduration;    //时长（单位：s）
        public int Vwidth;       //宽度
        public int Vheight;      //高度
        public int/*majortypes_t*/  Vmajortype;   //主类型，值参见mcmediatypes.h中mcmajortypes_t定义
        public int/*mediatypes_t*/  Vmediatype;   //媒体类型，值参见mcmediatypes.h中mcmediatypes_t定义

        //音频流信息
        public int Asamplecount; //帧数
        public double Aduration;    //时长（单位：s）
        public int/*majortypes_t*/  Amajortype;   //主类型，值参见mcmediatypes.h中mcmajortypes_t定义
        public int/*mediatypes_t*/  Amediatype;   //媒体类型，值参见mcmediatypes.h中mcmediatypes_t定义

        public tagClipInfoCLR()
        {
            szClipFile      = string.Empty;
            streamcount     = 0;
            Vsamplecount    = 0;
            Vduration       = 0;
            Vwidth          = 0;
            Vheight         = 0;
            Vmajortype      = 0;
            Vmediatype      = 0;
            Asamplecount    = 0; 
            Aduration       = 0; 
            Amajortype      = 0;
            Amediatype      = 0;
        }
    }

    //音视频分离原始素材信息结构
    public class tagDemuxClipInfoCLR
    {
        //以下三个为输入参数
        public string szClipFile;//素材文件名
        public long rtPos;//入点（单位：ms），如果不设置，则赋值0
        public long rtEndPos;//出点（单位：ms），如果不设置，则赋值0

        //以下三个为输出参数，不需要赋值，接口AddClip执行完成后返回值
        public string szDemuxedVFile;//分离的视频文件名
        public string szDemuxedAFile;//分离的音频文件名
        public double duration;//时长（单位：s）

        public tagDemuxClipInfoCLR()
        {
            szClipFile = string.Empty;
            rtPos = 0;
            rtEndPos = 0;
            szDemuxedVFile = string.Empty;
            szDemuxedAFile = string.Empty;
            duration = 0;
        }

        public tagDemuxClipInfoCLR(string cClipFile, long crtPos, long crtEndPos)
        {
            szClipFile = cClipFile;
            rtPos = crtPos;
            rtEndPos = crtEndPos;
            szDemuxedVFile = string.Empty;
            szDemuxedAFile = string.Empty;
            duration = 0;
        }
    }

    //字幕轨字幕信息结构
    public class tagZimuMixInfoCLR
    {
        public string szZimuFile;//字幕文件名
        public long rtStartPos;//开始时间（单位：ms）
        public long rtStopPos;//结束时间（单位：ms）
    
        // public int Type;//字幕类型，0 = 静态字幕；1=左飞；2=上滚
        public int Level;//字幕层次，当多层字幕时，上一层字幕将遮挡下一层字幕；数字越小表示层次越高，即0表示最顶层；1表示第二层，以此类推。
        public tagZimuMixInfoCLR()
        {
            szZimuFile = string.Empty;
            rtStartPos = 0;
            rtStopPos = 0;
            // Type = 0;
            Level = 0;
        }
    }

    public class tagZimuPreviewInfoCLR
    {
        public string szZimuFile;//字幕文件名
        public long rtStartPos;//在预览素材中的开始时间（单位：ms）
        public long rtStopPos;//在预览素材中的结束时间（单位：ms）

        public long duration;//字幕总播出时长（单位：ms）
        public long start;//字幕在预览素材中的开始时刻（单位：ms）

        public int Level;//字幕层次，当多层字幕时，上一层字幕将遮挡下一层字幕；数字越小表示层次越高，即0表示最顶层；1表示第二层，以此类推。

        public tagZimuPreviewInfoCLR()
        {
            szZimuFile = string.Empty;
            rtStartPos = 0;
            rtStopPos = 0;
            duration = 0;
            start = 0;
            Level = 0;
        }
    }

    //打包视频参数  --- 指可由用户设置的视频参数
    public class tagVideoParametersCLR
    {
        public int bit_rate;//比特率，单位：kbits/sec；缺省值：6000 (kbits/sec)

        public tagVideoParametersCLR()
        {
            bit_rate = 6000;
        }
    }


    //打包音频参数 --- 指可由用户设置的音频参数
    public class tagAudioParametersCLR
    {
        public double sample_rate;//音频采样频率，单位：kHz；常用音频采样频率有8kHz、11.025kHz、22.05kHz、16kHz、37.8kHz、44.1kHz、48kHz等，缺省值：44.1(kHz)

        public int bit_rate;//码率，单位：kbits/sec；可选的值有：0, 6, 7, 8, 10, 12, 14, 16, 20, 24, 28, 32, 40, 48, 56, 64, 80, 96, 112, 128, 160, 192, 224, 256, 320, 384, 448, 512, 640, 768, 896, 1024等，缺省值：160(kbits/sec)

        public tagAudioParametersCLR()
        {
            sample_rate = 44.1;
            bit_rate = 160;
        }
    }


    public class DemuxClipInfoList : BindingList<tagDemuxClipInfoCLR>
    {

    }

    public class ZimuMixInfoList : BindingList<tagZimuMixInfoCLR>
    {

    }

    public class ZimuPreviewInfoList : BindingList<tagZimuPreviewInfoCLR>
    {

    }



}
