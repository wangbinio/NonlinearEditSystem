namespace 主界面.窗体
{
    partial class PreferenceSetForm
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
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.styleManagerAmbient1 = new DevComponents.DotNetBar.StyleManagerAmbient(this.components);
            this.tabControlPanel_ProjDefaultSet = new DevComponents.DotNetBar.TabControlPanel();
            this.comboBoxEx_自动保存时间间隔 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboBoxEx_上下变换模式 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboBoxEx_默认音频转场 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboBoxEx_默认视频转场 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.doubleInput_默认字幕滚屏速度 = new DevComponents.Editors.DoubleInput();
            this.intInput_默认转场长度 = new DevComponents.Editors.IntegerInput();
            this.intInput_最大撤销步数 = new DevComponents.Editors.IntegerInput();
            this.intInput_单帧图像默认长度 = new DevComponents.Editors.IntegerInput();
            this.intInput_流程图默认长度 = new DevComponents.Editors.IntegerInput();
            this.intInput_初始音频轨道数 = new DevComponents.Editors.IntegerInput();
            this.intInput_初始视频轨道数 = new DevComponents.Editors.IntegerInput();
            this.buttonX_StyleSet = new DevComponents.DotNetBar.ButtonX();
            this.labelX_自动保存时间间隔 = new DevComponents.DotNetBar.LabelX();
            this.labelX_上下变换模式 = new DevComponents.DotNetBar.LabelX();
            this.labelX_默认滚屏速度 = new DevComponents.DotNetBar.LabelX();
            this.labelX_默认转场长度 = new DevComponents.DotNetBar.LabelX();
            this.labelX_单帧图像默认长度 = new DevComponents.DotNetBar.LabelX();
            this.labelX_默认音频转场 = new DevComponents.DotNetBar.LabelX();
            this.labelX_流程图默认长度 = new DevComponents.DotNetBar.LabelX();
            this.labelX_默认视频转场 = new DevComponents.DotNetBar.LabelX();
            this.labelX_初始音频轨道数 = new DevComponents.DotNetBar.LabelX();
            this.labelX_撤销步数 = new DevComponents.DotNetBar.LabelX();
            this.labelX_初始视频轨道数 = new DevComponents.DotNetBar.LabelX();
            this.tabItem_ProjDefaultSet = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControl_PreferSet = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel_TemplateLibSet = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItem_TemplateLibSet = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel_VideoDefalutSet = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItem_VideoDefalutSet = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel_AudioDefalutSet = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItem_AudioDefalutSet = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel_CancelSet = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItem_CancelSet = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel_GridSet = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItem_GridSet = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel_LUTSet = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItem_LUTSet = new DevComponents.DotNetBar.TabItem(this.components);
            this.buttonX_PreferSetOK = new DevComponents.DotNetBar.ButtonX();
            this.buttonX_PreferSetCancel = new DevComponents.DotNetBar.ButtonX();
            this.comboItem_淡入淡出 = new DevComponents.Editors.ComboItem();
            this.comboItem_线性交叉式淡入淡出 = new DevComponents.Editors.ComboItem();
            this.comboItem_信封模式 = new DevComponents.Editors.ComboItem();
            this.comboItem_10分钟 = new DevComponents.Editors.ComboItem();
            this.comboItem_15分钟 = new DevComponents.Editors.ComboItem();
            this.comboItem_30分钟 = new DevComponents.Editors.ComboItem();
            this.tabControlPanel_ProjDefaultSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doubleInput_默认字幕滚屏速度)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intInput_默认转场长度)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intInput_最大撤销步数)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intInput_单帧图像默认长度)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intInput_流程图默认长度)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intInput_初始音频轨道数)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intInput_初始视频轨道数)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl_PreferSet)).BeginInit();
            this.tabControl_PreferSet.SuspendLayout();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Light;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64))))));
            // 
            // tabControlPanel_ProjDefaultSet
            // 
            this.tabControlPanel_ProjDefaultSet.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.tabControlPanel_ProjDefaultSet.Controls.Add(this.comboBoxEx_自动保存时间间隔);
            this.tabControlPanel_ProjDefaultSet.Controls.Add(this.comboBoxEx_上下变换模式);
            this.tabControlPanel_ProjDefaultSet.Controls.Add(this.comboBoxEx_默认音频转场);
            this.tabControlPanel_ProjDefaultSet.Controls.Add(this.comboBoxEx_默认视频转场);
            this.tabControlPanel_ProjDefaultSet.Controls.Add(this.doubleInput_默认字幕滚屏速度);
            this.tabControlPanel_ProjDefaultSet.Controls.Add(this.intInput_默认转场长度);
            this.tabControlPanel_ProjDefaultSet.Controls.Add(this.intInput_最大撤销步数);
            this.tabControlPanel_ProjDefaultSet.Controls.Add(this.intInput_单帧图像默认长度);
            this.tabControlPanel_ProjDefaultSet.Controls.Add(this.intInput_流程图默认长度);
            this.tabControlPanel_ProjDefaultSet.Controls.Add(this.intInput_初始音频轨道数);
            this.tabControlPanel_ProjDefaultSet.Controls.Add(this.intInput_初始视频轨道数);
            this.tabControlPanel_ProjDefaultSet.Controls.Add(this.buttonX_StyleSet);
            this.tabControlPanel_ProjDefaultSet.Controls.Add(this.labelX_自动保存时间间隔);
            this.tabControlPanel_ProjDefaultSet.Controls.Add(this.labelX_上下变换模式);
            this.tabControlPanel_ProjDefaultSet.Controls.Add(this.labelX_默认滚屏速度);
            this.tabControlPanel_ProjDefaultSet.Controls.Add(this.labelX_默认转场长度);
            this.tabControlPanel_ProjDefaultSet.Controls.Add(this.labelX_单帧图像默认长度);
            this.tabControlPanel_ProjDefaultSet.Controls.Add(this.labelX_默认音频转场);
            this.tabControlPanel_ProjDefaultSet.Controls.Add(this.labelX_流程图默认长度);
            this.tabControlPanel_ProjDefaultSet.Controls.Add(this.labelX_默认视频转场);
            this.tabControlPanel_ProjDefaultSet.Controls.Add(this.labelX_初始音频轨道数);
            this.tabControlPanel_ProjDefaultSet.Controls.Add(this.labelX_撤销步数);
            this.tabControlPanel_ProjDefaultSet.Controls.Add(this.labelX_初始视频轨道数);
            this.tabControlPanel_ProjDefaultSet.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanel_ProjDefaultSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel_ProjDefaultSet.Location = new System.Drawing.Point(0, 28);
            this.tabControlPanel_ProjDefaultSet.Name = "tabControlPanel_ProjDefaultSet";
            this.tabControlPanel_ProjDefaultSet.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel_ProjDefaultSet.Size = new System.Drawing.Size(784, 404);
            this.tabControlPanel_ProjDefaultSet.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.tabControlPanel_ProjDefaultSet.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel_ProjDefaultSet.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(198)))));
            this.tabControlPanel_ProjDefaultSet.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel_ProjDefaultSet.Style.GradientAngle = 90;
            this.tabControlPanel_ProjDefaultSet.TabIndex = 1;
            this.tabControlPanel_ProjDefaultSet.TabItem = this.tabItem_ProjDefaultSet;
            // 
            // comboBoxEx_自动保存时间间隔
            // 
            this.comboBoxEx_自动保存时间间隔.DisplayMember = "Text";
            this.comboBoxEx_自动保存时间间隔.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx_自动保存时间间隔.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEx_自动保存时间间隔.FormattingEnabled = true;
            this.comboBoxEx_自动保存时间间隔.ItemHeight = 18;
            this.comboBoxEx_自动保存时间间隔.Items.AddRange(new object[] {
            this.comboItem_10分钟,
            this.comboItem_15分钟,
            this.comboItem_30分钟});
            this.comboBoxEx_自动保存时间间隔.Location = new System.Drawing.Point(148, 360);
            this.comboBoxEx_自动保存时间间隔.Name = "comboBoxEx_自动保存时间间隔";
            this.comboBoxEx_自动保存时间间隔.Size = new System.Drawing.Size(165, 24);
            this.comboBoxEx_自动保存时间间隔.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx_自动保存时间间隔.TabIndex = 5;
            this.comboBoxEx_自动保存时间间隔.Text = "10分钟";
            // 
            // comboBoxEx_上下变换模式
            // 
            this.comboBoxEx_上下变换模式.DisplayMember = "Text";
            this.comboBoxEx_上下变换模式.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx_上下变换模式.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEx_上下变换模式.FormattingEnabled = true;
            this.comboBoxEx_上下变换模式.ItemHeight = 18;
            this.comboBoxEx_上下变换模式.Items.AddRange(new object[] {
            this.comboItem_信封模式});
            this.comboBoxEx_上下变换模式.Location = new System.Drawing.Point(148, 326);
            this.comboBoxEx_上下变换模式.Name = "comboBoxEx_上下变换模式";
            this.comboBoxEx_上下变换模式.Size = new System.Drawing.Size(165, 24);
            this.comboBoxEx_上下变换模式.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx_上下变换模式.TabIndex = 5;
            this.comboBoxEx_上下变换模式.Text = "信封模式";
            // 
            // comboBoxEx_默认音频转场
            // 
            this.comboBoxEx_默认音频转场.DisplayMember = "Text";
            this.comboBoxEx_默认音频转场.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx_默认音频转场.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEx_默认音频转场.FormattingEnabled = true;
            this.comboBoxEx_默认音频转场.ItemHeight = 18;
            this.comboBoxEx_默认音频转场.Items.AddRange(new object[] {
            this.comboItem_线性交叉式淡入淡出});
            this.comboBoxEx_默认音频转场.Location = new System.Drawing.Point(148, 258);
            this.comboBoxEx_默认音频转场.Name = "comboBoxEx_默认音频转场";
            this.comboBoxEx_默认音频转场.Size = new System.Drawing.Size(165, 24);
            this.comboBoxEx_默认音频转场.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx_默认音频转场.TabIndex = 5;
            this.comboBoxEx_默认音频转场.Text = "线性交叉式淡入淡出";
            // 
            // comboBoxEx_默认视频转场
            // 
            this.comboBoxEx_默认视频转场.DisplayMember = "Text";
            this.comboBoxEx_默认视频转场.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx_默认视频转场.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEx_默认视频转场.FormattingEnabled = true;
            this.comboBoxEx_默认视频转场.ItemHeight = 18;
            this.comboBoxEx_默认视频转场.Items.AddRange(new object[] {
            this.comboItem_淡入淡出});
            this.comboBoxEx_默认视频转场.Location = new System.Drawing.Point(148, 224);
            this.comboBoxEx_默认视频转场.Name = "comboBoxEx_默认视频转场";
            this.comboBoxEx_默认视频转场.Size = new System.Drawing.Size(107, 24);
            this.comboBoxEx_默认视频转场.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx_默认视频转场.TabIndex = 5;
            this.comboBoxEx_默认视频转场.Text = "淡入淡出";
            // 
            // doubleInput_默认字幕滚屏速度
            // 
            this.doubleInput_默认字幕滚屏速度.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.doubleInput_默认字幕滚屏速度.BackgroundStyle.Class = "DateTimeInputBackground";
            this.doubleInput_默认字幕滚屏速度.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.doubleInput_默认字幕滚屏速度.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.doubleInput_默认字幕滚屏速度.ForeColor = System.Drawing.Color.Black;
            this.doubleInput_默认字幕滚屏速度.Increment = 1D;
            this.doubleInput_默认字幕滚屏速度.Location = new System.Drawing.Point(148, 157);
            this.doubleInput_默认字幕滚屏速度.MaxValue = 20D;
            this.doubleInput_默认字幕滚屏速度.MinValue = 0D;
            this.doubleInput_默认字幕滚屏速度.Name = "doubleInput_默认字幕滚屏速度";
            this.doubleInput_默认字幕滚屏速度.ShowUpDown = true;
            this.doubleInput_默认字幕滚屏速度.Size = new System.Drawing.Size(165, 23);
            this.doubleInput_默认字幕滚屏速度.TabIndex = 4;
            this.doubleInput_默认字幕滚屏速度.Value = 5D;
            // 
            // intInput_默认转场长度
            // 
            this.intInput_默认转场长度.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.intInput_默认转场长度.BackgroundStyle.Class = "DateTimeInputBackground";
            this.intInput_默认转场长度.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.intInput_默认转场长度.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.intInput_默认转场长度.ForeColor = System.Drawing.Color.Black;
            this.intInput_默认转场长度.Location = new System.Drawing.Point(148, 293);
            this.intInput_默认转场长度.MaxValue = 10;
            this.intInput_默认转场长度.MinValue = 0;
            this.intInput_默认转场长度.Name = "intInput_默认转场长度";
            this.intInput_默认转场长度.ShowUpDown = true;
            this.intInput_默认转场长度.Size = new System.Drawing.Size(165, 23);
            this.intInput_默认转场长度.TabIndex = 3;
            this.intInput_默认转场长度.Value = 1;
            // 
            // intInput_最大撤销步数
            // 
            this.intInput_最大撤销步数.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.intInput_最大撤销步数.BackgroundStyle.Class = "DateTimeInputBackground";
            this.intInput_最大撤销步数.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.intInput_最大撤销步数.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.intInput_最大撤销步数.ForeColor = System.Drawing.Color.Black;
            this.intInput_最大撤销步数.Location = new System.Drawing.Point(148, 191);
            this.intInput_最大撤销步数.MaxValue = 50;
            this.intInput_最大撤销步数.MinValue = 1;
            this.intInput_最大撤销步数.Name = "intInput_最大撤销步数";
            this.intInput_最大撤销步数.ShowUpDown = true;
            this.intInput_最大撤销步数.Size = new System.Drawing.Size(165, 23);
            this.intInput_最大撤销步数.TabIndex = 3;
            this.intInput_最大撤销步数.Value = 10;
            // 
            // intInput_单帧图像默认长度
            // 
            this.intInput_单帧图像默认长度.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.intInput_单帧图像默认长度.BackgroundStyle.Class = "DateTimeInputBackground";
            this.intInput_单帧图像默认长度.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.intInput_单帧图像默认长度.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.intInput_单帧图像默认长度.ForeColor = System.Drawing.Color.Black;
            this.intInput_单帧图像默认长度.Location = new System.Drawing.Point(148, 123);
            this.intInput_单帧图像默认长度.Name = "intInput_单帧图像默认长度";
            this.intInput_单帧图像默认长度.ShowUpDown = true;
            this.intInput_单帧图像默认长度.Size = new System.Drawing.Size(165, 23);
            this.intInput_单帧图像默认长度.TabIndex = 3;
            this.intInput_单帧图像默认长度.Value = 5;
            // 
            // intInput_流程图默认长度
            // 
            this.intInput_流程图默认长度.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.intInput_流程图默认长度.BackgroundStyle.Class = "DateTimeInputBackground";
            this.intInput_流程图默认长度.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.intInput_流程图默认长度.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.intInput_流程图默认长度.ForeColor = System.Drawing.Color.Black;
            this.intInput_流程图默认长度.Location = new System.Drawing.Point(148, 86);
            this.intInput_流程图默认长度.MaxValue = 600;
            this.intInput_流程图默认长度.MinValue = 1;
            this.intInput_流程图默认长度.Name = "intInput_流程图默认长度";
            this.intInput_流程图默认长度.ShowUpDown = true;
            this.intInput_流程图默认长度.Size = new System.Drawing.Size(165, 23);
            this.intInput_流程图默认长度.TabIndex = 3;
            this.intInput_流程图默认长度.Value = 4;
            // 
            // intInput_初始音频轨道数
            // 
            this.intInput_初始音频轨道数.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.intInput_初始音频轨道数.BackgroundStyle.Class = "DateTimeInputBackground";
            this.intInput_初始音频轨道数.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.intInput_初始音频轨道数.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.intInput_初始音频轨道数.ForeColor = System.Drawing.Color.Black;
            this.intInput_初始音频轨道数.Location = new System.Drawing.Point(148, 52);
            this.intInput_初始音频轨道数.MaxValue = 10;
            this.intInput_初始音频轨道数.MinValue = 1;
            this.intInput_初始音频轨道数.Name = "intInput_初始音频轨道数";
            this.intInput_初始音频轨道数.ShowUpDown = true;
            this.intInput_初始音频轨道数.Size = new System.Drawing.Size(165, 23);
            this.intInput_初始音频轨道数.TabIndex = 3;
            this.intInput_初始音频轨道数.Value = 2;
            // 
            // intInput_初始视频轨道数
            // 
            this.intInput_初始视频轨道数.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.intInput_初始视频轨道数.BackgroundStyle.Class = "DateTimeInputBackground";
            this.intInput_初始视频轨道数.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.intInput_初始视频轨道数.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.intInput_初始视频轨道数.ForeColor = System.Drawing.Color.Black;
            this.intInput_初始视频轨道数.Location = new System.Drawing.Point(148, 18);
            this.intInput_初始视频轨道数.MaxValue = 10;
            this.intInput_初始视频轨道数.MinValue = 1;
            this.intInput_初始视频轨道数.Name = "intInput_初始视频轨道数";
            this.intInput_初始视频轨道数.ShowUpDown = true;
            this.intInput_初始视频轨道数.Size = new System.Drawing.Size(165, 23);
            this.intInput_初始视频轨道数.TabIndex = 3;
            this.intInput_初始视频轨道数.Value = 2;
            // 
            // buttonX_StyleSet
            // 
            this.buttonX_StyleSet.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_StyleSet.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_StyleSet.Location = new System.Drawing.Point(262, 224);
            this.buttonX_StyleSet.Name = "buttonX_StyleSet";
            this.buttonX_StyleSet.Size = new System.Drawing.Size(51, 26);
            this.buttonX_StyleSet.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_StyleSet.TabIndex = 2;
            this.buttonX_StyleSet.Text = "样式";
            // 
            // labelX_自动保存时间间隔
            // 
            this.labelX_自动保存时间间隔.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_自动保存时间间隔.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_自动保存时间间隔.ForeColor = System.Drawing.Color.Black;
            this.labelX_自动保存时间间隔.Location = new System.Drawing.Point(12, 358);
            this.labelX_自动保存时间间隔.Name = "labelX_自动保存时间间隔";
            this.labelX_自动保存时间间隔.Size = new System.Drawing.Size(130, 26);
            this.labelX_自动保存时间间隔.TabIndex = 0;
            this.labelX_自动保存时间间隔.Text = "自动保存时间间隔";
            // 
            // labelX_上下变换模式
            // 
            this.labelX_上下变换模式.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_上下变换模式.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_上下变换模式.ForeColor = System.Drawing.Color.Black;
            this.labelX_上下变换模式.Location = new System.Drawing.Point(12, 324);
            this.labelX_上下变换模式.Name = "labelX_上下变换模式";
            this.labelX_上下变换模式.Size = new System.Drawing.Size(130, 26);
            this.labelX_上下变换模式.TabIndex = 0;
            this.labelX_上下变换模式.Text = "上下变换模式";
            // 
            // labelX_默认滚屏速度
            // 
            this.labelX_默认滚屏速度.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_默认滚屏速度.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_默认滚屏速度.ForeColor = System.Drawing.Color.Black;
            this.labelX_默认滚屏速度.Location = new System.Drawing.Point(12, 154);
            this.labelX_默认滚屏速度.Name = "labelX_默认滚屏速度";
            this.labelX_默认滚屏速度.Size = new System.Drawing.Size(130, 26);
            this.labelX_默认滚屏速度.TabIndex = 0;
            this.labelX_默认滚屏速度.Text = "滚屏字幕默认滚屏速度";
            // 
            // labelX_默认转场长度
            // 
            this.labelX_默认转场长度.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_默认转场长度.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_默认转场长度.ForeColor = System.Drawing.Color.Black;
            this.labelX_默认转场长度.Location = new System.Drawing.Point(12, 290);
            this.labelX_默认转场长度.Name = "labelX_默认转场长度";
            this.labelX_默认转场长度.Size = new System.Drawing.Size(130, 26);
            this.labelX_默认转场长度.TabIndex = 0;
            this.labelX_默认转场长度.Text = "默认转场长度(秒)";
            // 
            // labelX_单帧图像默认长度
            // 
            this.labelX_单帧图像默认长度.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_单帧图像默认长度.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_单帧图像默认长度.ForeColor = System.Drawing.Color.Black;
            this.labelX_单帧图像默认长度.Location = new System.Drawing.Point(12, 120);
            this.labelX_单帧图像默认长度.Name = "labelX_单帧图像默认长度";
            this.labelX_单帧图像默认长度.Size = new System.Drawing.Size(130, 26);
            this.labelX_单帧图像默认长度.TabIndex = 0;
            this.labelX_单帧图像默认长度.Text = "单帧图像默认长度(秒)";
            // 
            // labelX_默认音频转场
            // 
            this.labelX_默认音频转场.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_默认音频转场.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_默认音频转场.ForeColor = System.Drawing.Color.Black;
            this.labelX_默认音频转场.Location = new System.Drawing.Point(12, 256);
            this.labelX_默认音频转场.Name = "labelX_默认音频转场";
            this.labelX_默认音频转场.Size = new System.Drawing.Size(130, 26);
            this.labelX_默认音频转场.TabIndex = 0;
            this.labelX_默认音频转场.Text = "默认音频转场";
            // 
            // labelX_流程图默认长度
            // 
            this.labelX_流程图默认长度.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_流程图默认长度.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_流程图默认长度.ForeColor = System.Drawing.Color.Black;
            this.labelX_流程图默认长度.Location = new System.Drawing.Point(12, 86);
            this.labelX_流程图默认长度.Name = "labelX_流程图默认长度";
            this.labelX_流程图默认长度.Size = new System.Drawing.Size(130, 26);
            this.labelX_流程图默认长度.TabIndex = 0;
            this.labelX_流程图默认长度.Text = "流程图默认长度(秒)";
            // 
            // labelX_默认视频转场
            // 
            this.labelX_默认视频转场.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_默认视频转场.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_默认视频转场.ForeColor = System.Drawing.Color.Black;
            this.labelX_默认视频转场.Location = new System.Drawing.Point(12, 222);
            this.labelX_默认视频转场.Name = "labelX_默认视频转场";
            this.labelX_默认视频转场.Size = new System.Drawing.Size(130, 26);
            this.labelX_默认视频转场.TabIndex = 0;
            this.labelX_默认视频转场.Text = "默认视频转场";
            // 
            // labelX_初始音频轨道数
            // 
            this.labelX_初始音频轨道数.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_初始音频轨道数.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_初始音频轨道数.ForeColor = System.Drawing.Color.Black;
            this.labelX_初始音频轨道数.Location = new System.Drawing.Point(12, 52);
            this.labelX_初始音频轨道数.Name = "labelX_初始音频轨道数";
            this.labelX_初始音频轨道数.Size = new System.Drawing.Size(130, 26);
            this.labelX_初始音频轨道数.TabIndex = 0;
            this.labelX_初始音频轨道数.Text = "初始音频轨道数";
            // 
            // labelX_撤销步数
            // 
            this.labelX_撤销步数.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_撤销步数.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_撤销步数.ForeColor = System.Drawing.Color.Black;
            this.labelX_撤销步数.Location = new System.Drawing.Point(12, 188);
            this.labelX_撤销步数.Name = "labelX_撤销步数";
            this.labelX_撤销步数.Size = new System.Drawing.Size(130, 26);
            this.labelX_撤销步数.TabIndex = 0;
            this.labelX_撤销步数.Text = "最大撤销/恢复步骤数";
            // 
            // labelX_初始视频轨道数
            // 
            this.labelX_初始视频轨道数.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_初始视频轨道数.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_初始视频轨道数.ForeColor = System.Drawing.Color.Black;
            this.labelX_初始视频轨道数.Location = new System.Drawing.Point(12, 18);
            this.labelX_初始视频轨道数.Name = "labelX_初始视频轨道数";
            this.labelX_初始视频轨道数.Size = new System.Drawing.Size(130, 26);
            this.labelX_初始视频轨道数.TabIndex = 0;
            this.labelX_初始视频轨道数.Text = "初始视频轨道数";
            // 
            // tabItem_ProjDefaultSet
            // 
            this.tabItem_ProjDefaultSet.AttachedControl = this.tabControlPanel_ProjDefaultSet;
            this.tabItem_ProjDefaultSet.Name = "tabItem_ProjDefaultSet";
            this.tabItem_ProjDefaultSet.Text = "工程偏好设置";
            // 
            // tabControl_PreferSet
            // 
            this.tabControl_PreferSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.tabControl_PreferSet.CanReorderTabs = false;
            this.tabControl_PreferSet.Controls.Add(this.tabControlPanel_ProjDefaultSet);
            this.tabControl_PreferSet.Controls.Add(this.tabControlPanel_TemplateLibSet);
            this.tabControl_PreferSet.Controls.Add(this.tabControlPanel_VideoDefalutSet);
            this.tabControl_PreferSet.Controls.Add(this.tabControlPanel_AudioDefalutSet);
            this.tabControl_PreferSet.Controls.Add(this.tabControlPanel_CancelSet);
            this.tabControl_PreferSet.Controls.Add(this.tabControlPanel_GridSet);
            this.tabControl_PreferSet.Controls.Add(this.tabControlPanel_LUTSet);
            this.tabControl_PreferSet.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl_PreferSet.ForeColor = System.Drawing.Color.Black;
            this.tabControl_PreferSet.Location = new System.Drawing.Point(0, 0);
            this.tabControl_PreferSet.Name = "tabControl_PreferSet";
            this.tabControl_PreferSet.Padding = new System.Windows.Forms.Padding(3);
            this.tabControl_PreferSet.SelectedTabFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl_PreferSet.SelectedTabIndex = 0;
            this.tabControl_PreferSet.Size = new System.Drawing.Size(784, 432);
            this.tabControl_PreferSet.Style = DevComponents.DotNetBar.eTabStripStyle.Metro;
            this.tabControl_PreferSet.TabIndex = 2;
            this.tabControl_PreferSet.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl_PreferSet.Tabs.Add(this.tabItem_ProjDefaultSet);
            this.tabControl_PreferSet.Tabs.Add(this.tabItem_VideoDefalutSet);
            this.tabControl_PreferSet.Tabs.Add(this.tabItem_AudioDefalutSet);
            this.tabControl_PreferSet.Tabs.Add(this.tabItem_CancelSet);
            this.tabControl_PreferSet.Tabs.Add(this.tabItem_GridSet);
            this.tabControl_PreferSet.Tabs.Add(this.tabItem_LUTSet);
            this.tabControl_PreferSet.Tabs.Add(this.tabItem_TemplateLibSet);
            this.tabControl_PreferSet.Text = "tabControl_PreferSet";
            // 
            // tabControlPanel_TemplateLibSet
            // 
            this.tabControlPanel_TemplateLibSet.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanel_TemplateLibSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel_TemplateLibSet.Location = new System.Drawing.Point(0, 28);
            this.tabControlPanel_TemplateLibSet.Name = "tabControlPanel_TemplateLibSet";
            this.tabControlPanel_TemplateLibSet.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel_TemplateLibSet.Size = new System.Drawing.Size(784, 404);
            this.tabControlPanel_TemplateLibSet.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.tabControlPanel_TemplateLibSet.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel_TemplateLibSet.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(198)))));
            this.tabControlPanel_TemplateLibSet.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel_TemplateLibSet.Style.GradientAngle = 90;
            this.tabControlPanel_TemplateLibSet.TabIndex = 25;
            this.tabControlPanel_TemplateLibSet.TabItem = this.tabItem_TemplateLibSet;
            // 
            // tabItem_TemplateLibSet
            // 
            this.tabItem_TemplateLibSet.AttachedControl = this.tabControlPanel_TemplateLibSet;
            this.tabItem_TemplateLibSet.Name = "tabItem_TemplateLibSet";
            this.tabItem_TemplateLibSet.Text = "模板库设置";
            // 
            // tabControlPanel_VideoDefalutSet
            // 
            this.tabControlPanel_VideoDefalutSet.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanel_VideoDefalutSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel_VideoDefalutSet.Location = new System.Drawing.Point(0, 28);
            this.tabControlPanel_VideoDefalutSet.Name = "tabControlPanel_VideoDefalutSet";
            this.tabControlPanel_VideoDefalutSet.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel_VideoDefalutSet.Size = new System.Drawing.Size(784, 404);
            this.tabControlPanel_VideoDefalutSet.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.tabControlPanel_VideoDefalutSet.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel_VideoDefalutSet.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(198)))));
            this.tabControlPanel_VideoDefalutSet.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel_VideoDefalutSet.Style.GradientAngle = 90;
            this.tabControlPanel_VideoDefalutSet.TabIndex = 5;
            this.tabControlPanel_VideoDefalutSet.TabItem = this.tabItem_VideoDefalutSet;
            // 
            // tabItem_VideoDefalutSet
            // 
            this.tabItem_VideoDefalutSet.AttachedControl = this.tabControlPanel_VideoDefalutSet;
            this.tabItem_VideoDefalutSet.Name = "tabItem_VideoDefalutSet";
            this.tabItem_VideoDefalutSet.Text = "视频默认设置";
            // 
            // tabControlPanel_AudioDefalutSet
            // 
            this.tabControlPanel_AudioDefalutSet.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanel_AudioDefalutSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel_AudioDefalutSet.Location = new System.Drawing.Point(0, 28);
            this.tabControlPanel_AudioDefalutSet.Name = "tabControlPanel_AudioDefalutSet";
            this.tabControlPanel_AudioDefalutSet.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel_AudioDefalutSet.Size = new System.Drawing.Size(784, 404);
            this.tabControlPanel_AudioDefalutSet.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.tabControlPanel_AudioDefalutSet.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel_AudioDefalutSet.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(198)))));
            this.tabControlPanel_AudioDefalutSet.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel_AudioDefalutSet.Style.GradientAngle = 90;
            this.tabControlPanel_AudioDefalutSet.TabIndex = 9;
            this.tabControlPanel_AudioDefalutSet.TabItem = this.tabItem_AudioDefalutSet;
            // 
            // tabItem_AudioDefalutSet
            // 
            this.tabItem_AudioDefalutSet.AttachedControl = this.tabControlPanel_AudioDefalutSet;
            this.tabItem_AudioDefalutSet.Name = "tabItem_AudioDefalutSet";
            this.tabItem_AudioDefalutSet.Text = "音频默认设置";
            // 
            // tabControlPanel_CancelSet
            // 
            this.tabControlPanel_CancelSet.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanel_CancelSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel_CancelSet.Location = new System.Drawing.Point(0, 28);
            this.tabControlPanel_CancelSet.Name = "tabControlPanel_CancelSet";
            this.tabControlPanel_CancelSet.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel_CancelSet.Size = new System.Drawing.Size(784, 404);
            this.tabControlPanel_CancelSet.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.tabControlPanel_CancelSet.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel_CancelSet.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(198)))));
            this.tabControlPanel_CancelSet.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel_CancelSet.Style.GradientAngle = 90;
            this.tabControlPanel_CancelSet.TabIndex = 13;
            this.tabControlPanel_CancelSet.TabItem = this.tabItem_CancelSet;
            // 
            // tabItem_CancelSet
            // 
            this.tabItem_CancelSet.AttachedControl = this.tabControlPanel_CancelSet;
            this.tabItem_CancelSet.Name = "tabItem_CancelSet";
            this.tabItem_CancelSet.Text = "缓存设置";
            // 
            // tabControlPanel_GridSet
            // 
            this.tabControlPanel_GridSet.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanel_GridSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel_GridSet.Location = new System.Drawing.Point(0, 28);
            this.tabControlPanel_GridSet.Name = "tabControlPanel_GridSet";
            this.tabControlPanel_GridSet.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel_GridSet.Size = new System.Drawing.Size(784, 404);
            this.tabControlPanel_GridSet.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.tabControlPanel_GridSet.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel_GridSet.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(198)))));
            this.tabControlPanel_GridSet.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel_GridSet.Style.GradientAngle = 90;
            this.tabControlPanel_GridSet.TabIndex = 17;
            this.tabControlPanel_GridSet.TabItem = this.tabItem_GridSet;
            // 
            // tabItem_GridSet
            // 
            this.tabItem_GridSet.AttachedControl = this.tabControlPanel_GridSet;
            this.tabItem_GridSet.Name = "tabItem_GridSet";
            this.tabItem_GridSet.Text = "网格设置";
            // 
            // tabControlPanel_LUTSet
            // 
            this.tabControlPanel_LUTSet.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanel_LUTSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel_LUTSet.Location = new System.Drawing.Point(0, 28);
            this.tabControlPanel_LUTSet.Name = "tabControlPanel_LUTSet";
            this.tabControlPanel_LUTSet.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel_LUTSet.Size = new System.Drawing.Size(784, 404);
            this.tabControlPanel_LUTSet.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.tabControlPanel_LUTSet.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel_LUTSet.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(198)))));
            this.tabControlPanel_LUTSet.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel_LUTSet.Style.GradientAngle = 90;
            this.tabControlPanel_LUTSet.TabIndex = 21;
            this.tabControlPanel_LUTSet.TabItem = this.tabItem_LUTSet;
            // 
            // tabItem_LUTSet
            // 
            this.tabItem_LUTSet.AttachedControl = this.tabControlPanel_LUTSet;
            this.tabItem_LUTSet.Name = "tabItem_LUTSet";
            this.tabItem_LUTSet.Text = "LUT设置";
            // 
            // buttonX_PreferSetOK
            // 
            this.buttonX_PreferSetOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_PreferSetOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_PreferSetOK.Location = new System.Drawing.Point(614, 450);
            this.buttonX_PreferSetOK.Name = "buttonX_PreferSetOK";
            this.buttonX_PreferSetOK.Size = new System.Drawing.Size(82, 28);
            this.buttonX_PreferSetOK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_PreferSetOK.TabIndex = 3;
            this.buttonX_PreferSetOK.TabStop = false;
            this.buttonX_PreferSetOK.Text = "确认";
            // 
            // buttonX_PreferSetCancel
            // 
            this.buttonX_PreferSetCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_PreferSetCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_PreferSetCancel.Location = new System.Drawing.Point(702, 450);
            this.buttonX_PreferSetCancel.Name = "buttonX_PreferSetCancel";
            this.buttonX_PreferSetCancel.Size = new System.Drawing.Size(82, 28);
            this.buttonX_PreferSetCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_PreferSetCancel.TabIndex = 3;
            this.buttonX_PreferSetCancel.TabStop = false;
            this.buttonX_PreferSetCancel.Text = "取消";
            // 
            // comboItem_淡入淡出
            // 
            this.comboItem_淡入淡出.Text = "淡入淡出";
            // 
            // comboItem_线性交叉式淡入淡出
            // 
            this.comboItem_线性交叉式淡入淡出.Text = "线性交叉式淡入淡出";
            // 
            // comboItem_信封模式
            // 
            this.comboItem_信封模式.Text = "信封模式";
            // 
            // comboItem_10分钟
            // 
            this.comboItem_10分钟.Text = "10分钟";
            // 
            // comboItem_15分钟
            // 
            this.comboItem_15分钟.Text = "15分钟";
            // 
            // comboItem_30分钟
            // 
            this.comboItem_30分钟.Text = "30分钟";
            // 
            // PreferenceSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 485);
            this.Controls.Add(this.buttonX_PreferSetCancel);
            this.Controls.Add(this.buttonX_PreferSetOK);
            this.Controls.Add(this.tabControl_PreferSet);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PreferenceSetForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "偏好设置";
            this.TopMost = true;
            this.tabControlPanel_ProjDefaultSet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.doubleInput_默认字幕滚屏速度)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intInput_默认转场长度)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intInput_最大撤销步数)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intInput_单帧图像默认长度)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intInput_流程图默认长度)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intInput_初始音频轨道数)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intInput_初始视频轨道数)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl_PreferSet)).EndInit();
            this.tabControl_PreferSet.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.StyleManagerAmbient styleManagerAmbient1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel_ProjDefaultSet;
        private DevComponents.DotNetBar.TabItem tabItem_ProjDefaultSet;
        private DevComponents.DotNetBar.TabControl tabControl_PreferSet;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel_AudioDefalutSet;
        private DevComponents.DotNetBar.TabItem tabItem_AudioDefalutSet;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel_VideoDefalutSet;
        private DevComponents.DotNetBar.TabItem tabItem_VideoDefalutSet;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel_CancelSet;
        private DevComponents.DotNetBar.TabItem tabItem_CancelSet;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel_GridSet;
        private DevComponents.DotNetBar.TabItem tabItem_GridSet;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel_LUTSet;
        private DevComponents.DotNetBar.TabItem tabItem_LUTSet;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel_TemplateLibSet;
        private DevComponents.DotNetBar.TabItem tabItem_TemplateLibSet;
        private DevComponents.DotNetBar.ButtonX buttonX_PreferSetOK;
        private DevComponents.DotNetBar.ButtonX buttonX_PreferSetCancel;
        private DevComponents.DotNetBar.ButtonX buttonX_StyleSet;
        private DevComponents.DotNetBar.LabelX labelX_自动保存时间间隔;
        private DevComponents.DotNetBar.LabelX labelX_上下变换模式;
        private DevComponents.DotNetBar.LabelX labelX_默认滚屏速度;
        private DevComponents.DotNetBar.LabelX labelX_默认转场长度;
        private DevComponents.DotNetBar.LabelX labelX_单帧图像默认长度;
        private DevComponents.DotNetBar.LabelX labelX_默认音频转场;
        private DevComponents.DotNetBar.LabelX labelX_流程图默认长度;
        private DevComponents.DotNetBar.LabelX labelX_默认视频转场;
        private DevComponents.DotNetBar.LabelX labelX_初始音频轨道数;
        private DevComponents.DotNetBar.LabelX labelX_撤销步数;
        private DevComponents.DotNetBar.LabelX labelX_初始视频轨道数;
        private DevComponents.Editors.IntegerInput intInput_初始视频轨道数;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx_自动保存时间间隔;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx_上下变换模式;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx_默认音频转场;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx_默认视频转场;
        private DevComponents.Editors.DoubleInput doubleInput_默认字幕滚屏速度;
        private DevComponents.Editors.IntegerInput intInput_默认转场长度;
        private DevComponents.Editors.IntegerInput intInput_最大撤销步数;
        private DevComponents.Editors.IntegerInput intInput_单帧图像默认长度;
        private DevComponents.Editors.IntegerInput intInput_流程图默认长度;
        private DevComponents.Editors.IntegerInput intInput_初始音频轨道数;
        private DevComponents.Editors.ComboItem comboItem_线性交叉式淡入淡出;
        private DevComponents.Editors.ComboItem comboItem_淡入淡出;
        private DevComponents.Editors.ComboItem comboItem_10分钟;
        private DevComponents.Editors.ComboItem comboItem_15分钟;
        private DevComponents.Editors.ComboItem comboItem_30分钟;
        private DevComponents.Editors.ComboItem comboItem_信封模式;
    }
}