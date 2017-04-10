using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeSample
{
    /// <summary>
    /// 工程详细信息包括工程文件名、工程文件路径、长度、更新人、更新时间、
    /// 视频信息（分辨率、帧率、像素宽高比、扫描模式）、
    /// 音频信息（音频格式、音频流数、声道类型、音频采样频率、音频比特率）、备注等。
    /// 其中：
    /// 长度：显示工程或素材的总长度。
    /// 更新人：上传素材或最后提交工程的用户。
    /// 更新时间：上传素材或最后提交工程的时间。
    /// 分辨率：工程或素材的分辨率。
    /// 帧率：工程或素材的帧率
    /// 音频信息：包含音频采样频率、比特率及声道类型。
    /// 音频流数：原始音频素材包含的流数。
    /// 备注：双击此项为素材添加批注。
    /// </summary>
    [Serializable]
    public class ProjectInfo
    {
        public ProjectInfo()
        {
            
        }

        public ProjectInfo(string name, string path, long len, string updater, DateTime time, 
            VideoInfoStruct videoInfo, AudioInfoStruct audioInfo, string remarks)
        {
            ProjectName = name;
            ProjectPath = path;
            Length = len;
            UpdateUser = updater;
            UpdateTime = time;
            VideoInfo = videoInfo;
            AudioInfo = audioInfo;
            Remarks = remarks;
        }

        public string ProjectName { get; set; }
        public string ProjectPath { get; set; }
        public long Length { get; set; }
        public string UpdateUser { get; set; }
        public DateTime UpdateTime { get; set; }
        public VideoInfoStruct VideoInfo;
        public AudioInfoStruct AudioInfo;
        public string Remarks { get; set; }
    }

    /// <summary>
    /// 视频信息
    /// </summary>
    [Serializable]
    public struct VideoInfoStruct
    {
        public VideoInfoStruct(ResolutionStruct theResolution, double theFps, PixelRatioStruct thePixelRatio, ScanMode theScanMode)
        {
            resolution = theResolution;
            fps = theFps;
            pixelRatio = thePixelRatio;
            scanMode = theScanMode;
        }

        public ResolutionStruct resolution;
        public double fps;
        public PixelRatioStruct pixelRatio;
        public ScanMode scanMode;
    }

    /// <summary>
    /// 视频分辨率
    /// </summary>
    [Serializable]
    public struct ResolutionStruct
    {
        public ResolutionStruct(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }
    }

    /// <summary>
    /// 像素宽高比
    /// </summary>
    [Serializable]
    public struct PixelRatioStruct
    {
        public PixelRatioStruct(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }
    }

    /// <summary>
    /// 视频扫描模式
    /// </summary>
    public enum ScanMode
    {
        ScanMode_0 = 0,
        ScanMode_1 = 1,
    }

    /// <summary>
    /// 音频信息
    /// </summary>
    [Serializable]
    public struct AudioInfoStruct
    {
        public AudioInfoStruct(string audioFormat, int audioNums, TractType tractType, int samplingHz, int kbps)
        {
            this.audioFormat = audioFormat;
            this.audioNums = audioNums;
            this.tractType = tractType;
            this.samplingHz = samplingHz;
            this.kbps = kbps;
        }

        public string audioFormat;
        public int audioNums;
        public TractType tractType;
        public int samplingHz;
        public int kbps;
    }

    /// <summary>
    /// 声道类型
    /// </summary>
    public enum TractType
    {
        left_channel,
        right_channel,
        stereo
    }

}
