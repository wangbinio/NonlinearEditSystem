using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Common;

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
    /// 修改：2017-06-27 szwb 自己序列化保存与打开
    /// 修改：2017-08-01 szwb 修改工程保存的信息
    /// </summary>
    [Serializable]
    public class ProjectInfo
    {
        public ProjectInfo()
        {

        }

        public ProjectInfo(string version, string name, string path, string updater, DateTime time, string fileList,           TimeLineInfoStruct theTimeLineInfo, string remarks)
        {
            ProjectVersion = version;
            ProjectName = name;
            ProjectPath = path;
            UpdateUser = updater;
            UpdateTime = time;
            FileListPath = fileList;
            timeLineInfo = theTimeLineInfo;
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
        //public long Length { get; set; }

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
        //public VideoInfoStruct VideoInfo;

        /// <summary>
        /// 音频信息
        /// </summary>
        //public AudioInfoStruct AudioInfo;

        // FileListView文件夹
        public string FileListPath { get; set; }

        // 时间线信息
        public TimeLineInfoStruct timeLineInfo = new TimeLineInfoStruct();

        // 文件面板信息
        public List<FilePanelStruct> filePanels = new List<FilePanelStruct>(10);

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
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(ProjectInfo));
                Stream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                ProjectInfo projectInfo = xs.Deserialize(stream) as ProjectInfo;

                if (projectInfo != null)
                {
                    ProjectVersion = projectInfo.ProjectVersion;
                    ProjectName = projectInfo.ProjectName;
                    ProjectPath = projectInfo.ProjectPath;
                    UpdateUser = projectInfo.UpdateUser;
                    UpdateTime = projectInfo.UpdateTime;
                    FileListPath = projectInfo.FileListPath;
                    timeLineInfo = projectInfo.timeLineInfo;
                    filePanels = projectInfo.filePanels;
                    Remarks = projectInfo.Remarks;
                }

                stream.Close();
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }
        }

        /// <summary>
        /// 序列化文件存储到本地
        /// </summary>
        public void Save()
        {
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(ProjectInfo));
                ProjectVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
                UpdateUser = Environment.UserName;
                UpdateTime = DateTime.Now;
                Stream stream = new FileStream(ProjectPath + @"\" + ProjectName, FileMode.Create, FileAccess.Write, FileShare.Read);
                xs.Serialize(stream, this);
                stream.Close();
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }
        }

    }

    /// <summary>
    /// 用于保存时间线信息
    /// </summary>
    [Serializable]
    public class TimeLineInfoStruct
    {
        /// 当前一小格的时间值
        public int indexOfSecEveryTicks;

        /// 入点位置
        public int enterPos;

        /// 出点位置
        public int exitPos;

        /// 游标位置
        public int thumbHPos;

        public TimeLineInfoStruct()
        {
            indexOfSecEveryTicks = 3;
            enterPos = 100;
            exitPos = 300;
            thumbHPos = 200;
        }

        public TimeLineInfoStruct(int index, int enter, int exit, int thumb)
        {
            indexOfSecEveryTicks = index;
            enterPos = enter;
            exitPos = exit;
            thumbHPos = thumb;
        }
    }

    /// <summary>
    /// 用于保存文件面板信息
    /// </summary>
    [Serializable]
    public class FilePanelStruct
    {
        // 面板名称
        public string name;

        // 面板Text
        public string text;

        // 横坐标
        public int x;

        // 宽度
        public int width;

        // tag
        public string tag;

        // parentindex
        public int parentIndex;

        public FilePanelStruct()
        {
            name = string.Empty;
            x = 0;
            width = 0;
            tag = string.Empty;
            parentIndex = 0;
        }

        public FilePanelStruct(string theName, string theText, int theX, int theWidth, string theTag, int theParentIndex)
        {
            name = theName;
            text = theText;
            x = theX;
            width = theWidth;
            tag = theTag;
            parentIndex = theParentIndex;
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
