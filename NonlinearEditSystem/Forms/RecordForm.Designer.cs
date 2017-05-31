namespace NonLinearEditSystem.Forms
{
    partial class RecordForm
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
            this.groupBox_VTR设置 = new System.Windows.Forms.GroupBox();
            this.panelEx_Preview = new DevComponents.DotNetBar.PanelEx();
            this.labelX_PreviewTime = new DevComponents.DotNetBar.LabelX();
            this.groupBox_基本设置 = new System.Windows.Forms.GroupBox();
            this.groupBox_尾部黑场 = new System.Windows.Forms.GroupBox();
            this.integerInput_尾黑长度 = new DevComponents.Editors.IntegerInput();
            this.labelX_尾黑长度 = new DevComponents.DotNetBar.LabelX();
            this.groupBox_首部黑场 = new System.Windows.Forms.GroupBox();
            this.integerInput_首黑长度 = new DevComponents.Editors.IntegerInput();
            this.labelX_首黑长度 = new DevComponents.DotNetBar.LabelX();
            this.groupBox_彩条设置 = new System.Windows.Forms.GroupBox();
            this.checkBoxX_Add1KHZ = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.labelX_彩条类型 = new DevComponents.DotNetBar.LabelX();
            this.integerInput_彩条长度 = new DevComponents.Editors.IntegerInput();
            this.labelX_彩条长度 = new DevComponents.DotNetBar.LabelX();
            this.comboBoxEx_彩条类型 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.groupBox_序列设置 = new System.Windows.Forms.GroupBox();
            this.labelX_范围 = new DevComponents.DotNetBar.LabelX();
            this.labelX_序列入点 = new DevComponents.DotNetBar.LabelX();
            this.labelX_SegEnterTime = new DevComponents.DotNetBar.LabelX();
            this.labelX_序列出点 = new DevComponents.DotNetBar.LabelX();
            this.labelX_SegExitTime = new DevComponents.DotNetBar.LabelX();
            this.labelX_SegTimeLength = new DevComponents.DotNetBar.LabelX();
            this.labelX_序列长度 = new DevComponents.DotNetBar.LabelX();
            this.comboBoxEx_范围 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.groupBox_输出设置 = new System.Windows.Forms.GroupBox();
            this.radioButton_Combine = new System.Windows.Forms.RadioButton();
            this.radioButton_Insert = new System.Windows.Forms.RadioButton();
            this.buttonX_Reset = new DevComponents.DotNetBar.ButtonX();
            this.groupBox_录制通道设置 = new System.Windows.Forms.GroupBox();
            this.checkBoxX_A4 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.checkBoxX_A3 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.checkBoxX_A2 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.checkBoxX_A1 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.checkBoxX_A0Video = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.integerInput_出点等待 = new DevComponents.Editors.IntegerInput();
            this.labelX_模式 = new DevComponents.DotNetBar.LabelX();
            this.buttonX_DeviceSet = new DevComponents.DotNetBar.ButtonX();
            this.integerInput_入点等待 = new DevComponents.Editors.IntegerInput();
            this.labelX_出点等待 = new DevComponents.DotNetBar.LabelX();
            this.labelX_入点等待 = new DevComponents.DotNetBar.LabelX();
            this.groupBox_录制控制 = new System.Windows.Forms.GroupBox();
            this.progressBarX_RecordProgress = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.buttonX_CordEnd = new DevComponents.DotNetBar.ButtonX();
            this.buttonX_CordBegin = new DevComponents.DotNetBar.ButtonX();
            this.slider_PreviewTime = new MB.Controls.ColorSlider();
            this.groupBox_VTR设置.SuspendLayout();
            this.groupBox_基本设置.SuspendLayout();
            this.groupBox_尾部黑场.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.integerInput_尾黑长度)).BeginInit();
            this.groupBox_首部黑场.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.integerInput_首黑长度)).BeginInit();
            this.groupBox_彩条设置.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.integerInput_彩条长度)).BeginInit();
            this.groupBox_序列设置.SuspendLayout();
            this.groupBox_输出设置.SuspendLayout();
            this.groupBox_录制通道设置.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.integerInput_出点等待)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.integerInput_入点等待)).BeginInit();
            this.groupBox_录制控制.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_VTR设置
            // 
            this.groupBox_VTR设置.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.groupBox_VTR设置.Controls.Add(this.slider_PreviewTime);
            this.groupBox_VTR设置.Controls.Add(this.panelEx_Preview);
            this.groupBox_VTR设置.Controls.Add(this.labelX_PreviewTime);
            this.groupBox_VTR设置.ForeColor = System.Drawing.Color.Black;
            this.groupBox_VTR设置.Location = new System.Drawing.Point(425, 2);
            this.groupBox_VTR设置.Name = "groupBox_VTR设置";
            this.groupBox_VTR设置.Size = new System.Drawing.Size(409, 491);
            this.groupBox_VTR设置.TabIndex = 107;
            this.groupBox_VTR设置.TabStop = false;
            this.groupBox_VTR设置.Text = "VTR设置";
            // 
            // panelEx_Preview
            // 
            this.panelEx_Preview.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx_Preview.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx_Preview.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx_Preview.Location = new System.Drawing.Point(6, 22);
            this.panelEx_Preview.Name = "panelEx_Preview";
            this.panelEx_Preview.Size = new System.Drawing.Size(391, 391);
            this.panelEx_Preview.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx_Preview.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx_Preview.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx_Preview.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx_Preview.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx_Preview.Style.GradientAngle = 90;
            this.panelEx_Preview.TabIndex = 0;
            this.panelEx_Preview.Text = "视频预览";
            // 
            // labelX_PreviewTime
            // 
            this.labelX_PreviewTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_PreviewTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_PreviewTime.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labelX_PreviewTime.FontBold = true;
            this.labelX_PreviewTime.ForeColor = System.Drawing.Color.Black;
            this.labelX_PreviewTime.Location = new System.Drawing.Point(305, 424);
            this.labelX_PreviewTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_PreviewTime.Name = "labelX_PreviewTime";
            this.labelX_PreviewTime.Size = new System.Drawing.Size(92, 23);
            this.labelX_PreviewTime.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX_PreviewTime.TabIndex = 27;
            this.labelX_PreviewTime.Text = "00:00:00:00";
            // 
            // groupBox_基本设置
            // 
            this.groupBox_基本设置.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.groupBox_基本设置.Controls.Add(this.groupBox_尾部黑场);
            this.groupBox_基本设置.Controls.Add(this.groupBox_首部黑场);
            this.groupBox_基本设置.Controls.Add(this.groupBox_彩条设置);
            this.groupBox_基本设置.Controls.Add(this.groupBox_序列设置);
            this.groupBox_基本设置.ForeColor = System.Drawing.Color.Black;
            this.groupBox_基本设置.Location = new System.Drawing.Point(12, 2);
            this.groupBox_基本设置.Name = "groupBox_基本设置";
            this.groupBox_基本设置.Size = new System.Drawing.Size(403, 429);
            this.groupBox_基本设置.TabIndex = 100;
            this.groupBox_基本设置.TabStop = false;
            this.groupBox_基本设置.Text = "基本设置";
            // 
            // groupBox_尾部黑场
            // 
            this.groupBox_尾部黑场.Controls.Add(this.integerInput_尾黑长度);
            this.groupBox_尾部黑场.Controls.Add(this.labelX_尾黑长度);
            this.groupBox_尾部黑场.Location = new System.Drawing.Point(7, 348);
            this.groupBox_尾部黑场.Name = "groupBox_尾部黑场";
            this.groupBox_尾部黑场.Size = new System.Drawing.Size(388, 65);
            this.groupBox_尾部黑场.TabIndex = 104;
            this.groupBox_尾部黑场.TabStop = false;
            this.groupBox_尾部黑场.Text = "尾部黑场";
            // 
            // integerInput_尾黑长度
            // 
            // 
            // 
            // 
            this.integerInput_尾黑长度.BackgroundStyle.Class = "DateTimeInputBackground";
            this.integerInput_尾黑长度.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.integerInput_尾黑长度.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.integerInput_尾黑长度.Location = new System.Drawing.Point(86, 24);
            this.integerInput_尾黑长度.MaxValue = 100;
            this.integerInput_尾黑长度.MinValue = 0;
            this.integerInput_尾黑长度.Name = "integerInput_尾黑长度";
            this.integerInput_尾黑长度.ShowUpDown = true;
            this.integerInput_尾黑长度.Size = new System.Drawing.Size(296, 23);
            this.integerInput_尾黑长度.TabIndex = 6;
            this.integerInput_尾黑长度.Value = 5;
            // 
            // labelX_尾黑长度
            // 
            this.labelX_尾黑长度.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_尾黑长度.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_尾黑长度.ForeColor = System.Drawing.Color.Black;
            this.labelX_尾黑长度.Location = new System.Drawing.Point(6, 23);
            this.labelX_尾黑长度.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_尾黑长度.Name = "labelX_尾黑长度";
            this.labelX_尾黑长度.Size = new System.Drawing.Size(75, 23);
            this.labelX_尾黑长度.TabIndex = 7;
            this.labelX_尾黑长度.Text = "长度(s)";
            // 
            // groupBox_首部黑场
            // 
            this.groupBox_首部黑场.Controls.Add(this.integerInput_首黑长度);
            this.groupBox_首部黑场.Controls.Add(this.labelX_首黑长度);
            this.groupBox_首部黑场.Location = new System.Drawing.Point(7, 277);
            this.groupBox_首部黑场.Name = "groupBox_首部黑场";
            this.groupBox_首部黑场.Size = new System.Drawing.Size(388, 65);
            this.groupBox_首部黑场.TabIndex = 103;
            this.groupBox_首部黑场.TabStop = false;
            this.groupBox_首部黑场.Text = "首部黑场";
            // 
            // integerInput_首黑长度
            // 
            // 
            // 
            // 
            this.integerInput_首黑长度.BackgroundStyle.Class = "DateTimeInputBackground";
            this.integerInput_首黑长度.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.integerInput_首黑长度.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.integerInput_首黑长度.Location = new System.Drawing.Point(86, 24);
            this.integerInput_首黑长度.MaxValue = 100;
            this.integerInput_首黑长度.MinValue = 0;
            this.integerInput_首黑长度.Name = "integerInput_首黑长度";
            this.integerInput_首黑长度.ShowUpDown = true;
            this.integerInput_首黑长度.Size = new System.Drawing.Size(296, 23);
            this.integerInput_首黑长度.TabIndex = 5;
            this.integerInput_首黑长度.Value = 5;
            // 
            // labelX_首黑长度
            // 
            this.labelX_首黑长度.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_首黑长度.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_首黑长度.ForeColor = System.Drawing.Color.Black;
            this.labelX_首黑长度.Location = new System.Drawing.Point(6, 23);
            this.labelX_首黑长度.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_首黑长度.Name = "labelX_首黑长度";
            this.labelX_首黑长度.Size = new System.Drawing.Size(75, 23);
            this.labelX_首黑长度.TabIndex = 7;
            this.labelX_首黑长度.Text = "长度(s)";
            // 
            // groupBox_彩条设置
            // 
            this.groupBox_彩条设置.Controls.Add(this.checkBoxX_Add1KHZ);
            this.groupBox_彩条设置.Controls.Add(this.labelX_彩条类型);
            this.groupBox_彩条设置.Controls.Add(this.integerInput_彩条长度);
            this.groupBox_彩条设置.Controls.Add(this.labelX_彩条长度);
            this.groupBox_彩条设置.Controls.Add(this.comboBoxEx_彩条类型);
            this.groupBox_彩条设置.Location = new System.Drawing.Point(7, 174);
            this.groupBox_彩条设置.Name = "groupBox_彩条设置";
            this.groupBox_彩条设置.Size = new System.Drawing.Size(388, 97);
            this.groupBox_彩条设置.TabIndex = 102;
            this.groupBox_彩条设置.TabStop = false;
            this.groupBox_彩条设置.Text = "彩条设置";
            // 
            // checkBoxX_Add1KHZ
            // 
            // 
            // 
            // 
            this.checkBoxX_Add1KHZ.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX_Add1KHZ.Checked = true;
            this.checkBoxX_Add1KHZ.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxX_Add1KHZ.CheckValue = "Y";
            this.checkBoxX_Add1KHZ.Location = new System.Drawing.Point(274, 57);
            this.checkBoxX_Add1KHZ.Name = "checkBoxX_Add1KHZ";
            this.checkBoxX_Add1KHZ.Size = new System.Drawing.Size(108, 23);
            this.checkBoxX_Add1KHZ.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX_Add1KHZ.TabIndex = 4;
            this.checkBoxX_Add1KHZ.Text = "添加1KHz音频";
            // 
            // labelX_彩条类型
            // 
            this.labelX_彩条类型.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_彩条类型.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_彩条类型.ForeColor = System.Drawing.Color.Black;
            this.labelX_彩条类型.Location = new System.Drawing.Point(5, 24);
            this.labelX_彩条类型.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_彩条类型.Name = "labelX_彩条类型";
            this.labelX_彩条类型.Size = new System.Drawing.Size(75, 23);
            this.labelX_彩条类型.TabIndex = 7;
            this.labelX_彩条类型.Text = "类型";
            // 
            // integerInput_彩条长度
            // 
            // 
            // 
            // 
            this.integerInput_彩条长度.BackgroundStyle.Class = "DateTimeInputBackground";
            this.integerInput_彩条长度.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.integerInput_彩条长度.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.integerInput_彩条长度.Location = new System.Drawing.Point(86, 57);
            this.integerInput_彩条长度.MaxValue = 100;
            this.integerInput_彩条长度.MinValue = 0;
            this.integerInput_彩条长度.Name = "integerInput_彩条长度";
            this.integerInput_彩条长度.ShowUpDown = true;
            this.integerInput_彩条长度.Size = new System.Drawing.Size(167, 23);
            this.integerInput_彩条长度.TabIndex = 3;
            this.integerInput_彩条长度.Value = 5;
            // 
            // labelX_彩条长度
            // 
            this.labelX_彩条长度.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_彩条长度.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_彩条长度.ForeColor = System.Drawing.Color.Black;
            this.labelX_彩条长度.Location = new System.Drawing.Point(6, 56);
            this.labelX_彩条长度.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_彩条长度.Name = "labelX_彩条长度";
            this.labelX_彩条长度.Size = new System.Drawing.Size(75, 23);
            this.labelX_彩条长度.TabIndex = 7;
            this.labelX_彩条长度.Text = "长度(s)";
            // 
            // comboBoxEx_彩条类型
            // 
            this.comboBoxEx_彩条类型.DisplayMember = "Text";
            this.comboBoxEx_彩条类型.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx_彩条类型.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEx_彩条类型.FormattingEnabled = true;
            this.comboBoxEx_彩条类型.ItemHeight = 18;
            this.comboBoxEx_彩条类型.Location = new System.Drawing.Point(86, 23);
            this.comboBoxEx_彩条类型.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxEx_彩条类型.Name = "comboBoxEx_彩条类型";
            this.comboBoxEx_彩条类型.Size = new System.Drawing.Size(296, 24);
            this.comboBoxEx_彩条类型.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx_彩条类型.TabIndex = 2;
            this.comboBoxEx_彩条类型.Text = "100-0-100-0彩条";
            // 
            // groupBox_序列设置
            // 
            this.groupBox_序列设置.Controls.Add(this.labelX_范围);
            this.groupBox_序列设置.Controls.Add(this.labelX_序列入点);
            this.groupBox_序列设置.Controls.Add(this.labelX_SegEnterTime);
            this.groupBox_序列设置.Controls.Add(this.labelX_序列出点);
            this.groupBox_序列设置.Controls.Add(this.labelX_SegExitTime);
            this.groupBox_序列设置.Controls.Add(this.labelX_SegTimeLength);
            this.groupBox_序列设置.Controls.Add(this.labelX_序列长度);
            this.groupBox_序列设置.Controls.Add(this.comboBoxEx_范围);
            this.groupBox_序列设置.Location = new System.Drawing.Point(6, 22);
            this.groupBox_序列设置.Name = "groupBox_序列设置";
            this.groupBox_序列设置.Size = new System.Drawing.Size(389, 145);
            this.groupBox_序列设置.TabIndex = 101;
            this.groupBox_序列设置.TabStop = false;
            // 
            // labelX_范围
            // 
            this.labelX_范围.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_范围.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_范围.ForeColor = System.Drawing.Color.Black;
            this.labelX_范围.Location = new System.Drawing.Point(6, 23);
            this.labelX_范围.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_范围.Name = "labelX_范围";
            this.labelX_范围.Size = new System.Drawing.Size(75, 23);
            this.labelX_范围.TabIndex = 7;
            this.labelX_范围.Text = "范围";
            // 
            // labelX_序列入点
            // 
            this.labelX_序列入点.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_序列入点.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_序列入点.ForeColor = System.Drawing.Color.Black;
            this.labelX_序列入点.Location = new System.Drawing.Point(6, 54);
            this.labelX_序列入点.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_序列入点.Name = "labelX_序列入点";
            this.labelX_序列入点.Size = new System.Drawing.Size(75, 23);
            this.labelX_序列入点.TabIndex = 7;
            this.labelX_序列入点.Text = "序列入点";
            // 
            // labelX_SegEnterTime
            // 
            this.labelX_SegEnterTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_SegEnterTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_SegEnterTime.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labelX_SegEnterTime.FontBold = true;
            this.labelX_SegEnterTime.ForeColor = System.Drawing.Color.Black;
            this.labelX_SegEnterTime.Location = new System.Drawing.Point(87, 54);
            this.labelX_SegEnterTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_SegEnterTime.Name = "labelX_SegEnterTime";
            this.labelX_SegEnterTime.Size = new System.Drawing.Size(92, 23);
            this.labelX_SegEnterTime.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX_SegEnterTime.TabIndex = 7;
            this.labelX_SegEnterTime.Text = "00:00:00:00";
            // 
            // labelX_序列出点
            // 
            this.labelX_序列出点.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_序列出点.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_序列出点.ForeColor = System.Drawing.Color.Black;
            this.labelX_序列出点.Location = new System.Drawing.Point(6, 85);
            this.labelX_序列出点.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_序列出点.Name = "labelX_序列出点";
            this.labelX_序列出点.Size = new System.Drawing.Size(75, 23);
            this.labelX_序列出点.TabIndex = 7;
            this.labelX_序列出点.Text = "序列出点";
            // 
            // labelX_SegExitTime
            // 
            this.labelX_SegExitTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_SegExitTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_SegExitTime.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labelX_SegExitTime.FontBold = true;
            this.labelX_SegExitTime.ForeColor = System.Drawing.Color.Black;
            this.labelX_SegExitTime.Location = new System.Drawing.Point(87, 85);
            this.labelX_SegExitTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_SegExitTime.Name = "labelX_SegExitTime";
            this.labelX_SegExitTime.Size = new System.Drawing.Size(92, 23);
            this.labelX_SegExitTime.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX_SegExitTime.TabIndex = 7;
            this.labelX_SegExitTime.Text = "00:00:00:00";
            // 
            // labelX_SegTimeLength
            // 
            this.labelX_SegTimeLength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_SegTimeLength.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_SegTimeLength.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labelX_SegTimeLength.FontBold = true;
            this.labelX_SegTimeLength.ForeColor = System.Drawing.Color.Black;
            this.labelX_SegTimeLength.Location = new System.Drawing.Point(87, 116);
            this.labelX_SegTimeLength.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_SegTimeLength.Name = "labelX_SegTimeLength";
            this.labelX_SegTimeLength.Size = new System.Drawing.Size(92, 23);
            this.labelX_SegTimeLength.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX_SegTimeLength.TabIndex = 7;
            this.labelX_SegTimeLength.Text = "00:00:00:00";
            // 
            // labelX_序列长度
            // 
            this.labelX_序列长度.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_序列长度.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_序列长度.ForeColor = System.Drawing.Color.Black;
            this.labelX_序列长度.Location = new System.Drawing.Point(6, 116);
            this.labelX_序列长度.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_序列长度.Name = "labelX_序列长度";
            this.labelX_序列长度.Size = new System.Drawing.Size(75, 23);
            this.labelX_序列长度.TabIndex = 7;
            this.labelX_序列长度.Text = "长度";
            // 
            // comboBoxEx_范围
            // 
            this.comboBoxEx_范围.DisplayMember = "Text";
            this.comboBoxEx_范围.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx_范围.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEx_范围.FormattingEnabled = true;
            this.comboBoxEx_范围.ItemHeight = 18;
            this.comboBoxEx_范围.Location = new System.Drawing.Point(87, 22);
            this.comboBoxEx_范围.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxEx_范围.Name = "comboBoxEx_范围";
            this.comboBoxEx_范围.Size = new System.Drawing.Size(296, 24);
            this.comboBoxEx_范围.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx_范围.TabIndex = 1;
            this.comboBoxEx_范围.Text = "全部";
            // 
            // groupBox_输出设置
            // 
            this.groupBox_输出设置.Controls.Add(this.radioButton_Combine);
            this.groupBox_输出设置.Controls.Add(this.radioButton_Insert);
            this.groupBox_输出设置.Controls.Add(this.buttonX_Reset);
            this.groupBox_输出设置.Controls.Add(this.groupBox_录制通道设置);
            this.groupBox_输出设置.Controls.Add(this.integerInput_出点等待);
            this.groupBox_输出设置.Controls.Add(this.labelX_模式);
            this.groupBox_输出设置.Controls.Add(this.buttonX_DeviceSet);
            this.groupBox_输出设置.Controls.Add(this.integerInput_入点等待);
            this.groupBox_输出设置.Controls.Add(this.labelX_出点等待);
            this.groupBox_输出设置.Controls.Add(this.labelX_入点等待);
            this.groupBox_输出设置.Location = new System.Drawing.Point(12, 437);
            this.groupBox_输出设置.Name = "groupBox_输出设置";
            this.groupBox_输出设置.Size = new System.Drawing.Size(403, 238);
            this.groupBox_输出设置.TabIndex = 105;
            this.groupBox_输出设置.TabStop = false;
            this.groupBox_输出设置.Text = "输出设置";
            // 
            // radioButton_Combine
            // 
            this.radioButton_Combine.AutoSize = true;
            this.radioButton_Combine.Location = new System.Drawing.Point(174, 87);
            this.radioButton_Combine.Name = "radioButton_Combine";
            this.radioButton_Combine.Size = new System.Drawing.Size(50, 21);
            this.radioButton_Combine.TabIndex = 10;
            this.radioButton_Combine.TabStop = true;
            this.radioButton_Combine.Text = "组合";
            this.radioButton_Combine.UseVisualStyleBackColor = true;
            // 
            // radioButton_Insert
            // 
            this.radioButton_Insert.AutoSize = true;
            this.radioButton_Insert.Checked = true;
            this.radioButton_Insert.Location = new System.Drawing.Point(93, 87);
            this.radioButton_Insert.Name = "radioButton_Insert";
            this.radioButton_Insert.Size = new System.Drawing.Size(50, 21);
            this.radioButton_Insert.TabIndex = 9;
            this.radioButton_Insert.TabStop = true;
            this.radioButton_Insert.Text = "插入";
            this.radioButton_Insert.UseVisualStyleBackColor = true;
            // 
            // buttonX_Reset
            // 
            this.buttonX_Reset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_Reset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_Reset.Location = new System.Drawing.Point(207, 191);
            this.buttonX_Reset.Name = "buttonX_Reset";
            this.buttonX_Reset.Size = new System.Drawing.Size(188, 23);
            this.buttonX_Reset.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_Reset.TabIndex = 17;
            this.buttonX_Reset.Text = "复位到默认值";
            // 
            // groupBox_录制通道设置
            // 
            this.groupBox_录制通道设置.Controls.Add(this.checkBoxX_A4);
            this.groupBox_录制通道设置.Controls.Add(this.checkBoxX_A3);
            this.groupBox_录制通道设置.Controls.Add(this.checkBoxX_A2);
            this.groupBox_录制通道设置.Controls.Add(this.checkBoxX_A1);
            this.groupBox_录制通道设置.Controls.Add(this.checkBoxX_A0Video);
            this.groupBox_录制通道设置.Location = new System.Drawing.Point(6, 115);
            this.groupBox_录制通道设置.Name = "groupBox_录制通道设置";
            this.groupBox_录制通道设置.Size = new System.Drawing.Size(389, 58);
            this.groupBox_录制通道设置.TabIndex = 105;
            this.groupBox_录制通道设置.TabStop = false;
            this.groupBox_录制通道设置.Text = "录制通道设置";
            // 
            // checkBoxX_A4
            // 
            // 
            // 
            // 
            this.checkBoxX_A4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX_A4.Location = new System.Drawing.Point(330, 22);
            this.checkBoxX_A4.Name = "checkBoxX_A4";
            this.checkBoxX_A4.Size = new System.Drawing.Size(49, 23);
            this.checkBoxX_A4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX_A4.TabIndex = 15;
            this.checkBoxX_A4.Text = "A4";
            // 
            // checkBoxX_A3
            // 
            // 
            // 
            // 
            this.checkBoxX_A3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX_A3.Location = new System.Drawing.Point(249, 22);
            this.checkBoxX_A3.Name = "checkBoxX_A3";
            this.checkBoxX_A3.Size = new System.Drawing.Size(49, 23);
            this.checkBoxX_A3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX_A3.TabIndex = 14;
            this.checkBoxX_A3.Text = "A3";
            // 
            // checkBoxX_A2
            // 
            // 
            // 
            // 
            this.checkBoxX_A2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX_A2.Location = new System.Drawing.Point(168, 22);
            this.checkBoxX_A2.Name = "checkBoxX_A2";
            this.checkBoxX_A2.Size = new System.Drawing.Size(49, 23);
            this.checkBoxX_A2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX_A2.TabIndex = 13;
            this.checkBoxX_A2.Text = "A2";
            // 
            // checkBoxX_A1
            // 
            // 
            // 
            // 
            this.checkBoxX_A1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX_A1.Location = new System.Drawing.Point(87, 22);
            this.checkBoxX_A1.Name = "checkBoxX_A1";
            this.checkBoxX_A1.Size = new System.Drawing.Size(49, 23);
            this.checkBoxX_A1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX_A1.TabIndex = 12;
            this.checkBoxX_A1.Text = "A1";
            // 
            // checkBoxX_A0Video
            // 
            // 
            // 
            // 
            this.checkBoxX_A0Video.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX_A0Video.Checked = true;
            this.checkBoxX_A0Video.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxX_A0Video.CheckValue = "Y";
            this.checkBoxX_A0Video.Location = new System.Drawing.Point(6, 22);
            this.checkBoxX_A0Video.Name = "checkBoxX_A0Video";
            this.checkBoxX_A0Video.Size = new System.Drawing.Size(49, 23);
            this.checkBoxX_A0Video.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX_A0Video.TabIndex = 11;
            this.checkBoxX_A0Video.Text = "视频";
            // 
            // integerInput_出点等待
            // 
            // 
            // 
            // 
            this.integerInput_出点等待.BackgroundStyle.Class = "DateTimeInputBackground";
            this.integerInput_出点等待.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.integerInput_出点等待.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.integerInput_出点等待.Location = new System.Drawing.Point(93, 55);
            this.integerInput_出点等待.MaxValue = 100;
            this.integerInput_出点等待.MinValue = 0;
            this.integerInput_出点等待.Name = "integerInput_出点等待";
            this.integerInput_出点等待.ShowUpDown = true;
            this.integerInput_出点等待.Size = new System.Drawing.Size(296, 23);
            this.integerInput_出点等待.TabIndex = 8;
            this.integerInput_出点等待.Value = 5;
            // 
            // labelX_模式
            // 
            this.labelX_模式.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_模式.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_模式.ForeColor = System.Drawing.Color.Black;
            this.labelX_模式.Location = new System.Drawing.Point(7, 85);
            this.labelX_模式.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_模式.Name = "labelX_模式";
            this.labelX_模式.Size = new System.Drawing.Size(75, 23);
            this.labelX_模式.TabIndex = 7;
            this.labelX_模式.Text = "模式";
            // 
            // buttonX_DeviceSet
            // 
            this.buttonX_DeviceSet.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_DeviceSet.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_DeviceSet.Location = new System.Drawing.Point(7, 191);
            this.buttonX_DeviceSet.Name = "buttonX_DeviceSet";
            this.buttonX_DeviceSet.Size = new System.Drawing.Size(179, 23);
            this.buttonX_DeviceSet.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_DeviceSet.TabIndex = 16;
            this.buttonX_DeviceSet.Text = "设备设置...";
            // 
            // integerInput_入点等待
            // 
            // 
            // 
            // 
            this.integerInput_入点等待.BackgroundStyle.Class = "DateTimeInputBackground";
            this.integerInput_入点等待.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.integerInput_入点等待.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.integerInput_入点等待.Location = new System.Drawing.Point(93, 24);
            this.integerInput_入点等待.MaxValue = 100;
            this.integerInput_入点等待.MinValue = 0;
            this.integerInput_入点等待.Name = "integerInput_入点等待";
            this.integerInput_入点等待.ShowUpDown = true;
            this.integerInput_入点等待.Size = new System.Drawing.Size(296, 23);
            this.integerInput_入点等待.TabIndex = 7;
            this.integerInput_入点等待.Value = 5;
            // 
            // labelX_出点等待
            // 
            this.labelX_出点等待.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_出点等待.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_出点等待.ForeColor = System.Drawing.Color.Black;
            this.labelX_出点等待.Location = new System.Drawing.Point(7, 54);
            this.labelX_出点等待.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_出点等待.Name = "labelX_出点等待";
            this.labelX_出点等待.Size = new System.Drawing.Size(75, 23);
            this.labelX_出点等待.TabIndex = 7;
            this.labelX_出点等待.Text = "出点等待(帧)";
            // 
            // labelX_入点等待
            // 
            this.labelX_入点等待.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_入点等待.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_入点等待.ForeColor = System.Drawing.Color.Black;
            this.labelX_入点等待.Location = new System.Drawing.Point(7, 24);
            this.labelX_入点等待.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_入点等待.Name = "labelX_入点等待";
            this.labelX_入点等待.Size = new System.Drawing.Size(75, 23);
            this.labelX_入点等待.TabIndex = 7;
            this.labelX_入点等待.Text = "入点等待(帧)";
            // 
            // groupBox_录制控制
            // 
            this.groupBox_录制控制.Controls.Add(this.progressBarX_RecordProgress);
            this.groupBox_录制控制.Controls.Add(this.buttonX_CordEnd);
            this.groupBox_录制控制.Controls.Add(this.buttonX_CordBegin);
            this.groupBox_录制控制.Location = new System.Drawing.Point(425, 543);
            this.groupBox_录制控制.Name = "groupBox_录制控制";
            this.groupBox_录制控制.Size = new System.Drawing.Size(409, 132);
            this.groupBox_录制控制.TabIndex = 108;
            this.groupBox_录制控制.TabStop = false;
            this.groupBox_录制控制.Text = "录制控制";
            // 
            // progressBarX_RecordProgress
            // 
            this.progressBarX_RecordProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.progressBarX_RecordProgress.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressBarX_RecordProgress.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.progressBarX_RecordProgress.ForeColor = System.Drawing.Color.Black;
            this.progressBarX_RecordProgress.Location = new System.Drawing.Point(6, 42);
            this.progressBarX_RecordProgress.Name = "progressBarX_RecordProgress";
            this.progressBarX_RecordProgress.Size = new System.Drawing.Size(397, 23);
            this.progressBarX_RecordProgress.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.progressBarX_RecordProgress.TabIndex = 15;
            this.progressBarX_RecordProgress.Text = "50%";
            this.progressBarX_RecordProgress.TextVisible = true;
            this.progressBarX_RecordProgress.Value = 50;
            // 
            // buttonX_CordEnd
            // 
            this.buttonX_CordEnd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_CordEnd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_CordEnd.Location = new System.Drawing.Point(215, 83);
            this.buttonX_CordEnd.Name = "buttonX_CordEnd";
            this.buttonX_CordEnd.Size = new System.Drawing.Size(188, 23);
            this.buttonX_CordEnd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_CordEnd.TabIndex = 20;
            this.buttonX_CordEnd.Text = "停止";
            // 
            // buttonX_CordBegin
            // 
            this.buttonX_CordBegin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_CordBegin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_CordBegin.Location = new System.Drawing.Point(6, 83);
            this.buttonX_CordBegin.Name = "buttonX_CordBegin";
            this.buttonX_CordBegin.Size = new System.Drawing.Size(179, 23);
            this.buttonX_CordBegin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_CordBegin.TabIndex = 19;
            this.buttonX_CordBegin.Text = "开始";
            // 
            // slider_PreviewTime
            // 
            this.slider_PreviewTime.BackColor = System.Drawing.Color.Transparent;
            this.slider_PreviewTime.BarInnerColor = System.Drawing.SystemColors.ActiveBorder;
            this.slider_PreviewTime.BarOuterColor = System.Drawing.SystemColors.ActiveBorder;
            this.slider_PreviewTime.BarPenColor = System.Drawing.SystemColors.ActiveBorder;
            this.slider_PreviewTime.BorderRoundRectSize = new System.Drawing.Size(4, 4);
            this.slider_PreviewTime.ElapsedInnerColor = System.Drawing.SystemColors.HotTrack;
            this.slider_PreviewTime.ElapsedOuterColor = System.Drawing.SystemColors.HotTrack;
            this.slider_PreviewTime.LargeChange = ((uint)(5u));
            this.slider_PreviewTime.Location = new System.Drawing.Point(17, 424);
            this.slider_PreviewTime.Name = "slider_PreviewTime";
            this.slider_PreviewTime.Size = new System.Drawing.Size(281, 25);
            this.slider_PreviewTime.SmallChange = ((uint)(1u));
            this.slider_PreviewTime.TabIndex = 28;
            this.slider_PreviewTime.ThumbInnerColor = System.Drawing.SystemColors.HotTrack;
            this.slider_PreviewTime.ThumbOuterColor = System.Drawing.SystemColors.HotTrack;
            this.slider_PreviewTime.ThumbPenColor = System.Drawing.SystemColors.HotTrack;
            this.slider_PreviewTime.ThumbRoundRectSize = new System.Drawing.Size(5, 5);
            this.slider_PreviewTime.ThumbSize = 5;
            this.slider_PreviewTime.Value = 0;
            // 
            // RecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 687);
            this.Controls.Add(this.groupBox_录制控制);
            this.Controls.Add(this.groupBox_输出设置);
            this.Controls.Add(this.groupBox_VTR设置);
            this.Controls.Add(this.groupBox_基本设置);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RecordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "录制";
            this.groupBox_VTR设置.ResumeLayout(false);
            this.groupBox_基本设置.ResumeLayout(false);
            this.groupBox_尾部黑场.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.integerInput_尾黑长度)).EndInit();
            this.groupBox_首部黑场.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.integerInput_首黑长度)).EndInit();
            this.groupBox_彩条设置.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.integerInput_彩条长度)).EndInit();
            this.groupBox_序列设置.ResumeLayout(false);
            this.groupBox_输出设置.ResumeLayout(false);
            this.groupBox_输出设置.PerformLayout();
            this.groupBox_录制通道设置.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.integerInput_出点等待)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.integerInput_入点等待)).EndInit();
            this.groupBox_录制控制.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_VTR设置;
        private DevComponents.DotNetBar.PanelEx panelEx_Preview;
        private DevComponents.DotNetBar.LabelX labelX_PreviewTime;
        private System.Windows.Forms.GroupBox groupBox_基本设置;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx_范围;
        private DevComponents.DotNetBar.LabelX labelX_范围;
        private System.Windows.Forms.GroupBox groupBox_彩条设置;
        private DevComponents.DotNetBar.LabelX labelX_彩条长度;
        private System.Windows.Forms.GroupBox groupBox_序列设置;
        private DevComponents.DotNetBar.LabelX labelX_序列入点;
        private DevComponents.DotNetBar.LabelX labelX_SegEnterTime;
        private DevComponents.DotNetBar.LabelX labelX_序列出点;
        private DevComponents.DotNetBar.LabelX labelX_SegExitTime;
        private DevComponents.DotNetBar.LabelX labelX_SegTimeLength;
        private DevComponents.DotNetBar.LabelX labelX_序列长度;
        private DevComponents.Editors.IntegerInput integerInput_彩条长度;
        private System.Windows.Forms.GroupBox groupBox_尾部黑场;
        private DevComponents.Editors.IntegerInput integerInput_尾黑长度;
        private DevComponents.DotNetBar.LabelX labelX_尾黑长度;
        private System.Windows.Forms.GroupBox groupBox_首部黑场;
        private DevComponents.Editors.IntegerInput integerInput_首黑长度;
        private DevComponents.DotNetBar.LabelX labelX_首黑长度;
        private DevComponents.DotNetBar.LabelX labelX_彩条类型;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx_彩条类型;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX_Add1KHZ;
        private System.Windows.Forms.GroupBox groupBox_输出设置;
        private DevComponents.Editors.IntegerInput integerInput_出点等待;
        private DevComponents.Editors.IntegerInput integerInput_入点等待;
        private DevComponents.DotNetBar.LabelX labelX_出点等待;
        private DevComponents.DotNetBar.LabelX labelX_入点等待;
        private System.Windows.Forms.RadioButton radioButton_Combine;
        private System.Windows.Forms.RadioButton radioButton_Insert;
        private System.Windows.Forms.GroupBox groupBox_录制通道设置;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX_A4;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX_A3;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX_A2;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX_A1;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX_A0Video;
        private DevComponents.DotNetBar.LabelX labelX_模式;
        private System.Windows.Forms.GroupBox groupBox_录制控制;
        private DevComponents.DotNetBar.Controls.ProgressBarX progressBarX_RecordProgress;
        private DevComponents.DotNetBar.ButtonX buttonX_CordEnd;
        private DevComponents.DotNetBar.ButtonX buttonX_Reset;
        private DevComponents.DotNetBar.ButtonX buttonX_CordBegin;
        private DevComponents.DotNetBar.ButtonX buttonX_DeviceSet;
        private MB.Controls.ColorSlider slider_PreviewTime;
    }
}