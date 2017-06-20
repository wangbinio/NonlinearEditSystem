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

namespace NonLinearEditSystem.Forms
{
    public partial class MainForm : MetroForm
    {
        #region 成员变量

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

        #endregion 成员变量

        #region 初始化工作

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //panelEx_TrackContent.AutoScroll = true;
            //panelEx_TrackContent.HorizontalScroll.Visible = true;
            //panelEx_TrackContent.VerticalScroll.Visible = true;
            //panelEx_TrackContent.HScrollBar.Visible = true;
            //panelEx_TrackContent.HScrollBar.Enabled = true;

            ExecuteBat();

            InitVedioAndAudioFilesPanel();

            InitPlayControl();

            InitTimeLineControl();

            ShowClipsInFileBox();
        }

        private void ExecuteBat()
        {
            Process proc = new Process();
            proc.StartInfo.FileName = @".\del.bat";
            proc.StartInfo.CreateNoWindow = false;
            proc.Start();
            proc.WaitForExit();
        }

        /// <summary>
        /// 初始化音视频轨道文件panel
        /// </summary>
        private void InitVedioAndAudioFilesPanel()
        {
            try
            {
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
                    _vedioFilesPanel[i].Style.BackColor1.Color = System.Drawing.Color.SteelBlue;
                    _vedioFilesPanel[i].Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
                    _vedioFilesPanel[i].Style.BorderColor.ColorSchemePart =
                        DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
                    _vedioFilesPanel[i].Style.ForeColor.ColorSchemePart =
                        DevComponents.DotNetBar.eColorSchemePart.PanelText;
                    _vedioFilesPanel[i].Style.GradientAngle = 90;
                    _vedioFilesPanel[i].StyleMouseDown.Alignment = System.Drawing.StringAlignment.Center;
                    _vedioFilesPanel[i].StyleMouseDown.BackColor1.Alpha = ((byte)(128));
                    _vedioFilesPanel[i].StyleMouseDown.BackColor1.Color = System.Drawing.Color.DodgerBlue;
                    _vedioFilesPanel[i].StyleMouseOver.Alignment = System.Drawing.StringAlignment.Center;
                    _vedioFilesPanel[i].StyleMouseOver.BackColor1.Alpha = ((byte)(128));
                    _vedioFilesPanel[i].StyleMouseOver.BackColor1.Color = System.Drawing.Color.DodgerBlue;
                    _vedioFilesPanel[i].TabIndex = 0;
                    _vedioFilesPanel[i].Name = "VideoFile" + i;
                    _vedioFilesPanel[i].Text = "VideoFile" + i;
                    _vedioFilesPanel[i].Tag = 0;
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
                    _audioFilesPanel[i].Tag = 0;
                    _audioFilesPanel[i].MouseDown += new System.Windows.Forms.MouseEventHandler(this.VideoFile_MouseDown);
                    _audioFilesPanel[i].MouseMove += new System.Windows.Forms.MouseEventHandler(this.VideoFile_MouseMove);
                }
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

        private void InitTimeLineControl()
        {
            timeLineControl_MainTL.SetRelativeControl(timeLineControl_Sequence);
            timeLineControl_Sequence.SetRelativeControl(timeLineControl_MainTL);

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

                // 2.读取此文件的信息TODO:
                _iClipPlayControlCSharp.SetClip(fileName, PanelEx_Sequence.Handle);
                double duirationTime = _iClipPlayControlCSharp.GetDuration() * GeneralConversions.NanoSecToSec;

                int length =
                    (int)duirationTime /
                    timeLineControl_MainTL.SecondsEveryTicks[timeLineControl_MainTL.IndexOfSecEveryTicks] *
                    timeLineControl_MainTL.NDistanceOfTicks;


                // 3.0.计算位置信息
                Point mousePoint = ((PanelEx)sender).PointToClient(new Point(e.X, e.Y));

                // 3.根据文件信息初始化一个panel
                int vedioFilePanelIndex = CreateVedioOrAudioFilePanel(fileName, length, mousePoint.X);
                if (vedioFilePanelIndex == -1) return;

                // 4.将此panel添加到sender上
                ((PanelEx)sender).Controls.Add(_vedioFilesPanel[vedioFilePanelIndex]);
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
        private int CreateVedioOrAudioFilePanel(string fileName, int length, int pos, bool bVedio = true)
        {
            try
            {
                if (bVedio)
                {
                    // 找到_VediPFilesPanel中尚未初始化的一个panel
                    for (int i = 0; i < _vedioFilesPanel.Length; i++)
                    {
                        if ((int)_vedioFilesPanel[i].Tag == 0)
                        {
                            _vedioFilesPanel[i].Tag = 1;
                            _vedioFilesPanel[i].Name = fileName;
                            _vedioFilesPanel[i].Text = fileName;
                            _vedioFilesPanel[i].Width = length;
                            _vedioFilesPanel[i].Location = new System.Drawing.Point(pos, 0);

                            return i;
                        }
                    }
                }
                else
                {
                    // 找到_AudioFilesPanel中尚未初始化的一个panel
                    for (int i = 0; i < _audioFilesPanel.Length; i++)
                    {
                        if ((int)_audioFilesPanel[i].Tag == 0)
                        {
                            _audioFilesPanel[i].Tag = 1;
                            _audioFilesPanel[i].Name = fileName;
                            _audioFilesPanel[i].Text = fileName;
                            _audioFilesPanel[i].Width = length;
                            _audioFilesPanel[i].Location = new System.Drawing.Point(pos, 0);

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
            try
            {
                // 1.得到拖拽文件的文件名（全路径）
                string fileName = e.Data.GetData(DataFormats.FileDrop, true) as string;

                // 2.读取此文件的信息TODO:
                int length = 200;

                // 3.0.计算位置信息
                Point mousePoint = ((PanelEx)sender).PointToClient(new Point(e.X, e.Y));

                // 3.根据文件信息初始化一个panel
                int audioFilePanelIndex = CreateVedioOrAudioFilePanel(fileName, length, mousePoint.X, false);
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

        #region 菜单操作

        private void 偏好设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreferenceSetForm preferenceSetForm = new PreferenceSetForm();
            preferenceSetForm.ShowDialog();
        }

        private void 工程设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectSetForm projectSetForm = new ProjectSetForm();
            projectSetForm.ShowDialog();
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateProjectSetForm createProjectSetForm = new CreateProjectSetForm();
            createProjectSetForm.ShowDialog();
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

        private void 配音DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DubForm dubFrom = new DubForm();
            dubFrom.ShowDialog();
        }

        private void 打包输出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PackageForm packageForm = new PackageForm();
            packageForm.ShowDialog();
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
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                dialog.Description = "请选择工程文件夹";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ShowDirInFileBox(dialog.SelectedPath);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }
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
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timeLineControl_MainTL_MouseMove(object sender, MouseEventArgs e)
        {
            UpdateLabelTime();
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

        #endregion 视频轨道操作

        #region 音频轨道操作

        /// <summary>
        /// 在音视频轨道上拖动文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VideoFile_MouseMove(object sender, MouseEventArgs e)
        {
            PanelEx panelExSelected = (PanelEx)sender;

            if (panelExSelected.Capture && e.Button == MouseButtons.Left)
            {
                panelExSelected.Location = new Point(e.X - _mousePosDelta, 0);
                panelExSelected.Invalidate();
            }
        }

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
                slider_SeqTime.Maximum = clipDuration + 1;
                slider_SeqTime.Value = 0;
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
        }

        /// <summary>
        /// 移动序列监视器计时器slider游标的时候控制播放时间点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void slider_SeqTime_Scroll(object sender, ScrollEventArgs e)
        {
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



        private void panelEx_TrackContent_Scroll(object sender, ScrollEventArgs e)
        {
            //MessageBox.Show("Test");
            Rectangle rect = panelEx_TrackContent.ClientTextRectangle;

            Rectangle rect2 = rect;
        }

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
    }


}