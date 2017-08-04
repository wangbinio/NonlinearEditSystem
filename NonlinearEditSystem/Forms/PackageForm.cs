
using System;
using System.Windows.Forms;
using Common;
using NonLinearEditSystem;
using NonLinearEditSystem.Forms;

namespace NonLinearEditSystem.Forms
{
    public partial class PackageForm : DevComponents.DotNetBar.Metro.MetroForm
    {
        // 打包到位置
        public static readonly object[] PackToPos = { "硬盘", "浏览器" };

        // 预置
        public static readonly object[] Prefabs = { "HD @MP4(10MB)" };

        // 视频文件类型
        public static readonly object[] VedioFileTypes = { "MP4" };

        // 分辨率
        public static readonly object[] ResulotionTypes = { "HD 1920*1080" };

        // 压缩格式
        public static readonly object[] CompressModes = { "AVC" };

        // 位深度
        public static readonly object[] BitDepth = { "8" };

        // 音频文件类型
        public static readonly object[] AudioFileTypes = { "AAC" };

        // 采样格式
        public static readonly object[] SamplingFormat = { "AAC" };

        // 采样频率
        public static readonly object[] SamplingHz = { "48.00kHz", "44.1kHz", "32kHz" };

        // 比特率
        public static readonly object[] Kbps = { "128kbps", "192kbps", "256kbps", "320kbps" };

        // 采样位
        public static readonly object[] SamplingBit = { "8比特", "16比特", "32比特" };

        // 声道
        public static readonly object[] AudiotractType = { "立体声", "单声道" };

        // 打包模式
        public static readonly object[] PackModes = { "全部", "区间" };

        // 主窗口
        public MainForm theMainForm;

        // 选择了区间还是全部
        public bool bChooseInterval = false;


        public PackageForm()
        {
            InitializeComponent();

            InitComboBox();
            InitColor();
        }

        private void PackageForm_Load(object sender, System.EventArgs e)
        {
            progressBarX_Pack.Value = 0;
            progressBarX_Pack.Text = "0%";

            theMainForm = Owner as MainForm;

            if (theMainForm != null)
            {
                GetPackageClips(bChooseInterval);
            }
        }

        private void InitColor()
        {
            textBoxX_FilePath.BackColor = MainForm.bkgColor;
            textBoxX_FileName.BackColor = MainForm.bkgColor;
            textBoxX_Compress.BackColor = MainForm.bkgColor;
            textBoxX_输出音频流.BackColor = MainForm.bkgColor;
            listView_Files.BackColor = MainForm.bkgColor;
        }

        /// <summary>
        /// 初始化COmboBox
        /// </summary>
        private void InitComboBox()
        {
            comboBoxEx_PackTo.Items.AddRange(PackToPos);
            comboBoxEx_PackTo.SelectedIndex = 0;

            comboBoxEx_Prefab.Items.AddRange(Prefabs);
            comboBoxEx_Prefab.SelectedIndex = 0;

            comboBoxEx_FileType.Items.AddRange(VedioFileTypes);
            comboBoxEx_FileType.SelectedIndex = 0;

            comboBoxEx_Resolution.Items.AddRange(ResulotionTypes);
            comboBoxEx_Resolution.SelectedIndex = 0;

            comboBoxEx_BitDepth.Items.AddRange(BitDepth);
            comboBoxEx_BitDepth.SelectedIndex = 0;

            comboBoxEx_AudioFileType.Items.AddRange(AudioFileTypes);
            comboBoxEx_AudioFileType.SelectedIndex = 0;

            comboBoxEx_采样格式.Items.AddRange(SamplingFormat);
            comboBoxEx_采样格式.SelectedIndex = 0;

            comboBoxEx_采样频率.Items.AddRange(SamplingHz);
            comboBoxEx_采样频率.SelectedIndex = 1;

            comboBoxEx_比特率.Items.AddRange(Kbps);
            comboBoxEx_比特率.SelectedIndex = 0;

            comboBoxEx_采样位.Items.AddRange(SamplingBit);
            comboBoxEx_采样位.SelectedIndex = 1;

            comboBoxEx_通道类型.Items.AddRange(AudiotractType);
            comboBoxEx_通道类型.SelectedIndex = 0;

            comboBoxEx_打包模式.Items.AddRange(PackModes);
            comboBoxEx_打包模式.SelectedIndex = 0;

        }

