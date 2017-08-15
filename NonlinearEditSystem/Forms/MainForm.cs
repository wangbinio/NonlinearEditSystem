using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ClrInterfaceDll;
using Common;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using NonLinearEditSystem.Properties;
using XNetUtilities;
using ClrDataTypeChange;
using System.Diagnostics;
using NonLinearEditSystem;

namespace NonLinearEditSystem.Forms
{
    public partial class MainForm : MetroForm
    {

        #region 成员变量

        // 浮点数比较精度
        public static readonly double EPSON = 0.001;

        // 背景颜色
        public static Color bkgColor = Color.FromArgb(69, 69, 69);

        // 字体颜色
        public static Color fontsColor = Color.FromArgb(239, 239, 242);
        //public static Color fontsColor = Color.FromArgb(1, 1, 1);

        // 工程文件信息

        // 工程信息
        private ProjectInfo projectInfo = new ProjectInfo();

        // 数据库连接字符串
        private String _connectionString = "server=localhost;database=NonLinearEditSystem;uid=sa;pwd=123456;";

        // 视频播放接口类
        private ClipPlayControlCSharp _iClipPlayControlCSharp;

        // 音视频分离类
        //private Mp4DemuxIOCSharp _mp4DemuxIOCSharp;

        // 编解码类
        //private H264CodecIOCSharp _h264CodecIOCSharp;

        // 打包类
        //private Mp4FilesMuxIOCSharp _mp4FilesMuxIOCSharp;

        // 打包综合类
        public PacketIOCSharp packetIOCSharp;

        // 文件列表中选择的目录
        private string[] _choosedDirFullPath;

        // 文件列表中选择的文件
        private string[] _choosedFileFullPath;

        // 视频轨道上的视频文件
        private List<PanelEx> _vedioFilesPanel;

        // 音频轨道上的音频文件
        private List<PanelEx> _audioFilesPanel;

        // 轨道上文件个数
        private int _maxFilesPannel = 10;

        // 鼠标拖动音/视频文件panel时保存位置差
        private int _mousePosDeltaX = 0;
        private int _mousePosDeltaY = 0;

        // 音视频文件在轨道上的面板高度
        public static int trackHeight = 34;

        // 辅助操作面板
        private PanelEx operatorPanel;

        // 视频轨道面板1234
        private List<PanelEx> _vedioTrackPanels;

        // 音频轨道面板12
        private List<PanelEx> _audioTrackPanels;

        // 所有视频的开始/结束时间
        public List<double> sortedVedioTimes;

        // 素材路径
        public string theClipsPath = @"D:\视频素材";

        // 垫片路径
        public static string BlackVedio = @"D:\视频素材\BlackVedio.mp4";

        // 打包素材基本信息
        public struct PackageClips
        {
            public string strClipFileName;
            public Int64 rtPos;
            public Int64 rtEndPos;

            public PackageClips(string name, Int64 beginPos, Int64 endPos)
            {
                strClipFileName = name;
                rtPos = beginPos;
                rtEndPos = endPos;
            }
        }

        // 打包素材列表
        public DemuxClipInfoList packageClipsList;

        // 图标资源
        private static Icon _icon_eye_open = Resource.eye_open_16px;
        private static Icon _icon_eye_closed = Resource.eye_closed_16px;
        private static Icon _icon_lock_open = Resource.lock_open_16px;
        private static Icon _icon_lock_closed = Resource.lock_closed_16px;
        private static Icon _icon_volume_full = Resource.volume_full_16px;
        private static Icon _icon_volume_muted = Resource.volume_muted_16px;
        private static Icon _icon_headphone_open = Resource.headphone_open_16px;
        private static Icon _icon_headphone_closed = Resource.headphone_closed_16px;




        #endregion 成员变量


        #region 控件变量

        /// <summary>
        /// 时间线游标当前时间
        /// </summary>
        public string TimelineCurrentTime => labelItem_CurrentTime.Text;

        /// <summary>
        /// 轨道上的视频素材
        /// </summary>
        public List<PanelEx> listVedioClips = new List<PanelEx>();


        #endregion


        #region 给子界面使用的变量

        // 打包进度
        public double dPacketProcess = 0;

        // 打包是否完成
        public bool bPakcetFinish = false;

        #endregion


        #region 初始化工作

        public MainForm()
        {
            InitializeComponent();

            VideoFile1.Enabled = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            projectInfo = new ProjectInfo();

            ExecuteBat();

            InitAllChildForm();

            InitVedioAndAudioTrackPanels();

            CreateOperatorPanel();

            InitVedioAndAudioFilePanels();

            InitPlayControl();

            InitTimeLineControl();

            // TODO:现在显示的是数据库的内容,
            //ShowClipsInFileBox();

            // 测试版本显示本地文件夹的内容
            //ShowDirInFileBox(theClipsPath);
            label_FileInfo.Text = string.Empty;


            // 创建所有右键菜单
            CreateAllMenu();

            // 初始化控件颜色
            InitControlsColor();

            // 初始化图标
            InitIcons();
        }

        /// <summary>
        /// 执行脚本删除打包过程中残留文件
        /// </summary>
        public void ExecuteBat()
        {
            try
            {
                Process proc = new Process();
                proc.StartInfo.FileName = @".\del.bat";
                proc.StartInfo.CreateNoWindow = false;
                proc.Start();
                proc.WaitForExit();
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }
        }

        private void InitVedioAndAudioTrackPanels()
        {
            // 初始化音视频轨道panel
            _vedioTrackPanels = new List<PanelEx>(4);
            _vedioTrackPanels.Add(panelEx_VideoTrackConment4);
            _vedioTrackPanels.Add(panelEx_VideoTrackConment3);
            _vedioTrackPanels.Add(panelEx_VideoTrackConment2);
            _vedioTrackPanels.Add(panelEx_VideoTrackConment1);

            _audioTrackPanels = new List<PanelEx>(2);
            _audioTrackPanels.Add(panelEx_AudioTrackConment1);
            _audioTrackPanels.Add(panelEx_AudioTrackConment2);

            foreach (var panel in _vedioTrackPanels)
            {
                panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelEx_VideoTrackConment1_MouseMove);
                //panel.MouseEnter += panelEx_VideoTrackConment1_MouseEnter;
            }

            // 创建右键菜单
            CreateTrackBlankMenu();
        }

        /// <summary>
        /// 创建操作辅助面板,用于轨道上的文件操作
        /// </summary>
        private void CreateOperatorPanel()
        {
            operatorPanel = new PanelEx();

            operatorPanel.CanvasColor = System.Drawing.SystemColors.Control;
            operatorPanel.ColorSchemeStyle =
                DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            operatorPanel.DisabledBackColor = System.Drawing.Color.Empty;
            operatorPanel.Location = new System.Drawing.Point(0, 0);
            operatorPanel.Size = new System.Drawing.Size(200, panelEx_VideoTrackConment1.Height);
            operatorPanel.Style.Alignment = System.Drawing.StringAlignment.Center;
            operatorPanel.Style.BackColor1.Color = System.Drawing.Color.SteelBlue;
            operatorPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            operatorPanel.Style.BorderColor.ColorSchemePart =
                DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            operatorPanel.Style.ForeColor.ColorSchemePart =
                DevComponents.DotNetBar.eColorSchemePart.PanelText;
            operatorPanel.Style.GradientAngle = 90;
            operatorPanel.StyleMouseDown.Alignment = System.Drawing.StringAlignment.Center;
            operatorPanel.StyleMouseDown.BackColor1.Alpha = ((byte)(128));
            operatorPanel.StyleMouseDown.BackColor1.Color = System.Drawing.Color.SteelBlue;
            operatorPanel.StyleMouseOver.Alignment = System.Drawing.StringAlignment.Center;
            operatorPanel.StyleMouseOver.BackColor1.Alpha = ((byte)(128));
            operatorPanel.StyleMouseOver.BackColor1.Color = System.Drawing.Color.DodgerBlue;
            operatorPanel.TabIndex = 0;
            operatorPanel.Name = "operatorPanel";
            operatorPanel.Text = "";
            operatorPanel.Tag = "";

            operatorPanel.Style.BackColor1.Alpha = 0;
            operatorPanel.Style.BackColor1.Color = Color.Transparent;
            operatorPanel.Style.BackColor2.Alpha = 0;
            operatorPanel.Style.BackColor2.Color = Color.Transparent;
            operatorPanel.Style.BackgroundImage = Resource._0140230_50;
            operatorPanel.StyleMouseDown.BackColor1.Alpha = 0;
            operatorPanel.StyleMouseDown.BackColor1.Color = Color.Transparent;
            operatorPanel.StyleMouseDown.BackColor2.Alpha = 0;
            operatorPanel.StyleMouseDown.BackColor2.Color = Color.Transparent;
            operatorPanel.StyleMouseDown.BackgroundImage = Resource._0140230_50;
            operatorPanel.StyleMouseOver.BackColor1.Alpha = 0;
            operatorPanel.StyleMouseOver.BackColor1.Color = Color.Transparent;
            operatorPanel.StyleMouseOver.BackColor2.Alpha = 0;
            operatorPanel.StyleMouseOver.BackColor2.Color = Color.Transparent;
            operatorPanel.StyleMouseOver.BackgroundImage = Resource._0140230_50;
        }

        /// <summary>
        /// 初始化音视频轨道文件panel
        /// </summary>
        private void InitVedioAndAudioFilePanels()
        {
            try
            {
                // 初始化音视频文件panel
                //_vedioFilesPanel.Clear();
                //_audioFilesPanel.Clear();
                _vedioFilesPanel = new List<PanelEx>(_maxFilesPannel);
                _audioFilesPanel = new List<PanelEx>(_maxFilesPannel);
                ;

                for (int i = 0; i < _maxFilesPannel; i++)
                {
                    PanelEx tempVedioPanel = new PanelEx();
                    PanelEx tempAudioPanel = new PanelEx();

                    tempVedioPanel.CanvasColor = System.Drawing.SystemColors.Control;
                    tempVedioPanel.ColorSchemeStyle =
                        DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
                    tempVedioPanel.DisabledBackColor = System.Drawing.Color.Empty;
                    tempVedioPanel.Location = new System.Drawing.Point(0, 0);
                    tempVedioPanel.Size = new System.Drawing.Size(200, panelEx_VideoTrackConment1.Height);
                    tempVedioPanel.Style.Alignment = System.Drawing.StringAlignment.Center;
                    tempVedioPanel.Style.BackColor1.Color = System.Drawing.Color.SteelBlue;
                    tempVedioPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
                    tempVedioPanel.Style.BorderColor.ColorSchemePart =
                        DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
                    tempVedioPanel.Style.ForeColor.ColorSchemePart =
                        DevComponents.DotNetBar.eColorSchemePart.PanelText;
                    tempVedioPanel.Style.GradientAngle = 90;
                    tempVedioPanel.StyleMouseDown.Alignment = System.Drawing.StringAlignment.Center;
                    tempVedioPanel.StyleMouseDown.BackColor1.Alpha = ((byte)(128));
                    tempVedioPanel.StyleMouseDown.BackColor1.Color = System.Drawing.Color.SteelBlue;
                    tempVedioPanel.StyleMouseOver.Alignment = System.Drawing.StringAlignment.Center;
                    tempVedioPanel.StyleMouseOver.BackColor1.Alpha = ((byte)(128));
                    tempVedioPanel.StyleMouseOver.BackColor1.Color = System.Drawing.Color.DodgerBlue;
                    tempVedioPanel.TabIndex = 0;
                    tempVedioPanel.Name = "VideoFile" + i;
                    tempVedioPanel.Text = "VideoFile" + i;
                    tempVedioPanel.Tag = "";
                    tempVedioPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VideoFile_MouseDown);
                    tempVedioPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VideoFile_MouseMove);
                    tempVedioPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.VideoFile_MouseUp);
                    //tempVedioPanel.MouseEnter += panelEx_VideoTrackConment1_MouseEnter;


