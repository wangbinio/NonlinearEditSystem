using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using Common;
using System.Drawing;

namespace NonLinearEditSystem.Forms
{
    public partial class CreateProjectSetForm : DevComponents.DotNetBar.Metro.MetroForm
    {
        // 背景颜色
        public static Color bkgColor = MainForm.bkgColor;

        // 字体颜色
        public static Color fontsColor = MainForm.fontsColor;

        // 帧率
        public static readonly object[] FpsObjects = { "25fps", "30fps", "60fps" };

        // 扫描模式
        public static readonly object[] ScanModes = { "上场优先", "帧" };

        // 解交织
        public static readonly object[] DeInterleave = { "解交织" };

        // 采样位
        public static readonly object[] SamplingBit = { "8比特", "16比特", "32比特" };

        // 采样频率
        public static readonly object[] SamplingHz = { "48kHz" };

        // 声道
        public static readonly object[] AudiotractType = { "立体声", "左声道", "右声道" };

        // 主音频输出个数
        public static readonly object[] OutPutAudios = { "1", "2", "4" };

        /// <summary>
        /// 新建工程的时候 工程文件
        /// </summary>
        public ProjectInfo projectInfo = new ProjectInfo();

        public CreateProjectSetForm()
        {
            InitializeComponent();
        }

        private void buttonX_PreferSetCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 窗口加载,初始化属性
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateProjectSetForm_Load(object sender, EventArgs e)
        {
            InitComboBox();
        }

        /// <summary>
        /// 初始化数据
        /// </summary>
        private void InitComboBox()
        {
            comboBoxEx_帧率.Items.AddRange(FpsObjects);
            comboBoxEx_扫描模式.Items.AddRange(ScanModes);
            comboBoxEx_采样频率.Items.AddRange(SamplingHz);
            comboBoxEx_采样位.Items.AddRange(SamplingBit);
            comboBoxEx_声道.Items.AddRange(AudiotractType);
            comboBoxEx_输出音频流.Items.AddRange(OutPutAudios);
            comboBoxEx_解交织.Items.AddRange(DeInterleave);

            comboBoxEx_帧率.BackColor = bkgColor;
            comboBoxEx_扫描模式.BackColor = bkgColor;
            comboBoxEx_采样频率.BackColor = bkgColor;
            comboBoxEx_采样位.BackColor = bkgColor;
            comboBoxEx_声道.BackColor = bkgColor;
            comboBoxEx_输出音频流.BackColor = bkgColor;
            comboBoxEx_解交织.BackColor = bkgColor;

            comboBoxEx_帧率.SelectedIndex = 0;
            comboBoxEx_扫描模式.SelectedIndex = 0;
            comboBoxEx_采样频率.SelectedIndex = 0;
            comboBoxEx_采样位.SelectedIndex = 2;
            comboBoxEx_声道.SelectedIndex = 0;
            comboBoxEx_输出音频流.SelectedIndex = 1;
            comboBoxEx_解交织.SelectedIndex = 0;

            textBoxX_ProjFileName.BackColor = bkgColor;
            textBoxX_ProjFilePath.BackColor = bkgColor;
        }

        /// <summary>
        /// 浏览新建工程路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonX_CreateProjScan_Click(object sender, EventArgs e)
        {
            string defaultPath = textBoxX_ProjFilePath.Text;

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.SelectedPath = defaultPath;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBoxX_ProjFilePath.Text = dialog.SelectedPath;
            }
        }

        /// <summary>
        /// 新建工程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonX_CreateProjOK_Click(object sender, EventArgs e)
        {
            try
            {
                // projectInfo.ProjectVersion = Application.ProductVersion;
                projectInfo.ProjectPath = textBoxX_ProjFilePath.Text;
                projectInfo.ProjectName = textBoxX_ProjFileName.Text;
                string projectFullPath = projectInfo.ProjectPath + @"\" + projectInfo.ProjectName;

                if (!Directory.Exists(projectInfo.ProjectPath))
                {
                    MessageBox.Show("工程文件路径不存在请重新选择!");
                    return;
                }

                if (File.Exists(projectFullPath))
                {
                    if (MessageBox.Show("同名工程已存在，是否覆盖？", "确认覆盖文件", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    {
                        return;
                    }
                }


                projectInfo.Save();

                ;
            }
            catch (Exception ex)
            {
            	ExceptionHandle.ExceptionHdl(ex);
            }
            
        }
    }
}