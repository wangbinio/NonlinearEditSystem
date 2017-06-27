using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NonLinearEditSystem
{
    /// <summary>
    /// 类说明：
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
    /// 
    /// 日期：2017-04-10
    /// 作者：szwb
    /// 修改：2017-04-11 szwb 添加版本控制
    /// </summary>
    [Serializable]
    public class ProjectInfo
    {
        public ProjectInfo()
        {
            
        }

        public ProjectInfo(string version, string name, string path, long len, string updater, DateTime time, 
            VideoInfoStruct videoInfo, AudioInfoStruct audioInfo, string remarks)
        {
            ProjectVersion = version;
            ProjectName = name;
            ProjectPath = path;
            Length = len;
            UpdateUser = updater;
            UpdateTime = time;
            VideoInfo = videoInfo;
            AudioInfo = audioInfo;
            Remarks = remarks;
        }



        /// <summary>
        /// 工程版本
        /// </summary>
        public string ProjectVersion { get; set; }

        /// <summary>
        /// 工程文件名
        /// </summary>
        public string ProjectName { get; set; }

        /// <summary>
        /// 工程文件路径
        /// </summary>
        public string ProjectPath { get; set; }

        /// <summary>
        /// 长度
        /// </summary>
        public long Length { get; set; }

        /// <summary>
        /// 更新人
        /// </summary>
        public string UpdateUser { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// 视频信息
        /// </summary>
        public VideoInfoStruct VideoInfo;

        /// <summary>
        /// 音频信息
        /// </summary>
        public AudioInfoStruct AudioInfo;

        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks { get; set; }


        /// <summary>
        /// 从本地文件中反序列化出类
        /// </summary>
        /// <param name="fileName"></param>
        public void Load(string fileName)
        {
            XmlSerializer xs = new XmlSerializer(typeof(ProjectInfo));
            Stream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            ProjectInfo projectInfo = xs.Deserialize(stream) as ProjectInfo;

            if (projectInfo != null)
            {
                ProjectVersion = projectInfo.ProjectVersion;
                ProjectName = projectInfo.ProjectName;
                ProjectPath = projectInfo.ProjectPath;
                Length = projectInfo.Length;
                UpdateUser = projectInfo.UpdateUser;
                UpdateTime = projectInfo.UpdateTime;
                VideoInfo = projectInfo.VideoInfo;
                AudioInfo = projectInfo.AudioInfo;
                Remarks = projectInfo.Remarks;
            }

            stream.Close();
        }

        /// <summary>
        /// 序列化文件存储到本地
        /// </summary>
        public void Save()
        {
            XmlSerializer xs = new XmlSerializer(typeof(ProjectInfo));
            Stream stream = new FileStream(ProjectPath + @"\" + ProjectName, FileMode.Create, FileAccess.Write, FileShare.Read);
            xs.Serialize(stream, this);
            stream.Close();
        }

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
