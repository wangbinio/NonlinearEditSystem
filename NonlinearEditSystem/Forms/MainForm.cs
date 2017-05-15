using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        // 数据库连接字符串
        private String connectionString = "server=localhost;database=NonLinearEditSystem;uid=sa;pwd=123456;";

        // 视频播放接口类
        private IClipPlayControlCSharp _iClipPlayControlCSharp;

        private string[] _choosedDirFullPath;
        private string[] _choosedFileFullPath;

        public MainForm()
        {
            InitializeComponent();

            InitPlayControl();

        }

        /// <summary>
        /// 初始化视频播放组件
        /// </summary>
        private void InitPlayControl()
        {
            _iClipPlayControlCSharp = new IClipPlayControlCSharp();
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowClipsInFileBox();
            //ShowDirInFileBox(@"D:\");
        }

        // 将数据库的素材都显示到列表中
        private void ShowClipsInFileBox()
        {
            try
            {
                List<string> clipsNameList = new List<string>(10);
                List<string> clipsPathList = new List<string>(10);

                string commandText = "SELECT Name, FileAllName FROM ClipsTable";
                SqlParameter parameter = new SqlParameter("", SqlDbType.BigInt) { Value = 0 };
                using (SqlDataReader reader= SqlHelper.ExecuteReader(connectionString, commandText, CommandType.Text, parameter))
                {
                    while (reader.Read())
                    {
                        clipsNameList.Add(reader["Name"].ToString());
                        clipsPathList.Add(reader["FileAllName"].ToString());
                    }
                }

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


        #region 菜单

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

        private void 更新素材库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // 1.暂时将素材库目录设置为E:\\Clips
                // 2.获取目录底下的文件都存到数据库中
                // 3.先清空素材表
                string DeleteText = @"DELETE FROM ClipsTable";
                SqlParameter parameter = new SqlParameter("", SqlDbType.BigInt) { Value = 0 };
                int iRes = SqlHelper.ExecuteNonQuery(connectionString, DeleteText, CommandType.Text, parameter);
                iRes = 0;

                string commandText = @"INSERT ClipsTable ([Name],[ClipsTypeID],[ClipsClassID],[UploaderID],[StartDate],[FileAllName]) 
                                    VALUES (@Name, 1, 1, 1, @startDate, @FileAllName)";

                string[] ClipsPath = Directory.GetFiles("E:\\Clips", "*", SearchOption.AllDirectories);
                string[] filesName = ClearDirAndFilePath(ClipsPath);

                for (int i = 0; i < ClipsPath.Length; i++)
                {
                    SqlParameter[] paras = new SqlParameter[3];
                    paras[0] = new SqlParameter("@Name", SqlDbType.NVarChar) { Value = filesName[i] };
                    paras[1] = new SqlParameter("@StartDate", SqlDbType.DateTime) { Value = DateTime.Now };
                    paras[2] = new SqlParameter("@FileAllName", SqlDbType.NVarChar) { Value = ClipsPath[i] };

                    iRes += SqlHelper.ExecuteNonQuery(connectionString, commandText, CommandType.Text, paras);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }
        }


        #endregion 菜单


    }
}