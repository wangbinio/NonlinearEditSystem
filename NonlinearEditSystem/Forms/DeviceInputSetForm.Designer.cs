namespace 主界面.Forms
{
    partial class DeviceInputSetForm
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
            this.tabControl1 = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel_Property = new DevComponents.DotNetBar.TabControlPanel();
            this.groupBox_OutViewMode = new System.Windows.Forms.GroupBox();
            this.comboBoxEx_OutModeChannel = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem7 = new DevComponents.Editors.ComboItem();
            this.comboBoxEx_OutViewDevice = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem6 = new DevComponents.Editors.ComboItem();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.groupBox_AudioInput = new System.Windows.Forms.GroupBox();
            this.comboBoxEx_AudioSignal = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem5 = new DevComponents.Editors.ComboItem();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.groupBox_VideoInput = new System.Windows.Forms.GroupBox();
            this.textBoxX_ConnectStatus = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.comboBoxEx_VideoSignal = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.groupBox_ResolutionSet = new System.Windows.Forms.GroupBox();
            this.comboBoxEx_PicRatio = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboBoxEx_ColorDepth = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboBoxEx_ScanMode = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboBoxEx_Resolution = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem_上场优先 = new DevComponents.Editors.ComboItem();
            this.comboBoxEx_帧率 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem_25fps = new DevComponents.Editors.ComboItem();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX_扫描模式 = new DevComponents.DotNetBar.LabelX();
            this.labelX_帧率 = new DevComponents.DotNetBar.LabelX();
            this.comboBoxEx_InputFormat = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem_1080 = new DevComponents.Editors.ComboItem();
            this.tabItem_Property = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel_DeviceSet = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItem_DeviceSet = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel_SyncLock = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItem_SyncLock = new DevComponents.DotNetBar.TabItem(this.components);
            this.buttonX_Cancel = new DevComponents.DotNetBar.ButtonX();
            this.buttonX_OK = new DevComponents.DotNetBar.ButtonX();
            this.buttonX_Default = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabControlPanel_Property.SuspendLayout();
            this.groupBox_OutViewMode.SuspendLayout();
            this.groupBox_AudioInput.SuspendLayout();
            this.groupBox_VideoInput.SuspendLayout();
            this.groupBox_ResolutionSet.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.tabControl1.CanReorderTabs = true;
            this.tabControl1.Controls.Add(this.tabControlPanel_Property);
            this.tabControl1.Controls.Add(this.tabControlPanel_DeviceSet);
            this.tabControl1.Controls.Add(this.tabControlPanel_SyncLock);
            this.tabControl1.ForeColor = System.Drawing.Color.Black;
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl1.SelectedTabIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(554, 449);
            this.tabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.Metro;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl1.Tabs.Add(this.tabItem_Property);
            this.tabControl1.Tabs.Add(this.tabItem_SyncLock);
            this.tabControl1.Tabs.Add(this.tabItem_DeviceSet);
            this.tabControl1.Text = "tabControl1";
            // 
            // tabControlPanel_Property
            // 
            this.tabControlPanel_Property.Controls.Add(this.groupBox_OutViewMode);
            this.tabControlPanel_Property.Controls.Add(this.groupBox_AudioInput);
            this.tabControlPanel_Property.Controls.Add(this.groupBox_VideoInput);
            this.tabControlPanel_Property.Controls.Add(this.groupBox_ResolutionSet);
            this.tabControlPanel_Property.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanel_Property.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel_Property.Location = new System.Drawing.Point(0, 28);
            this.tabControlPanel_Property.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControlPanel_Property.Name = "tabControlPanel_Property";
            this.tabControlPanel_Property.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel_Property.Size = new System.Drawing.Size(554, 421);
            this.tabControlPanel_Property.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.tabControlPanel_Property.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel_Property.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(198)))));
            this.tabControlPanel_Property.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel_Property.Style.GradientAngle = 90;
            this.tabControlPanel_Property.TabIndex = 1;
            this.tabControlPanel_Property.TabItem = this.tabItem_Property;
            // 
            // groupBox_OutViewMode
            // 
            this.groupBox_OutViewMode.Controls.Add(this.comboBoxEx_OutModeChannel);
            this.groupBox_OutViewMode.Controls.Add(this.comboBoxEx_OutViewDevice);
            this.groupBox_OutViewMode.Controls.Add(this.labelX7);
            this.groupBox_OutViewMode.Location = new System.Drawing.Point(277, 242);
            this.groupBox_OutViewMode.Name = "groupBox_OutViewMode";
            this.groupBox_OutViewMode.Size = new System.Drawing.Size(264, 109);
            this.groupBox_OutViewMode.TabIndex = 3;
            this.groupBox_OutViewMode.TabStop = false;
            this.groupBox_OutViewMode.Text = "输出视图模式";
            // 
            // comboBoxEx_OutModeChannel
            // 
            this.comboBoxEx_OutModeChannel.DisplayMember = "Text";
            this.comboBoxEx_OutModeChannel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx_OutModeChannel.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEx_OutModeChannel.FormattingEnabled = true;
            this.comboBoxEx_OutModeChannel.ItemHeight = 18;
            this.comboBoxEx_OutModeChannel.Items.AddRange(new object[] {
            this.comboItem7});
            this.comboBoxEx_OutModeChannel.Location = new System.Drawing.Point(102, 69);
            this.comboBoxEx_OutModeChannel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxEx_OutModeChannel.Name = "comboBoxEx_OutModeChannel";
            this.comboBoxEx_OutModeChannel.Size = new System.Drawing.Size(140, 24);
            this.comboBoxEx_OutModeChannel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx_OutModeChannel.TabIndex = 10;
            this.comboBoxEx_OutModeChannel.TabStop = false;
            this.comboBoxEx_OutModeChannel.Text = "通道A";
            // 
            // comboItem7
            // 
            this.comboItem7.Text = "25.00 fps";
            // 
            // comboBoxEx_OutViewDevice
            // 
            this.comboBoxEx_OutViewDevice.DisplayMember = "Text";
            this.comboBoxEx_OutViewDevice.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx_OutViewDevice.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEx_OutViewDevice.FormattingEnabled = true;
            this.comboBoxEx_OutViewDevice.ItemHeight = 18;
            this.comboBoxEx_OutViewDevice.Items.AddRange(new object[] {
            this.comboItem6});
            this.comboBoxEx_OutViewDevice.Location = new System.Drawing.Point(102, 27);
            this.comboBoxEx_OutViewDevice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxEx_OutViewDevice.Name = "comboBoxEx_OutViewDevice";
            this.comboBoxEx_OutViewDevice.Size = new System.Drawing.Size(140, 24);
            this.comboBoxEx_OutViewDevice.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx_OutViewDevice.TabIndex = 10;
            this.comboBoxEx_OutViewDevice.TabStop = false;
            this.comboBoxEx_OutViewDevice.Text = "DecLink Studio 4K";
            // 
            // comboItem6
            // 
            this.comboItem6.Text = "25.00 fps";
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.ForeColor = System.Drawing.Color.Black;
            this.labelX7.Location = new System.Drawing.Point(21, 49);
            this.labelX7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(75, 23);
            this.labelX7.TabIndex = 8;
            this.labelX7.Text = "视图1";
            // 
            // groupBox_AudioInput
            // 
            this.groupBox_AudioInput.Controls.Add(this.comboBoxEx_AudioSignal);
            this.groupBox_AudioInput.Controls.Add(this.labelX6);
            this.groupBox_AudioInput.Location = new System.Drawing.Point(277, 144);
            this.groupBox_AudioInput.Name = "groupBox_AudioInput";
            this.groupBox_AudioInput.Size = new System.Drawing.Size(264, 73);
            this.groupBox_AudioInput.TabIndex = 3;
            this.groupBox_AudioInput.TabStop = false;
            this.groupBox_AudioInput.Text = "音频输入";
            // 
            // comboBoxEx_AudioSignal
            // 
            this.comboBoxEx_AudioSignal.DisplayMember = "Text";
            this.comboBoxEx_AudioSignal.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx_AudioSignal.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEx_AudioSignal.FormattingEnabled = true;
            this.comboBoxEx_AudioSignal.ItemHeight = 18;
            this.comboBoxEx_AudioSignal.Items.AddRange(new object[] {
            this.comboItem5});
            this.comboBoxEx_AudioSignal.Location = new System.Drawing.Point(102, 27);
            this.comboBoxEx_AudioSignal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxEx_AudioSignal.Name = "comboBoxEx_AudioSignal";
            this.comboBoxEx_AudioSignal.Size = new System.Drawing.Size(140, 24);
            this.comboBoxEx_AudioSignal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx_AudioSignal.TabIndex = 10;
            this.comboBoxEx_AudioSignal.TabStop = false;
            this.comboBoxEx_AudioSignal.Text = "嵌入音频";
            // 
            // comboItem5
            // 
            this.comboItem5.Text = "25.00 fps";
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.ForeColor = System.Drawing.Color.Black;
            this.labelX6.Location = new System.Drawing.Point(21, 28);
            this.labelX6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 8;
            this.labelX6.Text = "信号";
            // 
            // groupBox_VideoInput
            // 
            this.groupBox_VideoInput.Controls.Add(this.textBoxX_ConnectStatus);
            this.groupBox_VideoInput.Controls.Add(this.labelX5);
            this.groupBox_VideoInput.Controls.Add(this.labelX4);
            this.groupBox_VideoInput.Controls.Add(this.comboBoxEx_VideoSignal);
            this.groupBox_VideoInput.Location = new System.Drawing.Point(277, 13);
            this.groupBox_VideoInput.Name = "groupBox_VideoInput";
            this.groupBox_VideoInput.Size = new System.Drawing.Size(264, 116);
            this.groupBox_VideoInput.TabIndex = 3;
            this.groupBox_VideoInput.TabStop = false;
            this.groupBox_VideoInput.Text = "视频输入";
            // 
            // textBoxX_ConnectStatus
            // 
            this.textBoxX_ConnectStatus.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX_ConnectStatus.Border.Class = "TextBoxBorder";
            this.textBoxX_ConnectStatus.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX_ConnectStatus.DisabledBackColor = System.Drawing.Color.White;
            this.textBoxX_ConnectStatus.ForeColor = System.Drawing.Color.Black;
            this.textBoxX_ConnectStatus.Location = new System.Drawing.Point(102, 72);
            this.textBoxX_ConnectStatus.Name = "textBoxX_ConnectStatus";
            this.textBoxX_ConnectStatus.PreventEnterBeep = true;
            this.textBoxX_ConnectStatus.ReadOnly = true;
            this.textBoxX_ConnectStatus.Size = new System.Drawing.Size(140, 23);
            this.textBoxX_ConnectStatus.TabIndex = 11;
            this.textBoxX_ConnectStatus.Text = "无连接";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(21, 71);
            this.labelX5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 8;
            this.labelX5.Text = "连接状态";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(21, 33);
            this.labelX4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 8;
            this.labelX4.Text = "信号";
            // 
            // comboBoxEx_VideoSignal
            // 
            this.comboBoxEx_VideoSignal.DisplayMember = "Text";
            this.comboBoxEx_VideoSignal.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx_VideoSignal.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEx_VideoSignal.FormattingEnabled = true;
            this.comboBoxEx_VideoSignal.ItemHeight = 18;
            this.comboBoxEx_VideoSignal.Items.AddRange(new object[] {
            this.comboItem4});
            this.comboBoxEx_VideoSignal.Location = new System.Drawing.Point(102, 32);
            this.comboBoxEx_VideoSignal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxEx_VideoSignal.Name = "comboBoxEx_VideoSignal";
            this.comboBoxEx_VideoSignal.Size = new System.Drawing.Size(140, 24);
            this.comboBoxEx_VideoSignal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx_VideoSignal.TabIndex = 10;
            this.comboBoxEx_VideoSignal.TabStop = false;
            this.comboBoxEx_VideoSignal.Text = "SDI";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "25.00 fps";
            // 
            // groupBox_ResolutionSet
            // 
            this.groupBox_ResolutionSet.Controls.Add(this.comboBoxEx_PicRatio);
            this.groupBox_ResolutionSet.Controls.Add(this.comboBoxEx_ColorDepth);
            this.groupBox_ResolutionSet.Controls.Add(this.comboBoxEx_ScanMode);
            this.groupBox_ResolutionSet.Controls.Add(this.comboBoxEx_Resolution);
            this.groupBox_ResolutionSet.Controls.Add(this.comboBoxEx_帧率);
            this.groupBox_ResolutionSet.Controls.Add(this.labelX3);
            this.groupBox_ResolutionSet.Controls.Add(this.labelX2);
            this.groupBox_ResolutionSet.Controls.Add(this.labelX1);
            this.groupBox_ResolutionSet.Controls.Add(this.labelX_扫描模式);
            this.groupBox_ResolutionSet.Controls.Add(this.labelX_帧率);
            this.groupBox_ResolutionSet.Controls.Add(this.comboBoxEx_InputFormat);
            this.groupBox_ResolutionSet.Location = new System.Drawing.Point(10, 13);
            this.groupBox_ResolutionSet.Name = "groupBox_ResolutionSet";
            this.groupBox_ResolutionSet.Size = new System.Drawing.Size(251, 338);
            this.groupBox_ResolutionSet.TabIndex = 2;
            this.groupBox_ResolutionSet.TabStop = false;
            this.groupBox_ResolutionSet.Text = "分辨率设置";
            // 
            // comboBoxEx_PicRatio
            // 
            this.comboBoxEx_PicRatio.DisplayMember = "Text";
            this.comboBoxEx_PicRatio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx_PicRatio.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEx_PicRatio.FormattingEnabled = true;
            this.comboBoxEx_PicRatio.ItemHeight = 18;
            this.comboBoxEx_PicRatio.Items.AddRange(new object[] {
            this.comboItem3});
            this.comboBoxEx_PicRatio.Location = new System.Drawing.Point(95, 278);
            this.comboBoxEx_PicRatio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxEx_PicRatio.Name = "comboBoxEx_PicRatio";
            this.comboBoxEx_PicRatio.Size = new System.Drawing.Size(140, 24);
            this.comboBoxEx_PicRatio.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx_PicRatio.TabIndex = 9;
            this.comboBoxEx_PicRatio.TabStop = false;
            this.comboBoxEx_PicRatio.Text = "1:1";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "上场优先";
            // 
            // comboBoxEx_ColorDepth
            // 
            this.comboBoxEx_ColorDepth.DisplayMember = "Text";
            this.comboBoxEx_ColorDepth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx_ColorDepth.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEx_ColorDepth.FormattingEnabled = true;
            this.comboBoxEx_ColorDepth.ItemHeight = 18;
            this.comboBoxEx_ColorDepth.Items.AddRange(new object[] {
            this.comboItem2});
            this.comboBoxEx_ColorDepth.Location = new System.Drawing.Point(95, 229);
            this.comboBoxEx_ColorDepth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxEx_ColorDepth.Name = "comboBoxEx_ColorDepth";
            this.comboBoxEx_ColorDepth.Size = new System.Drawing.Size(140, 24);
            this.comboBoxEx_ColorDepth.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx_ColorDepth.TabIndex = 9;
            this.comboBoxEx_ColorDepth.TabStop = false;
            this.comboBoxEx_ColorDepth.Text = "8 bit";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "上场优先";
            // 
            // comboBoxEx_ScanMode
            // 
            this.comboBoxEx_ScanMode.DisplayMember = "Text";
            this.comboBoxEx_ScanMode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx_ScanMode.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEx_ScanMode.FormattingEnabled = true;
            this.comboBoxEx_ScanMode.ItemHeight = 18;
            this.comboBoxEx_ScanMode.Items.AddRange(new object[] {
            this.comboItem1});
            this.comboBoxEx_ScanMode.Location = new System.Drawing.Point(95, 180);
            this.comboBoxEx_ScanMode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxEx_ScanMode.Name = "comboBoxEx_ScanMode";
            this.comboBoxEx_ScanMode.Size = new System.Drawing.Size(140, 24);
            this.comboBoxEx_ScanMode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx_ScanMode.TabIndex = 9;
            this.comboBoxEx_ScanMode.TabStop = false;
            this.comboBoxEx_ScanMode.Text = "上场优先";
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "上场优先";
            // 
            // comboBoxEx_Resolution
            // 
            this.comboBoxEx_Resolution.DisplayMember = "Text";
            this.comboBoxEx_Resolution.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx_Resolution.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEx_Resolution.FormattingEnabled = true;
            this.comboBoxEx_Resolution.ItemHeight = 18;
            this.comboBoxEx_Resolution.Items.AddRange(new object[] {
            this.comboItem_上场优先});
            this.comboBoxEx_Resolution.Location = new System.Drawing.Point(95, 131);
            this.comboBoxEx_Resolution.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxEx_Resolution.Name = "comboBoxEx_Resolution";
            this.comboBoxEx_Resolution.Size = new System.Drawing.Size(140, 24);
            this.comboBoxEx_Resolution.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx_Resolution.TabIndex = 9;
            this.comboBoxEx_Resolution.TabStop = false;
            this.comboBoxEx_Resolution.Text = "1920*1080";
            // 
            // comboItem_上场优先
            // 
            this.comboItem_上场优先.Text = "上场优先";
            // 
            // comboBoxEx_帧率
            // 
            this.comboBoxEx_帧率.DisplayMember = "Text";
            this.comboBoxEx_帧率.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx_帧率.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEx_帧率.FormattingEnabled = true;
            this.comboBoxEx_帧率.ItemHeight = 18;
            this.comboBoxEx_帧率.Items.AddRange(new object[] {
            this.comboItem_25fps});
            this.comboBoxEx_帧率.Location = new System.Drawing.Point(95, 82);
            this.comboBoxEx_帧率.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxEx_帧率.Name = "comboBoxEx_帧率";
            this.comboBoxEx_帧率.Size = new System.Drawing.Size(140, 24);
            this.comboBoxEx_帧率.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx_帧率.TabIndex = 10;
            this.comboBoxEx_帧率.TabStop = false;
            this.comboBoxEx_帧率.Text = "25.00 fps";
            // 
            // comboItem_25fps
            // 
            this.comboItem_25fps.Text = "25.00 fps";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(14, 278);
            this.labelX3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 7;
            this.labelX3.Text = "图像横纵比";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(14, 229);
            this.labelX2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 7;
            this.labelX2.Text = "色彩深度";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(14, 180);
            this.labelX1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 7;
            this.labelX1.Text = "扫描模式";
            // 
            // labelX_扫描模式
            // 
            this.labelX_扫描模式.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_扫描模式.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_扫描模式.ForeColor = System.Drawing.Color.Black;
            this.labelX_扫描模式.Location = new System.Drawing.Point(14, 131);
            this.labelX_扫描模式.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_扫描模式.Name = "labelX_扫描模式";
            this.labelX_扫描模式.Size = new System.Drawing.Size(75, 23);
            this.labelX_扫描模式.TabIndex = 7;
            this.labelX_扫描模式.Text = "分辨率";
            // 
            // labelX_帧率
            // 
            this.labelX_帧率.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_帧率.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_帧率.ForeColor = System.Drawing.Color.Black;
            this.labelX_帧率.Location = new System.Drawing.Point(14, 82);
            this.labelX_帧率.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_帧率.Name = "labelX_帧率";
            this.labelX_帧率.Size = new System.Drawing.Size(75, 23);
            this.labelX_帧率.TabIndex = 8;
            this.labelX_帧率.Text = "帧率";
            // 
            // comboBoxEx_InputFormat
            // 
            this.comboBoxEx_InputFormat.DisplayMember = "Text";
            this.comboBoxEx_InputFormat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx_InputFormat.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEx_InputFormat.FormattingEnabled = true;
            this.comboBoxEx_InputFormat.ItemHeight = 18;
            this.comboBoxEx_InputFormat.Items.AddRange(new object[] {
            this.comboItem_1080});
            this.comboBoxEx_InputFormat.Location = new System.Drawing.Point(14, 33);
            this.comboBoxEx_InputFormat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxEx_InputFormat.Name = "comboBoxEx_InputFormat";
            this.comboBoxEx_InputFormat.Size = new System.Drawing.Size(231, 24);
            this.comboBoxEx_InputFormat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx_InputFormat.TabIndex = 1;
            this.comboBoxEx_InputFormat.Text = "单目 HD(1920*1080)@50i";
            // 
            // comboItem_1080
            // 
            this.comboItem_1080.Text = "单目 HD(1920*1080)@50i";
            // 
            // tabItem_Property
            // 
            this.tabItem_Property.AttachedControl = this.tabControlPanel_Property;
            this.tabItem_Property.Name = "tabItem_Property";
            this.tabItem_Property.Text = "属性";
            // 
            // tabControlPanel_DeviceSet
            // 
            this.tabControlPanel_DeviceSet.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanel_DeviceSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel_DeviceSet.Location = new System.Drawing.Point(0, 28);
            this.tabControlPanel_DeviceSet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControlPanel_DeviceSet.Name = "tabControlPanel_DeviceSet";
            this.tabControlPanel_DeviceSet.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel_DeviceSet.Size = new System.Drawing.Size(554, 421);
            this.tabControlPanel_DeviceSet.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.tabControlPanel_DeviceSet.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel_DeviceSet.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(198)))));
            this.tabControlPanel_DeviceSet.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel_DeviceSet.Style.GradientAngle = 90;
            this.tabControlPanel_DeviceSet.TabIndex = 9;
            this.tabControlPanel_DeviceSet.TabItem = this.tabItem_DeviceSet;
            // 
            // tabItem_DeviceSet
            // 
            this.tabItem_DeviceSet.AttachedControl = this.tabControlPanel_DeviceSet;
            this.tabItem_DeviceSet.Name = "tabItem_DeviceSet";
            this.tabItem_DeviceSet.Text = "设备设置";
            // 
            // tabControlPanel_SyncLock
            // 
            this.tabControlPanel_SyncLock.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanel_SyncLock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel_SyncLock.Location = new System.Drawing.Point(0, 28);
            this.tabControlPanel_SyncLock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControlPanel_SyncLock.Name = "tabControlPanel_SyncLock";
            this.tabControlPanel_SyncLock.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel_SyncLock.Size = new System.Drawing.Size(554, 421);
            this.tabControlPanel_SyncLock.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.tabControlPanel_SyncLock.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel_SyncLock.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(198)))));
            this.tabControlPanel_SyncLock.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel_SyncLock.Style.GradientAngle = 90;
            this.tabControlPanel_SyncLock.TabIndex = 5;
            this.tabControlPanel_SyncLock.TabItem = this.tabItem_SyncLock;
            // 
            // tabItem_SyncLock
            // 
            this.tabItem_SyncLock.AttachedControl = this.tabControlPanel_SyncLock;
            this.tabItem_SyncLock.Name = "tabItem_SyncLock";
            this.tabItem_SyncLock.Text = "同步锁定";
            // 
            // buttonX_Cancel
            // 
            this.buttonX_Cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_Cancel.Location = new System.Drawing.Point(491, 479);
            this.buttonX_Cancel.Name = "buttonX_Cancel";
            this.buttonX_Cancel.Size = new System.Drawing.Size(75, 23);
            this.buttonX_Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_Cancel.TabIndex = 1;
            this.buttonX_Cancel.Text = "取消";
            // 
            // buttonX_OK
            // 
            this.buttonX_OK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_OK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_OK.Location = new System.Drawing.Point(410, 479);
            this.buttonX_OK.Name = "buttonX_OK";
            this.buttonX_OK.Size = new System.Drawing.Size(75, 23);
            this.buttonX_OK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_OK.TabIndex = 1;
            this.buttonX_OK.Text = "确定";
            // 
            // buttonX_Default
            // 
            this.buttonX_Default.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_Default.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_Default.Location = new System.Drawing.Point(294, 479);
            this.buttonX_Default.Name = "buttonX_Default";
            this.buttonX_Default.Size = new System.Drawing.Size(75, 23);
            this.buttonX_Default.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_Default.TabIndex = 1;
            this.buttonX_Default.Text = "默认";
            // 
            // DeviceInputSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 521);
            this.Controls.Add(this.buttonX_Default);
            this.Controls.Add(this.buttonX_OK);
            this.Controls.Add(this.buttonX_Cancel);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeviceInputSetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "设备输入设置";
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabControlPanel_Property.ResumeLayout(false);
            this.groupBox_OutViewMode.ResumeLayout(false);
            this.groupBox_AudioInput.ResumeLayout(false);
            this.groupBox_VideoInput.ResumeLayout(false);
            this.groupBox_ResolutionSet.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.TabControl tabControl1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel_Property;
        private DevComponents.DotNetBar.TabItem tabItem_Property;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel_DeviceSet;
        private DevComponents.DotNetBar.TabItem tabItem_DeviceSet;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel_SyncLock;
        private DevComponents.DotNetBar.TabItem tabItem_SyncLock;
        private DevComponents.DotNetBar.ButtonX buttonX_Cancel;
        private DevComponents.DotNetBar.ButtonX buttonX_OK;
        private DevComponents.DotNetBar.ButtonX buttonX_Default;
        private System.Windows.Forms.GroupBox groupBox_ResolutionSet;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx_InputFormat;
        private DevComponents.Editors.ComboItem comboItem_1080;
        private System.Windows.Forms.GroupBox groupBox_AudioInput;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx_AudioSignal;
        private DevComponents.Editors.ComboItem comboItem5;
        private DevComponents.DotNetBar.LabelX labelX6;
        private System.Windows.Forms.GroupBox groupBox_VideoInput;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX_ConnectStatus;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx_VideoSignal;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx_PicRatio;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx_ColorDepth;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx_ScanMode;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx_Resolution;
        private DevComponents.Editors.ComboItem comboItem_上场优先;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx_帧率;
        private DevComponents.Editors.ComboItem comboItem_25fps;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX_扫描模式;
        private DevComponents.DotNetBar.LabelX labelX_帧率;
        private System.Windows.Forms.GroupBox groupBox_OutViewMode;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx_OutViewDevice;
        private DevComponents.Editors.ComboItem comboItem6;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx_OutModeChannel;
        private DevComponents.Editors.ComboItem comboItem7;
    }
}