                    tempAudioPanel.CanvasColor = System.Drawing.SystemColors.Control;
                    tempAudioPanel.ColorSchemeStyle =
                        DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
                    tempAudioPanel.DisabledBackColor = System.Drawing.Color.Empty;
                    tempAudioPanel.Location = new System.Drawing.Point(0, 0);
                    tempAudioPanel.Size = new System.Drawing.Size(200, panelEx_AudioTrackConment1.Height);
                    tempAudioPanel.Style.Alignment = System.Drawing.StringAlignment.Center;
                    tempAudioPanel.Style.BackColor1.Color = System.Drawing.Color.MediumAquamarine;
                    tempAudioPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
                    tempAudioPanel.Style.BorderColor.ColorSchemePart =
                        DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
                    tempAudioPanel.Style.ForeColor.ColorSchemePart =
                        DevComponents.DotNetBar.eColorSchemePart.PanelText;
                    tempAudioPanel.Style.GradientAngle = 90;
                    tempAudioPanel.StyleMouseDown.Alignment = System.Drawing.StringAlignment.Center;
                    tempAudioPanel.StyleMouseDown.BackColor1.Alpha = ((byte)(128));
                    tempAudioPanel.StyleMouseDown.BackColor1.Color = System.Drawing.Color.MediumAquamarine;
                    tempAudioPanel.StyleMouseOver.Alignment = System.Drawing.StringAlignment.Center;
                    tempAudioPanel.StyleMouseOver.BackColor1.Alpha = ((byte)(128));
                    tempAudioPanel.StyleMouseOver.BackColor1.Color = System.Drawing.Color.MediumAquamarine;
                    tempAudioPanel.TabIndex = 0;
                    tempAudioPanel.Name = "AudioFile" + i;
                    tempAudioPanel.Text = "AudioFile" + i;
                    tempAudioPanel.Tag = "";
                    tempAudioPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VideoFile_MouseDown);
                    tempAudioPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VideoFile_MouseMove);
                    tempAudioPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.VideoFile_MouseUp);
                    //tempAudioPanel.MouseEnter += panelEx_VideoTrackConment1_MouseEnter;

                    _vedioFilesPanel.Add(tempVedioPanel);
                    _audioFilesPanel.Add(tempAudioPanel);
                }

                // 每次初始化都应该创建右键菜单
                CreateTrackFileMenu();

                UpdateTrackWidthWhenAddFile(0);
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }
        }

        /// <summary>
        /// 初始化视频播放组件
        /// </summary>
        private void InitPlayControl()
        {
            try
            {
                _iClipPlayControlCSharp = new ClipPlayControlCSharp();

                //_mp4DemuxIOCSharp = new Mp4DemuxIOCSharp();
                //
                //_h264CodecIOCSharp = new H264CodecIOCSharp();
                //
                //_mp4FilesMuxIOCSharp = new Mp4FilesMuxIOCSharp();

                packetIOCSharp = new PacketIOCSharp();
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }
        }

        /// <summary>
        /// 初始化时间线
        /// </summary>
        private void InitTimeLineControl()
        {
            timeLineControl_MainTL.SetRelativeControl(timeLineControl_Sequence);
            timeLineControl_Sequence.SetRelativeControl(timeLineControl_MainTL);
            timeLineControl_Sequence.NDistanceOfTicks = 10;
            timeLineControl_MainTL.Invalidate();
            timeLineControl_Sequence.Invalidate();
            UpdateLabelTime();
        }

        /// <summary>
        /// 初始化控件颜色
        /// </summary>
        private void InitControlsColor()
        {
            listView_Files.BackColor = bkgColor;
        }



        /// <summary>
        /// 初始化按钮图标
        /// </summary>
        private void InitIcons()
        {
            // 眼睛按钮图标
            VideoTrackB1BI_See.Icon = _icon_eye_open;
            VideoTrackB2BI_See.Icon = _icon_eye_open;
            VideoTrackB3BI_See.Icon = _icon_eye_open;
            VideoTrackB4BI_See.Icon = _icon_eye_open;

            // 锁定按钮图标
            VideoTrackB1BI_Lock.Icon = _icon_lock_open;
            VideoTrackB2BI_Lock.Icon = _icon_lock_open;
            VideoTrackB3BI_Lock.Icon = _icon_lock_open;
            VideoTrackB4BI_Lock.Icon = _icon_lock_open;

            AudioTrackB1BI_Lock.Icon = _icon_lock_open;
            AudioTrackB2BI_Lock.Icon = _icon_lock_open;

            // 音量按钮图标
            AudioTrackB1BI_Volume.Icon = _icon_volume_full;
            AudioTrackB2BI_Volume.Icon = _icon_volume_full;

            // 独奏图标
            AudioTrackB1BI_Listen.Icon = _icon_headphone_closed;
            AudioTrackB2BI_Listen.Icon = _icon_headphone_closed;
        }

        #endregion 初始化工作


        #region 辅助函数

        /// <summary>
        ///     去除完整路径,只留下文件名
        /// </summary>
        /// <param name="dirsAndFilePath"></param>
        public static string[] ClearDirAndFilePath(string[] dirsAndFilePath)
        {
            try
            {
                var tempStrs = new string[dirsAndFilePath.Length];
                dirsAndFilePath.CopyTo(tempStrs, 0);

                for (var i = 0; i < tempStrs.Length; i++)
                {
                    var pos = tempStrs[i].LastIndexOf(@"\", StringComparison.Ordinal);
                    tempStrs[i] = tempStrs[i].Substring(pos + 1);
                }

                return tempStrs;
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
                return null;
            }
        }

        /// <summary>
        /// 按时间顺序排列轨道上的音视频文件
        /// </summary>
        public void SortVedioClips()
        {
            listVedioClips.Sort((x, y) =>
            {
                if (x.Location.X <= y.Location.X)
                {
                    return -1;
                }
                return 1;
            });
        }

        /// <summary>
        /// 获取一个视频的时间,单位s
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public double GetVedioDuiration(string fileName)
        {
            tagClipInfoCLR ctagClipInfoCLR = new tagClipInfoCLR();
            int res = packetIOCSharp.GetClipInfo(fileName, ref ctagClipInfoCLR);
            if (res < 0)
            {
                return 0;
            }

            return ctagClipInfoCLR.Vduration;
        }


        #endregion 辅助函数


        #region 文件拖动功能

        /// <summary>
        /// 从文件列表中将素材拖动出来
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_Files_ItemDrag(object sender, ItemDragEventArgs e)
        {
            try
            {
                ListView listViewFile = (ListView)sender;
                if (e.Button != MouseButtons.Left || listViewFile.SelectedItems.Count <= 0)
                {
                    return;
                }

                // put selected files into a string array
                // 每次只处理第一个
                //string[] files = new string[listViewFile.SelectedItems.Count];
                //int i = 0;
                //foreach (ListViewItem item in listViewFile.SelectedItems)
                //{
                //    files[i++] = item.Text;
                //}

                string selectedFile = listViewFile.SelectedItems[0].SubItems[2].Text;

                // create a dataobject holding this array as a filedrop
                DataObject data = new DataObject(DataFormats.FileDrop, selectedFile);

                // also add the selection as textdata
                data.SetData(DataFormats.StringFormat, selectedFile);

                // Do DragDrop
                DoDragDrop(data, DragDropEffects.Copy);
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }
        }

        /// <summary>
        /// 将视频文件拖到视频轨道上
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DragVideoEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /// <summary>
        /// 通过持续时间获取视频在时间线上的长度
        /// </summary>
        /// <param name="duirationTime"></param>
        /// <returns></returns>
        private int GetLengthByDuiration(double duirationTime)
        {
            return
                (int)
                (duirationTime / timeLineControl_MainTL.SecondsEveryTicks[timeLineControl_MainTL.IndexOfSecEveryTicks] *
                 timeLineControl_MainTL.NDistanceOfTicks);
        }

        /// <summary>
        /// 通过长度获取持续时间
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        private double GetDuirationBylength(int length)
        {
            return length / timeLineControl_MainTL.NDistanceOfTicks *
                   timeLineControl_MainTL.SecondsEveryTicks[timeLineControl_MainTL.IndexOfSecEveryTicks];
        }

        /// <summary>
        /// 将视频文件拖到视频轨道上
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DragVideoDrop(object sender, DragEventArgs e)
        {
            try
            {
                // 1.得到拖拽文件的文件名（全路径）
                string fileName = e.Data.GetData(DataFormats.FileDrop, true) as string;

                // 2.读取此文件的信息
                int length = 0;
                double duirationTime = 0;
                if (fileName.ToUpper().EndsWith("MP4"))
                {
                    //_iClipPlayControlCSharp.SetClip(fileName, PanelEx_Sequence.Handle);
                    //duirationTime = _iClipPlayControlCSharp.GetDuration() * GeneralConversions.NanoSecToSec;

                    duirationTime = GetVedioDuiration(fileName);
                }
                else if (fileName.ToUpper().EndsWith(zimuFileEnd))
                {
                    // 字幕默认持续时间5min, 300s
                    duirationTime = 300;
                }
                else
                {
                    // 其他默认2min 
                    duirationTime = 120;
                }

                length = GetLengthByDuiration(duirationTime);


                // 3.0.计算位置信息
                Point mousePoint = ((PanelEx)sender).PointToClient(new Point(e.X, e.Y));

                // 3.根据文件信息初始化一个panel
                int vedioFilePanelIndex = CreateVedioOrAudioFilePanel(fileName, duirationTime, length, mousePoint.X);
                if (vedioFilePanelIndex == -1) return;

                // 4.将此panel添加到sender上
                ((PanelEx)sender).Controls.Add(_vedioFilesPanel[vedioFilePanelIndex]);
                listVedioClips.Add(_vedioFilesPanel[vedioFilePanelIndex]);

                // 5.更新所有轨道面板的长度
                UpdateTrackWidthWhenAddFile(length);

                // 6.找到所需显示的视频
                FindNeedShowVedioByTime(timeLineControl_MainTL.ThumbValue);

                // 7.更新需要显示的帧TODO:
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }
        }

        /// <summary>
        /// 更新所有轨道面板的长度
        /// </summary>
        /// <param name="length"></param>
        private void UpdateTrackWidthWhenAddFile(int length)
        {
            try
            {
                int resLen = panelEx_VideoTrackConment1.Width + length;

                panelEx_VedioTrackComent.Width = resLen;
                panelEx_VideoTrackConment1.Width = resLen;
                panelEx_VideoTrackConment2.Width = resLen;
                panelEx_VideoTrackConment3.Width = resLen;
                panelEx_VideoTrackConment4.Width = resLen;

                panelEx_AudioTrackComent.Width = resLen;
                panelEx_AudioTrackConment1.Width = resLen;
                panelEx_AudioTrackConment2.Width = resLen;

                if (timeLineControl_MainTL.Width < resLen)
                {
                    timeLineControl_MainTL.Width = resLen;
                    int ticks = resLen / timeLineControl_MainTL.NDistanceOfTicks / 10;
                    timeLineControl_MainTL.NNumOfBigTicks = ticks + 2;
                }
                //int ticks = resLen / timeLineControl_MainTL.NDistanceOfTicks / 10;
                //timeLineControl_MainTL.NNumOfBigTicks = ticks + 2;
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }
        }

        /// <summary>
        /// 创建一个还未使用的视频或者音频文件panel
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="length"></param>
        /// <param name="pos"></param>
        /// <param name="bVedio"></param>
        /// <returns></returns>
        private int CreateVedioOrAudioFilePanel(string fileName, double duriation, int length, int pos,
            bool bVedio = true)
        {
            try
            {
                if (bVedio)
                {
                    // 找到_VediPFilesPanel中尚未初始化的一个panel
                    for (int i = 0; i < _vedioFilesPanel.Count; i++)
                    {
                        if ((string)_vedioFilesPanel[i].Tag == "")
                        {
                            _vedioFilesPanel[i].Name = fileName;

                            // 处理一下fileName,Text只显示文件名和持续时间,不显示路径
                            string duriationStr =
                                TimeLineControl.TimeLineControl.ChangeTimeValueToString((int)duriation);
                            string[] fileStrings = new string[1];
                            fileStrings[0] = fileName;
                            string[] tempStrings = ClearDirAndFilePath(fileStrings);

                            _vedioFilesPanel[i].Text = tempStrings[0] + " (" + duriationStr + ")";
                            _vedioFilesPanel[i].Width = length;
                            _vedioFilesPanel[i].Height = trackHeight;
                            _vedioFilesPanel[i].Location = new System.Drawing.Point(pos, 0);

                            // 使用tag来存储开始结束位置在时间线的时间,追加存储入点和出点时间
                            double dStartTime = timeLineControl_MainTL.GetTimeValueByPos(pos);
                            double dEndTime = dStartTime + duriation;
                            //double dEndTime = timeLineControl_MainTL.GetTimeValueByPos(pos+length);

                            string objStr = dStartTime + "-" + dEndTime + "-" + 0 + "-" + duriation;

                            _vedioFilesPanel[i].Tag = objStr;

                            return i;
                        }
                    }
                }
                else
                {
                    // 找到_AudioFilesPanel中尚未初始化的一个panel
                    for (int i = 0; i < _audioFilesPanel.Count; i++)
                    {
                        if ((string)_audioFilesPanel[i].Tag == "")
                        {
                            _audioFilesPanel[i].Name = fileName;

                            // 处理一下fileName,Text只显示文件名和持续时间,不显示路径
                            string duriationStr =
                                TimeLineControl.TimeLineControl.ChangeTimeValueToString((int)duriation);
                            string[] fileStrings = new string[1];
                            fileStrings[0] = fileName;
                            string[] tempStrings = ClearDirAndFilePath(fileStrings);

                            _audioFilesPanel[i].Text = tempStrings[0] + " (" + duriationStr + ")";
                            _audioFilesPanel[i].Width = length;
                            _audioFilesPanel[i].Height = trackHeight;
                            _audioFilesPanel[i].Location = new System.Drawing.Point(pos, 0);

                            // 使用tag来存储开始结束位置在时间线的时间
                            double dStartTime = timeLineControl_MainTL.GetTimeValueByPos(pos);
                            double dEndTime = dStartTime + duriation;

                            string objStr = dStartTime + "-" + dEndTime + "-" + 0 + "-" + duriation;

                            _audioFilesPanel[i].Tag = objStr;

                            return i;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }

            return -1;
        }

        /// <summary>
        /// 将音频文件拖到视频轨道上
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DragAudioEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /// <summary>
        /// 将音频文件拖到视频轨道上
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DragAudioDrop(object sender, DragEventArgs e)
        {
            //TODO:将音频拖到轨道上
            try
            {
                // 1.得到拖拽文件的文件名（全路径）
                string fileName = e.Data.GetData(DataFormats.FileDrop, true) as string;

                // 2.读取此文件的信息TODO:
                int length = 200;

                // 3.0.计算位置信息
                Point mousePoint = ((PanelEx)sender).PointToClient(new Point(e.X, e.Y));

                // 3.根据文件信息初始化一个panel
                int audioFilePanelIndex = CreateVedioOrAudioFilePanel(fileName, 100000, length, mousePoint.X, false);
                if (audioFilePanelIndex == -1) return;

                // 4.将此panel添加到sender上
                ((PanelEx)sender).Controls.Add(_audioFilesPanel[audioFilePanelIndex]);
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }
        }

        #endregion 文件拖动功能


        #region 主菜单操作

        public CreateProjectSetForm createProjectSetForm;
        public PreferenceSetForm preferenceSetForm;
        public ProjectSetForm projectSetForm;
        public DubForm dubFrom;
        public ImportP2Form importP2Form;
        public ImportXDCAMForm importXdcamForm;
        public ImportSxSForm importSxSForm;
        public ImportE2Form importE2Form;
        public ImportPPTForm importPPTForm;
        public PackageForm packageForm;

        // 当前是否已经打开了一个工程
        public bool bOpenedProject = false;

        /// <summary>
        /// 初始化所有子界面
        /// </summary>
        private void InitAllChildForm()
        {
            createProjectSetForm = new CreateProjectSetForm();
            preferenceSetForm = new PreferenceSetForm();
            projectSetForm = new ProjectSetForm();
            dubFrom = new DubForm();

            importP2Form = new ImportP2Form();
            importXdcamForm = new ImportXDCAMForm();
            importSxSForm = new ImportSxSForm();
            importE2Form = new ImportE2Form();
            importPPTForm = new ImportPPTForm();
            packageForm = new PackageForm();
            packageForm.Owner = this;
        }

        /// <summary>
        /// 新建工程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = createProjectSetForm.ShowDialog();

                // 1.创建新的工程文件
                if (createProjectSetForm.projectInfo.ProjectName == null)
                {
                    return;
                }

                // 新建一个工程等于打开一个工程
                bOpenedProject = true;

                projectInfo = createProjectSetForm.projectInfo;

                // 2.在文件列表显示素材库文件
                ShowDirInFileBox(theClipsPath);
                //label_FileInfo.Text = string.Empty;
                label_FileInfo.Text = projectInfo.ProjectName;

                // 3.重置时间线
                ResetTimeLineControl();

                // 4.删除轨道上所有面板
                DeleteAllTrackFiles();

                // 5.初始化轨道文件
                InitVedioAndAudioFilePanels();
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }
        }

        /// <summary>
        /// 重置时间线
        /// </summary>
        private void ResetTimeLineControl()
        {
            timeLineControl_MainTL.IndexOfSecEveryTicks = 3;
            timeLineControl_MainTL.ThumbHPos = 500;
            timeLineControl_MainTL.enterPos = 100;
            timeLineControl_MainTL.exitPos = 900;

            InitTimeLineControl();
        }

        /// <summary>
        /// 删除轨道上所有面板
        /// </summary>
        private void DeleteAllTrackFiles()
        {
            foreach (PanelEx panel in _vedioTrackPanels)
            {
                panel.Controls.Clear();
            }

            foreach (PanelEx panel in _audioTrackPanels)
            {
                panel.Controls.Clear();
            }
        }

        /// <summary>
        /// 打开工程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.InitialDirectory = projectInfo.ProjectPath;
                dialog.Filter = "Project File (*.Non)|*.Non";
                dialog.FilterIndex = 1;
                dialog.RestoreDirectory = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    OpenNewProject(dialog.FileName);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }
        }

        /// <summary>
        /// 打开选中的工程文件
        /// </summary>
        private void OpenNewProject(string fileName)
        {
            try
            {
                // 1.和新建工程一样重置主界面状态
                // 1.1.删除轨道上所有面板
                DeleteAllTrackFiles();

                // 1.2.初始化轨道文件
                InitVedioAndAudioFilePanels();

                // 2.从文件中加载工程
                projectInfo.Load(fileName);

                // 3.将信息显示到主界面上
                // 3.1.FileList
                ShowDirInFileBox(projectInfo.FileListPath);
                //label_FileInfo.Text = string.Empty;
                label_FileInfo.Text = projectInfo.ProjectName;

                // 3.2.恢复时间线
                timeLineControl_MainTL.IndexOfSecEveryTicks = projectInfo.timeLineInfo.indexOfSecEveryTicks;
                timeLineControl_MainTL.ThumbHPos = projectInfo.timeLineInfo.thumbHPos;
                timeLineControl_MainTL.enterPos = projectInfo.timeLineInfo.enterPos;
                timeLineControl_MainTL.exitPos = projectInfo.timeLineInfo.exitPos;
                InitTimeLineControl();

                // 3.3.恢复文件面板信息 // _vedioTrackPanels // _vedioFilesPanel
                for (int i = 0; i < projectInfo.filePanels.Count; i++)
                {
                    FilePanelStruct panelInfo = projectInfo.filePanels[i];

                    _vedioFilesPanel[i].Name = panelInfo.name;
                    _vedioFilesPanel[i].Text = panelInfo.text;
                    _vedioFilesPanel[i].Location = new Point(panelInfo.x, 0);
                    _vedioFilesPanel[i].Width = panelInfo.width;
                    _vedioFilesPanel[i].Tag = panelInfo.tag;
                    _vedioFilesPanel[i].Parent = _vedioTrackPanels[panelInfo.parentIndex];
                }

                // 设置打开工程为true
                bOpenedProject = true;

                Invalidate();
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }
        }

        /// <summary>
        /// 保存工程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveProject();
        }

        /// <summary>
        /// 保存工程文件
        /// </summary>
        private void SaveProject()
        {
            try
            {
                // 1.如果当前没有打开工程,则直接返回
                if (!bOpenedProject)
                {
                    return;
                }

                // 2.保存文件列表当前目录
                projectInfo.FileListPath = theClipsPath;

                // 3.保存时间线信息
                TimeLineInfoStruct cTimeLineInfoStruct = new TimeLineInfoStruct();
                cTimeLineInfoStruct.indexOfSecEveryTicks = timeLineControl_MainTL.IndexOfSecEveryTicks;
                cTimeLineInfoStruct.thumbHPos = (int)timeLineControl_MainTL.ThumbHPos;
                cTimeLineInfoStruct.enterPos = timeLineControl_MainTL.enterPos;
                cTimeLineInfoStruct.exitPos = timeLineControl_MainTL.exitPos;

                projectInfo.timeLineInfo = cTimeLineInfoStruct;

                // 4.保存轨道文件信息 // _vedioTrackPanels // _vedioFilesPanel

                projectInfo.filePanels.Clear();

                foreach (PanelEx panel in _vedioFilesPanel)
                {
                    // 如果panel的tag为空,说明不在轨道上
                    if (panel.Tag as string == "")
                    {
                        continue;
                    }

                    FilePanelStruct cFilePanelStruct = new FilePanelStruct();
                    cFilePanelStruct.name = panel.Name;
                    cFilePanelStruct.text = panel.Text;
                    cFilePanelStruct.x = panel.Location.X;
                    cFilePanelStruct.width = panel.Width;
                    cFilePanelStruct.tag = panel.Tag as string;
                    cFilePanelStruct.parentIndex = _vedioTrackPanels.IndexOf(panel.Parent as PanelEx);

                    projectInfo.filePanels.Add(cFilePanelStruct);
                }

                projectInfo.Save();
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }

        }

        /// <summary>
        /// 工程另存为
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.InitialDirectory = projectInfo.ProjectPath;
                dialog.Filter = "Project File (*.Non)|*.Non";
                dialog.FilterIndex = 1;
                dialog.RestoreDirectory = true;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string[] strArray = dialog.FileName.Split('\\');
                    projectInfo.ProjectName = strArray[strArray.Length - 1];
                    projectInfo.ProjectPath = "";
                    for (int i = 0; i < strArray.Length - 1; i++)
                    {
                        projectInfo.ProjectPath += strArray[i] + @"\";
                    }

                    SaveProject();
                }
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }
        }

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // 关闭一个工程
                bOpenedProject = false;

                projectInfo = new ProjectInfo();

                // 2.在文件列表显示素材库文件
                //ShowDirInFileBox(theClipsPath);
                listView_Files.Items.Clear();
                label_FileInfo.Text = string.Empty;

                // 3.重置时间线
                ResetTimeLineControl();

                // 4.删除轨道上所有面板
                DeleteAllTrackFiles();

                // 5.初始化轨道文件
                InitVedioAndAudioFilePanels();
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void 偏好设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            preferenceSetForm.ShowDialog();
        }

        private void 工程设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            projectSetForm.ShowDialog();
        }

        private void 导入工程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.InitialDirectory = projectInfo.ProjectPath;
                dialog.Filter = "Project File (*.Non)|*.Non";
                dialog.FilterIndex = 1;
                dialog.RestoreDirectory = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    //OpenNewProject(dialog.FileName);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }
        }

        private void 导入序列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.InitialDirectory = projectInfo.ProjectPath;
                dialog.Filter = "All Support Files(*.aaf,*nxf,*.xml,*.edl)|*.aaf,*nxf,*.xml,*.edl";
                dialog.FilterIndex = 1;
                dialog.RestoreDirectory = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    //OpenNewProject(dialog.FileName);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }
        }

        private void 导入AAFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.InitialDirectory = projectInfo.ProjectPath;
                dialog.Filter = "AAF Files(*.aaf)|*.aaf";
                dialog.FilterIndex = 1;
                dialog.RestoreDirectory = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    //OpenNewProject(dialog.FileName);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }
        }

        private void 导入配音序列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.InitialDirectory = projectInfo.ProjectPath;
                dialog.Filter = "AAF Files(*.aaf)|*.aaf";
                dialog.FilterIndex = 1;
                dialog.RestoreDirectory = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    //OpenNewProject(dialog.FileName);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }
        }

        private void 配音DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dubFrom.ShowDialog();
        }

        private void 导入P2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            importP2Form.ShowDialog();
        }

        private void 导入XDCAMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            importXdcamForm.ShowDialog();
        }

        private void 导入SxStoolStripMenuItem_Click(object sender, EventArgs e)
        {
            importSxSForm.ShowDialog();
        }

        private void 导入E2toolStripMenuItem_Click(object sender, EventArgs e)
        {
            importE2Form.ShowDialog();
        }

        private void 导入PPTtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            importPPTForm.ShowDialog();
        }

        private void 采集ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CaptureForm captureForm = new CaptureForm();
            captureForm.ShowDialog();
        }

        private void 设备输出设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeviceInputSetForm deviceInputSetForm = new DeviceInputSetForm();
            deviceInputSetForm.ShowDialog();
        }

        private void 录制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecordForm recordForm = new RecordForm();
            recordForm.ShowDialog();
        }

        private void 打包输出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            packageForm.ShowDialog();
        }

        /// <summary>
        /// 更新素材库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 更新素材库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // 1.选择一个文件夹，将次文件夹里面的素材更新到素材库
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                dialog.Description = "请选择需要上传素材文件夹";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    /////////////////这是数据库处理方式/////////////////////////////////////////
                    //UploadClipsInFolder(dialog.SelectedPath);
                    //
                    //// 2.刷新文件列表
                    //ShowClipsInFileBox();
                    //////////////////////////////////////////////////////////////////////////

                    // 这是显示本地文件夹
                    theClipsPath = dialog.SelectedPath;
                    ShowDirInFileBox(theClipsPath);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }
        }

        /// <summary>
        /// 选择文件夹，上传素材到数据库
        /// </summary>
        /// <param name="selectedPath"></param>
        private void UploadClipsInFolder(string selectedPath)
        {
            try
            {
                // TODO：
                // 0.先清空素材表
                // 1.获取目录底下的文件都存到数据库中
                string deleteText = @"DELETE FROM ClipsTable";
                SqlParameter parameter = new SqlParameter("", SqlDbType.BigInt) { Value = 0 };
                int iRes = SqlHelper.ExecuteNonQuery(_connectionString, deleteText, CommandType.Text, parameter);
                iRes = 0;

                string commandText =
                    @"INSERT ClipsTable ([Name],[ClipsTypeID],[ClipsClassID],[UploaderID],[StartDate],[FileAllName]) 
                                    VALUES (@Name, 1, 1, 1, @startDate, @FileAllName)";

                string[] clipsPath = Directory.GetFiles(selectedPath, "*", SearchOption.AllDirectories);
                string[] filesName = ClearDirAndFilePath(clipsPath);

                for (int i = 0; i < clipsPath.Length; i++)
                {
                    SqlParameter[] paras = new SqlParameter[3];
                    paras[0] = new SqlParameter("@Name", SqlDbType.NVarChar) { Value = filesName[i] };
                    paras[1] = new SqlParameter("@StartDate", SqlDbType.DateTime) { Value = DateTime.Now };
                    paras[2] = new SqlParameter("@FileAllName", SqlDbType.NVarChar) { Value = clipsPath[i] };

                    iRes += SqlHelper.ExecuteNonQuery(_connectionString, commandText, CommandType.Text, paras);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }
        }

        #endregion 菜单操作


        #region 主时间线操作

        /// <summary>
        /// 更新label上的时间
        /// </summary>
        private void UpdateLabelTime()
        {
            string strTime =
                TimeLineControl.TimeLineControl.ChangeTimeValueToString((int)timeLineControl_MainTL.ThumbValue);
            labelItem_CurrentTime.Text = strTime;
            labelX_SeqTime.Text = strTime;
        }

        /// <summary>
        /// 点击时间线,更新label上的时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timeLineControl_MainTL_Click(object sender, EventArgs e)
        {
            // 更新label时间
            UpdateLabelTime();

            // 找到所需显示的视频,并更新显示的帧
            FindNeedShowVedioByTime(timeLineControl_MainTL.ThumbValue);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timeLineControl_MainTL_MouseMove(object sender, MouseEventArgs e)
        {
            // 更新label时间
            UpdateLabelTime();

            if (timeLineControl_MainTL._chooseThumb)
            {
                // 找到所需显示的视频,并更新显示的帧
                FindNeedShowVedioByTime(timeLineControl_MainTL.ThumbValue);
            }
        }


        private void UpdateNeedShowFrame()
        {

        }

        #endregion 主时间线操作


        #region 轨道字幕处理

        public static string zimuFileEnd = "ZM";
        private ZimuMixInfoList ZimuList = new ZimuMixInfoList();

        /// <summary>
        /// 获取字幕轨道上的字幕文件列表
        /// </summary>
        private void GetZimuList()
        {
            ZimuList.Clear();
            int nLevel = 0;
            foreach (PanelEx panel in _vedioFilesPanel)
            {
                // 只遍历字幕文件,视频另外处理
                if (panel.Name.ToUpper().EndsWith(zimuFileEnd))
                {
                    string objStr = panel.Tag as string;
                    if (objStr == "") continue;
                    string[] startAndEndTime = objStr.Split('-');
                    if (startAndEndTime.Length < 2) continue;
                    double dStartTime = double.Parse(startAndEndTime[0]);
                    double dEndTime = double.Parse(startAndEndTime[1]);

                    tagZimuMixInfoCLR ctagZimuMixInfoCLR = new tagZimuMixInfoCLR();
                    ctagZimuMixInfoCLR.szZimuFile = panel.Name;
                    ctagZimuMixInfoCLR.rtStartPos = (long)(dStartTime * 1000);
                    ctagZimuMixInfoCLR.rtStopPos = (long)(dEndTime * 1000);
                    //ctagZimuMixInfoCLR.Type = 0;
                    ctagZimuMixInfoCLR.Level = nLevel++;

                    ZimuList.Add(ctagZimuMixInfoCLR);
                }
            }
        }


        #endregion


        #region 视频轨道操作

        private float fClickDelta = 10.0f;
        private bool _chooseVedioPanelSelf = false;
        private bool _chooseVedioPanelStart = false;
        private bool _chooseVedioPanelEnd = false;
        private bool _mouseMovedVedioPanel = false;
        private PanelEx _panelExSelected = new PanelEx();

        /// <summary>
        /// 在音视频轨道上拖动文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VideoFile_MouseDown(object sender, MouseEventArgs e)
        {
            //base.OnMouseDown(e);

            // 鼠标按下的时候让控件获取焦点
            //bool bFocused = Focus();

            PanelEx panelExSelected = (PanelEx)sender;

            if (e.Button == MouseButtons.Left)
            {
                panelExSelected.Capture = true;

                // 点中起点
                //if (Math.Abs((float)e.X - (float)panelExSelected.Location.X) < fClickDelta)
                if (e.X <= (int)fClickDelta)
                {
                    _chooseVedioPanelStart = true;
                    Cursor = Cursors.SizeWE;
                }
                // 点中终点
                //else if (Math.Abs((float)e.X - (float)panelExSelected.Location.X - panelExSelected.Width) < fClickDelta)
                else if (panelExSelected.Width - e.X <= (int)fClickDelta)
                {
                    _chooseVedioPanelEnd = true;
                    Cursor = Cursors.SizeWE;
                }
                // 点中本身
                else
                {
                    _chooseVedioPanelSelf = true;
                    Cursor = Cursors.Hand;
                }

                _mousePosDeltaX = e.X - panelExSelected.Location.X;
                _mousePosDeltaY = e.Y - panelExSelected.Location.Y;

                //_mousePosDeltaX = e.X;
                // 鼠标按下的时候，还未移动
                _mouseMovedVedioPanel = false;
            }
        }

        /// <summary>
        /// 在音视频轨道上拖动文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VideoFile_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                // 鼠标位置
                Point mousePoint = e.Location;
                //if (e.Location.X < 0) return;

                PanelEx panelExSelected = (PanelEx)sender;
                _panelExSelected = panelExSelected;
                int nStartPos = panelExSelected.Location.X;
                int nEndPos = nStartPos + panelExSelected.Width;

                if (panelExSelected.Capture && e.Button == MouseButtons.Left)
                {
                    /*
                    if (_mousePosDeltaY > panelExSelected.Height/2)
                    {
                        panelExSelected.Parent = panelEx_VideoTrackConment1;
                    }
                    else if (_mousePosDeltaY<0 && Math.Abs(_mousePosDeltaY)  > panelExSelected.Height / 2)
                    {
                        panelExSelected.Parent = panelEx_VideoTrackConment4;
                    }
                    */

                    // 设置鼠标移动为true
                    _mouseMovedVedioPanel = true;

                    // 1.如果是选中面板本身,则移动面板本身
                    if (_chooseVedioPanelSelf)
                    {
                        // 这一部分是移动面板本身
                        //panelExSelected.Location = new Point(e.X - _mousePosDeltaX > 0 ? e.X - _mousePosDeltaX : 0, 0);
                        //
                        //// 使用tag来存储开始结束位置在时间线的时间
                        //double dStartTime = timeLineControl_MainTL.GetTimeValueByPos(panelExSelected.Location.X);
                        //double dEndTime = timeLineControl_MainTL.GetTimeValueByPos(panelExSelected.Location.X + panelExSelected.Width);
                        //
                        //string objStr = dStartTime + "-" + dEndTime;
                        //
                        //panelExSelected.Tag = objStr;

                        // 这一部分是通过移动新面板,最后同步
                        operatorPanel.Location = new Point(e.X - _mousePosDeltaX > 0 ? e.X - _mousePosDeltaX : 0, 0);
                        //operatorPanel.Location = new Point(e.X - _mousePosDeltaX + panelExSelected.Location.X, 0);
                        operatorPanel.Size = panelExSelected.Size;

                        // 用于上下移动面板
                        PanelEx trackPanel = panelExSelected.Parent as PanelEx;
                        int index = _vedioTrackPanels.IndexOf(trackPanel);

                        // 拖动一个轨道
                        //if (e.Y >= panelExSelected.Height && index < _vedioTrackPanels.Count-1)
                        //{
                        //    // 1.往下拖动
                        //    _vedioTrackPanels[++index].Controls.Add(operatorPanel);
                        //}
                        //else if (e.Y <= -panelExSelected.Height && index > 0)
                        //{
                        //    // 2.往上拖动
                        //    _vedioTrackPanels[--index].Controls.Add(operatorPanel);
                        //}
                        //else
                        //{
                        //    panelExSelected.Parent.Controls.Add(operatorPanel);
                        //}

                        // 拖动多个轨道
                        if (e.Y >= panelExSelected.Height)
                        {
                            // 1.往下拖动
                            int nums = e.Y / panelExSelected.Height;
                            if (nums + index >= _vedioTrackPanels.Count)
                            {
                                nums = _vedioTrackPanels.Count - index - 1;
                            }

                            _vedioTrackPanels[nums + index].Controls.Add(operatorPanel);
                        }
                        else if (e.Y <= -panelExSelected.Height)
                        {
                            // 2.往上拖动
                            int nums = -e.Y / panelExSelected.Height;
                            if (nums > index)
                            {
                                nums = index;
                            }

                            _vedioTrackPanels[index - nums].Controls.Add(operatorPanel);
                        }
                        else
                        {
                            if (!panelExSelected.Parent.Controls.Contains(operatorPanel))
                            {

                                panelExSelected.Parent.Controls.Add(operatorPanel);

                                //panelExSelected.Parent.Controls.SetChildIndex(operatorPanel, 0);
                                // panelExSelected.Parent.Controls.SetChildIndex(panelExSelected, 1);
                            }
                        }

                        //panelExSelected.Parent.Controls.SetChildIndex(operatorPanel, 0);
                        //Cursor = Cursors.NoMoveHoriz;
                    }
                    // 2.如果是选中面板起始点,则移动起始点位置,字幕文件和音视频文件处理不同
                    else if (_chooseVedioPanelStart)
                    {
                        // 音视频文件最长为视频全长,最短为1
                        if (panelExSelected.Name.ToUpper().EndsWith("MP4"))
                        {
                            // 1.获取视频原始长度
                            int originLength = GetLengthByDuiration(GetVedioDuiration(panelExSelected.Name));

                            // 2.如果拉伸的长度小于原视频长度
                            // 2.左拉的距离不能超过tag中入点到0的距离,右拉不能让面板小于10(暂时定为10)
                            if (nEndPos - (e.X - _mousePosDeltaX) < originLength)
                            {
                                // 这一部分是移动面板本身
                                //panelExSelected.Width = /*panelExSelected.Width - */(nEndPos - (e.X - _mousePosDeltaX));
                                //panelExSelected.Location = new Point(e.X - _mousePosDeltaX, 0);

                                // 这一部分是通过移动新面板,最后同步
                                // 1.计算最远能左拉多少
                                // 2.首先解析tag获取信息
                                //string objStr = panelExSelected.Tag as string;
                                //if (objStr == null) return;
                                //string[] startAndEndTime = objStr.Split('-');
                                //if (startAndEndTime.Length < 4) return;
                                //
                                //// 3.得到原文件在时间线上的起始/终点时间,和自己的入点/出点时间
                                //double dOldStartTime = double.Parse(startAndEndTime[0]);
                                //double dOldEndTime = double.Parse(startAndEndTime[1]);
                                //double dOldEntreTime = double.Parse(startAndEndTime[2]);
                                //double dOldExitTime = double.Parse(startAndEndTime[3]);

                                // 4.左拉最远距离
                                //int maxLength = GetLengthByDuiration(dOldEntreTime - 0);

                                // 5.根据限制处理辅助面板位置
                                int movedPosX = e.X - _mousePosDeltaX > 0 ? e.X - _mousePosDeltaX : 0;
                                //if (movedPosX < panelExSelected.Location.X - maxLength)
                                //{
                                //    movedPosX = panelExSelected.Location.X - maxLength;
                                //}

                                operatorPanel.Location = new Point(movedPosX, 0);
                                operatorPanel.Height = panelExSelected.Height;
                                operatorPanel.Width = panelExSelected.Location.X + panelExSelected.Width -
                                                      operatorPanel.Location.X;
                                if (operatorPanel.Width < 10) operatorPanel.Width = 10;
                                //operatorPanel.Size = panelExSelected.Size;
                                panelExSelected.Parent.Controls.Add(operatorPanel);
                            }
                        }
                        // 字幕文件最长无限制,最短为1
                        else if (panelExSelected.Name.ToUpper().EndsWith(zimuFileEnd))
                        {
                            // 这一部分是通过移动新面板,最后同步
                            operatorPanel.Location = new Point(e.X - _mousePosDeltaX > 0 ? e.X - _mousePosDeltaX : 0, 0);
                            operatorPanel.Height = panelExSelected.Height;
                            operatorPanel.Width = panelExSelected.Location.X + panelExSelected.Width -
                                                  operatorPanel.Location.X;
                            if (operatorPanel.Width < 10) operatorPanel.Width = 10;
                            panelExSelected.Parent.Controls.Add(operatorPanel);
                        }
                    }
                    // 3.如果是选中面板起始点,则移动起始点位置,字幕文件和音视频文件处理不同
                    else if (_chooseVedioPanelEnd)
                    {
                        // 音视频文件最长为视频全长,最短为1
                        if (panelExSelected.Name.ToUpper().EndsWith("MP4"))
                        {
                            // 1.获取视频原始长度
                            int originLength = GetLengthByDuiration(GetVedioDuiration(panelExSelected.Name));

                            // 2.右拉的距离不能超过视频最大长度-出点
                            if (e.X < originLength)
                            {
                                // 1.计算最远能右拉多少
                                // 2.首先解析tag获取信息
                                //string objStr = panelExSelected.Tag as string;
                                //if (objStr == null) return;
                                //string[] startAndEndTime = objStr.Split('-');
                                //if (startAndEndTime.Length < 4) return;
                                //
                                //// 3.得到原文件在时间线上的起始/终点时间,和自己的入点/出点时间
                                //double dOldStartTime = double.Parse(startAndEndTime[0]);
                                //double dOldEndTime = double.Parse(startAndEndTime[1]);
                                //double dOldEntreTime = double.Parse(startAndEndTime[2]);
                                //double dOldExitTime = double.Parse(startAndEndTime[3]);
                                //
                                //// 4.右拉最远距离
                                //int maxLength = GetLengthByDuiration(GetVedioDuiration(panelExSelected.Name) - dOldExitTime);
                                //
                                //int movePosX = e.X - panelExSelected.Width;
                                //if (movePosX > maxLength)
                                //{
                                //    operatorPanel.Width = panelExSelected.Width + maxLength;
                                //}
                                //else
                                //{
                                //    operatorPanel.Width = e.X;
                                //}

                                operatorPanel.Location = panelExSelected.Location;
                                operatorPanel.Height = panelExSelected.Height;
                                operatorPanel.Width = e.X;
                                if (operatorPanel.Width < 10) operatorPanel.Width = 10;
                                //operatorPanel.Size = panelExSelected.Size;
                                panelExSelected.Parent.Controls.Add(operatorPanel);
                            }
                        }
                        // 字幕文件最长无限制,最短为1
                        else if (panelExSelected.Name.ToUpper().EndsWith(zimuFileEnd))
                        {
                            operatorPanel.Location = panelExSelected.Location;
                            operatorPanel.Height = panelExSelected.Height;
                            operatorPanel.Width = e.X;
                            if (operatorPanel.Width < 10) operatorPanel.Width = 10;
                            //operatorPanel.Size = panelExSelected.Size;
                            panelExSelected.Parent.Controls.Add(operatorPanel);
                        }
                    }
                    else
                    {
                        _mouseMovedVedioPanel = false;
                    }


                    panelExSelected.Invalidate();

                    // 找到所需显示的视频,并更新显示的帧
                    //FindNeedShowVedioByTime(timeLineControl_MainTL.ThumbValue);

                    //base.OnMouseMove(e);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }
        }

        /// <summary>
        /// 轨道鼠标弹起事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VideoFile_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    // 1.如果是选择文件本身,就是拖动
                    if (_chooseVedioPanelSelf && _mouseMovedVedioPanel)
                    {
                        // 1.改变文件位置及大小
                        if (operatorPanel.Parent == null)
                        {
                            return;
                        }
                        _panelExSelected.Location = operatorPanel.Location;
                        _panelExSelected.Size = operatorPanel.Size;

                        _panelExSelected.Parent = operatorPanel.Parent;
                        operatorPanel.Parent.Controls.Remove(operatorPanel);

                        // 2.首先解析tag获取信息
                        string objStr = _panelExSelected.Tag as string;
                        if (objStr == null) return;
                        string[] startAndEndTime = objStr.Split('-');
                        if (startAndEndTime.Length < 4) return;

                        // 3.得到原文件在时间线上的起始/终点时间,和自己的入点/出点时间
                        double dOldStartTime = double.Parse(startAndEndTime[0]);
                        double dOldEndTime = double.Parse(startAndEndTime[1]);
                        double dOldEntreTime = double.Parse(startAndEndTime[2]);
                        double dOldExitTime = double.Parse(startAndEndTime[3]);

                        // 4.如果只是拖动文件,只需要改时间线上的起始/终点时间,本身的出点/入点时间不需要修改
                        double dStartTime = timeLineControl_MainTL.GetTimeValueByPos(_panelExSelected.Location.X);
                        double dEndTime = dStartTime + dOldEndTime - dOldStartTime;

                        objStr = dStartTime + "-" + dEndTime + "-" + dOldEntreTime + "-" + dOldExitTime;
                        _panelExSelected.Tag = objStr;

                        // 5.更新panel的显示文字

                    }
                    // 2.如果是选中起点,就是拖拉起点
                    else if (_chooseVedioPanelStart && _mouseMovedVedioPanel)
                    {
                        // 2.首先解析tag获取信息
                        string objStr = _panelExSelected.Tag as string;
                        if (objStr == null) return;
                        string[] startAndEndTime = objStr.Split('-');
                        if (startAndEndTime.Length < 4) return;

                        // 3.得到原文件在时间线上的起始/终点时间,和自己的入点/出点时间
                        double dOldStartTime = double.Parse(startAndEndTime[0]);
                        double dOldEndTime = double.Parse(startAndEndTime[1]);
                        double dOldEntreTime = double.Parse(startAndEndTime[2]);
                        double dOldExitTime = double.Parse(startAndEndTime[3]);

                        // 4.如果是拖拉了起点,那么在时间线的起点和本身入点需要更新,终点和出点保持不变
                        // 判断入点不能小于0,入点不能小于0则代表,新的X和旧的X的差不能大于入点到0的长度
                        if (_panelExSelected.Name.ToUpper().EndsWith("MP4"))
                        {
                            int maxLength = GetLengthByDuiration(dOldEntreTime);
                            if (_panelExSelected.Location.X - operatorPanel.Location.X > maxLength)
                            {
                                operatorPanel.Location = new Point(_panelExSelected.Location.X - maxLength, 0);
                            }
                            double dStartTime = timeLineControl_MainTL.GetTimeValueByPos(operatorPanel.Location.X);
                            double dEntreTime = dOldExitTime - (dOldEndTime - dStartTime);
                            if (Math.Abs(dEntreTime) < 2)
                            {
                                dEntreTime = 0;
                            }
                            objStr = dStartTime + "-" + dOldEndTime + "-" + dEntreTime + "-" + dOldExitTime;
                            _panelExSelected.Tag = objStr;

                            // 5.更新panel的显示文字
                            string duriationStr =
                                TimeLineControl.TimeLineControl.ChangeTimeValueToString(
                                    (int)(dOldExitTime - dEntreTime));

                            string oldText = _panelExSelected.Text;
                            string temString = oldText.Substring(0, oldText.IndexOf("("));

                            _panelExSelected.Text = temString + "(" + duriationStr + ")";

                            // 改变文件位置及大小
                            _panelExSelected.Location = operatorPanel.Location;
                            _panelExSelected.Height = operatorPanel.Height;
                            _panelExSelected.Width = GetLengthByDuiration(dOldExitTime - dEntreTime);
                            _panelExSelected.Parent.Controls.Remove(operatorPanel);
                        }
                        else if (_panelExSelected.Name.ToUpper().EndsWith(zimuFileEnd))
                        {
                            double dStartTime = timeLineControl_MainTL.GetTimeValueByPos(operatorPanel.Location.X);
                            double dExitTime = dOldEndTime - dStartTime;
                            objStr = dStartTime + "-" + dOldEndTime + "-" + dOldEntreTime + "-" + dExitTime;
                            _panelExSelected.Tag = objStr;

                            // 5.更新panel的显示文字
                            string duriationStr =
                                TimeLineControl.TimeLineControl.ChangeTimeValueToString((int)(dExitTime));

                            string oldText = _panelExSelected.Text;
                            string temString = oldText.Substring(0, oldText.IndexOf("("));

                            _panelExSelected.Text = temString + "(" + duriationStr + ")";

                            _panelExSelected.Location = operatorPanel.Location;
                            _panelExSelected.Height = operatorPanel.Height;
                            _panelExSelected.Width = operatorPanel.Width;
                            _panelExSelected.Parent.Controls.Remove(operatorPanel);
                        }
                    }
                    // 2.如果是选中终点,就是拖拉终点
                    else if (_chooseVedioPanelEnd && _mouseMovedVedioPanel)
                    {

                        // 2.首先解析tag获取信息
                        string objStr = _panelExSelected.Tag as string;
                        if (objStr == null) return;
                        string[] startAndEndTime = objStr.Split('-');
                        if (startAndEndTime.Length < 4) return;

                        // 3.得到原文件在时间线上的起始/终点时间,和自己的入点/出点时间
                        double dOldStartTime = double.Parse(startAndEndTime[0]);
                        double dOldEndTime = double.Parse(startAndEndTime[1]);
                        double dOldEntreTime = double.Parse(startAndEndTime[2]);
                        double dOldExitTime = double.Parse(startAndEndTime[3]);

                        // 4.如果是拖拉终点,那么时间线的终点和出点需要更新,起点和入点保持不变
                        // 判断出点不能大于视频总时间.代表,新的width和旧的width之差不能大于视频总时间-出点长度
                        if (_panelExSelected.Name.ToUpper().EndsWith("MP4"))
                        {
                            double dDuiration = GetVedioDuiration(_panelExSelected.Name);
                            int maxLength = GetLengthByDuiration(dDuiration - dOldExitTime);
                            if (operatorPanel.Width - _panelExSelected.Width > maxLength)
                            {
                                operatorPanel.Width = _panelExSelected.Width + maxLength;
                            }
                            double dEndTime =
                                timeLineControl_MainTL.GetTimeValueByPos(operatorPanel.Location.X + operatorPanel.Width);
                            double dExitTime = dOldEntreTime + dEndTime - dOldStartTime;
                            if (Math.Abs(dExitTime - dDuiration) < 2)
                            {
                                dExitTime = dDuiration;
                            }

                            objStr = dOldStartTime + "-" + dEndTime + "-" + dOldEntreTime + "-" + dExitTime;
                            _panelExSelected.Tag = objStr;

                            // 5.更新panel的显示文字
                            string duriationStr =
                                TimeLineControl.TimeLineControl.ChangeTimeValueToString(
                                    (int)(dExitTime - dOldEntreTime));

                            string oldText = _panelExSelected.Text;
                            string temString = oldText.Substring(0, oldText.IndexOf("("));

                            _panelExSelected.Text = temString + "(" + duriationStr + ")";

                            // 1.改变文件位置及大小
                            _panelExSelected.Location = operatorPanel.Location;
                            _panelExSelected.Height = operatorPanel.Height;
                            _panelExSelected.Width = GetLengthByDuiration(dExitTime - dOldEntreTime);
                            _panelExSelected.Parent.Controls.Remove(operatorPanel);
                        }
                        else if (_panelExSelected.Name.ToUpper().EndsWith(zimuFileEnd))
                        {
                            double dEndTime =
                                timeLineControl_MainTL.GetTimeValueByPos(operatorPanel.Location.X + operatorPanel.Width);
                            double dExitTime = dEndTime - dOldStartTime;
                            objStr = dOldStartTime + "-" + dEndTime + "-" + dOldEntreTime + "-" + dExitTime;
                            _panelExSelected.Tag = objStr;

                            // 5.更新panel的显示文字
                            string duriationStr =
                                TimeLineControl.TimeLineControl.ChangeTimeValueToString((int)(dExitTime));

                            string oldText = _panelExSelected.Text;
                            string temString = oldText.Substring(0, oldText.IndexOf("("));

                            _panelExSelected.Text = temString + "(" + duriationStr + ")";

                            _panelExSelected.Location = operatorPanel.Location;
                            _panelExSelected.Height = operatorPanel.Height;
                            _panelExSelected.Width = operatorPanel.Width;
                            _panelExSelected.Parent.Controls.Remove(operatorPanel);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }

            Cursor = Cursors.Arrow;
            _chooseVedioPanelSelf = false;
            _chooseVedioPanelStart = false;
            _chooseVedioPanelEnd = false;
            _mouseMovedVedioPanel = false;
            _panelExSelected = new PanelEx();
        }


        /// <summary>
        /// 鼠标进入获取焦点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelEx_VideoTrackConment1_MouseEnter(object sender, EventArgs e)
        {
            bool bFocused = (sender as PanelEx).Focus();
        }

        /// <summary>
        /// 视频轨道面板鼠标移动事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelEx_VideoTrackConment1_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                //PanelEx panelTrack = sender as PanelEx;

                //foreach (PanelEx panel in panelTrack.Controls)
                //{
                //    VideoFile_MouseMove(panel, e);
                //}
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }
        }

        /// <summary>
        /// 更新音视频文件的显示,在轨道上的长度
        /// </summary>
        private void UpdateTrackFilesShow(bool bAdd)
        {
            try
            {
                // TODO:不能缩放,缩放会引起比例问题,需要记录起点和终点
                double ratio = 0;

                // 如果是放大
                if (bAdd)
                {
                    // 1.先求放大的比例
                    ratio =
                        (double)
                        timeLineControl_MainTL.SecondsEveryTicks[timeLineControl_MainTL.IndexOfSecEveryTicks + 1] /
                        timeLineControl_MainTL.SecondsEveryTicks[timeLineControl_MainTL.IndexOfSecEveryTicks];
                }
                else // 如果是缩小
                {
                    // 1.先求缩小的比例
                    ratio =
                        (double)
                        timeLineControl_MainTL.SecondsEveryTicks[timeLineControl_MainTL.IndexOfSecEveryTicks - 1] /
                        timeLineControl_MainTL.SecondsEveryTicks[timeLineControl_MainTL.IndexOfSecEveryTicks];
                }

                // 音视频轨道面板同步时间线长度
                panelEx_VedioTrackComent.Width = timeLineControl_MainTL.Width;
                panelEx_VideoTrackConment1.Width = timeLineControl_MainTL.Width;
                panelEx_VideoTrackConment2.Width = timeLineControl_MainTL.Width;
                panelEx_VideoTrackConment3.Width = timeLineControl_MainTL.Width;
                panelEx_VideoTrackConment4.Width = timeLineControl_MainTL.Width;

                panelEx_AudioTrackComent.Width = timeLineControl_MainTL.Width;
                panelEx_AudioTrackConment1.Width = timeLineControl_MainTL.Width;
                panelEx_AudioTrackConment2.Width = timeLineControl_MainTL.Width;

                // 音视频内容面板单独处理
                foreach (var panel in _vedioFilesPanel)
                {
                    if (panel.Tag as string == "")
                    {
                        return;
                    }
                    // 1.先计算新的location.X与length
                    string objStr = panel.Tag as string;
                    if (objStr == null) return;
                    string[] startAndEndTime = objStr.Split('-');
                    if (startAndEndTime.Length < 2) return;

                    int startX = (int)timeLineControl_MainTL.GetPosByTimeValue(double.Parse(startAndEndTime[0]));
                    int endX = (int)timeLineControl_MainTL.GetPosByTimeValue(double.Parse(startAndEndTime[1]));
                    panel.Location = new Point(startX, 0);
                    panel.Width = endX - startX;
                }

                // 音视频内容面板单独处理
                foreach (var panel in _audioFilesPanel)
                {
                    if (panel.Tag as string == "")
                    {
                        return;
                    }

                    // 1.先计算新的location.X与length
                    string objStr = panel.Tag as string;
                    if (objStr == null) return;
                    string[] startAndEndTime = objStr.Split('-');


                    int startX = (int)timeLineControl_MainTL.GetPosByTimeValue(double.Parse(startAndEndTime[0]));
                    int endX = (int)timeLineControl_MainTL.GetPosByTimeValue(double.Parse(startAndEndTime[1]));
                    panel.Location = new Point(startX, 0);
                    panel.Width = endX - startX;
                }

                Invalidate();
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }
        }


        /// <summary>
        /// 更新所有视频文件的开始/结束时间,按顺序存储
        /// </summary>
        /// <param name="bInterval">是否是选择区间</param>
        public void UpdateVedioTrackFilesTimes(bool bInterval)
        {
            try
            {
                // 1.首先清空列表
                sortedVedioTimes = new List<double>();
                sortedVedioTimes.Clear();

                // 2.将所有的开始/结束时间 按顺序存储到列表中
                foreach (PanelEx panel in _vedioFilesPanel)
                {
                    // 只遍历视频文件,字幕另外处理
                    if (panel.Name.ToUpper().EndsWith("MP4"))
                    {
                        string objStr = panel.Tag as string;
                        if (objStr == "") continue;
                        string[] startAndEndTime = objStr.Split('-');
                        if (startAndEndTime.Length < 2) continue;
                        double dStartTime = double.Parse(startAndEndTime[0]);
                        double dEndTime = double.Parse(startAndEndTime[1]);

                        sortedVedioTimes.Add(dStartTime);
                        sortedVedioTimes.Add(dEndTime);
                    }

                }

                if (sortedVedioTimes.Count > 0)
                {
                    // 3.如果有加入到列表中的时间,则添加0,并排序
                    sortedVedioTimes.Add(0);

                    // 4.果是区间, 那么要去头去尾
                    if (bInterval)
                    {
                        // 5.获取入点/出点的时间
                        double dEnterValue = timeLineControl_MainTL.enterValue;
                        double dExitValue = timeLineControl_MainTL.exitValue;

                        List<double> needRemoveItems = new List<double>(10);

                        foreach (double dItem in sortedVedioTimes)
                        {
                            if (dItem <= dEnterValue || dItem >= dExitValue)
                            {
                                needRemoveItems.Add(dItem);
                            }
                        }

                        foreach (double dItem in needRemoveItems)
                        {
                            sortedVedioTimes.Remove(dItem);
                        }

                        sortedVedioTimes.Add(dEnterValue);
                        sortedVedioTimes.Add(dExitValue);
                    }

                    sortedVedioTimes.Sort();
                }
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }
        }


        /// <summary>
        /// 更新打包素材列表
        /// </summary>
        /// <param name="bInterval">是否是选择区间</param>
        public void UpdatePackageClips(bool bInterval)
        {
            try
            {
                // 0.更新所有视频文件的开始/结束时间,按顺序存储
                //UpdateVedioTrackFilesTimes(bInterval);

                // 1.初始化打包素材列表
                packageClipsList = new DemuxClipInfoList();
                packageClipsList.Clear();

                for (int i = 0; i < sortedVedioTimes.Count - 1; i++)
                {
                    // 2.如果后一个时间和前一个时间相等,那么不需要处理
                    double dBeginTime = sortedVedioTimes[i];
                    double dEndTime = sortedVedioTimes[i + 1];
                    if (dEndTime - dBeginTime < EPSON) continue;

                    // 3.获取中间时间
                    double dMidTime = (dBeginTime + dEndTime) / 2;

                    // 4.查找此时间的视频
                    PanelEx thePanel = FindNeedShowVedioByTime(dMidTime);

                    if (thePanel == null)
                    {
                        // 测试 空不处理
                        // 5.如果没找到,说明是空,需要用垫片
                        tagDemuxClipInfoCLR theClips = new tagDemuxClipInfoCLR(BlackVedio, 0,
                            (Int64)((dEndTime - dBeginTime) * 1000));
                        packageClipsList.Add(theClips);
                    }
                    else
                    {
                        // 6.如果找到,则这一段时间就将此视频添加到打包素材列表中
                        // 这里的入点和出点,应该转为视频时间,而不是时间线上的时间
                        // 解析tag获取信息
                        string objStr = thePanel.Tag as string;
                        if (objStr == null) continue;
                        string[] startAndEndTime = objStr.Split('-');
                        if (startAndEndTime.Length < 4) continue;

                        // 得到原文件在时间线上的起始/终点时间,和自己的入点/出点时间
                        double dOldStartTime = double.Parse(startAndEndTime[0]);
                        double dOldEndTime = double.Parse(startAndEndTime[1]);
                        double dOldEntreTime = double.Parse(startAndEndTime[2]);
                        double dOldExitTime = double.Parse(startAndEndTime[3]);

                        tagDemuxClipInfoCLR theClips = new tagDemuxClipInfoCLR(thePanel.Name,
                            (Int64)((dBeginTime - dOldStartTime + dOldEntreTime) * 1000),
                            (Int64)((dEndTime - dOldStartTime + dOldEntreTime) * 1000));

                        //tagDemuxClipInfoCLR theClips = new tagDemuxClipInfoCLR(thePanel.Name, 0, 0);
                        packageClipsList.Add(theClips);
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }

        }

        /// <summary>
        /// 获取轨道上的文件的最终时间
        /// </summary>
        public double GetTrackFilesEndTime(bool bInterval)
        {
            try
            {
                // 在此处先判断轨道上是否有文件


                if (bInterval)
                {
                    return timeLineControl_MainTL.exitValue;
                }

                double dMin = 0;
                foreach (PanelEx panel in _vedioFilesPanel)
                {
                    // 只遍历视频文件
                    if (panel.Name.ToUpper().EndsWith("MP4"))
                    {
                        string objStr = panel.Tag as string;
                        if (objStr == "") continue;
                        string[] startAndEndTime = objStr.Split('-');
                        if (startAndEndTime.Length < 2) continue;
                        //double dStartTime = double.Parse(startAndEndTime[0]);
                        double dEndTime = double.Parse(startAndEndTime[1]);

                        if (dEndTime > dMin)
                        {
                            dMin = dEndTime;
                        }
                    }
                }

                return dMin;
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
                return 0;
            }
        }


        #endregion 视频轨道操作


        #region 音频轨道操作



        #endregion 音频轨道操作


        #region 文件列表操作

        /// <summary>
        /// 将数据库的素材都显示到列表中
        /// </summary>
        private void ShowClipsInFileBox()
        {
            try
            {
                List<string> clipsNameList = new List<string>(10);
                List<string> clipsPathList = new List<string>(10);

                string commandText = "SELECT Name, FileAllName FROM ClipsTable";
                SqlParameter parameter = new SqlParameter("", SqlDbType.BigInt) { Value = 0 };
                using (
                    SqlDataReader reader = SqlHelper.ExecuteReader(_connectionString, commandText, CommandType.Text,
                        parameter))
                {
                    while (reader.Read())
                    {
                        clipsNameList.Add(reader["Name"].ToString());
                        clipsPathList.Add(reader["FileAllName"].ToString());
                    }
                }

                // 清空列表
                listView_Files.Items.Clear();

                for (int i = 0; i < clipsNameList.Count; i++)
                {
                    ListViewItem item = new ListViewItem(clipsNameList[i]);
                    item.ImageIndex = 1;
                    var sSepStrs = clipsNameList[i].Split('.');
                    var sFileType = sSepStrs[sSepStrs.Length - 1];
                    item.SubItems.Add(sFileType);
                    item.SubItems.Add(clipsPathList[i]);
                    listView_Files.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }
        }

        /// <summary>
        ///     在文件面板中显示某个文件夹中的文件
        /// </summary>
        private void ShowDirInFileBox(string path)
        {
            try
            {
                // 1.获得目录下的文件夹和文件(完整路径)
                _choosedDirFullPath = Directory.GetDirectories(path);
                _choosedFileFullPath = Directory.GetFiles(path);
                var fileEntries = Directory.GetFileSystemEntries(path);

                // 2.去除完整路径,只留下文件名
                var dirsNames = ClearDirAndFilePath(_choosedDirFullPath);
                var filesNames = ClearDirAndFilePath(_choosedFileFullPath);

                // 3.0.清空列表
                listView_Files.Items.Clear();

                // 3.1.第一行显示“..”,双击表示回到上一级
                // 3.2.如果是磁盘根目录，则不需要显示
                if (path.Length > 3)
                {
                    var itemUp = new ListViewItem("..");
                    itemUp.SubItems.Add("文件夹");
                    int length = path.LastIndexOf(@"\", StringComparison.Ordinal);
                    string upPath = path.Remove(length);
                    // 如果上级是磁盘根目录，后面要加上"\"
                    if (upPath.Length < 3)
                    {
                        upPath += @"\";
                    }
                    itemUp.SubItems.Add(upPath);
                    listView_Files.Items.Add(itemUp);
                }

                // 3.将文件夹显示到文件列表中
                for (var i = 0; i < dirsNames.Length; i++)
                {
                    var item = new ListViewItem(dirsNames[i]);
                    item.ImageIndex = 0;
                    item.SubItems.Add("文件夹");
                    item.SubItems.Add(_choosedDirFullPath[i]);
                    listView_Files.Items.Add(item);
                }

                // 4.将MP4文件显示到文件列表中
                for (var i = 0; i < filesNames.Length; i++)
                {
                    var item = new ListViewItem(filesNames[i]);
                    item.ImageIndex = 1;
                    var sSepStrs = filesNames[i].Split('.');
                    var sFileType = sSepStrs[sSepStrs.Length - 1];
                    if (sFileType.ToUpper() == "MP4")
                    {
                        item.SubItems.Add(sFileType.ToUpper());
                        item.SubItems.Add(_choosedFileFullPath[i]);
                        item.SubItems.Add("");

                        item.SubItems.Add(sFileType.ToUpper());
                        double dDuriation = GetVedioDuiration(_choosedFileFullPath[i]);
                        string duriationStr = TimeLineControl.TimeLineControl.ChangeTimeValueToString((int)dDuriation);
                        item.SubItems.Add(duriationStr);
                        listView_Files.Items.Add(item);
                    }
                }

                // 5.将字幕文件显示到文件列表中
                for (var i = 0; i < filesNames.Length; i++)
                {
                    var item = new ListViewItem(filesNames[i]);
                    item.ImageIndex = 1;
                    var sSepStrs = filesNames[i].Split('.');
                    var sFileType = sSepStrs[sSepStrs.Length - 1];
                    if (sFileType.ToUpper() == zimuFileEnd)
                    {
                        item.SubItems.Add("字幕");
                        item.SubItems.Add(_choosedFileFullPath[i]);
                        item.SubItems.Add("");

                        //item.SubItems.Add(sFileType.ToUpper());
                        //double dDuriation = GetVedioDuiration(_choosedFileFullPath[i]);
                        //string duriationStr = TimeLineControl.TimeLineControl.ChangeTimeValueToString((int)dDuriation);
                        //item.SubItems.Add(duriationStr);
                        listView_Files.Items.Add(item);
                    }
                }
            }
            catch (System.Exception ex)
            {
                //MessageBox.Show(ex.Message);
                ExceptionHandle.ExceptionHdl(ex);
            }
        }

        /// <summary>
        ///     文件列表中选中项改变的时候,在上面label中同时更改描述
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_Files_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listView_Files.SelectedItems.Count > 0)
                {
                    var sItemString = listView_Files.SelectedItems[0].Text;
                    label_FileInfo.Text = projectInfo.ProjectName + "\n" + sItemString;
                }
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }
        }

        /// <summary>
        /// 双击文件列表文件播放视频
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_Files_DoubleClick(object sender, EventArgs e)
        {
            // 关闭双击播放视频功能
            return;
            try
            {
                if (listView_Files.SelectedItems.Count <= 0) return;
                if (listView_Files.SelectedItems[0].SubItems.Count <= 2) return;

                // 得到文件类型和路径
                var sFileType = listView_Files.SelectedItems[0].SubItems[1].Text;
                var sFilePath = listView_Files.SelectedItems[0].SubItems[2].Text;

                // 双击打开文件夹
                if (sFileType == "文件夹")
                {
                    ShowDirInFileBox(sFilePath);
                }

                // 现在只播放MP4类型文件
                if (sFileType.ToUpper() != "MP4") return;

                IntPtr rendWnd = PanelEx_Sequence.Handle;
                int ires = _iClipPlayControlCSharp.SetClip(sFilePath, rendWnd);
                _iClipPlayControlCSharp.Play();
                timer_Sequence.Stop();
                timer_Sequence.Start();

                // 获取视频时间长度（秒），并将其显示到labelX_SeqTime上
                int clipDuration = (int)(_iClipPlayControlCSharp.GetDuration() * GeneralConversions.NanoSecToSec);
                //labelX_SeqTime.Text = TimeLineControl.TimeLineControl.ChangeTimeValueToString(clipDuration);
                labelX_SeqTime.Text = TimeLineControl.TimeLineControl.ChangeTimeValueToString(0);

                // slider_SeqTime用来控制视频播放时间
                //slider_SeqTime.Maximum = clipDuration + 1;
                //slider_SeqTime.Value = 0;
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }
        }

        #endregion 文件列表操作


        #region 序列监视器操作

        /// <summary>
        /// 序列监视器计时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Sequence_Tick(object sender, EventArgs e)
        {
            try
            {
                // 0.1.每次移动之后要判断是否到了结尾停止播放
                // 0.2.找到轨道文件最终时间
                double dEndTime = GetTrackFilesEndTime((bool)timer_Sequence.Tag);
                if (timeLineControl_MainTL.ThumbValue >= dEndTime)
                {
                    // 1.播放停止,定时器停止
                    _iClipPlayControlCSharp.Stop();
                    timer_Sequence.Stop();

                    // 2.将按钮的symble转换为点击播放
                    if ((bool)timer_Sequence.Tag)
                    {
                        buttonX_PlayInterval.Symbol = _symbolIntervalPlay;
                    }
                    else
                    {
                        buttonX_PlayAndStop.Symbol = _symbolPlay;
                    }
                    return;
                }

                // 1.游标向前移动1秒
                timeLineControl_MainTL.MoveForward(1.0);

                // 2.获取当前正在播放的视频
                string palyFileName = _iClipPlayControlCSharp.GetClip();

                // 3.找到当前游标位置视频
                PanelEx panel = FindThumbPosVedio();

                if (panel == null)
                {
                    _iClipPlayControlCSharp.SetClip("", (IntPtr)PanelEx_Sequence.Handle);
                    _iClipPlayControlCSharp.Play();
                }
                else
                {
                    // 4.如果游标位置的视频不是当前播放的视频,则要开始播放游标位置的视频
                    if (panel.Name != palyFileName)
                    {
                        // 3.如果当前有视频,则开始播放当前视频
                        _iClipPlayControlCSharp.SetClip(panel.Name, (IntPtr)PanelEx_Sequence.Handle);

                        // 4.找到开始播放的位置
                        // 4.1.首先解析tag获取信息
                        string objStr = panel.Tag as string;
                        if (objStr == null) return;
                        string[] startAndEndTime = objStr.Split('-');
                        if (startAndEndTime.Length < 4) return;

                        // 4.2.得到原文件在时间线上的起始/终点时间,和自己的入点/出点时间
                        double dStartTime = double.Parse(startAndEndTime[0]);
                        //double dEndTime = double.Parse(startAndEndTime[1]);
                        double dEntreTime = double.Parse(startAndEndTime[2]);

                        double dPlayTime = timeLineControl_MainTL.ThumbValue - dStartTime + dEntreTime;

                        _iClipPlayControlCSharp.SetPosition((long)(dPlayTime * GeneralConversions.SecToNanoSec), 0);
                        _iClipPlayControlCSharp.Play();
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }
        }

        /// <summary>
        /// 移动序列监视器计时器slider游标的时候控制播放时间点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void slider_SeqTime_Scroll(object sender, ScrollEventArgs e)
        {
            /*
            try
            {
                if (_iClipPlayControlCSharp.GetCurState() == 0)
                {
                    _iClipPlayControlCSharp.SetPosition((long)(slider_SeqTime.Value * GeneralConversions.SecToNanoSec), 0);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }
            */
        }

        /// <summary>
        /// 找到游标所在位置的视频
        /// </summary>
        /// <returns></returns>
        private PanelEx FindThumbPosVedio()
        {
            return FindNeedShowVedioByTime(timeLineControl_MainTL.ThumbValue);
        }

        /// <summary>
        /// 通过位置(坐标)找到当前游标所在位置的视频
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        private PanelEx FindNeedShowVedioByPos(int pos)
        {
            double dTime = timeLineControl_MainTL.GetTimeValueByPos(pos);
            return FindNeedShowVedioByTime(dTime);
        }

        /// <summary>
        /// 通过时间找到当前游标所在位置的视频
        /// </summary>
        private PanelEx FindNeedShowVedioByTime(double dTime)
        {
            //TODO:更新需要显示的帧的处理不能这样
            //return;
            try
            {
                foreach (PanelEx vedioTrackPanel in _vedioTrackPanels)
                {
                    foreach (Control control in vedioTrackPanel.Controls)
                    {
                        PanelEx panel = control as PanelEx;
                        if (panel == null || !panel.Name.ToUpper().EndsWith("MP4")) continue;

                        if (IsNeededShowPanel(panel, dTime))
                        {
                            return panel;
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
                return null;
            }
        }

        /// <summary>
        /// 是否是需要显示的视频
        /// </summary>
        /// <param name="panel"></param>
        /// <returns></returns>
        private bool IsNeededShowPanel(PanelEx panel, double dTime)
        {
            try
            {
                // 1.先取得每个panel在时间线上的起始时间和终止时间
                string objStr = panel.Tag as string;
                if (objStr == null) return false;
                string[] startAndEndTime = objStr.Split('-');
                if (startAndEndTime.Length < 2) return false;

                // 如果时间线的游标时间处于两者之间,则说明此panel是处于可显示状态
                if (dTime > double.Parse(startAndEndTime[0])
                    && dTime < double.Parse(startAndEndTime[1]))
                {
                    //double playTime = timeLineControl_MainTL.ThumbValue - double.Parse(startAndEndTime[0]);
                    //ShowThisPanelFrame(panel.Name, (long)(playTime * GeneralConversions.SecToNanoSec));
                    return true;
                }
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
                return false;
            }
            return false;
        }

        /// <summary>
        /// 显示这一帧
        /// </summary>
        /// <param name="panelName"></param>
        /// <param name="playTime"></param>
        private void ShowThisPanelFrame(string panelName, long playTime)
        {
            try
            {
                IntPtr rendWnd = PanelEx_Sequence.Handle;
                int ires = _iClipPlayControlCSharp.SetClip(panelName, rendWnd);
                _iClipPlayControlCSharp.SetPosition(playTime, 0);
                _iClipPlayControlCSharp.Play();
                //_iClipPlayControlCSharp.Pause();
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }
        }

        #endregion 序列监视器操作


        #region 片段监视器操作

        /// <summary>
        /// 片段监视器计时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Segment_Tick(object sender, EventArgs e)
        {
            // 暂时不要实现
        }

        #endregion 片段监视器操作


        #region 视频轨道名称面板操作


        /// <summary>
        /// 眼睛按钮点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VideoTrackB4BI_See_Click(object sender, EventArgs e)
        {
            try
            {
                ButtonItem item = sender as ButtonItem;

                if (item.Icon == _icon_eye_open)
                {
                    item.Icon = _icon_eye_closed;
                }
                else
                {
                    item.Icon = _icon_eye_open;
                }

            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }
        }

        /// <summary>
        /// 锁定按钮点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VideoTrackB4BI_Lock_Click(object sender, EventArgs e)
        {
            try
            {
                ButtonItem item = sender as ButtonItem;

                if (item.Icon == _icon_lock_open)
                {
                    item.Icon = _icon_lock_closed;
                }
                else
                {
                    item.Icon = _icon_lock_open;
                }

            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }
        }

        /// <summary>
        /// 音量按钮点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AudioTrackB1BI_Volume_Click(object sender, EventArgs e)
        {
            try
            {
                ButtonItem item = sender as ButtonItem;

                if (item.Icon == _icon_volume_full)
                {
                    item.Icon = _icon_volume_muted;
                }
                else
                {
                    item.Icon = _icon_volume_full;
                }
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }
        }

        /// <summary>
        /// 独奏按钮点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AudioTrackB1BI_Listen_Click(object sender, EventArgs e)
        {
            try
            {
                ButtonItem item = sender as ButtonItem;

                if (item.Icon == _icon_headphone_open)
                {
                    item.Icon = _icon_headphone_closed;
                }
                else
                {
                    item.Icon = _icon_headphone_open;
                }
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }
        }


        // private void TrackName_BtnMouseHover(object sender, EventArgs e)
        // {
        //     ((ButtonItem)sender).Icon = Resources.lock_closed_16px;
        // }
        // 
        // private void TrackName_BtnMouseLeave(object sender, EventArgs e)
        // {
        //     ((ButtonItem)sender).Icon = Resources.lock_open_16px;
        // }

        #endregion 视频轨道名称面板操作


        #region 音频轨道名称面板操作

        #endregion 音频轨道名称面板操作


        #region 时间线快捷按钮点击事件

        // 播放/暂停图标
        private static readonly string _symbolPlay = "57401";
        private static readonly string _symbolStop = "57398";
        private static readonly string _symbolIntervalPlay = "57408";
        private static readonly string _symbolIntervalStop = "57396";

        //private bool _onlyPlayInterval = false;

        /// <summary>
        /// 播放和暂停
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonX_PlayAndStop_Click(object sender, EventArgs e)
        {
            //string strFileName = _iClipPlayControlCSharp.GetClip();
            //MessageBox.Show(strFileName);
            try
            {
                // 如果当前没有播放视频(或者在播放区间),那么从游标位置开始播放视频
                if (_iClipPlayControlCSharp.GetCurState() != 0 || (bool)timer_Sequence.Tag == true)
                {
                    // 1.找到当前游标位置视频
                    PanelEx panel = FindThumbPosVedio();

                    if (panel == null)
                    {
                        // 2.如果当前位置没有视频,为空白,则设置播放视频为空
                        _iClipPlayControlCSharp.SetClip("", (IntPtr)PanelEx_Sequence.Handle);
                    }
                    else
                    {
                        // 3.如果当前有视频,则开始播放当前视频
                        _iClipPlayControlCSharp.SetClip(panel.Name, (IntPtr)PanelEx_Sequence.Handle);

                        // 4.找到开始播放的位置
                        // 4.1.首先解析tag获取信息
                        string objStr = panel.Tag as string;
                        if (objStr == null) return;
                        string[] startAndEndTime = objStr.Split('-');
                        if (startAndEndTime.Length < 4) return;

                        // 4.2.得到原文件在时间线上的起始/终点时间,和自己的入点/出点时间
                        double dStartTime = double.Parse(startAndEndTime[0]);
                        double dEndTime = double.Parse(startAndEndTime[1]);
                        double dEntreTime = double.Parse(startAndEndTime[2]);

                        double dPlayTime = timeLineControl_MainTL.ThumbValue - dStartTime + dEntreTime;

                        _iClipPlayControlCSharp.SetPosition((long)(dPlayTime * GeneralConversions.SecToNanoSec), 0);
                    }

                    // 5.播放视频,计时器开始,如果播放全部,则计时器tag为false
                    //_onlyPlayInterval = false;
                    _iClipPlayControlCSharp.Play();
                    timer_Sequence.Tag = false;
                    timer_Sequence.Start();

                    // 6.将自身symble转换为点击暂停
                    buttonX_PlayAndStop.Symbol = _symbolStop;
                    buttonX_PlayInterval.Symbol = _symbolIntervalPlay;
                }
                else
                {
                    // 如果当前正在播放视频,则停止播放

                    // 1.播放停止,定时器停止
                    _iClipPlayControlCSharp.Stop();
                    timer_Sequence.Stop();

                    // 2.将自身symble转换为点击播放,将另一个置为点击播放
                    (sender as ButtonX).Symbol = _symbolPlay;
                }
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }
        }

        /// <summary>
        /// 播放区间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonX_PlayInterval_Click(object sender, EventArgs e)
        {
            try
            {
                // 如果当前没有播放视频(或者在播放全部视频),那么从游标位置开始播放视频
                if (_iClipPlayControlCSharp.GetCurState() != 0 || (bool)timer_Sequence.Tag == false)
                {
                    // 0.首先将游标移动到入点位置
                    buttonX_MoveToEnter_Click(sender, e);

                    // 1.找到当前游标位置视频
                    PanelEx panel = FindThumbPosVedio();

                    if (panel == null)
                    {
                        // 2.如果当前位置没有视频,为空白,则设置播放视频为空
                        _iClipPlayControlCSharp.SetClip("", (IntPtr)PanelEx_Sequence.Handle);
                    }
                    else
                    {
                        // 3.如果当前有视频,则开始播放当前视频
                        _iClipPlayControlCSharp.SetClip(panel.Name, (IntPtr)PanelEx_Sequence.Handle);

                        // 4.找到开始播放的位置
                        // 4.1.首先解析tag获取信息
                        string objStr = panel.Tag as string;
                        if (objStr == null) return;
                        string[] startAndEndTime = objStr.Split('-');
                        if (startAndEndTime.Length < 4) return;

                        // 4.2.得到原文件在时间线上的起始/终点时间,和自己的入点/出点时间
                        double dStartTime = double.Parse(startAndEndTime[0]);
                        double dEndTime = double.Parse(startAndEndTime[1]);
                        double dEntreTime = double.Parse(startAndEndTime[2]);

                        double dPlayTime = timeLineControl_MainTL.ThumbValue - dStartTime + dEntreTime;

                        _iClipPlayControlCSharp.SetPosition((long)(dPlayTime * GeneralConversions.SecToNanoSec), 0);
                    }

                    // 5.播放区间,计时器开始,如果播放区间,则计时器tag为true
                    //_onlyPlayInterval = true;
                    _iClipPlayControlCSharp.Play();
                    timer_Sequence.Tag = true;
                    timer_Sequence.Start();

                    // 6.将自身symble转换为点击暂停,将另一个置为点击播放
                    buttonX_PlayInterval.Symbol = _symbolIntervalStop;
                    buttonX_PlayAndStop.Symbol = _symbolPlay;
                }
                else
                {
                    // 如果当前正在播放视频,则停止播放

                    // 1.播放停止,定时器停止
                    _iClipPlayControlCSharp.Stop();
                    timer_Sequence.Stop();

                    // 2.将自身symble转换为点击播放
                    (sender as ButtonX).Symbol = _symbolIntervalPlay;
                }
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }
        }

        /// <summary>
        /// 时间线刻度缩小
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonX_SecondsTicksAdd_Click(object sender, EventArgs e)
        {
            if (timeLineControl_MainTL.ChangeIndexOfSecEveryTicks(true))
            {
                UpdateLabelTime();

                UpdateTrackFilesShow(true);
            }
        }

        /// <summary>
        /// 时间线刻度增加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonX_SecondsTicksSub_Click(object sender, EventArgs e)
        {
            if (timeLineControl_MainTL.ChangeIndexOfSecEveryTicks(false))
            {
                UpdateLabelTime();

                UpdateTrackFilesShow(false);
            }
        }

        /// <summary>
        /// 设置入点,将入点设置到游标位置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonX_SetEnter_Click(object sender, EventArgs e)
        {
            // 如果游标位置 <= 出点位置 - distance, 同时游标和入点不在一个位置, 优化效率
            if (timeLineControl_MainTL.ThumbHPos <= timeLineControl_MainTL.exitPos - timeLineControl_MainTL.NDistanceOfTicks
                && timeLineControl_MainTL.enterPos != timeLineControl_MainTL.ThumbHPos)
            {
                timeLineControl_MainTL.enterPos = (int)timeLineControl_MainTL.ThumbHPos;
                timeLineControl_Sequence.enterPos = (int)timeLineControl_Sequence.ThumbHPos;

                timeLineControl_MainTL.Invalidate();
                timeLineControl_Sequence.Invalidate();
            }
        }

        /// <summary>
        /// 设置出点,将出点设置到游标位置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonX_SetExit_Click(object sender, EventArgs e)
        {
            // 如果游标位置 >= 入点位置 + distance, 同时游标和出点不在一个位置, 优化效率
            if (timeLineControl_MainTL.ThumbHPos >= timeLineControl_MainTL.enterPos + timeLineControl_MainTL.NDistanceOfTicks
                && timeLineControl_MainTL.exitPos != timeLineControl_MainTL.ThumbHPos)
            {
                timeLineControl_MainTL.exitPos = (int)timeLineControl_MainTL.ThumbHPos;
                timeLineControl_Sequence.exitPos = (int)timeLineControl_Sequence.ThumbHPos;

                timeLineControl_MainTL.Invalidate();
                timeLineControl_Sequence.Invalidate();
            }
        }

        /// <summary>
        /// 将游标移至入点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonX_MoveToEnter_Click(object sender, EventArgs e)
        {
            // 只要游标本身不与出点/入点在同一个位置,就将其移动到游标位置
            if (timeLineControl_MainTL.enterPos != timeLineControl_MainTL.ThumbHPos)
            {
                timeLineControl_MainTL.ThumbHPos = timeLineControl_MainTL.enterPos;
                timeLineControl_Sequence.ThumbHPos = timeLineControl_Sequence.enterPos;

                timeLineControl_MainTL.Invalidate();
                timeLineControl_Sequence.Invalidate();

                UpdateLabelTime();
            }
        }

        /// <summary>
        /// 将游标移至出点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonX_MoveToExit_Click(object sender, EventArgs e)
        {
            if (timeLineControl_MainTL.exitPos != timeLineControl_MainTL.ThumbHPos)
            {
                timeLineControl_MainTL.ThumbHPos = timeLineControl_MainTL.exitPos;
                timeLineControl_Sequence.ThumbHPos = timeLineControl_Sequence.exitPos;

                timeLineControl_MainTL.Invalidate();
                timeLineControl_Sequence.Invalidate();

                UpdateLabelTime();
            }
        }

        #endregion


        #region 右键菜单成员变量

        // 轨道空白右键菜单
        private ContextMenuStrip _trackBlankMenu;
        private ToolStripMenuItem _trackBlank删除空隙;
        private ToolStripMenuItem _trackBlank粘贴空隙;
        private ToolStripMenuItem _trackBlank粘贴;
        private ToolStripSeparator _trackBlankSeparator1;
        private ToolStripMenuItem _trackBlank当前轨道中插入工作区;
        private ToolStripMenuItem _trackBlank删除当前轨道工作区;
        private ToolStripMenuItem _trackBlank清除当前轨道工作区;

        // 视频轨道文件右键菜单
        private ContextMenuStrip _vedioTrackFileMenu;
        private ToolStripMenuItem _vedioTrackFile打开片段;
        private ToolStripMenuItem _vedioTrackFile剪切;
        private ToolStripMenuItem _vedioTrackFile复制;
        private ToolStripMenuItem _vedioTrackFile删除;
        private ToolStripMenuItem _vedioTrackFile独立删除;
        private ToolStripMenuItem _vedioTrackFile涟漪删除;
        private ToolStripMenuItem _vedioTrackFile片段静音;
        private ToolStripSeparator _vedioTrackFileSeparator1;
        private ToolStripMenuItem _vedioTrackFile在片段监视器上加载原始片段;
        private ToolStripMenuItem _vedioTrackFile在工程浏览器中查找片段;
        private ToolStripMenuItem _vedioTrackFile保存模版;

        private ToolStripMenuItem _vedioTrackFile复制特技;
        private ToolStripMenuItem _vedioTrackFile复制属性特技;

        private ToolStripMenuItem _vedioTrackFile粘贴特技;
        private ToolStripMenuItem _vedioTrackFile删除特技;
        private ToolStripSeparator _vedioTrackFileSeparator2;

        private ToolStripMenuItem _vedioTrackFile轨道内移动;
        private ToolStripMenuItem _vedioTrackFile向左平移一帧;
        private ToolStripMenuItem _vedioTrackFile向左平移五帧;
        private ToolStripMenuItem _vedioTrackFile向右平移一帧;
        private ToolStripMenuItem _vedioTrackFile向右平移五帧;
        private ToolStripMenuItem _vedioTrackFile向左平移指定时间长度;
        private ToolStripMenuItem _vedioTrackFile向右平移指定时间长度;
        private ToolStripMenuItem _vedioTrackFile平移片段入点至上一个片段出点;
        private ToolStripMenuItem _vedioTrackFile平移片段出点至上一个片段入点;

        private ToolStripMenuItem _vedioTrackFile移到时码线处;
        private ToolStripMenuItem _vedioTrackFile平移片段入点至时码线处;
        private ToolStripMenuItem _vedioTrackFile平移片段出点至时码线处;
        private ToolStripMenuItem _vedioTrackFile平移片段之后至时码线处;
        private ToolStripMenuItem _vedioTrackFile平移片段之前至时码线处;

        private ToolStripSeparator _vedioTrackFileSeparator3;
        private ToolStripMenuItem _vedioTrackFile片段编组;
        private ToolStripMenuItem _vedioTrackFile解组;
        private ToolStripMenuItem _vedioTrackFile素材互换;

        private ToolStripMenuItem _vedioTrackFile联动控制;
        private ToolStripMenuItem _vedioTrackFile视音频联动;
        private ToolStripMenuItem _vedioTrackFile音频联动;
        private ToolStripMenuItem _vedioTrackFile独立;

        private ToolStripSeparator _vedioTrackFileSeparator4;
        private ToolStripMenuItem _vedioTrackFile自动上下变换;

        // 主时间线右键菜单
        private ContextMenuStrip _mainTimeLineMenu;
        private ToolStripMenuItem _mainTimeLineMenu添加标记点;
        private ToolStripMenuItem _mainTimeLineMenu注释标记点;
        private ToolStripMenuItem _mainTimeLineMenu删除标记点;
        private ToolStripMenuItem _mainTimeLineMenu删除所有标记点;
        private ToolStripMenuItem _mainTimeLineMenu上一个标记点;
        private ToolStripMenuItem _mainTimeLineMenu下一个标记点;
        private ToolStripMenuItem _mainTimeLineMenu标记点管理;
        private ToolStripSeparator _mainTimeLineMenuSeparator1;

        private ToolStripMenuItem _mainTimeLineMenu设置工作区入点;
        private ToolStripMenuItem _mainTimeLineMenu设置工作区出点;
        private ToolStripMenuItem _mainTimeLineMenu移至工作区入点;
        private ToolStripMenuItem _mainTimeLineMenu移至工作区出点;
        private ToolStripSeparator _mainTimeLineMenuSeparator2;

        private ToolStripMenuItem _mainTimeLineMenu设置序列入出点;
        private ToolStripMenuItem _mainTimeLineMenu加入批打包列表;
        private ToolStripMenuItem _mainTimeLineMenu查看批打包列表;
        private ToolStripMenuItem _mainTimeLineMenu清除批打包列表;
        private ToolStripMenuItem _mainTimeLineMenu时间标尺精度;
        private ToolStripSeparator _mainTimeLineMenuSeparator3;

        private ToolStripMenuItem _mainTimeLineMenu所有轨道插入工作区;
        private ToolStripMenuItem _mainTimeLineMenu删除工作区中所有片段;
        private ToolStripMenuItem _mainTimeLineMenu清除工作区中所有片段;
        private ToolStripMenuItem _mainTimeLineMenu复制工作区中片段;
        private ToolStripMenuItem _mainTimeLineMenu粘贴工作区至时码线;
        private ToolStripSeparator _mainTimeLineMenuSeparator4;

        private ToolStripMenuItem _mainTimeLineMenu黑场检测;
        private ToolStripMenuItem _mainTimeLineMenu质量检测;

        // 序列监视器右键
        private ContextMenuStrip _sequenceMenu;
        private ToolStripMenuItem _sequenceMenu显示模式;
        private ToolStripMenuItem _sequenceMenu帧方式显示;
        private ToolStripMenuItem _sequenceMenu显示第一场;
        private ToolStripMenuItem _sequenceMenu显示第二场;
        private ToolStripSeparator _sequenceMenuSeparator1;

        private ToolStripMenuItem _sequenceMenu缩放;
        private ToolStripMenuItem _sequenceMenu缩放适配;
        private ToolStripMenuItem _sequenceMenu缩放25;
        private ToolStripMenuItem _sequenceMenu缩放50;
        private ToolStripMenuItem _sequenceMenu缩放100;
        private ToolStripMenuItem _sequenceMenu缩放150;
        private ToolStripMenuItem _sequenceMenu缩放200;
        private ToolStripMenuItem _sequenceMenu放大;
        private ToolStripMenuItem _sequenceMenu缩小;
        private ToolStripSeparator _sequenceMenuSeparator2;

        private ToolStripMenuItem _sequenceMenu通道;
        private ToolStripMenuItem _sequenceMenu通道RGBA;
        private ToolStripMenuItem _sequenceMenu通道RGB;
        private ToolStripMenuItem _sequenceMenu通道红色通道;
        private ToolStripMenuItem _sequenceMenu通道绿色通道;
        private ToolStripMenuItem _sequenceMenu通道蓝色通道;
        private ToolStripMenuItem _sequenceMenu通道Alpha通道;
        private ToolStripMenuItem _sequenceMenu通道亮度通道709;
        private ToolStripMenuItem _sequenceMenu通道亮度通道601;
        private ToolStripMenuItem _sequenceMenu输出图像;
        private ToolStripSeparator _sequenceMenuSeparator3;

        private ToolStripMenuItem _sequenceMenu方形像素显示;
        private ToolStripMenuItem _sequenceMenu显示棋盘格;
        private ToolStripMenuItem _sequenceMenu显示素材信息;
        private ToolStripMenuItem _sequenceMenu网格;
        private ToolStripMenuItem _sequenceMenu辅助线;
        private ToolStripMenuItem _sequenceMenu辅助线显示辅助线;
        private ToolStripSeparator _sequenceMenu辅助线Separator1;
        private ToolStripMenuItem _sequenceMenu标题操作安全区域;
        private ToolStripMenuItem _sequenceMenu辅助线图像框;
        private ToolStripMenuItem _sequenceMenu辅助线坐标轴;

        // 文件列表右键菜单
        private ContextMenuStrip _fileListMenu;
        private ToolStripMenuItem _fileListMenu粘贴;
        private ToolStripMenuItem _fileListMenu新建文件夹;
        private ToolStripMenuItem _fileListMenu新建项;
        private ToolStripMenuItem _fileListMenu创建字幕;
        private ToolStripMenuItem _fileListMenu导入;
        private ToolStripMenuItem _fileListMenu导入双目影像文件;
        private ToolStripMenuItem _fileListMenu查找;
        private ToolStripMenuItem _fileListMenu隐藏字幕模板文件夹;
        private ToolStripMenuItem _fileListMenu隐藏流程图库;
        private ToolStripSeparator _fileListMenuSeparator1;




        #endregion


        #region 创建右键菜单
        public static Size _menuSize = new Size(125, 148);
        public static Size _menuItemSize = new Size(124, 22);
        public static Size _seperatorSize = new Size(121, 6);
        public static Color _menuColor = fontsColor;
        public static Color _menufontsColor = bkgColor;

        /// <summary>
        /// 初始化主菜单的颜色
        /// </summary>
        private void InitMainMenuColor()
        {
            工程ToolStripMenuItem.BackColor = bkgColor;
            编辑ToolStripMenuItem.BackColor = bkgColor;
            输入ToolStripMenuItem.BackColor = bkgColor;
            输出ToolStripMenuItem.BackColor = bkgColor;

            另存为ToolStripMenuItem.BackColor = bkgColor;
            关闭ToolStripMenuItem.BackColor = bkgColor;
            偏好设置ToolStripMenuItem.BackColor = bkgColor;
            工程设置ToolStripMenuItem.BackColor = bkgColor;
            导入工程ToolStripMenuItem.BackColor = bkgColor;
            导入序列ToolStripMenuItem.BackColor = bkgColor;
            导入AAFToolStripMenuItem.BackColor = bkgColor;
            导入配音序列ToolStripMenuItem.BackColor = bkgColor;
            删除未引用的素材ToolStripMenuItem.BackColor = bkgColor;
            工程整理ToolStripMenuItem.BackColor = bkgColor;
            工程信息统计ToolStripMenuItem.BackColor = bkgColor;
            最近打开工程ToolStripMenuItem.BackColor = bkgColor;
            退出ToolStripMenuItem.BackColor = bkgColor;
            配音DToolStripMenuItem.BackColor = bkgColor;
            显示第二效果监视器ToolStripMenuItem.BackColor = bkgColor;
            缓存管理ToolStripMenuItem.BackColor = bkgColor;
            导入ToolStripMenuItem.BackColor = bkgColor;
            导入P2ToolStripMenuItem.BackColor = bkgColor;
            导入XDCAMToolStripMenuItem.BackColor = bkgColor;
            导入SxStoolStripMenuItem.BackColor = bkgColor;
            导入E2toolStripMenuItem.BackColor = bkgColor;
            导入PPTtoolStripMenuItem.BackColor = bkgColor;
            光盘刻录ToolStripMenuItem.BackColor = bkgColor;
            更新素材库ToolStripMenuItem.BackColor = bkgColor;
            分离ToolStripMenuItem.BackColor = bkgColor;
            编解码ToolStripMenuItem.BackColor = bkgColor;
            打包ToolStripMenuItem.BackColor = bkgColor;
            测试ToolStripMenuItem.BackColor = bkgColor;
            新建ToolStripMenuItem.BackColor = bkgColor;
            打开ToolStripMenuItem.BackColor = bkgColor;
            保存ToolStripMenuItem.BackColor = bkgColor;
            撤销ToolStripMenuItem.BackColor = bkgColor;
            重做ToolStripMenuItem.BackColor = bkgColor;
            采集ToolStripMenuItem.BackColor = bkgColor;
            录制ToolStripMenuItem.BackColor = bkgColor;
            打包输出ToolStripMenuItem.BackColor = bkgColor;
            设备输出设置ToolStripMenuItem.BackColor = bkgColor;
            关于ToolStripMenuItem.BackColor = bkgColor;

            //toolStripSeparator1.BackColor = bkgColor;
            //toolStripSeparator2.BackColor = bkgColor;
            //toolStripSeparator3.BackColor = bkgColor;
            //toolStripSeparator4.BackColor = bkgColor;
            //toolStripSeparator5.BackColor = bkgColor;
            //toolStripSeparator6.BackColor = bkgColor;
            //toolStripSeparator7.BackColor = bkgColor;
            //toolStripSeparator8.BackColor = bkgColor;
            //toolStripSeparator9.BackColor = bkgColor;
            //toolStripSeparator10.BackColor = bkgColor;
            //
            //toolStripSeparator1.ForeColor = bkgColor;
            //toolStripSeparator2.ForeColor = bkgColor;
            //toolStripSeparator3.ForeColor = bkgColor;
            //toolStripSeparator4.ForeColor = bkgColor;
            //toolStripSeparator5.ForeColor = bkgColor;
            //toolStripSeparator6.ForeColor = bkgColor;
            //toolStripSeparator7.ForeColor = bkgColor;
            //toolStripSeparator8.ForeColor = bkgColor;
            //toolStripSeparator9.ForeColor = bkgColor;
            //toolStripSeparator10.ForeColor = bkgColor;
        }

        /// <summary>
        /// 创建所有菜单
        /// </summary>
        private void CreateAllMenu()
        {
            InitMainMenuColor();

            //CreateTrackBlankMenu();

            //CreateTrackFileMenu();

            CreateTimelineMenu();

            CreatesequenceMenu();

            CreateFileListMenu();
        }

        /// <summary>
        /// 创建轨道空白右键菜单
        /// </summary>
        private void CreateTrackBlankMenu()
        {
            _trackBlankMenu = new ContextMenuStrip
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_trackBlankMenu",
                Size = _menuSize
            };

            _trackBlank删除空隙 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_删除空隙MenuItem",
                Size = _menuItemSize,
                Text = "删除空隙"
            };
            _trackBlank删除空隙.Click += 删除空隙ToolStripMenuItem_Click;

            _trackBlank粘贴空隙 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_粘贴空隙MenuItem",
                Size = _menuItemSize,
                Text = "粘贴空隙"
            };

            _trackBlank粘贴 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_粘贴MenuItem",
                Size = _menuItemSize,
                Text = "粘贴"
            };

            _trackBlankSeparator1 = new ToolStripSeparator
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_trackBlankSeparator1",
                Size = _seperatorSize,
            };

            _trackBlank当前轨道中插入工作区 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_当前轨道中插入工作区MenuItem",
                Size = _menuItemSize,
                Text = "当前轨道中插入工作区"
            };

            _trackBlank删除当前轨道工作区 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_删除当前轨道工作区MenuItem",
                Size = _menuItemSize,
                Text = "删除当前轨道工作区"
            };

            _trackBlank清除当前轨道工作区 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_清除当前轨道工作区MenuItem",
                Size = _menuItemSize,
                Text = "清除当前轨道工作区"
            };

            _trackBlankMenu.Items.AddRange(new ToolStripItem[]
            {
                _trackBlank删除空隙,
                _trackBlank粘贴空隙,
                _trackBlank粘贴,
                _trackBlankSeparator1,
                _trackBlank当前轨道中插入工作区,
                _trackBlank删除当前轨道工作区,
                _trackBlank清除当前轨道工作区
            });

            foreach (PanelEx panelEx in _vedioTrackPanels)
            {
                panelEx.ContextMenuStrip = _trackBlankMenu;
            }

            foreach (PanelEx panelEx in _audioTrackPanels)
            {
                panelEx.ContextMenuStrip = _trackBlankMenu;
            }

        }

        /// <summary>
        /// 创建轨道视频文件右键菜单
        /// </summary>
        private void CreateTrackFileMenu()
        {
            _vedioTrackFileMenu = new ContextMenuStrip
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_vedioTrackFileMenu",
                Size = _menuSize
            };

            _vedioTrackFile打开片段 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_vedioTrackFile打开片段",
                Size = _menuItemSize,
                Text = "打开片段"
            };
            _vedioTrackFile剪切 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_vedioTrackFile剪切",
                Size = _menuItemSize,
                Text = "剪切"
            };
            _vedioTrackFile复制 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_vedioTrackFile复制",
                Size = _menuItemSize,
                Text = "复制"
            };
            _vedioTrackFile删除 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_vedioTrackFile删除",
                Size = _menuItemSize,
                Text = "删除"
            };
            _vedioTrackFile删除.Click += _vedioTrackFile删除_Click;

            _vedioTrackFile独立删除 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_vedioTrackFile独立删除",
                Size = _menuItemSize,
                Text = "独立删除"
            };
            _vedioTrackFile涟漪删除 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_vedioTrackFile涟漪删除",
                Size = _menuItemSize,
                Text = "涟漪删除"
            };
            _vedioTrackFile片段静音 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_vedioTrackFile片段静音",
                Size = _menuItemSize,
                Text = "片段静音",

                CheckOnClick = true
            };
            _vedioTrackFileSeparator1 = new ToolStripSeparator
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_vedioTrackFileSeparator1",
                Size = _seperatorSize,
            };

            _vedioTrackFile在片段监视器上加载原始片段 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_vedioTrackFile在片段监视器上加载原始片段",
                Size = _menuItemSize,
                Text = "在片段监视器上加载原始片段"
            };
            _vedioTrackFile在工程浏览器中查找片段 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_vedioTrackFile在工程浏览器中查找片段",
                Size = _menuItemSize,
                Text = "在工程浏览器中查找片段"
            };
            _vedioTrackFile保存模版 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_vedioTrackFile保存模版",
                Size = _menuItemSize,
                Text = "保存模版"
            };
            _vedioTrackFile复制特技 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_vedioTrackFile复制特技",
                Size = _menuItemSize,
                Text = "复制特技"
            };
            _vedioTrackFile复制属性特技 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_vedioTrackFile复制属性特技",
                Size = _menuItemSize,
                Text = "复制属性特技"
            };
            _vedioTrackFile粘贴特技 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_vedioTrackFile粘贴特技",
                Size = _menuItemSize,
                Text = "粘贴特技"
            };
            _vedioTrackFile删除特技 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_vedioTrackFile删除特技",
                Size = _menuItemSize,
                Text = "删除特技"
            };
            _vedioTrackFileSeparator2 = new ToolStripSeparator
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_vedioTrackFileSeparator2",
                Size = _seperatorSize,
            };

            _vedioTrackFile轨道内移动 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_vedioTrackFile轨道内移动",
                Size = _menuItemSize,
                Text = "轨道内移动"
            };
            _vedioTrackFile向左平移一帧 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_vedioTrackFile向左平移一帧",
                Size = _menuItemSize,
                Text = "向左平移一帧"
            };
            _vedioTrackFile向左平移五帧 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_vedioTrackFile向左平移五帧",
                Size = _menuItemSize,
                Text = "向左平移五帧"
            };
            _vedioTrackFile向右平移一帧 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_vedioTrackFile向右平移一帧",
                Size = _menuItemSize,
                Text = "向右平移一帧"
            };
            _vedioTrackFile向右平移五帧 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_vedioTrackFile向右平移五帧",
                Size = _menuItemSize,
                Text = "向右平移五帧"
            };
            _vedioTrackFile向左平移指定时间长度 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_vedioTrackFile向左平移指定时间长度",
                Size = _menuItemSize,
                Text = "向左平移指定时间长度"
            };
            _vedioTrackFile向右平移指定时间长度 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_vedioTrackFile向右平移指定时间长度",
                Size = _menuItemSize,
                Text = "向右平移指定时间长度"
            };
            _vedioTrackFile平移片段入点至上一个片段出点 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_vedioTrackFile平移片段入点至上一个片段出点",
                Size = _menuItemSize,
                Text = "平移片段入点至上一个片段出点"
            };
            _vedioTrackFile平移片段出点至上一个片段入点 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_vedioTrackFile平移片段出点至上一个片段入点",
                Size = _menuItemSize,
                Text = "平移片段出点至上一个片段入点"
            };

            _vedioTrackFile移到时码线处 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_vedioTrackFile移到时码线处",
                Size = _menuItemSize,
                Text = "移到时码线处"
            };
            _vedioTrackFile平移片段入点至时码线处 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_vedioTrackFile平移片段入点至时码线处",
                Size = _menuItemSize,
                Text = "平移片段入点至时码线处"
            };
            _vedioTrackFile平移片段出点至时码线处 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_vedioTrackFile平移片段出点至时码线处",
                Size = _menuItemSize,
                Text = "平移片段出点至时码线处"
            };
            _vedioTrackFile平移片段之后至时码线处 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_vedioTrackFile平移片段之后至时码线处",
                Size = _menuItemSize,
                Text = "平移片段之后至时码线处"
            };
            _vedioTrackFile平移片段之前至时码线处 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_vedioTrackFile平移片段之前至时码线处",
                Size = _menuItemSize,
                Text = "平移片段之前至时码线处"
            };

            _vedioTrackFileSeparator3 = new ToolStripSeparator
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_vedioTrackFileSeparator3",
                Size = _seperatorSize,
            };
            _vedioTrackFile片段编组 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_vedioTrackFile片段编组",
                Size = _menuItemSize,
                Text = "片段编组"
            };
            _vedioTrackFile解组 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_vedioTrackFile解组",
                Size = _menuItemSize,
                Text = "解组"
            };
            _vedioTrackFile素材互换 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_vedioTrackFile素材互换",
                Size = _menuItemSize,
                Text = "素材互换"
            };

            _vedioTrackFile联动控制 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_vedioTrackFile联动控制",
                Size = _menuItemSize,
                Text = "联动控制"
            };
            _vedioTrackFile视音频联动 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_vedioTrackFile视音频联动",
                Size = _menuItemSize,
                Text = "视音频联动"
            };
            _vedioTrackFile音频联动 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_vedioTrackFile音频联动",
                Size = _menuItemSize,
                Text = "音频联动"
            };
            _vedioTrackFile独立 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_vedioTrackFile独立",
                Size = _menuItemSize,
                Text = "独立"
            };

            _vedioTrackFileSeparator4 = new ToolStripSeparator
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_vedioTrackFileSeparator4",
                Size = _seperatorSize,
            };
            _vedioTrackFile自动上下变换 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_vedioTrackFile自动上下变换",
                Size = _menuItemSize,
                Text = "自动上下变换",

                CheckOnClick = true
            };

            _vedioTrackFile复制特技.DropDownItems.AddRange(new ToolStripItem[]
            {
                _vedioTrackFile复制属性特技
            });

            _vedioTrackFile轨道内移动.DropDownItems.AddRange(new ToolStripItem[]
            {
                _vedioTrackFile向左平移一帧,
                _vedioTrackFile向左平移五帧,
                _vedioTrackFile向右平移一帧,
                _vedioTrackFile向右平移五帧,
                _vedioTrackFile向左平移指定时间长度,
                _vedioTrackFile向右平移指定时间长度,
                _vedioTrackFile平移片段入点至上一个片段出点,
                _vedioTrackFile平移片段出点至上一个片段入点
            });

            _vedioTrackFile移到时码线处.DropDownItems.AddRange(new ToolStripItem[]
            {
                _vedioTrackFile平移片段入点至时码线处,
                _vedioTrackFile平移片段出点至时码线处,
                _vedioTrackFile平移片段之后至时码线处,
                _vedioTrackFile平移片段之前至时码线处
            });

            _vedioTrackFile联动控制.DropDownItems.AddRange(new ToolStripItem[]
            {
                _vedioTrackFile视音频联动,
                _vedioTrackFile音频联动,
                _vedioTrackFile独立
            });

            _vedioTrackFileMenu.Items.AddRange(new ToolStripItem[]
            {
                _vedioTrackFile打开片段,
                _vedioTrackFile剪切,
                _vedioTrackFile复制,
                _vedioTrackFile删除,
                _vedioTrackFile独立删除,
                _vedioTrackFile涟漪删除,
                _vedioTrackFile片段静音,
                _vedioTrackFileSeparator1,
                _vedioTrackFile在片段监视器上加载原始片段,
                _vedioTrackFile在工程浏览器中查找片段,
                _vedioTrackFile保存模版,
                _vedioTrackFile复制特技,
                _vedioTrackFile粘贴特技,
                _vedioTrackFile删除特技,
                _vedioTrackFileSeparator2,
                _vedioTrackFile轨道内移动,
                _vedioTrackFile移到时码线处,
                _vedioTrackFileSeparator3,
                _vedioTrackFile片段编组,
                _vedioTrackFile解组,
                _vedioTrackFile素材互换,
                _vedioTrackFile联动控制,
                _vedioTrackFileSeparator4,
                _vedioTrackFile自动上下变换
            });

            foreach (PanelEx panelEx in _vedioFilesPanel)
            {
                panelEx.ContextMenuStrip = _vedioTrackFileMenu;
            }

            foreach (PanelEx panelEx in _audioFilesPanel)
            {
                panelEx.ContextMenuStrip = _vedioTrackFileMenu;
            }
        }

        /// <summary>
        /// 创建时间线右键菜单
        /// </summary>
        private void CreateTimelineMenu()
        {
            _mainTimeLineMenu = new ContextMenuStrip
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_mainTimeLineMenu",
                Size = _menuSize
            };
            _mainTimeLineMenu添加标记点 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_mainTimeLineMenu添加标记点",
                Size = _menuItemSize,
                Text = "添加标记点"
            };
            _mainTimeLineMenu注释标记点 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_mainTimeLineMenu注释标记点",
                Size = _menuItemSize,
                Text = "注释标记点"
            };
            _mainTimeLineMenu删除标记点 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_mainTimeLineMenu删除标记点",
                Size = _menuItemSize,
                Text = "删除标记点"
            };
            _mainTimeLineMenu删除所有标记点 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_mainTimeLineMenu删除所有标记点",
                Size = _menuItemSize,
                Text = "删除所有标记点"
            };
            _mainTimeLineMenu上一个标记点 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_mainTimeLineMenu上一个标记点",
                Size = _menuItemSize,
                Text = "上一个标记点"
            };
            _mainTimeLineMenu下一个标记点 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_mainTimeLineMenu下一个标记点",
                Size = _menuItemSize,
                Text = "下一个标记点"
            };
            _mainTimeLineMenu标记点管理 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_mainTimeLineMenu标记点管理",
                Size = _menuItemSize,
                Text = "标记点管理"
            };
            _mainTimeLineMenuSeparator1 = new ToolStripSeparator
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_mainTimeLineMenuSeparator1",
                Size = _seperatorSize,
            };

            _mainTimeLineMenu设置工作区入点 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_mainTimeLineMenu设置工作区入点",
                Size = _menuItemSize,
                Text = "设置工作区入点"
            };
            _mainTimeLineMenu设置工作区出点 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_mainTimeLineMenu设置工作区出点",
                Size = _menuItemSize,
                Text = "设置工作区出点"
            };
            _mainTimeLineMenu移至工作区入点 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_mainTimeLineMenu移至工作区入点",
                Size = _menuItemSize,
                Text = "移至工作区入点"
            };
            _mainTimeLineMenu移至工作区出点 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_mainTimeLineMenu移至工作区出点",
                Size = _menuItemSize,
                Text = "移至工作区出点"
            };
            _mainTimeLineMenuSeparator2 = new ToolStripSeparator
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_mainTimeLineMenuSeparator2",
                Size = _seperatorSize,
            };

            _mainTimeLineMenu设置序列入出点 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_mainTimeLineMenu设置序列入出点",
                Size = _menuItemSize,
                Text = "设置序列入出点"
            };
            _mainTimeLineMenu加入批打包列表 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_mainTimeLineMenu加入批打包列表",
                Size = _menuItemSize,
                Text = "加入批打包列表"
            };
            _mainTimeLineMenu查看批打包列表 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_mainTimeLineMenu查看批打包列表",
                Size = _menuItemSize,
                Text = "查看批打包列表"
            };
            _mainTimeLineMenu清除批打包列表 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_mainTimeLineMenu清除批打包列表",
                Size = _menuItemSize,
                Text = "清除批打包列表"
            };
            _mainTimeLineMenu时间标尺精度 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_mainTimeLineMenu时间标尺精度",
                Size = _menuItemSize,
                Text = "时间标尺精度"
            };
            _mainTimeLineMenuSeparator3 = new ToolStripSeparator
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_mainTimeLineMenuSeparator3",
                Size = _seperatorSize,
            };

            _mainTimeLineMenu所有轨道插入工作区 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_mainTimeLineMenu所有轨道插入工作区",
                Size = _menuItemSize,
                Text = "所有轨道插入工作区"
            };
            _mainTimeLineMenu删除工作区中所有片段 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_mainTimeLineMenu删除工作区中所有片段",
                Size = _menuItemSize,
                Text = "删除工作区中所有片段"
            };
            _mainTimeLineMenu清除工作区中所有片段 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_mainTimeLineMenu清除工作区中所有片段",
                Size = _menuItemSize,
                Text = "清除工作区中所有片段"
            };
            _mainTimeLineMenu复制工作区中片段 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_mainTimeLineMenu复制工作区中片段",
                Size = _menuItemSize,
                Text = "复制工作区中片段"
            };
            _mainTimeLineMenu粘贴工作区至时码线 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_mainTimeLineMenu粘贴工作区至时码线",
                Size = _menuItemSize,
                Text = "粘贴工作区至时码线"
            };
            _mainTimeLineMenuSeparator4 = new ToolStripSeparator
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_mainTimeLineMenuSeparator4",
                Size = _seperatorSize,
            };

            _mainTimeLineMenu黑场检测 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_mainTimeLineMenu黑场检测",
                Size = _menuItemSize,
                Text = "黑场检测"
            };
            _mainTimeLineMenu质量检测 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_mainTimeLineMenu质量检测",
                Size = _menuItemSize,
                Text = "质量检测"
            };

            _mainTimeLineMenu.Items.AddRange(new ToolStripItem[]
            {
                _mainTimeLineMenu添加标记点,
                _mainTimeLineMenu注释标记点,
                _mainTimeLineMenu删除标记点,
                _mainTimeLineMenu删除所有标记点,
                _mainTimeLineMenu上一个标记点,
                _mainTimeLineMenu下一个标记点,
                _mainTimeLineMenu标记点管理,
                _mainTimeLineMenuSeparator1,
                _mainTimeLineMenu设置工作区入点,
                _mainTimeLineMenu设置工作区出点,
                _mainTimeLineMenu移至工作区入点,
                _mainTimeLineMenu移至工作区出点,
                _mainTimeLineMenuSeparator2,
                _mainTimeLineMenu设置序列入出点,
                _mainTimeLineMenu加入批打包列表,
                _mainTimeLineMenu查看批打包列表,
                _mainTimeLineMenu清除批打包列表,
                _mainTimeLineMenu时间标尺精度,
                _mainTimeLineMenuSeparator3,
                _mainTimeLineMenu所有轨道插入工作区,
                _mainTimeLineMenu删除工作区中所有片段,
                _mainTimeLineMenu清除工作区中所有片段,
                _mainTimeLineMenu复制工作区中片段,
                _mainTimeLineMenu粘贴工作区至时码线,
                _mainTimeLineMenuSeparator4,
                _mainTimeLineMenu黑场检测,
                _mainTimeLineMenu质量检测,
            });

            timeLineControl_MainTL.ContextMenuStrip = _mainTimeLineMenu;

        }

        /// <summary>
        /// 创建序列监视器面板右键菜单
        /// </summary>
        private void CreatesequenceMenu()
        {
            _sequenceMenu = new ContextMenuStrip
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_sequenceMenu",
                Size = _menuSize
            };
            _sequenceMenu显示模式 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_sequenceMenu显示模式",
                Size = _menuItemSize,
                Text = "显示模式"
            };
            _sequenceMenu帧方式显示 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_sequenceMenu帧方式显示",
                Size = _menuItemSize,
                Text = "帧方式显示"
            };
            _sequenceMenu显示第一场 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_sequenceMenu显示第一场",
                Size = _menuItemSize,
                Text = "显示第一场"
            };
            _sequenceMenu显示第二场 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_sequenceMenu显示第二场",
                Size = _menuItemSize,
                Text = "显示第二场"
            };
            _sequenceMenuSeparator1 = new ToolStripSeparator
            {
                //BackColor = _menuColor, ForeColor = _menufontsColor,
                //ForeColor = _menuColor,
                Name = "_sequenceMenuSeparator1",
                Size = _seperatorSize,
            };

            _sequenceMenu缩放 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_sequenceMenu缩放",
                Size = _menuItemSize,
                Text = "缩放"
            };
            _sequenceMenu缩放适配 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_sequenceMenu缩放适配",
                Size = _menuItemSize,
                Text = "适配"
            };
            _sequenceMenu缩放25 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_sequenceMenu缩放25",
                Size = _menuItemSize,
                Text = "25%"
            };
            _sequenceMenu缩放50 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_sequenceMenu缩放50",
                Size = _menuItemSize,
                Text = "50%"
            };
            _sequenceMenu缩放100 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_sequenceMenu缩放100",
                Size = _menuItemSize,
                Text = "100%"
            };
            _sequenceMenu缩放150 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_sequenceMenu缩放150",
                Size = _menuItemSize,
                Text = "150%"
            };
            _sequenceMenu缩放200 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_sequenceMenu缩放200",
                Size = _menuItemSize,
                Text = "200%"
            };
            _sequenceMenu放大 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_sequenceMenu放大",
                Size = _menuItemSize,
                Text = "放大"
            };
            _sequenceMenu缩小 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_sequenceMenu缩小",
                Size = _menuItemSize,
                Text = "缩小"
            };
            _sequenceMenuSeparator2 = new ToolStripSeparator
            {
                //BackColor = _menuColor, ForeColor = _menufontsColor,
                //ForeColor = _menuColor,
                Name = "_sequenceMenuSeparator2",
                Size = _seperatorSize,
            };

            _sequenceMenu通道 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_sequenceMenu通道",
                Size = _menuItemSize,
                Text = "通道"
            };
            _sequenceMenu通道RGBA = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_sequenceMenu通道RGBA",
                Size = _menuItemSize,
                Text = "RGBA"
            };
            _sequenceMenu通道RGB = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_sequenceMenu通道RGB",
                Size = _menuItemSize,
                Text = "RGB"
            };
            _sequenceMenu通道红色通道 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_sequenceMenu通道红色通道",
                Size = _menuItemSize,
                Text = "红色通道"
            };
            _sequenceMenu通道绿色通道 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_sequenceMenu通道绿色通道",
                Size = _menuItemSize,
                Text = "绿色通道"
            };
            _sequenceMenu通道蓝色通道 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_sequenceMenu通道蓝色通道",
                Size = _menuItemSize,
                Text = "蓝色通道"
            };
            _sequenceMenu通道Alpha通道 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_sequenceMenu通道Alpha通道",
                Size = _menuItemSize,
                Text = "Alpha通道"
            };
            _sequenceMenu通道亮度通道709 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_sequenceMenu通道亮度通道709",
                Size = _menuItemSize,
                Text = "亮度通道(709)"
            };
            _sequenceMenu通道亮度通道601 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_sequenceMenu通道亮度通道601",
                Size = _menuItemSize,
                Text = "亮度通道(601)"
            };
            _sequenceMenu输出图像 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_sequenceMenu输出图像",
                Size = _menuItemSize,
                Text = "输出图像"
            };
            _sequenceMenuSeparator3 = new ToolStripSeparator
            {
                //BackColor = _menuColor, ForeColor = _menufontsColor,
                //ForeColor = _menuColor,
                Name = "_sequenceMenuSeparator3",
                Size = _seperatorSize,
            };

            _sequenceMenu方形像素显示 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_sequenceMenu方形像素显示",
                Size = _menuItemSize,
                Text = "方形像素显示"
            };
            _sequenceMenu显示棋盘格 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_sequenceMenu显示棋盘格",
                Size = _menuItemSize,
                Text = "显示棋盘格"
            };
            _sequenceMenu显示素材信息 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_sequenceMenu显示素材信息",
                Size = _menuItemSize,
                Text = "显示素材信息"
            };
            _sequenceMenu网格 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_sequenceMenu网格",
                Size = _menuItemSize,
                Text = "网格"
            };
            _sequenceMenu辅助线 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_sequenceMenu辅助线",
                Size = _menuItemSize,
                Text = "辅助线"
            };
            _sequenceMenu辅助线显示辅助线 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_sequenceMenu辅助线显示辅助线",
                Size = _menuItemSize,
                Text = "显示辅助线"
            };
            _sequenceMenu辅助线Separator1 = new ToolStripSeparator
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_sequenceMenu辅助线Separator1",
                Size = _seperatorSize,
            };
            _sequenceMenu标题操作安全区域 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_sequenceMenu标题操作安全区域",
                Size = _menuItemSize,
                Text = "标题/操作安全区域"
            };
            _sequenceMenu辅助线图像框 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_sequenceMenu辅助线图像框",
                Size = _menuItemSize,
                Text = "辅助线图像框"
            };
            _sequenceMenu辅助线坐标轴 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_sequenceMenu辅助线坐标轴",
                Size = _menuItemSize,
                Text = "辅助线坐标轴"
            };

            _sequenceMenu.Items.AddRange(new ToolStripItem[]
            {
               _sequenceMenu显示模式,
               _sequenceMenuSeparator1,
               _sequenceMenu缩放,
               _sequenceMenu放大,
               _sequenceMenu缩小,
               _sequenceMenuSeparator2,
               _sequenceMenu通道,
               _sequenceMenu输出图像,
               _sequenceMenuSeparator3,
               _sequenceMenu方形像素显示,
               _sequenceMenu显示棋盘格,
               _sequenceMenu显示素材信息,
               _sequenceMenu网格,
               _sequenceMenu辅助线
            });

            _sequenceMenu显示模式.DropDownItems.AddRange(new ToolStripItem[]
            {
                _sequenceMenu帧方式显示,
                _sequenceMenu显示第一场,
                _sequenceMenu显示第二场
            });

            _sequenceMenu缩放.DropDownItems.AddRange(new ToolStripItem[]
            {
               _sequenceMenu缩放适配,
                _sequenceMenu缩放25,
                _sequenceMenu缩放50,
                _sequenceMenu缩放100,
                _sequenceMenu缩放150,
                _sequenceMenu缩放200
            });

            _sequenceMenu通道.DropDownItems.AddRange(new ToolStripItem[]
            {
                _sequenceMenu通道RGBA,
                _sequenceMenu通道RGB,
                _sequenceMenu通道红色通道,
                _sequenceMenu通道绿色通道,
                _sequenceMenu通道蓝色通道,
                _sequenceMenu通道Alpha通道,
                _sequenceMenu通道亮度通道709,
                _sequenceMenu通道亮度通道601
            });

            _sequenceMenu辅助线.DropDownItems.AddRange(new ToolStripItem[]
            {
                _sequenceMenu辅助线显示辅助线,
                _sequenceMenu辅助线Separator1,
                _sequenceMenu标题操作安全区域,
                _sequenceMenu辅助线图像框,
                _sequenceMenu辅助线坐标轴
            });

            PanelEx_Sequence.ContextMenuStrip = _sequenceMenu;
        }

        /// <summary>
        /// 创建文件列表右键菜单
        /// </summary>
        private void CreateFileListMenu()
        {
            _fileListMenu = new ContextMenuStrip
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_fileListMenu",
                Size = _menuSize
            };

            _fileListMenu粘贴 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "粘贴",
                Size = _menuItemSize,
                Text = "粘贴"
            };

            _fileListMenu新建文件夹 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_fileListMenu新建文件夹",
                Size = _menuItemSize,
                Text = "新建文件夹"
            };

            _fileListMenu新建项 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_fileListMenu新建项",
                Size = _menuItemSize,
                Text = "新建项"
            };

            _fileListMenu创建字幕 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_fileListMenu创建字幕",
                Size = _menuItemSize,
                Text = "创建字幕"
            };

            _fileListMenu导入 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_fileListMenu导入",
                Size = _menuItemSize,
                Text = "导入"
            };

            _fileListMenu导入双目影像文件 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_fileListMenu导入双目影像文件",
                Size = _menuItemSize,
                Text = "导入双目影像文件"
            };

            _fileListMenu查找 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_fileListMenu查找",
                Size = _menuItemSize,
                Text = "查找"
            };

            _fileListMenu隐藏字幕模板文件夹 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_fileListMenu隐藏字幕模板文件夹",
                Size = _menuItemSize,
                Text = "隐藏字幕模板文件夹",

                CheckOnClick = true
            };

            _fileListMenu隐藏流程图库 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_fileListMenu隐藏流程图库",
                Size = _menuItemSize,
                Text = "隐藏流程图库",

                CheckOnClick = true
            };

            _fileListMenuSeparator1 = new ToolStripSeparator
            {
                BackColor = _menuColor,
                ForeColor = _menufontsColor,
                Name = "_fileListMenuSeparator1",
                Size = _seperatorSize,
            };

            _fileListMenu.Items.AddRange(new ToolStripItem[]
            {
                _fileListMenu粘贴,
                _fileListMenu新建文件夹,
                _fileListMenu新建项,
                _fileListMenu创建字幕,
                _fileListMenu导入,
                _fileListMenu导入双目影像文件,
                _fileListMenu查找,
                _fileListMenuSeparator1,
                _fileListMenu隐藏字幕模板文件夹,
                _fileListMenu隐藏流程图库
            });

            listView_Files.ContextMenuStrip = _fileListMenu;

        }

        #endregion


        #region 右键菜单事件处理

        /// <summary>
        /// 删除视频轨道空隙
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除空隙ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("删除空隙");
        }

        /// <summary>
        /// 删除轨道上的音视频或者字幕文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _vedioTrackFile删除_Click(object sender, EventArgs e)
        {
            try
            {
                // 1.首先得到是哪一个panel
                ToolStripMenuItem item = sender as ToolStripMenuItem;
                ContextMenuStrip menu = item.GetCurrentParent() as ContextMenuStrip;
                PanelEx panel = menu.SourceControl as PanelEx;

                // 2.删除此panel
                DeleteTrackFilePanel(panel);
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }
        }

        /// <summary>
        /// 删除一个文件面板
        /// </summary>
        /// <param name="panel"></param>
        private void DeleteTrackFilePanel(PanelEx panel)
        {
            panel.Tag = "";
            panel.Parent.Controls.Remove(panel);
        }

        #endregion 右键菜单事件处理




        #region 打包

        private void 分离ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void 编解码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void 打包ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void 测试ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void StartPacket()
        {
            Thread threadPacket = new Thread(PacketThread);
            threadPacket.Start();
        }

        public void PacketThread()
        {
            try
            {
                // UpdateVedioTrackFilesTimes();

                // UpdatePackageClips();

                // 1.音视频分离
                int res = packetIOCSharp.DemuxClips(packageClipsList);
                if (res < 0)
                {
                    MessageBox.Show("分离失败!");
                }

                // 2.初始化打包
                // 2.1.获取字幕
                GetZimuList();
                res = packetIOCSharp.PacketingInitial(ZimuList);
                if (res < 0)
                {
                    MessageBox.Show("打包初始化失败!");
                }

                // 3.开始打包
                res = packetIOCSharp.PacketStart();
                if (res < 0)
                {
                    MessageBox.Show("打包失败!");
                }

                // 4.等待打包结束
                while (!packetIOCSharp.PacketIsFinish())
                {
                    Thread.Sleep(1000);

                    dPacketProcess = packetIOCSharp.GetProgress();
                }

                // 5.混合
                string strPackedFile = theClipsPath + @"\C#生成_" + DateTime.Now.ToString("yyyy.M.d_hh-mm-ss") + ".mp4";
                res = packetIOCSharp.MuxerStart(strPackedFile);
                if (res < 0)
                {
                    MessageBox.Show("混合失败!");
                }

                //5 waiting muxed finished
                while (!packetIOCSharp.MuxerIsFinish())
                {
                    Thread.Sleep(1000);
                }

                // 6.叠加字幕
                //GetZimuList();
                //res = packetIOCSharp.MixZimu(ZimuList);
                //if (res < 0)
                //{
                //    MessageBox.Show("字幕叠加失败!");
                //}

                bPakcetFinish = true;
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }

        }

















        #endregion 打包


        // end line
    }


}