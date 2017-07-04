
using System.Windows.Forms;

namespace NonLinearEditSystem.Forms
{
    public partial class ImportP2Form : DevComponents.DotNetBar.Metro.MetroForm
    {
        // 缩略图
        public static readonly object[] MiniPicObjects = { "小图标", "中等图标", "大图标" };

        public ImportP2Form()
        {
            InitializeComponent();
        }

        private void ImportP2Form_Load(object sender, System.EventArgs e)
        {
            InitComboBox();
            InitListView();
        }

        private void InitComboBox()
        {
            comboBoxEx_缩略图.Items.AddRange(MiniPicObjects);
            comboBoxEx_缩略图.SelectedIndex = 0;
        }

        private void InitListView()
        {
            string[] headStrings1 = new[]
            {
                "片段名", "逻辑关系", "硬盘名称", "P2卡序列号", "媒体长度", "视频格式",
                "编码格式", "视频比特率", "帧率", "图像宽高比", "数据大小",
                "音频格式", "采样率", "音频比特率", "音频通道", "创建日期"
            };

            string[] headStrings2 = new[]
            {
                "片段名", "片段长度", "创建日期", "编码格式", "文件路径", "逻辑关系",
                "音频通道", "帧率"
            };

            System.Windows.Forms.ColumnHeader[] columnHeaders1 = new System.Windows.Forms.ColumnHeader[16];
            System.Windows.Forms.ColumnHeader[] columnHeaders2 = new System.Windows.Forms.ColumnHeader[8];

            for (int i = 0; i < columnHeaders1.Length; i++)
            {
                columnHeaders1[i] = new ColumnHeader();
                columnHeaders1[i].Text = headStrings1[i];
                columnHeaders1[i].Width = 80;

            }

            for (int i = 0; i < columnHeaders2.Length; i++)
            {
                columnHeaders2[i] = new ColumnHeader();
                columnHeaders2[i].Text = headStrings2[i];
                columnHeaders2[i].Width = 80;
            }

            listViewEx1.Columns.AddRange(columnHeaders1);
            listViewEx2.Columns.AddRange(columnHeaders2);

        }

        private void groupBox1_Enter(object sender, System.EventArgs e)
        {

        }






        // end line
    }


}