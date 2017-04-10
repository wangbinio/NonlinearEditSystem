namespace NonLinearEditSystem.Forms
{
    partial class DubForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox_当前状态 = new System.Windows.Forms.GroupBox();
            this.progressBarX_DubProgress = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.labelX_配音长度 = new DevComponents.DotNetBar.LabelX();
            this.labelX_准备配音 = new DevComponents.DotNetBar.LabelX();
            this.labelX_配音进度 = new DevComponents.DotNetBar.LabelX();
            this.labelX_CapTime = new DevComponents.DotNetBar.LabelX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timeLineControl1 = new TimeLineControl.TimeLineControl();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxEx_采样位数 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.buttonX_AddTrack = new DevComponents.DotNetBar.ButtonX();
            this.comboBoxEx_指定轨道 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.labelX_采样位数 = new DevComponents.DotNetBar.LabelX();
            this.comboBoxEx_采样频率 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem_采样频率 = new DevComponents.Editors.ComboItem();
            this.labelX_指定轨道 = new DevComponents.DotNetBar.LabelX();
            this.labelX_采样频率 = new DevComponents.DotNetBar.LabelX();
            this.integerInput1 = new DevComponents.Editors.IntegerInput();
            this.buttonX_ScanFilePath = new DevComponents.DotNetBar.ButtonX();
            this.textBoxX_FileName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX_FilePath = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX_预卷时间 = new DevComponents.DotNetBar.LabelX();
            this.labelX_文件名称 = new DevComponents.DotNetBar.LabelX();
            this.labelX_文件路径 = new DevComponents.DotNetBar.LabelX();
            this.checkBoxX_单声道输入 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.checkBoxX_区间配音 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.labelX_出点 = new DevComponents.DotNetBar.LabelX();
            this.labelX_入点时间 = new DevComponents.DotNetBar.LabelX();
            this.labelX_出点时间 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonX_GiveUp = new DevComponents.DotNetBar.ButtonX();
            this.buttonX_Record = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX5 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX6 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX7 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX8 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX9 = new DevComponents.DotNetBar.ButtonX();
            this.slider_PreviewTime = new DevComponents.DotNetBar.Controls.Slider();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.tabControl_Preview = new DevComponents.DotNetBar.TabControl();
            this.tabItem_Preview = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel_Preview = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItem_ScrollWnd = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel_ScrollWnd = new DevComponents.DotNetBar.TabControlPanel();
            this.groupBox_当前状态.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.integerInput1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl_Preview)).BeginInit();
            this.tabControl_Preview.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_当前状态
            // 
            this.groupBox_当前状态.Controls.Add(this.progressBarX_DubProgress);
            this.groupBox_当前状态.Controls.Add(this.labelX_配音长度);
            this.groupBox_当前状态.Controls.Add(this.labelX_准备配音);
            this.groupBox_当前状态.Controls.Add(this.labelX_配音进度);
            this.groupBox_当前状态.Controls.Add(this.labelX_CapTime);
            this.groupBox_当前状态.Location = new System.Drawing.Point(13, 13);
            this.groupBox_当前状态.Name = "groupBox_当前状态";
            this.groupBox_当前状态.Size = new System.Drawing.Size(379, 121);
            this.groupBox_当前状态.TabIndex = 0;
            this.groupBox_当前状态.TabStop = false;
            this.groupBox_当前状态.Text = "当前状态";
            // 
            // progressBarX_DubProgress
            // 
            this.progressBarX_DubProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.progressBarX_DubProgress.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressBarX_DubProgress.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.progressBarX_DubProgress.ForeColor = System.Drawing.Color.Black;
            this.progressBarX_DubProgress.Location = new System.Drawing.Point(78, 54);
            this.progressBarX_DubProgress.Name = "progressBarX_DubProgress";
            this.progressBarX_DubProgress.Size = new System.Drawing.Size(295, 23);
            this.progressBarX_DubProgress.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.progressBarX_DubProgress.TabIndex = 17;
            this.progressBarX_DubProgress.Text = "50%";
            this.progressBarX_DubProgress.TextVisible = true;
            this.progressBarX_DubProgress.Value = 50;
            // 
            // labelX_配音长度
            // 
            this.labelX_配音长度.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX_配音长度.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_配音长度.ForeColor = System.Drawing.Color.Black;
            this.labelX_配音长度.Location = new System.Drawing.Point(6, 85);
            this.labelX_配音长度.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_配音长度.Name = "labelX_配音长度";
            this.labelX_配音长度.Size = new System.Drawing.Size(66, 23);
            this.labelX_配音长度.TabIndex = 16;
            this.labelX_配音长度.Text = "配音长度:";
            // 
            // labelX_准备配音
            // 
            this.labelX_准备配音.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX_准备配音.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_准备配音.ForeColor = System.Drawing.Color.Black;
            this.labelX_准备配音.Location = new System.Drawing.Point(6, 23);
            this.labelX_准备配音.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_准备配音.Name = "labelX_准备配音";
            this.labelX_准备配音.Size = new System.Drawing.Size(66, 23);
            this.labelX_准备配音.TabIndex = 16;
            this.labelX_准备配音.Text = "准备配音";
            // 
            // labelX_配音进度
            // 
            this.labelX_配音进度.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX_配音进度.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_配音进度.ForeColor = System.Drawing.Color.Black;
            this.labelX_配音进度.Location = new System.Drawing.Point(6, 54);
            this.labelX_配音进度.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_配音进度.Name = "labelX_配音进度";
            this.labelX_配音进度.Size = new System.Drawing.Size(66, 23);
            this.labelX_配音进度.TabIndex = 16;
            this.labelX_配音进度.Text = "进度:";
            // 
            // labelX_CapTime
            // 
            this.labelX_CapTime.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX_CapTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_CapTime.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labelX_CapTime.FontBold = true;
            this.labelX_CapTime.ForeColor = System.Drawing.Color.Black;
            this.labelX_CapTime.Location = new System.Drawing.Point(78, 85);
            this.labelX_CapTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_CapTime.Name = "labelX_CapTime";
            this.labelX_CapTime.Size = new System.Drawing.Size(80, 23);
            this.labelX_CapTime.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX_CapTime.TabIndex = 15;
            this.labelX_CapTime.Text = "00:00:00:00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.timeLineControl1);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Location = new System.Drawing.Point(13, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 97);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "时间线控制";
            // 
            // timeLineControl1
            // 
            this.timeLineControl1.Location = new System.Drawing.Point(6, 53);
            this.timeLineControl1.Name = "timeLineControl1";
            this.timeLineControl1.NBigTicksLength = 10;
            this.timeLineControl1.NBotmPadding = 3;
            this.timeLineControl1.NDistanceOfTicks = 15;
            this.timeLineControl1.NNeedShowSeconds = 3600;
            this.timeLineControl1.NNumOfBigTicks = 6;
            this.timeLineControl1.Size = new System.Drawing.Size(367, 35);
            this.timeLineControl1.TabIndex = 0;
            this.timeLineControl1.Text = "timeLineControl1";
            this.timeLineControl1.ThumbHPos = 200;
            this.timeLineControl1.ThumbRectangle = new System.Drawing.Rectangle(193, 0, 15, 15);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labelX1.FontBold = true;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(52, 23);
            this.labelX1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(80, 23);
            this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX1.TabIndex = 15;
            this.labelX1.Text = "00:00:00:00";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxEx_采样位数);
            this.groupBox2.Controls.Add(this.buttonX_AddTrack);
            this.groupBox2.Controls.Add(this.comboBoxEx_指定轨道);
            this.groupBox2.Controls.Add(this.labelX_采样位数);
            this.groupBox2.Controls.Add(this.comboBoxEx_采样频率);
            this.groupBox2.Controls.Add(this.labelX_指定轨道);
            this.groupBox2.Controls.Add(this.labelX_采样频率);
            this.groupBox2.Controls.Add(this.integerInput1);
            this.groupBox2.Controls.Add(this.buttonX_ScanFilePath);
            this.groupBox2.Controls.Add(this.textBoxX_FileName);
            this.groupBox2.Controls.Add(this.textBoxX_FilePath);
            this.groupBox2.Controls.Add(this.labelX_预卷时间);
            this.groupBox2.Controls.Add(this.labelX_文件名称);
            this.groupBox2.Controls.Add(this.labelX_文件路径);
            this.groupBox2.Controls.Add(this.checkBoxX_单声道输入);
            this.groupBox2.Controls.Add(this.checkBoxX_区间配音);
            this.groupBox2.Controls.Add(this.labelX_出点);
            this.groupBox2.Controls.Add(this.labelX_入点时间);
            this.groupBox2.Controls.Add(this.labelX_出点时间);
            this.groupBox2.Controls.Add(this.labelX2);
            this.groupBox2.Location = new System.Drawing.Point(13, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 246);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "设置";
            // 
            // comboBoxEx_采样位数
            // 
            this.comboBoxEx_采样位数.DisplayMember = "Text";
            this.comboBoxEx_采样位数.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx_采样位数.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEx_采样位数.FormattingEnabled = true;
            this.comboBoxEx_采样位数.ItemHeight = 18;
            this.comboBoxEx_采样位数.Items.AddRange(new object[] {
            this.comboItem2});
            this.comboBoxEx_采样位数.Location = new System.Drawing.Point(274, 176);
            this.comboBoxEx_采样位数.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxEx_采样位数.Name = "comboBoxEx_采样位数";
            this.comboBoxEx_采样位数.Size = new System.Drawing.Size(99, 24);
            this.comboBoxEx_采样位数.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx_采样位数.TabIndex = 108;
            this.comboBoxEx_采样位数.TabStop = false;
            this.comboBoxEx_采样位数.Text = "采样频率";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "采样频率";
            // 
            // buttonX_AddTrack
            // 
            this.buttonX_AddTrack.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_AddTrack.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_AddTrack.Location = new System.Drawing.Point(274, 207);
            this.buttonX_AddTrack.Name = "buttonX_AddTrack";
            this.buttonX_AddTrack.Size = new System.Drawing.Size(99, 23);
            this.buttonX_AddTrack.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_AddTrack.TabIndex = 101;
            this.buttonX_AddTrack.Text = "添加轨道";
            // 
            // comboBoxEx_指定轨道
            // 
            this.comboBoxEx_指定轨道.DisplayMember = "Text";
            this.comboBoxEx_指定轨道.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx_指定轨道.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEx_指定轨道.FormattingEnabled = true;
            this.comboBoxEx_指定轨道.ItemHeight = 18;
            this.comboBoxEx_指定轨道.Items.AddRange(new object[] {
            this.comboItem1});
            this.comboBoxEx_指定轨道.Location = new System.Drawing.Point(274, 146);
            this.comboBoxEx_指定轨道.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxEx_指定轨道.Name = "comboBoxEx_指定轨道";
            this.comboBoxEx_指定轨道.Size = new System.Drawing.Size(99, 24);
            this.comboBoxEx_指定轨道.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx_指定轨道.TabIndex = 108;
            this.comboBoxEx_指定轨道.TabStop = false;
            this.comboBoxEx_指定轨道.Text = "采样频率";
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "采样频率";
            // 
            // labelX_采样位数
            // 
            this.labelX_采样位数.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX_采样位数.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_采样位数.ForeColor = System.Drawing.Color.Black;
            this.labelX_采样位数.Location = new System.Drawing.Point(203, 177);
            this.labelX_采样位数.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_采样位数.Name = "labelX_采样位数";
            this.labelX_采样位数.Size = new System.Drawing.Size(73, 23);
            this.labelX_采样位数.TabIndex = 107;
            this.labelX_采样位数.Text = "采样位数";
            // 
            // comboBoxEx_采样频率
            // 
            this.comboBoxEx_采样频率.DisplayMember = "Text";
            this.comboBoxEx_采样频率.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx_采样频率.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEx_采样频率.FormattingEnabled = true;
            this.comboBoxEx_采样频率.ItemHeight = 18;
            this.comboBoxEx_采样频率.Items.AddRange(new object[] {
            this.comboItem_采样频率});
            this.comboBoxEx_采样频率.Location = new System.Drawing.Point(78, 176);
            this.comboBoxEx_采样频率.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxEx_采样频率.Name = "comboBoxEx_采样频率";
            this.comboBoxEx_采样频率.Size = new System.Drawing.Size(99, 24);
            this.comboBoxEx_采样频率.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx_采样频率.TabIndex = 108;
            this.comboBoxEx_采样频率.TabStop = false;
            this.comboBoxEx_采样频率.Text = "采样频率";
            // 
            // comboItem_采样频率
            // 
            this.comboItem_采样频率.Text = "采样频率";
            // 
            // labelX_指定轨道
            // 
            this.labelX_指定轨道.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX_指定轨道.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_指定轨道.ForeColor = System.Drawing.Color.Black;
            this.labelX_指定轨道.Location = new System.Drawing.Point(203, 147);
            this.labelX_指定轨道.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_指定轨道.Name = "labelX_指定轨道";
            this.labelX_指定轨道.Size = new System.Drawing.Size(73, 23);
            this.labelX_指定轨道.TabIndex = 107;
            this.labelX_指定轨道.Text = "指定轨道";
            // 
            // labelX_采样频率
            // 
            this.labelX_采样频率.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX_采样频率.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_采样频率.ForeColor = System.Drawing.Color.Black;
            this.labelX_采样频率.Location = new System.Drawing.Point(7, 177);
            this.labelX_采样频率.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_采样频率.Name = "labelX_采样频率";
            this.labelX_采样频率.Size = new System.Drawing.Size(73, 23);
            this.labelX_采样频率.TabIndex = 107;
            this.labelX_采样频率.Text = "采样频率";
            // 
            // integerInput1
            // 
            // 
            // 
            // 
            this.integerInput1.BackgroundStyle.Class = "DateTimeInputBackground";
            this.integerInput1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.integerInput1.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.integerInput1.Location = new System.Drawing.Point(78, 146);
            this.integerInput1.Name = "integerInput1";
            this.integerInput1.ShowUpDown = true;
            this.integerInput1.Size = new System.Drawing.Size(99, 23);
            this.integerInput1.TabIndex = 106;
            // 
            // buttonX_ScanFilePath
            // 
            this.buttonX_ScanFilePath.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_ScanFilePath.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_ScanFilePath.Location = new System.Drawing.Point(294, 115);
            this.buttonX_ScanFilePath.Name = "buttonX_ScanFilePath";
            this.buttonX_ScanFilePath.Size = new System.Drawing.Size(80, 23);
            this.buttonX_ScanFilePath.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_ScanFilePath.TabIndex = 101;
            this.buttonX_ScanFilePath.Text = "浏览...";
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
            this.textBoxX_FileName.Location = new System.Drawing.Point(78, 84);
            this.textBoxX_FileName.Name = "textBoxX_FileName";
            this.textBoxX_FileName.PreventEnterBeep = true;
            this.textBoxX_FileName.Size = new System.Drawing.Size(209, 23);
            this.textBoxX_FileName.TabIndex = 102;
            this.textBoxX_FileName.Text = "配音";
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
            this.textBoxX_FilePath.Location = new System.Drawing.Point(78, 115);
            this.textBoxX_FilePath.Name = "textBoxX_FilePath";
            this.textBoxX_FilePath.PreventEnterBeep = true;
            this.textBoxX_FilePath.Size = new System.Drawing.Size(209, 23);
            this.textBoxX_FilePath.TabIndex = 105;
            this.textBoxX_FilePath.TabStop = false;
            // 
            // labelX_预卷时间
            // 
            this.labelX_预卷时间.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX_预卷时间.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_预卷时间.ForeColor = System.Drawing.Color.Black;
            this.labelX_预卷时间.Location = new System.Drawing.Point(6, 146);
            this.labelX_预卷时间.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_预卷时间.Name = "labelX_预卷时间";
            this.labelX_预卷时间.Size = new System.Drawing.Size(73, 23);
            this.labelX_预卷时间.TabIndex = 103;
            this.labelX_预卷时间.Text = "预卷时间(s)";
            // 
            // labelX_文件名称
            // 
            this.labelX_文件名称.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX_文件名称.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_文件名称.ForeColor = System.Drawing.Color.Black;
            this.labelX_文件名称.Location = new System.Drawing.Point(7, 84);
            this.labelX_文件名称.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_文件名称.Name = "labelX_文件名称";
            this.labelX_文件名称.Size = new System.Drawing.Size(66, 23);
            this.labelX_文件名称.TabIndex = 103;
            this.labelX_文件名称.Text = "文件名称";
            // 
            // labelX_文件路径
            // 
            this.labelX_文件路径.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX_文件路径.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_文件路径.ForeColor = System.Drawing.Color.Black;
            this.labelX_文件路径.Location = new System.Drawing.Point(6, 115);
            this.labelX_文件路径.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_文件路径.Name = "labelX_文件路径";
            this.labelX_文件路径.Size = new System.Drawing.Size(66, 23);
            this.labelX_文件路径.TabIndex = 104;
            this.labelX_文件路径.Text = "文件路径";
            // 
            // checkBoxX_单声道输入
            // 
            // 
            // 
            // 
            this.checkBoxX_单声道输入.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX_单声道输入.Location = new System.Drawing.Point(7, 207);
            this.checkBoxX_单声道输入.Name = "checkBoxX_单声道输入";
            this.checkBoxX_单声道输入.Size = new System.Drawing.Size(100, 23);
            this.checkBoxX_单声道输入.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX_单声道输入.TabIndex = 0;
            this.checkBoxX_单声道输入.Text = "单声道输入";
            // 
            // checkBoxX_区间配音
            // 
            // 
            // 
            // 
            this.checkBoxX_区间配音.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX_区间配音.Location = new System.Drawing.Point(7, 23);
            this.checkBoxX_区间配音.Name = "checkBoxX_区间配音";
            this.checkBoxX_区间配音.Size = new System.Drawing.Size(100, 23);
            this.checkBoxX_区间配音.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX_区间配音.TabIndex = 0;
            this.checkBoxX_区间配音.Text = "区间配音";
            // 
            // labelX_出点
            // 
            this.labelX_出点.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX_出点.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_出点.ForeColor = System.Drawing.Color.Black;
            this.labelX_出点.Location = new System.Drawing.Point(138, 53);
            this.labelX_出点.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_出点.Name = "labelX_出点";
            this.labelX_出点.Size = new System.Drawing.Size(39, 23);
            this.labelX_出点.TabIndex = 16;
            this.labelX_出点.Text = "出点";
            // 
            // labelX_入点时间
            // 
            this.labelX_入点时间.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX_入点时间.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_入点时间.ForeColor = System.Drawing.Color.Black;
            this.labelX_入点时间.Location = new System.Drawing.Point(7, 53);
            this.labelX_入点时间.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_入点时间.Name = "labelX_入点时间";
            this.labelX_入点时间.Size = new System.Drawing.Size(39, 23);
            this.labelX_入点时间.TabIndex = 16;
            this.labelX_入点时间.Text = "入点";
            // 
            // labelX_出点时间
            // 
            this.labelX_出点时间.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX_出点时间.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_出点时间.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labelX_出点时间.FontBold = true;
            this.labelX_出点时间.ForeColor = System.Drawing.Color.Black;
            this.labelX_出点时间.Location = new System.Drawing.Point(183, 53);
            this.labelX_出点时间.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_出点时间.Name = "labelX_出点时间";
            this.labelX_出点时间.Size = new System.Drawing.Size(80, 23);
            this.labelX_出点时间.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX_出点时间.TabIndex = 15;
            this.labelX_出点时间.Text = "00:00:00:00";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labelX2.FontBold = true;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(52, 53);
            this.labelX2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(80, 23);
            this.labelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX2.TabIndex = 15;
            this.labelX2.Text = "00:00:00:00";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonX_GiveUp);
            this.groupBox3.Controls.Add(this.buttonX_Record);
            this.groupBox3.Location = new System.Drawing.Point(13, 498);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(379, 60);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "录音操作";
            // 
            // buttonX_GiveUp
            // 
            this.buttonX_GiveUp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_GiveUp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_GiveUp.Location = new System.Drawing.Point(202, 22);
            this.buttonX_GiveUp.Name = "buttonX_GiveUp";
            this.buttonX_GiveUp.Size = new System.Drawing.Size(171, 23);
            this.buttonX_GiveUp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_GiveUp.TabIndex = 101;
            this.buttonX_GiveUp.Text = "放弃";
            // 
            // buttonX_Record
            // 
            this.buttonX_Record.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_Record.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_Record.Location = new System.Drawing.Point(7, 22);
            this.buttonX_Record.Name = "buttonX_Record";
            this.buttonX_Record.Size = new System.Drawing.Size(171, 23);
            this.buttonX_Record.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_Record.TabIndex = 101;
            this.buttonX_Record.Text = "录音";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(408, 14);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(117, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 101;
            this.buttonX1.Text = "打开";
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(531, 14);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(117, 23);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 101;
            this.buttonX2.Text = "编辑";
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Location = new System.Drawing.Point(654, 13);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(117, 23);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX3.TabIndex = 101;
            this.buttonX3.Text = "保存";
            // 
            // buttonX4
            // 
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX4.Location = new System.Drawing.Point(408, 43);
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Size = new System.Drawing.Size(117, 23);
            this.buttonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX4.TabIndex = 101;
            this.buttonX4.Text = "字体";
            // 
            // buttonX5
            // 
            this.buttonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX5.Location = new System.Drawing.Point(531, 43);
            this.buttonX5.Name = "buttonX5";
            this.buttonX5.Size = new System.Drawing.Size(117, 23);
            this.buttonX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX5.TabIndex = 101;
            this.buttonX5.Text = "字体颜色";
            // 
            // buttonX6
            // 
            this.buttonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX6.Location = new System.Drawing.Point(654, 42);
            this.buttonX6.Name = "buttonX6";
            this.buttonX6.Size = new System.Drawing.Size(117, 23);
            this.buttonX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX6.TabIndex = 101;
            this.buttonX6.Text = "应用";
            // 
            // buttonX7
            // 
            this.buttonX7.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX7.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX7.Location = new System.Drawing.Point(408, 72);
            this.buttonX7.Name = "buttonX7";
            this.buttonX7.Size = new System.Drawing.Size(117, 23);
            this.buttonX7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX7.TabIndex = 101;
            this.buttonX7.Text = "开始";
            // 
            // buttonX8
            // 
            this.buttonX8.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX8.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX8.Location = new System.Drawing.Point(531, 72);
            this.buttonX8.Name = "buttonX8";
            this.buttonX8.Size = new System.Drawing.Size(117, 23);
            this.buttonX8.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX8.TabIndex = 101;
            this.buttonX8.Text = "停止";
            // 
            // buttonX9
            // 
            this.buttonX9.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX9.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX9.Location = new System.Drawing.Point(654, 71);
            this.buttonX9.Name = "buttonX9";
            this.buttonX9.Size = new System.Drawing.Size(117, 23);
            this.buttonX9.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX9.TabIndex = 101;
            this.buttonX9.Text = "清除";
            // 
            // slider_PreviewTime
            // 
            this.slider_PreviewTime.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.slider_PreviewTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.slider_PreviewTime.ForeColor = System.Drawing.Color.Black;
            this.slider_PreviewTime.LabelVisible = false;
            this.slider_PreviewTime.Location = new System.Drawing.Point(479, 111);
            this.slider_PreviewTime.Name = "slider_PreviewTime";
            this.slider_PreviewTime.Size = new System.Drawing.Size(292, 23);
            this.slider_PreviewTime.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.slider_PreviewTime.TabIndex = 102;
            this.slider_PreviewTime.Value = 50;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(408, 111);
            this.labelX3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(39, 23);
            this.labelX3.TabIndex = 16;
            this.labelX3.Text = "滚屏";
            // 
            // tabControl_Preview
            // 
            this.tabControl_Preview.BackColor = System.Drawing.Color.White;
            this.tabControl_Preview.CanReorderTabs = true;
            this.tabControl_Preview.Controls.Add(this.tabControlPanel_Preview);
            this.tabControl_Preview.Controls.Add(this.tabControlPanel_ScrollWnd);
            this.tabControl_Preview.ForeColor = System.Drawing.Color.Black;
            this.tabControl_Preview.Location = new System.Drawing.Point(408, 142);
            this.tabControl_Preview.Name = "tabControl_Preview";
            this.tabControl_Preview.SelectedTabFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.tabControl_Preview.SelectedTabIndex = 0;
            this.tabControl_Preview.Size = new System.Drawing.Size(363, 416);
            this.tabControl_Preview.Style = DevComponents.DotNetBar.eTabStripStyle.Metro;
            this.tabControl_Preview.TabIndex = 103;
            this.tabControl_Preview.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl_Preview.Tabs.Add(this.tabItem_Preview);
            this.tabControl_Preview.Tabs.Add(this.tabItem_ScrollWnd);
            this.tabControl_Preview.Text = "tabControl1";
            // 
            // tabItem_Preview
            // 
            this.tabItem_Preview.AttachedControl = this.tabControlPanel_Preview;
            this.tabItem_Preview.Name = "tabItem_Preview";
            this.tabItem_Preview.Text = "预览";
            // 
            // tabControlPanel_Preview
            // 
            this.tabControlPanel_Preview.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanel_Preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel_Preview.Location = new System.Drawing.Point(0, 29);
            this.tabControlPanel_Preview.Name = "tabControlPanel_Preview";
            this.tabControlPanel_Preview.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel_Preview.Size = new System.Drawing.Size(363, 387);
            this.tabControlPanel_Preview.Style.BackColor1.Color = System.Drawing.Color.White;
            this.tabControlPanel_Preview.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel_Preview.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.tabControlPanel_Preview.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel_Preview.Style.GradientAngle = 90;
            this.tabControlPanel_Preview.TabIndex = 1;
            this.tabControlPanel_Preview.TabItem = this.tabItem_Preview;
            // 
            // tabItem_ScrollWnd
            // 
            this.tabItem_ScrollWnd.AttachedControl = this.tabControlPanel_ScrollWnd;
            this.tabItem_ScrollWnd.Name = "tabItem_ScrollWnd";
            this.tabItem_ScrollWnd.Text = "滚屏窗口";
            // 
            // tabControlPanel_ScrollWnd
            // 
            this.tabControlPanel_ScrollWnd.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanel_ScrollWnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel_ScrollWnd.Location = new System.Drawing.Point(0, 29);
            this.tabControlPanel_ScrollWnd.Name = "tabControlPanel_ScrollWnd";
            this.tabControlPanel_ScrollWnd.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel_ScrollWnd.Size = new System.Drawing.Size(363, 387);
            this.tabControlPanel_ScrollWnd.Style.BackColor1.Color = System.Drawing.Color.White;
            this.tabControlPanel_ScrollWnd.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel_ScrollWnd.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.tabControlPanel_ScrollWnd.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel_ScrollWnd.Style.GradientAngle = 90;
            this.tabControlPanel_ScrollWnd.TabIndex = 5;
            this.tabControlPanel_ScrollWnd.TabItem = this.tabItem_ScrollWnd;
            // 
            // DubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 598);
            this.Controls.Add(this.tabControl_Preview);
            this.Controls.Add(this.slider_PreviewTime);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonX9);
            this.Controls.Add(this.buttonX6);
            this.Controls.Add(this.buttonX3);
            this.Controls.Add(this.buttonX8);
            this.Controls.Add(this.buttonX5);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.buttonX7);
            this.Controls.Add(this.buttonX4);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_当前状态);
            this.Controls.Add(this.labelX3);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DubForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MetroForm";
            this.groupBox_当前状态.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.integerInput1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl_Preview)).EndInit();
            this.tabControl_Preview.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_当前状态;
        private DevComponents.DotNetBar.Controls.ProgressBarX progressBarX_DubProgress;
        private DevComponents.DotNetBar.LabelX labelX_配音长度;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX_准备配音;
        private DevComponents.DotNetBar.LabelX labelX_配音进度;
        private DevComponents.DotNetBar.LabelX labelX_CapTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private TimeLineControl.TimeLineControl timeLineControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX_区间配音;
        private DevComponents.DotNetBar.LabelX labelX_出点;
        private DevComponents.DotNetBar.LabelX labelX_入点时间;
        private DevComponents.DotNetBar.LabelX labelX_出点时间;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX buttonX_ScanFilePath;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX_FileName;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX_FilePath;
        private DevComponents.DotNetBar.LabelX labelX_文件名称;
        private DevComponents.DotNetBar.LabelX labelX_文件路径;
        private DevComponents.DotNetBar.LabelX labelX_预卷时间;
        private DevComponents.Editors.IntegerInput integerInput1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx_采样位数;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx_指定轨道;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.DotNetBar.LabelX labelX_采样位数;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx_采样频率;
        private DevComponents.Editors.ComboItem comboItem_采样频率;
        private DevComponents.DotNetBar.LabelX labelX_指定轨道;
        private DevComponents.DotNetBar.LabelX labelX_采样频率;
        private DevComponents.DotNetBar.ButtonX buttonX_AddTrack;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX_单声道输入;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevComponents.DotNetBar.ButtonX buttonX_GiveUp;
        private DevComponents.DotNetBar.ButtonX buttonX_Record;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.ButtonX buttonX4;
        private DevComponents.DotNetBar.ButtonX buttonX5;
        private DevComponents.DotNetBar.ButtonX buttonX6;
        private DevComponents.DotNetBar.ButtonX buttonX7;
        private DevComponents.DotNetBar.ButtonX buttonX8;
        private DevComponents.DotNetBar.ButtonX buttonX9;
        private DevComponents.DotNetBar.Controls.Slider slider_PreviewTime;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.TabControl tabControl_Preview;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel_Preview;
        private DevComponents.DotNetBar.TabItem tabItem_Preview;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel_ScrollWnd;
        private DevComponents.DotNetBar.TabItem tabItem_ScrollWnd;
    }
}