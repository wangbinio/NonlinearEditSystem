namespace NonLinearEditSystem.Forms
{
    partial class ImportPPTForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonX_ScanFilePath = new DevComponents.DotNetBar.ButtonX();
            this.textBoxX_FilePath = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX_生成路径 = new DevComponents.DotNetBar.LabelX();
            this.comboBoxEx_生成到 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX_缩略图 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX_FileName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX_文件名 = new DevComponents.DotNetBar.LabelX();
            this.buttonX_Start = new DevComponents.DotNetBar.ButtonX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX_PPT路径 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX_ScanPPT = new DevComponents.DotNetBar.ButtonX();
            this.radioButton_生成图片 = new System.Windows.Forms.RadioButton();
            this.radioButton_生成视频 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // buttonX_ScanFilePath
            // 
            this.buttonX_ScanFilePath.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_ScanFilePath.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_ScanFilePath.Location = new System.Drawing.Point(422, 167);
            this.buttonX_ScanFilePath.Name = "buttonX_ScanFilePath";
            this.buttonX_ScanFilePath.Size = new System.Drawing.Size(76, 23);
            this.buttonX_ScanFilePath.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_ScanFilePath.TabIndex = 6;
            this.buttonX_ScanFilePath.Text = "浏览...";
            // 
            // textBoxX_FilePath
            // 
            this.textBoxX_FilePath.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX_FilePath.Border.Class = "TextBoxBorder";
            this.textBoxX_FilePath.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX_FilePath.DisabledBackColor = System.Drawing.Color.White;
            this.textBoxX_FilePath.ForeColor = System.Drawing.Color.Black;
            this.textBoxX_FilePath.Location = new System.Drawing.Point(101, 167);
            this.textBoxX_FilePath.Name = "textBoxX_FilePath";
            this.textBoxX_FilePath.PreventEnterBeep = true;
            this.textBoxX_FilePath.Size = new System.Drawing.Size(315, 23);
            this.textBoxX_FilePath.TabIndex = 100;
            this.textBoxX_FilePath.TabStop = false;
            this.textBoxX_FilePath.Text = "C:\\Users\\Administrator";
            // 
            // labelX_生成路径
            // 
            this.labelX_生成路径.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_生成路径.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_生成路径.ForeColor = System.Drawing.Color.Black;
            this.labelX_生成路径.Location = new System.Drawing.Point(19, 167);
            this.labelX_生成路径.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_生成路径.Name = "labelX_生成路径";
            this.labelX_生成路径.Size = new System.Drawing.Size(63, 23);
            this.labelX_生成路径.TabIndex = 7;
            this.labelX_生成路径.Text = "生成路径";
            // 
            // comboBoxEx_生成到
            // 
            this.comboBoxEx_生成到.DisplayMember = "Text";
            this.comboBoxEx_生成到.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx_生成到.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEx_生成到.FormattingEnabled = true;
            this.comboBoxEx_生成到.ItemHeight = 18;
            this.comboBoxEx_生成到.Location = new System.Drawing.Point(101, 50);
            this.comboBoxEx_生成到.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxEx_生成到.Name = "comboBoxEx_生成到";
            this.comboBoxEx_生成到.Size = new System.Drawing.Size(315, 24);
            this.comboBoxEx_生成到.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx_生成到.TabIndex = 6;
            // 
            // labelX_缩略图
            // 
            this.labelX_缩略图.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_缩略图.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_缩略图.ForeColor = System.Drawing.Color.Black;
            this.labelX_缩略图.Location = new System.Drawing.Point(18, 50);
            this.labelX_缩略图.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_缩略图.Name = "labelX_缩略图";
            this.labelX_缩略图.Size = new System.Drawing.Size(77, 23);
            this.labelX_缩略图.TabIndex = 7;
            this.labelX_缩略图.Text = "生成到";
            // 
            // textBoxX_FileName
            // 
            this.textBoxX_FileName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX_FileName.Border.Class = "TextBoxBorder";
            this.textBoxX_FileName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX_FileName.DisabledBackColor = System.Drawing.Color.White;
            this.textBoxX_FileName.ForeColor = System.Drawing.Color.Black;
            this.textBoxX_FileName.Location = new System.Drawing.Point(101, 89);
            this.textBoxX_FileName.Name = "textBoxX_FileName";
            this.textBoxX_FileName.PreventEnterBeep = true;
            this.textBoxX_FileName.Size = new System.Drawing.Size(315, 23);
            this.textBoxX_FileName.TabIndex = 100;
            this.textBoxX_FileName.TabStop = false;
            this.textBoxX_FileName.Text = "文件";
            // 
            // labelX_文件名
            // 
            this.labelX_文件名.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_文件名.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_文件名.ForeColor = System.Drawing.Color.Black;
            this.labelX_文件名.Location = new System.Drawing.Point(19, 89);
            this.labelX_文件名.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_文件名.Name = "labelX_文件名";
            this.labelX_文件名.Size = new System.Drawing.Size(76, 23);
            this.labelX_文件名.TabIndex = 7;
            this.labelX_文件名.Text = "文件名";
            // 
            // buttonX_Start
            // 
            this.buttonX_Start.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_Start.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_Start.Location = new System.Drawing.Point(423, 213);
            this.buttonX_Start.Name = "buttonX_Start";
            this.buttonX_Start.Size = new System.Drawing.Size(76, 23);
            this.buttonX_Start.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_Start.TabIndex = 5;
            this.buttonX_Start.Text = "开始";
            this.buttonX_Start.Click += new System.EventHandler(this.buttonX_Start_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(18, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 2);
            this.groupBox2.TabIndex = 104;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(19, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 2);
            this.groupBox1.TabIndex = 104;
            this.groupBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(18, 205);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(480, 2);
            this.groupBox5.TabIndex = 104;
            this.groupBox5.TabStop = false;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(19, 128);
            this.labelX1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(76, 23);
            this.labelX1.TabIndex = 7;
            this.labelX1.Text = "PPT路径";
            // 
            // textBoxX_PPT路径
            // 
            this.textBoxX_PPT路径.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX_PPT路径.Border.Class = "TextBoxBorder";
            this.textBoxX_PPT路径.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX_PPT路径.DisabledBackColor = System.Drawing.Color.White;
            this.textBoxX_PPT路径.ForeColor = System.Drawing.Color.Black;
            this.textBoxX_PPT路径.Location = new System.Drawing.Point(101, 128);
            this.textBoxX_PPT路径.Name = "textBoxX_PPT路径";
            this.textBoxX_PPT路径.PreventEnterBeep = true;
            this.textBoxX_PPT路径.Size = new System.Drawing.Size(315, 23);
            this.textBoxX_PPT路径.TabIndex = 100;
            this.textBoxX_PPT路径.TabStop = false;
            // 
            // buttonX_ScanPPT
            // 
            this.buttonX_ScanPPT.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_ScanPPT.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_ScanPPT.Location = new System.Drawing.Point(422, 128);
            this.buttonX_ScanPPT.Name = "buttonX_ScanPPT";
            this.buttonX_ScanPPT.Size = new System.Drawing.Size(76, 23);
            this.buttonX_ScanPPT.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_ScanPPT.TabIndex = 6;
            this.buttonX_ScanPPT.Text = "浏览...";
            // 
            // radioButton_生成图片
            // 
            this.radioButton_生成图片.AutoSize = true;
            this.radioButton_生成图片.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.radioButton_生成图片.ForeColor = System.Drawing.Color.Black;
            this.radioButton_生成图片.Location = new System.Drawing.Point(19, 10);
            this.radioButton_生成图片.Name = "radioButton_生成图片";
            this.radioButton_生成图片.Size = new System.Drawing.Size(74, 21);
            this.radioButton_生成图片.TabIndex = 114;
            this.radioButton_生成图片.Text = "生成图片";
            this.radioButton_生成图片.UseVisualStyleBackColor = false;
            // 
            // radioButton_生成视频
            // 
            this.radioButton_生成视频.AutoSize = true;
            this.radioButton_生成视频.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.radioButton_生成视频.Checked = true;
            this.radioButton_生成视频.ForeColor = System.Drawing.Color.Black;
            this.radioButton_生成视频.Location = new System.Drawing.Point(127, 10);
            this.radioButton_生成视频.Name = "radioButton_生成视频";
            this.radioButton_生成视频.Size = new System.Drawing.Size(74, 21);
            this.radioButton_生成视频.TabIndex = 114;
            this.radioButton_生成视频.TabStop = true;
            this.radioButton_生成视频.Text = "生成视频";
            this.radioButton_生成视频.UseVisualStyleBackColor = false;
            // 
            // ImportPPTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 240);
            this.Controls.Add(this.radioButton_生成视频);
            this.Controls.Add(this.radioButton_生成图片);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.comboBoxEx_生成到);
            this.Controls.Add(this.textBoxX_PPT路径);
            this.Controls.Add(this.textBoxX_FileName);
            this.Controls.Add(this.labelX_缩略图);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.labelX_文件名);
            this.Controls.Add(this.buttonX_Start);
            this.Controls.Add(this.buttonX_ScanPPT);
            this.Controls.Add(this.buttonX_ScanFilePath);
            this.Controls.Add(this.textBoxX_FilePath);
            this.Controls.Add(this.labelX_生成路径);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportPPTForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "导入PPT文件";
            this.Load += new System.EventHandler(this.ImportPPTForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevComponents.DotNetBar.LabelX labelX_生成路径;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX_FilePath;
        private DevComponents.DotNetBar.ButtonX buttonX_ScanFilePath;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx_生成到;
        private DevComponents.DotNetBar.LabelX labelX_缩略图;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX_FileName;
        private DevComponents.DotNetBar.LabelX labelX_文件名;
        private DevComponents.DotNetBar.ButtonX buttonX_Start;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX_PPT路径;
        private DevComponents.DotNetBar.ButtonX buttonX_ScanPPT;
        private System.Windows.Forms.RadioButton radioButton_生成图片;
        private System.Windows.Forms.RadioButton radioButton_生成视频;
    }
}