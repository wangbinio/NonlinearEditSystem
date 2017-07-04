
using System.Windows.Forms;

namespace NonLinearEditSystem.Forms
{
    public partial class ImportXDCAMForm : DevComponents.DotNetBar.Metro.MetroForm
    {
        

        public ImportXDCAMForm()
        {
            InitializeComponent();
        }

        private void ImportXDCAMForm_Load(object sender, System.EventArgs e)
        {

            InitListView();
        }

        private void InitListView()
        {
            string[] headStrings1 = new[]
            {
                "片段名", "格式", "视频类型", "音频类型", "音频比特率", "帧率",
                "媒体长度", "音频通道", "图像宽高比", "创建日期"
            };


            System.Windows.Forms.ColumnHeader[] columnHeaders1 = new System.Windows.Forms.ColumnHeader[10];

            for (int i = 0; i < columnHeaders1.Length; i++)
            {
                columnHeaders1[i] = new ColumnHeader();
                columnHeaders1[i].Text = headStrings1[i];
                columnHeaders1[i].Width = 80;

            }

            listViewEx1.Columns.AddRange(columnHeaders1);
        }







        // end line
    }


}