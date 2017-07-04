
using System.Windows.Forms;

namespace NonLinearEditSystem.Forms
{
    public partial class ImportPPTForm : DevComponents.DotNetBar.Metro.MetroForm
    {
        // 缩略图
        public static readonly object[] StoreTObjects = { "浏览器", "硬盘" };

        public ImportPPTForm()
        {
            InitializeComponent();
        }

        private void ImportPPTForm_Load(object sender, System.EventArgs e)
        {
            InitComboBox();
        }

        private void InitComboBox()
        {
            comboBoxEx_生成到.Items.AddRange(StoreTObjects);
            comboBoxEx_生成到.SelectedIndex = 0;
        }






        // end line
    }


}