
using System.Windows.Forms;

namespace NonLinearEditSystem.Forms
{
    public partial class ImportSxSForm : DevComponents.DotNetBar.Metro.MetroForm
    {
        // 缩略图
        public static readonly object[] MiniPicObjects = { "小图标", "中等图标", "大图标" };

        public ImportSxSForm()
        {
            InitializeComponent();
        }

        private void ImportSxSForm_Load(object sender, System.EventArgs e)
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
                "片段名", "格式", "视频类型", "音频类型", "帧率", "长度",
                "图像宽高比", "音频通道", "创建日期"
            };

            string[] headStrings2 = new[]
            {
                "片段名", "格式", "视频类型", "音频类型", "帧率", "长度",
                "图像宽高比", "音频通道", "创建日期", "文件路径"
            };

            System.Windows.Forms.ColumnHeader[] columnHeaders1 = new System.Windows.Forms.ColumnHeader[9];
            System.Windows.Forms.ColumnHeader[] columnHeaders2 = new System.Windows.Forms.ColumnHeader[10];

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







        // end line
    }


}