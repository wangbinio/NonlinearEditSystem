namespace NonLinearEditSystem.Forms
{
    public partial class PackageForm : DevComponents.DotNetBar.Metro.MetroForm
    {
        // 打包到位置
        public static readonly object[] PackToPos = {"硬盘", "浏览器"};

        // 预置
        public static readonly object[] Prefabs = {"HD @MP4(10MB)"};

        // 视频文件类型
        public static readonly object[] VedioFileTypes = { "MP4" };

        // 分辨率
        public static readonly object[] ResulotionTypes = {"HD 1920*1080"};

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
        public static readonly object[] AudiotractType = { "立体声", "单声道"};

        // 打包模式
        public static readonly object[] PackModes = { "全部", "区间" };


        public PackageForm()
        {
            InitializeComponent();
        }

        private void PackageForm_Load(object sender, System.EventArgs e)
        {
            InitComboBox();
        }

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



    }


}