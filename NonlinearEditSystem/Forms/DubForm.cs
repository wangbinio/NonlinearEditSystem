using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace NonLinearEditSystem.Forms
{
    public partial class DubForm : DevComponents.DotNetBar.Metro.MetroForm
    {
        public DubForm()
        {
            InitializeComponent();

        }

        private void InitColor()
        {
            textBoxX_FilePath.BackColor = MainForm.bkgColor;
            textBoxX_FileName.BackColor = MainForm.bkgColor;
        }

        private void DubForm_Load(object sender, EventArgs e)
        {
            InitColor();
        }
    }
}