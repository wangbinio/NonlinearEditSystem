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

        // 工程文件信息
        private ProjectInfo projectInfo;

        // 数据库连接字符串
        private String _connectionString = "server=localhost;database=NonLinearEditSystem;uid=sa;pwd=123456;";

        // 视频播放接口类
        private ClipPlayControlCSharp _iClipPlayControlCSharp;

        // 音视频分离类
        private Mp4DemuxIOCSharp _mp4DemuxIOCSharp;

        // 编解码类
        private H264CodecIOCSharp _h264CodecIOCSharp;

        // 打包类
        private Mp4FilesMuxIOCSharp _mp4FilesMuxIOCSharp;

        // 文件列表中选择的目录
        private string[] _choosedDirFullPath;

        // 文件列表中选择的文件
        private string[] _choosedFileFullPath;

        // 视频轨道上的视频文件
        private PanelEx[] _vedioFilesPanel;

        // 音频轨道上的音频文件
        private PanelEx[] _audioFilesPanel;

        // 轨道上文件个数
        private int _maxFilesPannel = 10;

        // 鼠标拖动音/视频文件panel时保存位置差
        private int _mousePosDelta = 0;

        // 音视频文件在轨道上的面板高度
        public static int trackHeight = 34;

        // 视频轨道面板1234
        private List<PanelEx> _vedioTrackPanels;

        // 音频轨道面板12
        private List<PanelEx> _audioTrackPanels;

        #endregion 成员变量


        #region 控件变量

        public string TimelineCurrentTime => labelItem_CurrentTime.Text;

        #endregion


        #region 初始化工作

        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            projectInfo = new ProjectInfo();

            ExecuteBat();

            InitAllChildForm();

            InitVedioAndAudioTrackPanels();

            InitVedioAndAudioFilePanels();

            InitPlayControl();

            InitTimeLineControl();

            // TODO:现在显示的是数据库的内容,
            //ShowClipsInFileBox();

            // 测试版本显示本地文件夹的内容
            ShowDirInFileBox(@"D:\视频素材");


            // 创建所有右键菜单
            CreateAllMenu();
        }

        private void ExecuteBat()
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
        }

        /// <summary>
        /// 初始化音视频轨道文件panel
        /// </summary>
        private void InitVedioAndAudioFilePanels()
        {
            try
            {
                // 初始化音视频文件panel
                _vedioFilesPanel = new PanelEx[_maxFilesPannel];
                _audioFilesPanel = new PanelEx[_maxFilesPannel];

                for (int i = 0; i < _maxFilesPannel; i++)
                {
                    _vedioFilesPanel[i] = new PanelEx();
                    _audioFilesPanel[i] = new PanelEx();

                    _vedioFilesPanel[i].CanvasColor = System.Drawing.SystemColors.Control;
                    _vedioFilesPanel[i].ColorSchemeStyle =
                        DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
                    _vedioFilesPanel[i].DisabledBackColor = System.Drawing.Color.Empty;
                    _vedioFilesPanel[i].Location = new System.Drawing.Point(0, 0);
                    _vedioFilesPanel[i].Size = new System.Drawing.Size(200, panelEx_VideoTrackConment1.Height);
                    _vedioFilesPanel[i].Style.Alignment = System.Drawing.StringAlignment.Center;
                    _vedioFilesPanel[i].Style.BackColor1.Color = System.Drawing.Color.SkyBlue;
                    _vedioFilesPanel[i].Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
                    _vedioFilesPanel[i].Style.BorderColor.ColorSchemePart =
                        DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
                    _vedioFilesPanel[i].Style.ForeColor.ColorSchemePart =
                        DevComponents.DotNetBar.eColorSchemePart.PanelText;
                    _vedioFilesPanel[i].Style.GradientAngle = 90;
                    _vedioFilesPanel[i].StyleMouseDown.Alignment = System.Drawing.StringAlignment.Center;
                    _vedioFilesPanel[i].StyleMouseDown.BackColor1.Alpha = ((byte)(128));
                    _vedioFilesPanel[i].StyleMouseDown.BackColor1.Color = System.Drawing.Color.SkyBlue;
                    _vedioFilesPanel[i].StyleMouseOver.Alignment = System.Drawing.StringAlignment.Center;
                    _vedioFilesPanel[i].StyleMouseOver.BackColor1.Alpha = ((byte)(128));
                    _vedioFilesPanel[i].StyleMouseOver.BackColor1.Color = System.Drawing.Color.DodgerBlue;
                    _vedioFilesPanel[i].TabIndex = 0;
                    _vedioFilesPanel[i].Name = "VideoFile" + i;
                    _vedioFilesPanel[i].Text = "VideoFile" + i;
                    _vedioFilesPanel[i].Tag = "";
                    _vedioFilesPanel[i].MouseDown += new System.Windows.Forms.MouseEventHandler(this.VideoFile_MouseDown);
                    _vedioFilesPanel[i].MouseMove += new System.Windows.Forms.MouseEventHandler(this.VideoFile_MouseMove);

                    _audioFilesPanel[i].CanvasColor = System.Drawing.SystemColors.Control;
                    _audioFilesPanel[i].ColorSchemeStyle =
                        DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
                    _audioFilesPanel[i].DisabledBackColor = System.Drawing.Color.Empty;
                    _audioFilesPanel[i].Location = new System.Drawing.Point(0, 0);
                    _audioFilesPanel[i].Size = new System.Drawing.Size(200, panelEx_AudioTrackConment1.Height);
                    _audioFilesPanel[i].Style.Alignment = System.Drawing.StringAlignment.Center;
                    _audioFilesPanel[i].Style.BackColor1.Color = System.Drawing.Color.MediumAquamarine;
                    _audioFilesPanel[i].Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
                    _audioFilesPanel[i].Style.BorderColor.ColorSchemePart =
                        DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
                    _audioFilesPanel[i].Style.ForeColor.ColorSchemePart =
                        DevComponents.DotNetBar.eColorSchemePart.PanelText;
                    _audioFilesPanel[i].Style.GradientAngle = 90;
                    _audioFilesPanel[i].StyleMouseDown.Alignment = System.Drawing.StringAlignment.Center;
                    _audioFilesPanel[i].StyleMouseDown.BackColor1.Alpha = ((byte)(128));
                    _audioFilesPanel[i].StyleMouseDown.BackColor1.Color = System.Drawing.Color.MediumAquamarine;
                    _audioFilesPanel[i].StyleMouseOver.Alignment = System.Drawing.StringAlignment.Center;
                    _audioFilesPanel[i].StyleMouseOver.BackColor1.Alpha = ((byte)(128));
                    _audioFilesPanel[i].StyleMouseOver.BackColor1.Color = System.Drawing.Color.MediumAquamarine;
                    _audioFilesPanel[i].TabIndex = 0;
                    _audioFilesPanel[i].Name = "AudioFile" + i;
                    _audioFilesPanel[i].Text = "AudioFile" + i;
                    _audioFilesPanel[i].Tag = "";
                    _audioFilesPanel[i].MouseDown += new System.Windows.Forms.MouseEventHandler(this.VideoFile_MouseDown);
                    _audioFilesPanel[i].MouseMove += new System.Windows.Forms.MouseEventHandler(this.VideoFile_MouseMove);
                }

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

                _mp4DemuxIOCSharp = new Mp4DemuxIOCSharp();

                _h264CodecIOCSharp = new H264CodecIOCSharp();

                _mp4FilesMuxIOCSharp = new Mp4FilesMuxIOCSharp();
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

            UpdateLabelTime();
        }

        #endregion 初始化工作


        #region 辅助函数

        /// <summary>
        ///     去除完整路径,只留下文件名
        /// </summary>
        /// <param name="dirsAndFilePath"></param>
        private static string[] ClearDirAndFilePath(string[] dirsAndFilePath)
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
                _iClipPlayControlCSharp.SetClip(fileName, PanelEx_Sequence.Handle);
                double duirationTime = _iClipPlayControlCSharp.GetDuration() * GeneralConversions.NanoSecToSec;

                int length =
                    (int)(duirationTime /
                    timeLineControl_MainTL.SecondsEveryTicks[timeLineControl_MainTL.IndexOfSecEveryTicks] *
                    timeLineControl_MainTL.NDistanceOfTicks);


                // 3.0.计算位置信息
                Point mousePoint = ((PanelEx)sender).PointToClient(new Point(e.X, e.Y));

                // 3.根据文件信息初始化一个panel
                int vedioFilePanelIndex = CreateVedioOrAudioFilePanel(fileName, duirationTime, length, mousePoint.X);
                if (vedioFilePanelIndex == -1) return;

                // 4.将此panel添加到sender上
                ((PanelEx)sender).Controls.Add(_vedioFilesPanel[vedioFilePanelIndex]);

                // 5.更新所有轨道面板的长度
                UpdateTrackWidthWhenAddFile(length);

                //((PanelEx) sender).Invalidate();
                // 6.更新需要显示的帧
                UpdateShowFrame();
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
        private int CreateVedioOrAudioFilePanel(string fileName, double duriation, int length, int pos, bool bVedio = true)
        {
            try
            {
                if (bVedio)
                {
                    // 找到_VediPFilesPanel中尚未初始化的一个panel
                    for (int i = 0; i < _vedioFilesPanel.Length; i++)
                    {
                        if ((string)_vedioFilesPanel[i].Tag == "")
                        {
                            _vedioFilesPanel[i].Name = fileName;

                            // 处理一下fileName,Text只显示文件名和持续时间,不显示路径
                            string duriationStr = TimeLineControl.TimeLineControl.ChangeTimeValueToString((int)duriation);
                            string[] fileStrings = new string[1];
                            fileStrings[0] = fileName;
                            string[] tempStrings = ClearDirAndFilePath(fileStrings);

                            _vedioFilesPanel[i].Text = tempStrings[0] + " (" + duriationStr + ")";
                            _vedioFilesPanel[i].Width = length;
                            _vedioFilesPanel[i].Height = trackHeight;
                            _vedioFilesPanel[i].Location = new System.Drawing.Point(pos, 0);

                            // 使用tag来存储开始结束位置在时间线的时间
                            double dStartTime = timeLineControl_MainTL.GetTimeValueByPos(pos);
                            double dEndTime = dStartTime + duriation;

                            string objStr = dStartTime + "-" + dEndTime;

                            _vedioFilesPanel[i].Tag = objStr;

                            return i;
                        }
                    }
                }
                else
                {
                    // 找到_AudioFilesPanel中尚未初始化的一个panel
                    for (int i = 0; i < _audioFilesPanel.Length; i++)
                    {
                        if ((string)_audioFilesPanel[i].Tag == "")
                        {
                            _audioFilesPanel[i].Name = fileName;

                            // 处理一下fileName,Text只显示文件名和持续时间,不显示路径
                            string duriationStr = TimeLineControl.TimeLineControl.ChangeTimeValueToString((int)duriation);
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

                            string objStr = dStartTime + "-" + dEndTime;

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
        {//TODO:将音频拖到轨道上
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
        }




        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = createProjectSetForm.ShowDialog();

            projectInfo = createProjectSetForm.projectInfo;
        }

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
        /// 打开选中的工程
        /// </summary>
        private void OpenNewProject(string fileName)
        {
            try
            {
                projectInfo.Load(fileName);
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveProject();
        }

        /// <summary>
        /// 保存工程文件
        /// </summary>
        private void SaveProject()
        {
            projectInfo.Save();
        }

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
            PackageForm packageForm = new PackageForm();
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
                    UploadClipsInFolder(dialog.SelectedPath);

                    // 2.刷新文件列表
                    ShowClipsInFileBox();
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
            string strTime = TimeLineControl.TimeLineControl.ChangeTimeValueToString((int)timeLineControl_MainTL.ThumbValue);
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
            UpdateLabelTime();

            UpdateShowFrame();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timeLineControl_MainTL_MouseMove(object sender, MouseEventArgs e)
        {
            UpdateLabelTime();

            if (timeLineControl_MainTL._chooseThumb)
            {
                UpdateShowFrame();
            }
        }

        #endregion 主时间线操作


        #region 视频轨道操作

        /// <summary>
        /// 在音视频轨道上拖动文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VideoFile_MouseDown(object sender, MouseEventArgs e)
        {
            PanelEx panelExSelected = (PanelEx)sender;

            if (e.Button == MouseButtons.Left)
            {
                panelExSelected.Capture = true;
                _mousePosDelta = e.X - panelExSelected.Location.X;
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
                PanelEx panelExSelected = (PanelEx)sender;

                if (panelExSelected.Capture && e.Button == MouseButtons.Left)
                {
                    panelExSelected.Location = new Point(e.X - _mousePosDelta > 0 ? e.X - _mousePosDelta : 0, 0);

                    // 使用tag来存储开始结束位置在时间线的时间
                    double dStartTime = timeLineControl_MainTL.GetTimeValueByPos(panelExSelected.Location.X);
                    double dEndTime = timeLineControl_MainTL.GetTimeValueByPos(panelExSelected.Location.X + panelExSelected.Width);

                    string objStr = dStartTime + "-" + dEndTime;

                    panelExSelected.Tag = objStr;

                    panelExSelected.Invalidate();

                    UpdateShowFrame();
                }
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
                    ratio = (double)timeLineControl_MainTL.SecondsEveryTicks[timeLineControl_MainTL.IndexOfSecEveryTicks + 1] /
                        timeLineControl_MainTL.SecondsEveryTicks[timeLineControl_MainTL.IndexOfSecEveryTicks];
                }
                else// 如果是缩小
                {
                    // 1.先求缩小的比例
                    ratio = (double)timeLineControl_MainTL.SecondsEveryTicks[timeLineControl_MainTL.IndexOfSecEveryTicks - 1] /
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

                    int startX = timeLineControl_MainTL.GetPosByTimeValue(double.Parse(startAndEndTime[0]));
                    int endX = timeLineControl_MainTL.GetPosByTimeValue(double.Parse(startAndEndTime[1]));
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


                    int startX = timeLineControl_MainTL.GetPosByTimeValue(double.Parse(startAndEndTime[0]));
                    int endX = timeLineControl_MainTL.GetPosByTimeValue(double.Parse(startAndEndTime[1]));
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

                // 4.将文件显示到文件列表中
                for (var i = 0; i < filesNames.Length; i++)
                {
                    var item = new ListViewItem(filesNames[i]);
                    item.ImageIndex = 1;
                    var sSepStrs = filesNames[i].Split('.');
                    var sFileType = sSepStrs[sSepStrs.Length - 1];
                    item.SubItems.Add(sFileType);
                    item.SubItems.Add(_choosedFileFullPath[i]);
                    listView_Files.Items.Add(item);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                    label_FileInfo.Text = sItemString;
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
            /*
            try
            {
                // 如果播放到最后一秒，则停止播放
                if (slider_SeqTime.Value == slider_SeqTime.Maximum)
                {
                    slider_SeqTime.Value = 0;
                    timer_Sequence.Stop();
                    _iClipPlayControlCSharp.Stop();
                }
                else
                {
                    slider_SeqTime.Value++;
                }

                // 更新labelX_SeqTime显示时间
                labelX_SeqTime.Text = TimeLineControl.TimeLineControl.ChangeTimeValueToString(slider_SeqTime.Value);
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }
            */
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
        /// 更新序列监视面板需要显示的帧
        /// </summary>
        private void UpdateShowFrame()
        {
            try
            {
                foreach (PanelEx vedioTrackPanel in _vedioTrackPanels)
                {
                    foreach (Control control in vedioTrackPanel.Controls)
                    {
                        PanelEx panel = control as PanelEx;
                        if (panel == null) continue;

                        if (IsNeededShowPanel(panel))
                        {
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }
        }


        private bool IsNeededShowPanel(PanelEx panel)
        {
            try
            {
                // 1.先取得每个panel在时间线上的起始时间和终止时间
                string objStr = panel.Tag as string;
                if (objStr == null) return false;
                string[] startAndEndTime = objStr.Split('-');
                if (startAndEndTime.Length < 2) return false;

                // 如果时间线的游标时间处于两者之间,则说明此panel是处于可显示状态
                if (timeLineControl_MainTL.ThumbValue > double.Parse(startAndEndTime[0])
                    && timeLineControl_MainTL.ThumbValue < double.Parse(startAndEndTime[1]))
                {
                    double playTime = timeLineControl_MainTL.ThumbValue - double.Parse(startAndEndTime[0]);
                    ShowThisPanelFrame(panel.Name, (long)(playTime * GeneralConversions.SecToNanoSec));
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

        private void TrackName_BtnMouseHover(object sender, EventArgs e)
        {
            ((ButtonItem)sender).Icon = Resources.lock_closed_16px;
        }

        private void TrackName_BtnMouseLeave(object sender, EventArgs e)
        {
            ((ButtonItem)sender).Icon = Resources.lock_open_16px;
        }

        #endregion 视频轨道名称面板操作


        #region 音频轨道名称面板操作

        #endregion 音频轨道名称面板操作


        #region 时间线快捷按钮点击事件

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
                timeLineControl_MainTL.enterPos = timeLineControl_MainTL.ThumbHPos;
                timeLineControl_Sequence.enterPos = timeLineControl_Sequence.ThumbHPos;

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
                timeLineControl_MainTL.exitPos = timeLineControl_MainTL.ThumbHPos;
                timeLineControl_Sequence.exitPos = timeLineControl_Sequence.ThumbHPos;

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





        #endregion


        #region 创建右键菜单
        public static Size _menuSize = new Size(125, 148);
        public static Size _menuItemSize = new Size(124, 22);
        public static Size _seperatorSize = new Size(121, 6);
        public static Color _menuColor = Color.FromArgb(239, 239, 242);

        private void CreateAllMenu()
        {
            CreateTrackBlankMenu();

            CreateTrackFileMenu();

            CreateTimelineMenu();

            CreatesequenceMenu();
        }

        /// <summary>
        /// 创建轨道空白右键菜单
        /// </summary>
        private void CreateTrackBlankMenu()
        {
            _trackBlankMenu = new ContextMenuStrip
            {
                BackColor = _menuColor,
                Name = "_trackBlankMenu",
                Size = _menuSize
            };

            _trackBlank删除空隙 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_删除空隙MenuItem",
                Size = _menuItemSize,
                Text = "删除空隙"
            };
            _trackBlank删除空隙.Click += 删除空隙ToolStripMenuItem_Click;

            _trackBlank粘贴空隙 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_粘贴空隙MenuItem",
                Size = _menuItemSize,
                Text = "粘贴空隙"
            };

            _trackBlank粘贴 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_粘贴MenuItem",
                Size = _menuItemSize,
                Text = "粘贴"
            };

            _trackBlankSeparator1 = new ToolStripSeparator
            {
                BackColor = _menuColor,
                ForeColor = _menuColor,
                Name = "_trackBlankSeparator1",
                Size = _seperatorSize,
            };

            _trackBlank当前轨道中插入工作区 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_当前轨道中插入工作区MenuItem",
                Size = _menuItemSize,
                Text = "当前轨道中插入工作区"
            };

            _trackBlank删除当前轨道工作区 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_删除当前轨道工作区MenuItem",
                Size = _menuItemSize,
                Text = "删除当前轨道工作区"
            };

            _trackBlank清除当前轨道工作区 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
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
                Name = "_vedioTrackFileMenu",
                Size = _menuSize
            };

            _vedioTrackFile打开片段 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_vedioTrackFile打开片段",
                Size = _menuItemSize,
                Text = "打开片段"
            };
            _vedioTrackFile剪切 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_vedioTrackFile剪切",
                Size = _menuItemSize,
                Text = "剪切"
            };
            _vedioTrackFile复制 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_vedioTrackFile复制",
                Size = _menuItemSize,
                Text = "复制"
            };
            _vedioTrackFile删除 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_vedioTrackFile删除",
                Size = _menuItemSize,
                Text = "删除"
            };
            _vedioTrackFile独立删除 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_vedioTrackFile独立删除",
                Size = _menuItemSize,
                Text = "独立删除"
            };
            _vedioTrackFile涟漪删除 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_vedioTrackFile涟漪删除",
                Size = _menuItemSize,
                Text = "涟漪删除"
            };
            _vedioTrackFile片段静音 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_vedioTrackFile片段静音",
                Size = _menuItemSize,
                Text = "片段静音",

                CheckOnClick = true
            };
            _vedioTrackFileSeparator1 = new ToolStripSeparator
            {
                BackColor = _menuColor,
                Name = "_vedioTrackFileSeparator1",
                Size = _seperatorSize,
            };

            _vedioTrackFile在片段监视器上加载原始片段 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_vedioTrackFile在片段监视器上加载原始片段",
                Size = _menuItemSize,
                Text = "在片段监视器上加载原始片段"
            };
            _vedioTrackFile在工程浏览器中查找片段 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_vedioTrackFile在工程浏览器中查找片段",
                Size = _menuItemSize,
                Text = "在工程浏览器中查找片段"
            };
            _vedioTrackFile保存模版 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_vedioTrackFile保存模版",
                Size = _menuItemSize,
                Text = "保存模版"
            };
            _vedioTrackFile复制特技 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_vedioTrackFile复制特技",
                Size = _menuItemSize,
                Text = "复制特技"
            };
            _vedioTrackFile复制属性特技 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_vedioTrackFile复制属性特技",
                Size = _menuItemSize,
                Text = "复制属性特技"
            };
            _vedioTrackFile粘贴特技 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_vedioTrackFile粘贴特技",
                Size = _menuItemSize,
                Text = "粘贴特技"
            };
            _vedioTrackFile删除特技 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_vedioTrackFile删除特技",
                Size = _menuItemSize,
                Text = "删除特技"
            };
            _vedioTrackFileSeparator2 = new ToolStripSeparator
            {
                BackColor = _menuColor,
                Name = "_vedioTrackFileSeparator2",
                Size = _seperatorSize,
            };

            _vedioTrackFile轨道内移动 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_vedioTrackFile轨道内移动",
                Size = _menuItemSize,
                Text = "轨道内移动"
            };
            _vedioTrackFile向左平移一帧 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_vedioTrackFile向左平移一帧",
                Size = _menuItemSize,
                Text = "向左平移一帧"
            };
            _vedioTrackFile向左平移五帧 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_vedioTrackFile向左平移五帧",
                Size = _menuItemSize,
                Text = "向左平移五帧"
            };
            _vedioTrackFile向右平移一帧 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_vedioTrackFile向右平移一帧",
                Size = _menuItemSize,
                Text = "向右平移一帧"
            };
            _vedioTrackFile向右平移五帧 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_vedioTrackFile向右平移五帧",
                Size = _menuItemSize,
                Text = "向右平移五帧"
            };
            _vedioTrackFile向左平移指定时间长度 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_vedioTrackFile向左平移指定时间长度",
                Size = _menuItemSize,
                Text = "向左平移指定时间长度"
            };
            _vedioTrackFile向右平移指定时间长度 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_vedioTrackFile向右平移指定时间长度",
                Size = _menuItemSize,
                Text = "向右平移指定时间长度"
            };
            _vedioTrackFile平移片段入点至上一个片段出点 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_vedioTrackFile平移片段入点至上一个片段出点",
                Size = _menuItemSize,
                Text = "平移片段入点至上一个片段出点"
            };
            _vedioTrackFile平移片段出点至上一个片段入点 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_vedioTrackFile平移片段出点至上一个片段入点",
                Size = _menuItemSize,
                Text = "平移片段出点至上一个片段入点"
            };

            _vedioTrackFile移到时码线处 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_vedioTrackFile移到时码线处",
                Size = _menuItemSize,
                Text = "移到时码线处"
            };
            _vedioTrackFile平移片段入点至时码线处 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_vedioTrackFile平移片段入点至时码线处",
                Size = _menuItemSize,
                Text = "平移片段入点至时码线处"
            };
            _vedioTrackFile平移片段出点至时码线处 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_vedioTrackFile平移片段出点至时码线处",
                Size = _menuItemSize,
                Text = "平移片段出点至时码线处"
            };
            _vedioTrackFile平移片段之后至时码线处 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_vedioTrackFile平移片段之后至时码线处",
                Size = _menuItemSize,
                Text = "平移片段之后至时码线处"
            };
            _vedioTrackFile平移片段之前至时码线处 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_vedioTrackFile平移片段之前至时码线处",
                Size = _menuItemSize,
                Text = "平移片段之前至时码线处"
            };

            _vedioTrackFileSeparator3 = new ToolStripSeparator
            {
                BackColor = _menuColor,
                Name = "_vedioTrackFileSeparator3",
                Size = _seperatorSize,
            };
            _vedioTrackFile片段编组 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_vedioTrackFile片段编组",
                Size = _menuItemSize,
                Text = "片段编组"
            };
            _vedioTrackFile解组 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_vedioTrackFile解组",
                Size = _menuItemSize,
                Text = "解组"
            };
            _vedioTrackFile素材互换 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_vedioTrackFile素材互换",
                Size = _menuItemSize,
                Text = "素材互换"
            };

            _vedioTrackFile联动控制 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_vedioTrackFile联动控制",
                Size = _menuItemSize,
                Text = "联动控制"
            };
            _vedioTrackFile视音频联动 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_vedioTrackFile视音频联动",
                Size = _menuItemSize,
                Text = "视音频联动"
            };
            _vedioTrackFile音频联动 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_vedioTrackFile音频联动",
                Size = _menuItemSize,
                Text = "音频联动"
            };
            _vedioTrackFile独立 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_vedioTrackFile独立",
                Size = _menuItemSize,
                Text = "独立"
            };

            _vedioTrackFileSeparator4 = new ToolStripSeparator
            {
                BackColor = _menuColor,
                Name = "_vedioTrackFileSeparator4",
                Size = _seperatorSize,
            };
            _vedioTrackFile自动上下变换 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
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
                Name = "_mainTimeLineMenu",
                Size = _menuSize
            };
            _mainTimeLineMenu添加标记点 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_mainTimeLineMenu添加标记点",
                Size = _menuItemSize,
                Text = "添加标记点"
            };
            _mainTimeLineMenu注释标记点 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_mainTimeLineMenu注释标记点",
                Size = _menuItemSize,
                Text = "注释标记点"
            };
            _mainTimeLineMenu删除标记点 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_mainTimeLineMenu删除标记点",
                Size = _menuItemSize,
                Text = "删除标记点"
            };
            _mainTimeLineMenu删除所有标记点 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_mainTimeLineMenu删除所有标记点",
                Size = _menuItemSize,
                Text = "删除所有标记点"
            };
            _mainTimeLineMenu上一个标记点 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_mainTimeLineMenu上一个标记点",
                Size = _menuItemSize,
                Text = "上一个标记点"
            };
            _mainTimeLineMenu下一个标记点 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_mainTimeLineMenu下一个标记点",
                Size = _menuItemSize,
                Text = "下一个标记点"
            };
            _mainTimeLineMenu标记点管理 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_mainTimeLineMenu标记点管理",
                Size = _menuItemSize,
                Text = "标记点管理"
            };
            _mainTimeLineMenuSeparator1 = new ToolStripSeparator
            {
                BackColor = _menuColor,
                ForeColor = _menuColor,
                Name = "_mainTimeLineMenuSeparator1",
                Size = _seperatorSize,
            };

            _mainTimeLineMenu设置工作区入点 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_mainTimeLineMenu设置工作区入点",
                Size = _menuItemSize,
                Text = "设置工作区入点"
            };
            _mainTimeLineMenu设置工作区出点 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_mainTimeLineMenu设置工作区出点",
                Size = _menuItemSize,
                Text = "设置工作区出点"
            };
            _mainTimeLineMenu移至工作区入点 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_mainTimeLineMenu移至工作区入点",
                Size = _menuItemSize,
                Text = "移至工作区入点"
            };
            _mainTimeLineMenu移至工作区出点 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_mainTimeLineMenu移至工作区出点",
                Size = _menuItemSize,
                Text = "移至工作区出点"
            };
            _mainTimeLineMenuSeparator2 = new ToolStripSeparator
            {
                BackColor = _menuColor,
                ForeColor = _menuColor,
                Name = "_mainTimeLineMenuSeparator2",
                Size = _seperatorSize,
            };

            _mainTimeLineMenu设置序列入出点 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_mainTimeLineMenu设置序列入出点",
                Size = _menuItemSize,
                Text = "设置序列入出点"
            };
            _mainTimeLineMenu加入批打包列表 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_mainTimeLineMenu加入批打包列表",
                Size = _menuItemSize,
                Text = "加入批打包列表"
            };
            _mainTimeLineMenu查看批打包列表 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_mainTimeLineMenu查看批打包列表",
                Size = _menuItemSize,
                Text = "查看批打包列表"
            };
            _mainTimeLineMenu清除批打包列表 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_mainTimeLineMenu清除批打包列表",
                Size = _menuItemSize,
                Text = "清除批打包列表"
            };
            _mainTimeLineMenu时间标尺精度 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_mainTimeLineMenu时间标尺精度",
                Size = _menuItemSize,
                Text = "时间标尺精度"
            };
            _mainTimeLineMenuSeparator3 = new ToolStripSeparator
            {
                BackColor = _menuColor,
                ForeColor = _menuColor,
                Name = "_mainTimeLineMenuSeparator3",
                Size = _seperatorSize,
            };

            _mainTimeLineMenu所有轨道插入工作区 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_mainTimeLineMenu所有轨道插入工作区",
                Size = _menuItemSize,
                Text = "所有轨道插入工作区"
            };
            _mainTimeLineMenu删除工作区中所有片段 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_mainTimeLineMenu删除工作区中所有片段",
                Size = _menuItemSize,
                Text = "删除工作区中所有片段"
            };
            _mainTimeLineMenu清除工作区中所有片段 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_mainTimeLineMenu清除工作区中所有片段",
                Size = _menuItemSize,
                Text = "清除工作区中所有片段"
            };
            _mainTimeLineMenu复制工作区中片段 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_mainTimeLineMenu复制工作区中片段",
                Size = _menuItemSize,
                Text = "复制工作区中片段"
            };
            _mainTimeLineMenu粘贴工作区至时码线 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_mainTimeLineMenu粘贴工作区至时码线",
                Size = _menuItemSize,
                Text = "粘贴工作区至时码线"
            };
            _mainTimeLineMenuSeparator4 = new ToolStripSeparator
            {
                BackColor = _menuColor,
                ForeColor = _menuColor,
                Name = "_mainTimeLineMenuSeparator4",
                Size = _seperatorSize,
            };

            _mainTimeLineMenu黑场检测 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_mainTimeLineMenu黑场检测",
                Size = _menuItemSize,
                Text = "黑场检测"
            };
            _mainTimeLineMenu质量检测 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
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
                Name = "_sequenceMenu",
                Size = _menuSize
            };
            _sequenceMenu显示模式 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_sequenceMenu显示模式",
                Size = _menuItemSize,
                Text = "显示模式"
            };
            _sequenceMenu帧方式显示 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_sequenceMenu帧方式显示",
                Size = _menuItemSize,
                Text = "帧方式显示"
            };
            _sequenceMenu显示第一场 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_sequenceMenu显示第一场",
                Size = _menuItemSize,
                Text = "显示第一场"
            };
            _sequenceMenu显示第二场 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_sequenceMenu显示第二场",
                Size = _menuItemSize,
                Text = "显示第二场"
            };
            _sequenceMenuSeparator1 = new ToolStripSeparator
            {
                //BackColor = _menuColor,
                //ForeColor = _menuColor,
                Name = "_sequenceMenuSeparator1",
                Size = _seperatorSize,
            };

            _sequenceMenu缩放 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_sequenceMenu缩放",
                Size = _menuItemSize,
                Text = "缩放"
            };
            _sequenceMenu缩放适配 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_sequenceMenu缩放适配",
                Size = _menuItemSize,
                Text = "适配"
            };
            _sequenceMenu缩放25 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_sequenceMenu缩放25",
                Size = _menuItemSize,
                Text = "25%"
            };
            _sequenceMenu缩放50 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_sequenceMenu缩放50",
                Size = _menuItemSize,
                Text = "50%"
            };
            _sequenceMenu缩放100 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_sequenceMenu缩放100",
                Size = _menuItemSize,
                Text = "100%"
            };
            _sequenceMenu缩放150 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_sequenceMenu缩放150",
                Size = _menuItemSize,
                Text = "150%"
            };
            _sequenceMenu缩放200 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_sequenceMenu缩放200",
                Size = _menuItemSize,
                Text = "200%"
            };
            _sequenceMenu放大 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_sequenceMenu放大",
                Size = _menuItemSize,
                Text = "放大"
            };
            _sequenceMenu缩小 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_sequenceMenu缩小",
                Size = _menuItemSize,
                Text = "缩小"
            };
            _sequenceMenuSeparator2 = new ToolStripSeparator
            {
                //BackColor = _menuColor,
                //ForeColor = _menuColor,
                Name = "_sequenceMenuSeparator2",
                Size = _seperatorSize,
            };

            _sequenceMenu通道 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_sequenceMenu通道",
                Size = _menuItemSize,
                Text = "通道"
            };
            _sequenceMenu通道RGBA = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_sequenceMenu通道RGBA",
                Size = _menuItemSize,
                Text = "RGBA"
            };
            _sequenceMenu通道RGB = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_sequenceMenu通道RGB",
                Size = _menuItemSize,
                Text = "RGB"
            };
            _sequenceMenu通道红色通道 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_sequenceMenu通道红色通道",
                Size = _menuItemSize,
                Text = "红色通道"
            };
            _sequenceMenu通道绿色通道 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_sequenceMenu通道绿色通道",
                Size = _menuItemSize,
                Text = "绿色通道"
            };
            _sequenceMenu通道蓝色通道 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_sequenceMenu通道蓝色通道",
                Size = _menuItemSize,
                Text = "蓝色通道"
            };
            _sequenceMenu通道Alpha通道 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_sequenceMenu通道Alpha通道",
                Size = _menuItemSize,
                Text = "Alpha通道"
            };
            _sequenceMenu通道亮度通道709 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_sequenceMenu通道亮度通道709",
                Size = _menuItemSize,
                Text = "亮度通道(709)"
            };
            _sequenceMenu通道亮度通道601 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_sequenceMenu通道亮度通道601",
                Size = _menuItemSize,
                Text = "亮度通道(601)"
            };
            _sequenceMenu输出图像 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_sequenceMenu输出图像",
                Size = _menuItemSize,
                Text = "输出图像"
            };
            _sequenceMenuSeparator3 = new ToolStripSeparator
            {
                //BackColor = _menuColor,
                //ForeColor = _menuColor,
                Name = "_sequenceMenuSeparator3",
                Size = _seperatorSize,
            };

            _sequenceMenu方形像素显示 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_sequenceMenu方形像素显示",
                Size = _menuItemSize,
                Text = "方形像素显示"
            };
            _sequenceMenu显示棋盘格 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_sequenceMenu显示棋盘格",
                Size = _menuItemSize,
                Text = "显示棋盘格"
            };
            _sequenceMenu显示素材信息 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_sequenceMenu显示素材信息",
                Size = _menuItemSize,
                Text = "显示素材信息"
            };
            _sequenceMenu网格 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_sequenceMenu网格",
                Size = _menuItemSize,
                Text = "网格"
            };
            _sequenceMenu辅助线 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_sequenceMenu辅助线",
                Size = _menuItemSize,
                Text = "辅助线"
            };
            _sequenceMenu辅助线显示辅助线 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_sequenceMenu辅助线显示辅助线",
                Size = _menuItemSize,
                Text = "显示辅助线"
            };
            _sequenceMenu辅助线Separator1 = new ToolStripSeparator
            {
                BackColor = _menuColor,
                ForeColor = _menuColor,
                Name = "_sequenceMenu辅助线Separator1",
                Size = _seperatorSize,
            };
            _sequenceMenu标题操作安全区域 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_sequenceMenu标题操作安全区域",
                Size = _menuItemSize,
                Text = "标题/操作安全区域"
            };
            _sequenceMenu辅助线图像框 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
                Name = "_sequenceMenu辅助线图像框",
                Size = _menuItemSize,
                Text = "辅助线图像框"
            };
            _sequenceMenu辅助线坐标轴 = new ToolStripMenuItem
            {
                BackColor = _menuColor,
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

        #endregion


        #region 右键菜单事件处理

        private void 删除空隙ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("删除空隙");
        }


        #endregion




        #region TestCode

        string strDemuxVideoFile = string.Empty;
        string strDemuxAudioFile = string.Empty;

        string strOutH264FileName = string.Empty;
        string strOutAacFileName = string.Empty;

        private void 分离ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = @"D:\视频素材";
                openFileDialog.Filter = "mp4 files (*.mp4)|*.mp4| All Files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filename = openFileDialog.FileName;

                    int res = _mp4DemuxIOCSharp.AddClip(ref strDemuxVideoFile, ref strDemuxAudioFile, filename, 0, 0);

                    if (res >= 0)
                    {
                        MessageBox.Show("分离成功");
                    }
                    else
                    {
                        MessageBox.Show("分离失败");
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }
        }

        private void 编解码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //int Start(System::Collections::Generic::List < String ^> strInH264VideoFileList, String ^ strOutH264FileName);
                //int StartAACDecEncoder(System::Collections::Generic::List < String ^> strInAacFileList, String ^ strOutAacFileName);

                //List<String> strInH264VideoFileList = new List<String>(10);
                //List<String> strInAacFileList = new List<String>(10);

                StringList strInH264VideoFileList = new StringList();
                StringList strInAacFileList = new StringList(); ;

                strInH264VideoFileList.Add(strDemuxVideoFile);
                strInAacFileList.Add(strDemuxAudioFile);

                int resVedio = _h264CodecIOCSharp.Start(strInH264VideoFileList, ref strOutH264FileName);
                int resAudio = _h264CodecIOCSharp.StartAACDecEncoder(strInAacFileList, ref strOutAacFileName);

                while (true)
                {
                    if (_h264CodecIOCSharp.isFinish())
                    {
                        break;
                    }
                    else
                    {
                        Thread.Sleep(1000);
                    }
                }

                if (resVedio >= 0 && resAudio >= 0)
                {
                    MessageBox.Show("编解码成功");
                }
                else
                {
                    MessageBox.Show("编解码失败");
                }
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }

        }

        private void 打包ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // int StartMuxer(StringList ^ strInH264FileList, String ^% stroutput_filename);

                StringList strInH264FileList = new StringList();
                //strInH264FileList.Add(strOutH264FileName);
                //strInH264FileList.Add(strOutAacFileName);
                strInH264FileList.Add(strDemuxVideoFile);
                strInH264FileList.Add(strDemuxAudioFile);

                string strPackedFile = @"D:\视频素材\C#生成_" + DateTime.Now.ToString("yyyy.M.d_hh-mm-ss") + ".mp4";
                int res = _mp4FilesMuxIOCSharp.StartMuxer(strInH264FileList, strPackedFile);

                while (true)
                {
                    if (_mp4FilesMuxIOCSharp.MuxerFinished())
                    {
                        break;
                    }
                    else
                    {
                        Thread.Sleep(1000);
                    }
                }

                if (res >= 0)
                {
                    MessageBox.Show("打包成功");
                }
                else
                {
                    MessageBox.Show("打包失败");
                }
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }
        }

        private void 测试ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = @"D:\视频素材";
                openFileDialog.Filter = "mp4 files (*.mp4)|*.mp4| All Files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filename = openFileDialog.FileName;

                    int res = _mp4DemuxIOCSharp.AddClip(ref strDemuxVideoFile, ref strDemuxAudioFile, filename, 0, 0);

                    if (res >= 0)
                    {
                        StringList strInH264VideoFileList = new StringList();
                        StringList strInAacFileList = new StringList(); ;

                        strInH264VideoFileList.Add(strDemuxVideoFile);
                        strInAacFileList.Add(strDemuxAudioFile);

                        int resVedio = _h264CodecIOCSharp.Start(strInH264VideoFileList, ref strOutH264FileName);
                        int resAudio = _h264CodecIOCSharp.StartAACDecEncoder(strInAacFileList, ref strOutAacFileName);

                        while (true)
                        {
                            if (_h264CodecIOCSharp.isFinish())
                            {
                                break;
                            }
                            else
                            {
                                Thread.Sleep(1000);
                            }
                        }

                        if (resVedio >= 0 && resAudio >= 0)
                        {
                            StringList strInH264FileList = new StringList();
                            //strInH264FileList.Add(strOutH264FileName);
                            //strInH264FileList.Add(strOutAacFileName);
                            strInH264FileList.Add(strDemuxVideoFile);
                            strInH264FileList.Add(strDemuxAudioFile);

                            string strPackedFile = @"D:\视频素材\C#生成_" + DateTime.Now.ToString("yyyy.M.d_hh-mm-ss") + ".mp4";
                            int PackRes = _mp4FilesMuxIOCSharp.StartMuxer(strInH264FileList, strPackedFile);

                            while (true)
                            {
                                if (_mp4FilesMuxIOCSharp.MuxerFinished())
                                {
                                    break;
                                }
                                else
                                {
                                    Thread.Sleep(1000);
                                }
                            }

                            if (PackRes >= 0)
                            {
                                if (MessageBox.Show("打包成功") == DialogResult.OK)
                                {
                                    Close();
                                }

                            }
                            else
                            {
                                MessageBox.Show("打包失败");
                            }
                        }
                        else
                        {
                            MessageBox.Show("编解码失败");
                        }
                    }
                    else
                    {
                        MessageBox.Show("分离失败");
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }
        }











        #endregion


        // end line
    }


}