        /// <summary>
        /// 获取主界面素材列表,并更新本身label上的时间显示
        /// </summary>
        /// <param name="bInterval">是否是选择区间</param>
        private void GetPackageClips(bool bInterval)
        {
            try
            {
                if (theMainForm != null)
                {
                    theMainForm.UpdateVedioTrackFilesTimes(bInterval);
                    if (theMainForm.sortedVedioTimes.Count > 1)
                    {
                        labelX_EntrePoint.Text = TimeLineControl.TimeLineControl.ChangeTimeValueToString((int)theMainForm.sortedVedioTimes[0]);
                        labelX_ExitPoint.Text = TimeLineControl.TimeLineControl.ChangeTimeValueToString((int)theMainForm.sortedVedioTimes[theMainForm.sortedVedioTimes.Count - 1]);
                    }
                }

            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }

        }

        /// <summary>
        /// 开始打包
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonX_StartPack_Click(object sender, System.EventArgs e)
        {
            try
            {
                // 删除打包残留文件
                //theMainForm.ExecuteBat();

                theMainForm.UpdatePackageClips(bChooseInterval);
                theMainForm.StartPacket();
                timerPacket.Start();
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }

        }

        /// <summary>
        /// 计时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerPacket_Tick(object sender, System.EventArgs e)
        {
            try
            {
                // 让开始按钮不能再次点击
                buttonX_StartPack.Enabled = false;

                double dProcess = theMainForm.dPacketProcess;

                progressBarX_Pack.Value = (int)(dProcess * 100);

                progressBarX_Pack.Text = progressBarX_Pack.Value.ToString() + "%";

                if (theMainForm.bPakcetFinish)
                {
                    progressBarX_Pack.Value = 100;

                    progressBarX_Pack.Text = "100%";

                    timerPacket.Stop();

                    MessageBox.Show("打包完成!");

                    // 打包完成之后重置进度条
                    progressBarX_Pack.Value = 0;

                    progressBarX_Pack.Text = "0%";

                    // 打包一次完成之后要将标记置为否
                    theMainForm.bPakcetFinish = false;

                    // 让开始按钮能再次点击
                    buttonX_StartPack.Enabled = true;

                    // 删除打包残留文件
                    theMainForm.ExecuteBat();
                }
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }

        }

        /// <summary>
        /// 改变打包模式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxEx_打包模式_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            try
            {
                ComboBox packageMode = sender as ComboBox;

                // "全部"
                if (packageMode.SelectedIndex == 0)
                {
                    bChooseInterval = false;
                    GetPackageClips(false);
                }
                // "区间"
                else if (packageMode.SelectedIndex == 1)
                {
                    bChooseInterval = true;
                    GetPackageClips(true);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }
        }

        /// <summary>
        /// 停止打包
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonX_StopPack_Click(object sender, EventArgs e)
        {
            try
            {
                theMainForm.packetIOCSharp.StopDemux();
                theMainForm.packetIOCSharp.PacketStop();
                theMainForm.packetIOCSharp.MuxerStop();

                theMainForm.ExecuteBat();

                buttonX_StartPack.Enabled = true;
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }
        }

        /// <summary>
        /// 丢弃打包文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonX_DelPack_Click(object sender, EventArgs e)
        {
            try
            {
                theMainForm.packetIOCSharp.StopDemux();
                theMainForm.packetIOCSharp.PacketStop();
                theMainForm.packetIOCSharp.MuxerStop();

                theMainForm.ExecuteBat();

                buttonX_StartPack.Enabled = true;
            }
            catch (Exception ex)
            {
                ExceptionHandle.ExceptionHdl(ex);
            }
        }
    }


}