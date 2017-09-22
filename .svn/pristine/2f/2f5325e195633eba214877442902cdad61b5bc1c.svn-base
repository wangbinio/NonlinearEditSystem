namespace NonLinearEditSystem.Forms
{
    public partial class ProjectSetForm : DevComponents.DotNetBar.Metro.MetroForm
    {

        /*
        // 帧率
        public static readonly object[] FpsObjects = { "25fps", "30fps", "60fps" };

        // 扫描模式
        public static readonly object[] ScanModes = { "上场优先", "帧" };

        // 采样位
        public static readonly object[] SamplingBit = { "8比特", "16比特", "32比特" };

        // 采样频率
        public static readonly object[] SamplingHz = { "48kHz"};

        // 声道
        public static readonly object[] AudiotractType = { "立体声", "左声道", "右声道" };

        // 主音频输出个数
        public static readonly object[] OutPutAudios = { "1", "2", "4" };
        */

        public ProjectSetForm()
        {
            InitializeComponent();
        }

        private void ProjectSetForm_Load(object sender, System.EventArgs e)
        {
            InitComboBox();
        }

        /// <summary>
        /// 初始化数据
        /// </summary>
        private void InitComboBox()
        {
            comboBoxEx_帧率.Items.AddRange(CreateProjectSetForm.FpsObjects);
            comboBoxEx_扫描模式.Items.AddRange(CreateProjectSetForm.ScanModes);
            comboBoxEx_采样频率.Items.AddRange(CreateProjectSetForm.SamplingHz);
            comboBoxEx_采样位.Items.AddRange(CreateProjectSetForm.SamplingBit);
            comboBoxEx_声道.Items.AddRange(CreateProjectSetForm.AudiotractType);
            comboBoxEx_输出音频流.Items.AddRange(CreateProjectSetForm.OutPutAudios);

            comboBoxEx_帧率.SelectedIndex = 0;
            comboBoxEx_扫描模式.SelectedIndex = 0;
            comboBoxEx_采样频率.SelectedIndex = 0;
            comboBoxEx_采样位.SelectedIndex = 2;
            comboBoxEx_声道.SelectedIndex = 0;
            comboBoxEx_输出音频流.SelectedIndex = 1;
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