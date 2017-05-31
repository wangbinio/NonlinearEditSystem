using System.Drawing;

namespace NonLinearEditSystem.Forms
{
    public partial class PreferenceSetForm : DevComponents.DotNetBar.Metro.MetroForm
    {
        public PreferenceSetForm()
        {
            InitializeComponent();
        }

        private void PreferenceSetForm_Load(object sender, System.EventArgs e)
        {
            colorPickerButton1.SelectedColor = Color.Green;
            colorPickerButton2.SelectedColor = Color.White;
        }
    }
}