using System.Drawing;
using System.Windows.Forms;

namespace NonLinearEditSystem.Forms
{
    public partial class PreferenceSetForm : DevComponents.DotNetBar.Metro.MetroForm
    {
        // 默认视频转场
        public static readonly object[] VedioChangeStyles = { "淡入淡出", "划像", "闪黑闪白", "卷页", "摆动", "旋转", "帘式", "翻转", "筋斗", "立方体旋转", "开关门", "推", "交换", "拆分", "中心拆分", "伸展进入", "镜头眩光", "散焦模糊" };

        // 默认音频转场
        public static readonly object[] AudioChangeStyles = { "并存式淡入淡出", "对半式淡入淡出", "底部交叉式淡入淡出", "线性交叉式淡入淡出", "对数交叉式淡入淡出" };

        // 上下变换模式
        public static readonly object[] UpDownChangeStyles = { "信封模式", "裁剪模式", "拉伸模式" };

        // 自动保存时间间隔
        public static readonly object[] AutoSaveTime = { "1分钟", "5分钟", "10分钟", "20分钟", "30分钟", "1小时", "2小时", "5小时", };

        // 色彩深度
        public static readonly object[] ColorDepth = { "8比特", "16比特", "32比特" };

        // 图像宽高比
        public static readonly object[] PicRatios = { "1:1", "4:3", "16:9", "16:10" };

        // 视图模式
        public static readonly object[] ViewStyles = { "单目", "双目" };

        // 主音频输出个数
        public static readonly object[] OutPutAudios = { "1", "2", "4" };

        // LUT位深度
        public static readonly object[] LUTDepth = { "自动", "8比特", "16比特", "32比特" };




        public PreferenceSetForm()
        {
            InitializeComponent();
        }

        private void PreferenceSetForm_Load(object sender, System.EventArgs e)
        {
            // 初始化工程默认设置
            InitProjDefaultSet();

            // 初始化视频默认设置
            InitVedioDefaultSet();

            // 初始化音频默认设置
            InitAudioDefaultSet();

            // 初始化网格设置
            InitGridSet();

            // 初始化LUT设置
            InitLUT();
        }

        /// <summary>
        /// 初始化工程默认设置
        /// </summary>
        private void InitProjDefaultSet()
        {
            comboBoxEx_默认视频转场.Items.AddRange(VedioChangeStyles);
            comboBoxEx_默认音频转场.Items.AddRange(AudioChangeStyles);
            comboBoxEx_上下变换模式.Items.AddRange(UpDownChangeStyles);
            comboBoxEx_自动保存时间间隔.Items.AddRange(AutoSaveTime);

            comboBoxEx_默认视频转场.SelectedIndex = 0;
            comboBoxEx_默认音频转场.SelectedIndex = 3;
            comboBoxEx_上下变换模式.SelectedIndex = 0;
            comboBoxEx_自动保存时间间隔.SelectedIndex = 2;

        }

        /// <summary>
        /// 初始化视频默认设置
        /// </summary>
        private void InitVedioDefaultSet()
        {
            comboBoxEx_视频总模式.Items.Add("单目 HD(1920*1080)@50i");
            comboBoxEx_视频总模式.SelectedIndex = 0;

            comboBoxEx_帧率.Items.Add("25 fps");
            comboBoxEx_帧率.SelectedIndex = 0;

            comboBoxEx_Resolution.Items.Add("1920*1080");
            comboBoxEx_Resolution.SelectedIndex = 0;

            comboBoxEx_ScanMode.Items.Add("上场优先");
            comboBoxEx_ScanMode.SelectedIndex = 0;

            comboBoxEx_ColorDepth.Items.AddRange(ColorDepth);
            comboBoxEx_ColorDepth.SelectedIndex = 0;

            comboBoxEx_PixelRatio.Items.Add("1:1");
            comboBoxEx_PixelRatio.SelectedIndex = 0;

            comboBoxEx_PicRatio.Items.AddRange(PicRatios);
            comboBoxEx_PicRatio.SelectedIndex = 2;

            comboBoxEx_解交织.Items.Add("解交织");
            comboBoxEx_解交织.SelectedIndex = 0;

            comboBoxEx_ViewStyle.Items.AddRange(ViewStyles);
            comboBoxEx_ViewStyle.SelectedIndex = 0;
        }

        /// <summary>
        /// 初始化音频默认设置
        /// </summary>
        private void InitAudioDefaultSet()
        {
            comboBoxEx_主音频输出个数.Items.AddRange(OutPutAudios);
            comboBoxEx_主音频输出个数.SelectedIndex = 1;
        }

        /// <summary>
        /// 初始化网格设置
        /// </summary>
        private void InitGridSet()
        {
            colorPickerButton1.SelectedColor = Color.Green;
            colorPickerButton2.SelectedColor = Color.White;
        }

        /// <summary>
        /// 初始化LUT设置
        /// </summary>
        private void InitLUT()
        {
            comboBoxEx_DefalutLUT.Items.Add("无LUT");
            comboBoxEx_LUTBitDepth.Items.AddRange(LUTDepth);
            comboBoxEx_CurrentLUT.Items.Add("无LUT");

            comboBoxEx_DefalutLUT.SelectedIndex = 0;
            comboBoxEx_LUTBitDepth.SelectedIndex = 0;
            comboBoxEx_CurrentLUT.SelectedIndex = 0;
        }


        /// <summary>
        /// 设置缓存位置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonX_CacheScan_Click(object sender, System.EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.SelectedPath = textBoxX_CachePath.Text;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBoxX_CachePath.Text = dialog.SelectedPath;
            }
        }

        /// <summary>
        /// 模版库位置设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonX_TemplateScan_Click(object sender, System.EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.SelectedPath = textBoxX_Template.Text;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBoxX_Template.Text = dialog.SelectedPath;
            }
        }



        private void buttonX_PreferSetOK_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void buttonX_PreferSetCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }



    }
}