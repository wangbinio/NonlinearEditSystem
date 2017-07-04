namespace NonLinearEditSystem.Forms
{
    partial class ImportP2Form
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
            this.labelX_目标路径 = new DevComponents.DotNetBar.LabelX();
            this.checkBoxX_导入到网络 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.comboBoxEx_缩略图 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX_缩略图 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX_FileName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX_文件名 = new DevComponents.DotNetBar.LabelX();
            this.buttonX_AddName = new DevComponents.DotNetBar.ButtonX();
            this.labelX_进度 = new DevComponents.DotNetBar.LabelX();
            this.progressBarX_Current = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.listViewEx1 = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.buttonX_连接设备 = new DevComponents.DotNetBar.ButtonX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonX_本地路径 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX_逻辑模式 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX_物理模式 = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listViewEx2 = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonX_合并导入 = new DevComponents.DotNetBar.ButtonX();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.buttonX_停止 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX_载入 = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.progressBarX_All = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.panelEx_Preview = new DevComponents.DotNetBar.PanelEx();
            this.timeLineControl1 = new TimeLineControl.TimeLineControl();
            this.checkBoxX_CutFile = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.labelX_EntrePoint = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // buttonX_ScanFilePath
            // 
            this.buttonX_ScanFilePath.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_ScanFilePath.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_ScanFilePath.Location = new System.Drawing.Point(471, 50);
            this.buttonX_ScanFilePath.Name = "buttonX_ScanFilePath";
            this.buttonX_ScanFilePath.Size = new System.Drawing.Size(67, 23);
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
            this.textBoxX_FilePath.Location = new System.Drawing.Point(198, 50);
            this.textBoxX_FilePath.Name = "textBoxX_FilePath";
            this.textBoxX_FilePath.PreventEnterBeep = true;
            this.textBoxX_FilePath.Size = new System.Drawing.Size(267, 23);
            this.textBoxX_FilePath.TabIndex = 100;
            this.textBoxX_FilePath.TabStop = false;
            this.textBoxX_FilePath.Text = "C:\\Users\\Administrator";
            // 
            // labelX_目标路径
            // 
            this.labelX_目标路径.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_目标路径.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_目标路径.ForeColor = System.Drawing.Color.Black;
            this.labelX_目标路径.Location = new System.Drawing.Point(129, 50);
            this.labelX_目标路径.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_目标路径.Name = "labelX_目标路径";
            this.labelX_目标路径.Size = new System.Drawing.Size(63, 23);
            this.labelX_目标路径.TabIndex = 7;
            this.labelX_目标路径.Text = "目标路径";
            // 
            // checkBoxX_导入到网络
            // 
            this.checkBoxX_导入到网络.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.checkBoxX_导入到网络.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX_导入到网络.ForeColor = System.Drawing.Color.Black;
            this.checkBoxX_导入到网络.Location = new System.Drawing.Point(18, 50);
            this.checkBoxX_导入到网络.Name = "checkBoxX_导入到网络";
            this.checkBoxX_导入到网络.Size = new System.Drawing.Size(91, 23);
            this.checkBoxX_导入到网络.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX_导入到网络.TabIndex = 5;
            this.checkBoxX_导入到网络.Text = "导入到网络";
            // 
            // comboBoxEx_缩略图
            // 
            this.comboBoxEx_缩略图.DisplayMember = "Text";
            this.comboBoxEx_缩略图.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx_缩略图.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEx_缩略图.FormattingEnabled = true;
            this.comboBoxEx_缩略图.ItemHeight = 18;
            this.comboBoxEx_缩略图.Location = new System.Drawing.Point(74, 88);
            this.comboBoxEx_缩略图.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxEx_缩略图.Name = "comboBoxEx_缩略图";
            this.comboBoxEx_缩略图.Size = new System.Drawing.Size(102, 24);
            this.comboBoxEx_缩略图.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx_缩略图.TabIndex = 6;
            // 
            // labelX_缩略图
            // 
            this.labelX_缩略图.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_缩略图.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_缩略图.ForeColor = System.Drawing.Color.Black;
            this.labelX_缩略图.Location = new System.Drawing.Point(19, 89);
            this.labelX_缩略图.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_缩略图.Name = "labelX_缩略图";
            this.labelX_缩略图.Size = new System.Drawing.Size(49, 23);
            this.labelX_缩略图.TabIndex = 7;
            this.labelX_缩略图.Text = "缩略图";
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
            this.textBoxX_FileName.Location = new System.Drawing.Point(801, 647);
            this.textBoxX_FileName.Name = "textBoxX_FileName";
            this.textBoxX_FileName.PreventEnterBeep = true;
            this.textBoxX_FileName.Size = new System.Drawing.Size(176, 23);
            this.textBoxX_FileName.TabIndex = 100;
            this.textBoxX_FileName.TabStop = false;
            // 
            // labelX_文件名
            // 
            this.labelX_文件名.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_文件名.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_文件名.ForeColor = System.Drawing.Color.Black;
            this.labelX_文件名.Location = new System.Drawing.Point(710, 647);
            this.labelX_文件名.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_文件名.Name = "labelX_文件名";
            this.labelX_文件名.Size = new System.Drawing.Size(85, 23);
            this.labelX_文件名.TabIndex = 7;
            this.labelX_文件名.Text = "文件名";
            // 
            // buttonX_AddName
            // 
            this.buttonX_AddName.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_AddName.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_AddName.Location = new System.Drawing.Point(471, 87);
            this.buttonX_AddName.Name = "buttonX_AddName";
            this.buttonX_AddName.Size = new System.Drawing.Size(68, 23);
            this.buttonX_AddName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_AddName.TabIndex = 5;
            this.buttonX_AddName.Text = "添加";
            // 
            // labelX_进度
            // 
            this.labelX_进度.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_进度.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_进度.ForeColor = System.Drawing.Color.Black;
            this.labelX_进度.Location = new System.Drawing.Point(18, 618);
            this.labelX_进度.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_进度.Name = "labelX_进度";
            this.labelX_进度.Size = new System.Drawing.Size(66, 23);
            this.labelX_进度.TabIndex = 13;
            this.labelX_进度.Text = "当前进程";
            // 
            // progressBarX_Current
            // 
            this.progressBarX_Current.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.progressBarX_Current.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressBarX_Current.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.progressBarX_Current.ForeColor = System.Drawing.Color.Black;
            this.progressBarX_Current.Location = new System.Drawing.Point(90, 618);
            this.progressBarX_Current.Name = "progressBarX_Current";
            this.progressBarX_Current.Size = new System.Drawing.Size(448, 23);
            this.progressBarX_Current.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.progressBarX_Current.TabIndex = 14;
            this.progressBarX_Current.Text = "50%";
            this.progressBarX_Current.TextVisible = true;
            this.progressBarX_Current.Value = 50;
            // 
            // listViewEx1
            // 
            this.listViewEx1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.listViewEx1.Border.Class = "ListViewBorder";
            this.listViewEx1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.listViewEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.listViewEx1.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.listViewEx1.ForeColor = System.Drawing.Color.Black;
            this.listViewEx1.FullRowSelect = true;
            this.listViewEx1.Location = new System.Drawing.Point(18, 127);
            this.listViewEx1.Name = "listViewEx1";
            this.listViewEx1.Size = new System.Drawing.Size(521, 217);
            this.listViewEx1.TabIndex = 103;
            this.listViewEx1.UseCompatibleStateImageBehavior = false;
            this.listViewEx1.View = System.Windows.Forms.View.Details;
            this.listViewEx1.VirtualListSize = 20;
            // 
            // buttonX_连接设备
            // 
            this.buttonX_连接设备.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_连接设备.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_连接设备.Location = new System.Drawing.Point(19, 12);
            this.buttonX_连接设备.Name = "buttonX_连接设备";
            this.buttonX_连接设备.Size = new System.Drawing.Size(120, 23);
            this.buttonX_连接设备.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_连接设备.TabIndex = 0;
            this.buttonX_连接设备.Text = "连接设备";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(18, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 2);
            this.groupBox2.TabIndex = 104;
            this.groupBox2.TabStop = false;
            // 
            // buttonX_本地路径
            // 
            this.buttonX_本地路径.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_本地路径.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_本地路径.Location = new System.Drawing.Point(152, 12);
            this.buttonX_本地路径.Name = "buttonX_本地路径";
            this.buttonX_本地路径.Size = new System.Drawing.Size(120, 23);
            this.buttonX_本地路径.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_本地路径.TabIndex = 5;
            this.buttonX_本地路径.Text = "本地路径";
            // 
            // buttonX_逻辑模式
            // 
            this.buttonX_逻辑模式.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_逻辑模式.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_逻辑模式.Location = new System.Drawing.Point(285, 12);
            this.buttonX_逻辑模式.Name = "buttonX_逻辑模式";
            this.buttonX_逻辑模式.Size = new System.Drawing.Size(120, 23);
            this.buttonX_逻辑模式.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_逻辑模式.TabIndex = 5;
            this.buttonX_逻辑模式.Text = "逻辑模式";
            // 
            // buttonX_物理模式
            // 
            this.buttonX_物理模式.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_物理模式.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_物理模式.Location = new System.Drawing.Point(418, 12);
            this.buttonX_物理模式.Name = "buttonX_物理模式";
            this.buttonX_物理模式.Size = new System.Drawing.Size(120, 23);
            this.buttonX_物理模式.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_物理模式.TabIndex = 5;
            this.buttonX_物理模式.Text = "物理模式";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(19, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 2);
            this.groupBox1.TabIndex = 104;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(19, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(520, 2);
            this.groupBox3.TabIndex = 104;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(19, 119);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(520, 2);
            this.groupBox4.TabIndex = 104;
            this.groupBox4.TabStop = false;
            // 
            // listViewEx2
            // 
            this.listViewEx2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.listViewEx1.Border.Class = "ListViewBorder";
            this.listViewEx1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.listViewEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.listViewEx2.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.listViewEx2.ForeColor = System.Drawing.Color.Black;
            this.listViewEx2.FullRowSelect = true;
            this.listViewEx2.Location = new System.Drawing.Point(18, 358);
            this.listViewEx2.Name = "listViewEx2";
            this.listViewEx2.Size = new System.Drawing.Size(521, 217);
            this.listViewEx2.TabIndex = 103;
            this.listViewEx2.UseCompatibleStateImageBehavior = false;
            this.listViewEx2.View = System.Windows.Forms.View.Details;
            this.listViewEx2.VirtualListSize = 20;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(18, 350);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(520, 2);
            this.groupBox5.TabIndex = 104;
            this.groupBox5.TabStop = false;
            // 
            // buttonX_合并导入
            // 
            this.buttonX_合并导入.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_合并导入.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_合并导入.Location = new System.Drawing.Point(18, 589);
            this.buttonX_合并导入.Name = "buttonX_合并导入";
            this.buttonX_合并导入.Size = new System.Drawing.Size(140, 23);
            this.buttonX_合并导入.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_合并导入.TabIndex = 5;
            this.buttonX_合并导入.Text = "合并导入";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.groupBox6.ForeColor = System.Drawing.Color.Black;
            this.groupBox6.Location = new System.Drawing.Point(18, 581);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(520, 2);
            this.groupBox6.TabIndex = 104;
            this.groupBox6.TabStop = false;
            // 
            // buttonX_停止
            // 
            this.buttonX_停止.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_停止.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_停止.Location = new System.Drawing.Point(400, 589);
            this.buttonX_停止.Name = "buttonX_停止";
            this.buttonX_停止.Size = new System.Drawing.Size(138, 23);
            this.buttonX_停止.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_停止.TabIndex = 5;
            this.buttonX_停止.Text = "停止";
            // 
            // buttonX_载入
            // 
            this.buttonX_载入.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_载入.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_载入.Location = new System.Drawing.Point(210, 589);
            this.buttonX_载入.Name = "buttonX_载入";
            this.buttonX_载入.Size = new System.Drawing.Size(140, 23);
            this.buttonX_载入.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_载入.TabIndex = 5;
            this.buttonX_载入.Text = "载入";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(18, 647);
            this.labelX1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(66, 23);
            this.labelX1.TabIndex = 13;
            this.labelX1.Text = "总进程";
            // 
            // progressBarX_All
            // 
            this.progressBarX_All.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.progressBarX_All.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressBarX_All.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.progressBarX_All.ForeColor = System.Drawing.Color.Black;
            this.progressBarX_All.Location = new System.Drawing.Point(90, 647);
            this.progressBarX_All.Name = "progressBarX_All";
            this.progressBarX_All.Size = new System.Drawing.Size(448, 23);
            this.progressBarX_All.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.progressBarX_All.TabIndex = 14;
            this.progressBarX_All.Text = "50%";
            this.progressBarX_All.TextVisible = true;
            this.progressBarX_All.Value = 50;
            // 
            // panelEx_Preview
            // 
            this.panelEx_Preview.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx_Preview.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx_Preview.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx_Preview.Location = new System.Drawing.Point(545, 2);
            this.panelEx_Preview.Name = "panelEx_Preview";
            this.panelEx_Preview.Size = new System.Drawing.Size(635, 532);
            this.panelEx_Preview.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx_Preview.Style.BackColor1.Color = System.Drawing.Color.Black;
            this.panelEx_Preview.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx_Preview.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx_Preview.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx_Preview.Style.GradientAngle = 90;
            this.panelEx_Preview.TabIndex = 105;
            // 
            // timeLineControl1
            // 
            this.timeLineControl1.IndexOfSecEveryTicks = 5;
            this.timeLineControl1.Location = new System.Drawing.Point(544, 540);
            this.timeLineControl1.Name = "timeLineControl1";
            this.timeLineControl1.NBigTicksLength = 10;
            this.timeLineControl1.NBotmPadding = 3;
            this.timeLineControl1.NDistanceOfTicks = 15;
            this.timeLineControl1.NNeedShowSeconds = 7200;
            this.timeLineControl1.NNumOfBigTicks = 24;
            this.timeLineControl1.Size = new System.Drawing.Size(635, 35);
            this.timeLineControl1.TabIndex = 109;
            this.timeLineControl1.Text = "timeLineControl1";
            this.timeLineControl1.ThumbHPos = 200;
            this.timeLineControl1.ThumbRectangle = new System.Drawing.Rectangle(193, 0, 15, 15);
            // 
            // checkBoxX_CutFile
            // 
            this.checkBoxX_CutFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.checkBoxX_CutFile.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX_CutFile.ForeColor = System.Drawing.Color.Black;
            this.checkBoxX_CutFile.Location = new System.Drawing.Point(545, 647);
            this.checkBoxX_CutFile.Name = "checkBoxX_CutFile";
            this.checkBoxX_CutFile.Size = new System.Drawing.Size(91, 23);
            this.checkBoxX_CutFile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX_CutFile.TabIndex = 5;
            this.checkBoxX_CutFile.Text = "剪切文件";
            // 
            // labelX_EntrePoint
            // 
            this.labelX_EntrePoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_EntrePoint.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_EntrePoint.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labelX_EntrePoint.FontBold = true;
            this.labelX_EntrePoint.ForeColor = System.Drawing.Color.Black;
            this.labelX_EntrePoint.Location = new System.Drawing.Point(544, 619);
            this.labelX_EntrePoint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_EntrePoint.Name = "labelX_EntrePoint";
            this.labelX_EntrePoint.Size = new System.Drawing.Size(80, 23);
            this.labelX_EntrePoint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX_EntrePoint.TabIndex = 110;
            this.labelX_EntrePoint.Text = "00:00:00:00";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labelX2.FontBold = true;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(814, 617);
            this.labelX2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(80, 23);
            this.labelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX2.TabIndex = 110;
            this.labelX2.Text = "00:00:00:00";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labelX3.FontBold = true;
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(1100, 619);
            this.labelX3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(80, 23);
            this.labelX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX3.TabIndex = 110;
            this.labelX3.Text = "00:00:00:00";
            // 
            // ImportP2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 677);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX_EntrePoint);
            this.Controls.Add(this.timeLineControl1);
            this.Controls.Add(this.panelEx_Preview);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.comboBoxEx_缩略图);
            this.Controls.Add(this.listViewEx2);
            this.Controls.Add(this.listViewEx1);
            this.Controls.Add(this.textBoxX_FileName);
            this.Controls.Add(this.labelX_缩略图);
            this.Controls.Add(this.labelX_文件名);
            this.Controls.Add(this.progressBarX_All);
            this.Controls.Add(this.progressBarX_Current);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.buttonX_AddName);
            this.Controls.Add(this.labelX_进度);
            this.Controls.Add(this.checkBoxX_CutFile);
            this.Controls.Add(this.checkBoxX_导入到网络);
            this.Controls.Add(this.buttonX_物理模式);
            this.Controls.Add(this.buttonX_逻辑模式);
            this.Controls.Add(this.buttonX_本地路径);
            this.Controls.Add(this.buttonX_载入);
            this.Controls.Add(this.buttonX_停止);
            this.Controls.Add(this.buttonX_合并导入);
            this.Controls.Add(this.buttonX_连接设备);
            this.Controls.Add(this.buttonX_ScanFilePath);
            this.Controls.Add(this.textBoxX_FilePath);
            this.Controls.Add(this.labelX_目标路径);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportP2Form";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "导入P2文件";
            this.Load += new System.EventHandler(this.ImportP2Form_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.LabelX labelX_目标路径;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX_FilePath;
        private DevComponents.DotNetBar.ButtonX buttonX_ScanFilePath;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX_导入到网络;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx_缩略图;
        private DevComponents.DotNetBar.LabelX labelX_缩略图;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX_FileName;
        private DevComponents.DotNetBar.LabelX labelX_文件名;
        private DevComponents.DotNetBar.ButtonX buttonX_AddName;
        private DevComponents.DotNetBar.LabelX labelX_进度;
        private DevComponents.DotNetBar.Controls.ProgressBarX progressBarX_Current;
        private DevComponents.DotNetBar.Controls.ListViewEx listViewEx1;
        private DevComponents.DotNetBar.ButtonX buttonX_连接设备;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.ButtonX buttonX_本地路径;
        private DevComponents.DotNetBar.ButtonX buttonX_逻辑模式;
        private DevComponents.DotNetBar.ButtonX buttonX_物理模式;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevComponents.DotNetBar.Controls.ListViewEx listViewEx2;
        private System.Windows.Forms.GroupBox groupBox5;
        private DevComponents.DotNetBar.ButtonX buttonX_合并导入;
        private System.Windows.Forms.GroupBox groupBox6;
        private DevComponents.DotNetBar.ButtonX buttonX_停止;
        private DevComponents.DotNetBar.ButtonX buttonX_载入;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ProgressBarX progressBarX_All;
        private DevComponents.DotNetBar.PanelEx panelEx_Preview;
        private TimeLineControl.TimeLineControl timeLineControl1;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX_CutFile;
        private DevComponents.DotNetBar.LabelX labelX_EntrePoint;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
    }
}