﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ClrInterfaceDll;
using Common;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using NonLinearEditSystem.Properties;
using XNetUtilities;

namespace NonLinearEditSystem.Forms
{
    public partial class MainForm : MetroForm
    {
        #region 成员变量

        // 数据库连接字符串
        private String _connectionString = "server=localhost;database=NonLinearEditSystem;uid=sa;pwd=123456;";

        // 视频播放接口类
        private IClipPlayControlCSharp _iClipPlayControlCSharp;

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

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitVedioAndAudioFilesPanel();

            InitPlayControl();

            ShowClipsInFileBox();
        }

        /// <summary>
        /// 初始化音视频轨道文件panel
        /// </summary>
        private void InitVedioAndAudioFilesPanel()
        {
            _vedioFilesPanel = new PanelEx[_maxFilesPannel];
            _audioFilesPanel = new PanelEx[_maxFilesPannel];

            for (int i = 0; i < _maxFilesPannel; i++)
            {
                _vedioFilesPanel[i] = new PanelEx();
                _audioFilesPanel[i] = new PanelEx();

                _vedioFilesPanel[i].CanvasColor = System.Drawing.SystemColors.Control;
                _vedioFilesPanel[i].ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
                _vedioFilesPanel[i].DisabledBackColor = System.Drawing.Color.Empty;
                _vedioFilesPanel[i].Location = new System.Drawing.Point(0, 0);
                _vedioFilesPanel[i].Size = new System.Drawing.Size(200, panelEx_VideoTrackConment1.Height);
                _vedioFilesPanel[i].Style.Alignment = System.Drawing.StringAlignment.Center;
                _vedioFilesPanel[i].Style.BackColor1.Color = System.Drawing.Color.SteelBlue;
                _vedioFilesPanel[i].Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
                _vedioFilesPanel[i].Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
                _vedioFilesPanel[i].Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
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
                _audioFilesPanel[i].ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
                _audioFilesPanel[i].DisabledBackColor = System.Drawing.Color.Empty;
                _audioFilesPanel[i].Location = new System.Drawing.Point(0, 0);
                _audioFilesPanel[i].Size = new System.Drawing.Size(200, panelEx_AudioTrackConment1.Height);
                _audioFilesPanel[i].Style.Alignment = System.Drawing.StringAlignment.Center;
                _audioFilesPanel[i].Style.BackColor1.Color = System.Drawing.Color.MediumAquamarine;
                _audioFilesPanel[i].Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
                _audioFilesPanel[i].Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
                _audioFilesPanel[i].Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
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

        /// <summary>
        /// 初始化视频播放组件
        /// </summary>
        private void InitPlayControl()
        {
            _iClipPlayControlCSharp = new IClipPlayControlCSharp();
        }

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
                using (SqlDataReader reader = SqlHelper.ExecuteReader(_connectionString, commandText, CommandType.Text, parameter))
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
        ///     去除完整路径,只留下文件名
        /// </summary>
        /// <param name="dirsAndFilePath"></param>
        private static string[] ClearDirAndFilePath(string[] dirsAndFilePath)
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

        /// <summary>
        ///     文件列表中选中项改变的时候,在上面label中同时更改描述
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_Files_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_Files.SelectedItems.Count > 0)
            {
                var sItemString = listView_Files.SelectedItems[0].Text;
                label_FileInfo.Text = sItemString;
            }
        }

        /// <summary>
        ///     双击播放视频
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_Files_DoubleClick(object sender, EventArgs e)
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
            timer_Segment.Start();

            IntPtr rendWnd = PanelEx_Sequence.Handle;
            int ires = _iClipPlayControlCSharp.SetClip(sFilePath, rendWnd);
            _iClipPlayControlCSharp.Play();
            timer_Sequence.Start();

            timeLineControl_Sequence.NNeedShowSeconds =
                (int)(_iClipPlayControlCSharp.GetDuration() * GeneralConversions.HT_TIME_TO_SECONDS);
            timeLineControl_Sequence.ThumbHPos = 0;
            timeLineControl_Sequence.Invalidate();
        }

        /// <summary>
        /// 序列监视器计时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Sequence_Tick(object sender, EventArgs e)
        {
            if (timeLineControl_Sequence.ThumbValue >= timeLineControl_Sequence.NNeedShowSeconds)
            {
                timer_Sequence.Stop();
                _iClipPlayControlCSharp.Stop();
            }
            else
            {
                timeLineControl_Sequence.ThumbHPos += timeLineControl_Sequence.IntervalEverySec;
                timeLineControl_Sequence.Invalidate();
            }
        }

        /// <summary>
        ///     片段监视器计时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Segment_Tick(object sender, EventArgs e)
        {
            //if (Segment_TrackBar.Value == Segment_TrackBar.Maximum)
            //{
            //    vlc_player.Stop();
            //    timer_Segment.Stop();
            //}
            //else
            //{
            //    ++Segment_TrackBar.Value;
            //}

            // LabelItem_CurrentTime显示当前时间
            // labelItem_CurrentTime.Text = DateTime.Now.ToString("HH:mm:ss:ff");
        }

        private void TrackName_BtnMouseHover(object sender, EventArgs e)
        {
            ((ButtonItem)sender).Icon = Resources.lock_closed_16px;
        }

        private void TrackName_BtnMouseLeave(object sender, EventArgs e)
        {
            ((ButtonItem)sender).Icon = Resources.lock_open_16px;
        }

        private void timeLineControl1_Click(object sender, EventArgs e)
        {
            var mouseEventArgs = (MouseEventArgs)e;
            label_FileInfo.Text = $@"X:{mouseEventArgs.X}, Y:{mouseEventArgs.Y}";
            labelItem_CurrentTime.Text =
                TimeLineControl.TimeLineControl.ChangeTimeValueToString((int)timeLineControl_MainTL.ThumbValue);
        }

        /// <summary>
        /// 序列监视器视频播放时候移动游标控制播放时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timeLineControl_Sequence_MouseMove(object sender, MouseEventArgs e)
        {
            if (timeLineControl_Sequence.Capture && e.Button == MouseButtons.Left)
            {
                // 等到游标位置时间，转换为100ns单位
                long rtPos = (long)(timeLineControl_Sequence.ThumbValue * GeneralConversions.SECONDS_TO_HT_TIME);

                // 如果视频处于某种状态，则播放
                if (_iClipPlayControlCSharp.GetCurState() == 0 || _iClipPlayControlCSharp.GetCurState() == 1)
                {
                    if (rtPos >= _iClipPlayControlCSharp.GetDuration())
                    {
                        _iClipPlayControlCSharp.SetPosition(0, 0);
                        timeLineControl_Sequence.ThumbHPos = 0;
                        timeLineControl_Sequence.Invalidate();
                    }
                    else
                    {
                        _iClipPlayControlCSharp.SetPosition(rtPos, 0);
                    }
                }
            }
        }


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

                string commandText = @"INSERT ClipsTable ([Name],[ClipsTypeID],[ClipsClassID],[UploaderID],[StartDate],[FileAllName]) 
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


        #region 文件拖动功能

        /// <summary>
        /// 从文件列表中将素材拖动出来
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_Files_ItemDrag(object sender, ItemDragEventArgs e)
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
                int length = 200;

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
            PanelEx panelExSelected = (PanelEx)sender;

            if (panelExSelected.Capture && e.Button == MouseButtons.Left)
            {
                panelExSelected.Location = new Point(e.X - _mousePosDelta, 0);
                panelExSelected.Invalidate();
            }
        }


        #endregion 文件拖动功能



    }
}