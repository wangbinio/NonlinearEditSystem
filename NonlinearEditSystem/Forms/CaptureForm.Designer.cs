namespace 主界面.窗体
{
    partial class CaptureForm
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
            this.groupBox_SDI采集设置 = new System.Windows.Forms.GroupBox();
            this.textBoxX_CapInfos = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX_AddFileName = new DevComponents.DotNetBar.ButtonX();
            this.buttonX_DeviceSet = new DevComponents.DotNetBar.ButtonX();
            this.buttonX_FormatSet = new DevComponents.DotNetBar.ButtonX();
            this.buttonX_ScanFilePath = new DevComponents.DotNetBar.ButtonX();
            this.buttonX_CapCardExitPoint = new DevComponents.DotNetBar.ButtonX();
            this.buttonX__CapCardEnterPoint = new DevComponents.DotNetBar.ButtonX();
            this.textBoxX_FileName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX_FilePath = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX_CardName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.comboBoxEx_FileStorePos = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem_硬盘 = new DevComponents.Editors.ComboItem();
            this.comboBoxEx_InputFormat = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem_1080 = new DevComponents.Editors.ComboItem();
            this.labelX_文件名 = new DevComponents.DotNetBar.LabelX();
            this.labelX_路径 = new DevComponents.DotNetBar.LabelX();
            this.labelX_时长 = new DevComponents.DotNetBar.LabelX();
            this.labelX_TimeLength = new DevComponents.DotNetBar.LabelX();
            this.labelX_CardExitPoint = new DevComponents.DotNetBar.LabelX();
            this.labelX_磁带出点 = new DevComponents.DotNetBar.LabelX();
            this.labelX_CardEnterPoint = new DevComponents.DotNetBar.LabelX();
            this.labelX_磁带入点 = new DevComponents.DotNetBar.LabelX();
            this.labelX_磁带名 = new DevComponents.DotNetBar.LabelX();
            this.labelX_采集素材存放 = new DevComponents.DotNetBar.LabelX();
            this.labelX_输入格式 = new DevComponents.DotNetBar.LabelX();
            this.groupBox_IPCapSet = new System.Windows.Forms.GroupBox();
            this.integerInput_Port = new DevComponents.Editors.IntegerInput();
            this.ipAddressInput_IP = new DevComponents.Editors.IpAddressInput();
            this.buttonX_Connect = new DevComponents.DotNetBar.ButtonX();
            this.labelX_Port = new DevComponents.DotNetBar.LabelX();
            this.labelX_IP = new DevComponents.DotNetBar.LabelX();
            this.groupBox_CapControl = new System.Windows.Forms.GroupBox();
            this.progressBarX_CapProgress = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.labelX_DiskVolumn = new DevComponents.DotNetBar.LabelX();
            this.buttonX_AddAllCaps = new DevComponents.DotNetBar.ButtonX();
            this.buttonX_CapBegin = new DevComponents.DotNetBar.ButtonX();
            this.buttonX_CapPause = new DevComponents.DotNetBar.ButtonX();
            this.buttonX_CapStop = new DevComponents.DotNetBar.ButtonX();
            this.buttonX_CapDel = new DevComponents.DotNetBar.ButtonX();
            this.labelX_CapTime = new DevComponents.DotNetBar.LabelX();
            this.groupBox_Preview = new System.Windows.Forms.GroupBox();
            this.slider_PreviewTime = new DevComponents.DotNetBar.Controls.Slider();
            this.panelEx_Preview = new DevComponents.DotNetBar.PanelEx();
            this.labelX_PreviewTime = new DevComponents.DotNetBar.LabelX();
            this.groupBox_SDI采集设置.SuspendLayout();
            this.groupBox_IPCapSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.integerInput_Port)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipAddressInput_IP)).BeginInit();
            this.groupBox_CapControl.SuspendLayout();
            this.groupBox_Preview.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_SDI采集设置
            // 
            this.groupBox_SDI采集设置.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.groupBox_SDI采集设置.Controls.Add(this.textBoxX_CapInfos);
            this.groupBox_SDI采集设置.Controls.Add(this.buttonX_AddFileName);
            this.groupBox_SDI采集设置.Controls.Add(this.buttonX_DeviceSet);
            this.groupBox_SDI采集设置.Controls.Add(this.buttonX_FormatSet);
            this.groupBox_SDI采集设置.Controls.Add(this.buttonX_ScanFilePath);
            this.groupBox_SDI采集设置.Controls.Add(this.buttonX_CapCardExitPoint);
            this.groupBox_SDI采集设置.Controls.Add(this.buttonX__CapCardEnterPoint);
            this.groupBox_SDI采集设置.Controls.Add(this.textBoxX_FileName);
            this.groupBox_SDI采集设置.Controls.Add(this.textBoxX_FilePath);
            this.groupBox_SDI采集设置.Controls.Add(this.textBoxX_CardName);
            this.groupBox_SDI采集设置.Controls.Add(this.comboBoxEx_FileStorePos);
            this.groupBox_SDI采集设置.Controls.Add(this.comboBoxEx_InputFormat);
            this.groupBox_SDI采集设置.Controls.Add(this.labelX_文件名);
            this.groupBox_SDI采集设置.Controls.Add(this.labelX_路径);
            this.groupBox_SDI采集设置.Controls.Add(this.labelX_时长);
            this.groupBox_SDI采集设置.Controls.Add(this.labelX_TimeLength);
            this.groupBox_SDI采集设置.Controls.Add(this.labelX_CardExitPoint);
            this.groupBox_SDI采集设置.Controls.Add(this.labelX_磁带出点);
            this.groupBox_SDI采集设置.Controls.Add(this.labelX_CardEnterPoint);
            this.groupBox_SDI采集设置.Controls.Add(this.labelX_磁带入点);
            this.groupBox_SDI采集设置.Controls.Add(this.labelX_磁带名);
            this.groupBox_SDI采集设置.Controls.Add(this.labelX_采集素材存放);
            this.groupBox_SDI采集设置.Controls.Add(this.labelX_输入格式);
            this.groupBox_SDI采集设置.ForeColor = System.Drawing.Color.Black;
            this.groupBox_SDI采集设置.Location = new System.Drawing.Point(12, 2);
            this.groupBox_SDI采集设置.Name = "groupBox_SDI采集设置";
            this.groupBox_SDI采集设置.Size = new System.Drawing.Size(403, 580);
            this.groupBox_SDI采集设置.TabIndex = 0;
            this.groupBox_SDI采集设置.TabStop = false;
            this.groupBox_SDI采集设置.Text = "SDI采集设置";
            // 
            // textBoxX_CapInfos
            // 
            this.textBoxX_CapInfos.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX_CapInfos.Border.Class = "TextBoxBorder";
            this.textBoxX_CapInfos.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX_CapInfos.DisabledBackColor = System.Drawing.Color.White;
            this.textBoxX_CapInfos.ForeColor = System.Drawing.Color.Black;
            this.textBoxX_CapInfos.Location = new System.Drawing.Point(6, 282);
            this.textBoxX_CapInfos.Multiline = true;
            this.textBoxX_CapInfos.Name = "textBoxX_CapInfos";
            this.textBoxX_CapInfos.PreventEnterBeep = true;
            this.textBoxX_CapInfos.Size = new System.Drawing.Size(390, 191);
            this.textBoxX_CapInfos.TabIndex = 8;
            this.textBoxX_CapInfos.TabStop = false;
            this.textBoxX_CapInfos.Text = "采集信息";
            // 
            // buttonX_AddFileName
            // 
            this.buttonX_AddFileName.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_AddFileName.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_AddFileName.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.buttonX_AddFileName.Location = new System.Drawing.Point(300, 251);
            this.buttonX_AddFileName.Name = "buttonX_AddFileName";
            this.buttonX_AddFileName.Size = new System.Drawing.Size(26, 23);
            this.buttonX_AddFileName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_AddFileName.TabIndex = 7;
            this.buttonX_AddFileName.Text = "+ ";
            // 
            // buttonX_DeviceSet
            // 
            this.buttonX_DeviceSet.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_DeviceSet.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_DeviceSet.Location = new System.Drawing.Point(206, 479);
            this.buttonX_DeviceSet.Name = "buttonX_DeviceSet";
            this.buttonX_DeviceSet.Size = new System.Drawing.Size(190, 23);
            this.buttonX_DeviceSet.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_DeviceSet.TabIndex = 10;
            this.buttonX_DeviceSet.Text = "设备设置...";
            // 
            // buttonX_FormatSet
            // 
            this.buttonX_FormatSet.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_FormatSet.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_FormatSet.Location = new System.Drawing.Point(6, 479);
            this.buttonX_FormatSet.Name = "buttonX_FormatSet";
            this.buttonX_FormatSet.Size = new System.Drawing.Size(190, 23);
            this.buttonX_FormatSet.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_FormatSet.TabIndex = 9;
            this.buttonX_FormatSet.Text = "格式设置...";
            // 
            // buttonX_ScanFilePath
            // 
            this.buttonX_ScanFilePath.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_ScanFilePath.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_ScanFilePath.Location = new System.Drawing.Point(300, 220);
            this.buttonX_ScanFilePath.Name = "buttonX_ScanFilePath";
            this.buttonX_ScanFilePath.Size = new System.Drawing.Size(96, 23);
            this.buttonX_ScanFilePath.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_ScanFilePath.TabIndex = 5;
            this.buttonX_ScanFilePath.Text = "浏览...";
            // 
            // buttonX_CapCardExitPoint
            // 
            this.buttonX_CapCardExitPoint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_CapCardExitPoint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_CapCardExitPoint.Location = new System.Drawing.Point(300, 158);
            this.buttonX_CapCardExitPoint.Name = "buttonX_CapCardExitPoint";
            this.buttonX_CapCardExitPoint.Size = new System.Drawing.Size(96, 23);
            this.buttonX_CapCardExitPoint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_CapCardExitPoint.TabIndex = 4;
            this.buttonX_CapCardExitPoint.Text = "采集磁带出点";
            // 
            // buttonX__CapCardEnterPoint
            // 
            this.buttonX__CapCardEnterPoint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX__CapCardEnterPoint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX__CapCardEnterPoint.Location = new System.Drawing.Point(300, 126);
            this.buttonX__CapCardEnterPoint.Name = "buttonX__CapCardEnterPoint";
            this.buttonX__CapCardEnterPoint.Size = new System.Drawing.Size(96, 23);
            this.buttonX__CapCardEnterPoint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX__CapCardEnterPoint.TabIndex = 3;
            this.buttonX__CapCardEnterPoint.Text = "采集磁带入点";
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
            this.textBoxX_FileName.Location = new System.Drawing.Point(101, 251);
            this.textBoxX_FileName.Name = "textBoxX_FileName";
            this.textBoxX_FileName.PreventEnterBeep = true;
            this.textBoxX_FileName.Size = new System.Drawing.Size(193, 23);
            this.textBoxX_FileName.TabIndex = 6;
            this.textBoxX_FileName.Text = "文件";
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
            this.textBoxX_FilePath.Location = new System.Drawing.Point(101, 220);
            this.textBoxX_FilePath.Name = "textBoxX_FilePath";
            this.textBoxX_FilePath.PreventEnterBeep = true;
            this.textBoxX_FilePath.Size = new System.Drawing.Size(193, 23);
            this.textBoxX_FilePath.TabIndex = 100;
            this.textBoxX_FilePath.TabStop = false;
            // 
            // textBoxX_CardName
            // 
            this.textBoxX_CardName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX_CardName.Border.Class = "TextBoxBorder";
            this.textBoxX_CardName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX_CardName.DisabledBackColor = System.Drawing.Color.White;
            this.textBoxX_CardName.ForeColor = System.Drawing.Color.Black;
            this.textBoxX_CardName.Location = new System.Drawing.Point(101, 97);
            this.textBoxX_CardName.Name = "textBoxX_CardName";
            this.textBoxX_CardName.PreventEnterBeep = true;
            this.textBoxX_CardName.Size = new System.Drawing.Size(295, 23);
            this.textBoxX_CardName.TabIndex = 2;
            this.textBoxX_CardName.Text = "默认磁带";
            // 
            // comboBoxEx_FileStorePos
            // 
            this.comboBoxEx_FileStorePos.DisplayMember = "Text";
            this.comboBoxEx_FileStorePos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx_FileStorePos.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEx_FileStorePos.FormattingEnabled = true;
            this.comboBoxEx_FileStorePos.ItemHeight = 18;
            this.comboBoxEx_FileStorePos.Items.AddRange(new object[] {
            this.comboItem_硬盘});
            this.comboBoxEx_FileStorePos.Location = new System.Drawing.Point(101, 64);
            this.comboBoxEx_FileStorePos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxEx_FileStorePos.Name = "comboBoxEx_FileStorePos";
            this.comboBoxEx_FileStorePos.Size = new System.Drawing.Size(295, 24);
            this.comboBoxEx_FileStorePos.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx_FileStorePos.TabIndex = 1;
            this.comboBoxEx_FileStorePos.Text = "硬盘";
            // 
            // comboItem_硬盘
            // 
            this.comboItem_硬盘.Text = "硬盘";
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
            this.comboBoxEx_InputFormat.Location = new System.Drawing.Point(101, 33);
            this.comboBoxEx_InputFormat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxEx_InputFormat.Name = "comboBoxEx_InputFormat";
            this.comboBoxEx_InputFormat.Size = new System.Drawing.Size(295, 24);
            this.comboBoxEx_InputFormat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx_InputFormat.TabIndex = 0;
            this.comboBoxEx_InputFormat.Text = "单目 HD(1920*1080)@50i";
            // 
            // comboItem_1080
            // 
            this.comboItem_1080.Text = "单目 HD(1920*1080)@50i";
            // 
            // labelX_文件名
            // 
            this.labelX_文件名.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_文件名.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_文件名.ForeColor = System.Drawing.Color.Black;
            this.labelX_文件名.Location = new System.Drawing.Point(6, 251);
            this.labelX_文件名.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_文件名.Name = "labelX_文件名";
            this.labelX_文件名.Size = new System.Drawing.Size(75, 23);
            this.labelX_文件名.TabIndex = 7;
            this.labelX_文件名.Text = "文件名";
            // 
            // labelX_路径
            // 
            this.labelX_路径.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_路径.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_路径.ForeColor = System.Drawing.Color.Black;
            this.labelX_路径.Location = new System.Drawing.Point(6, 220);
            this.labelX_路径.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_路径.Name = "labelX_路径";
            this.labelX_路径.Size = new System.Drawing.Size(75, 23);
            this.labelX_路径.TabIndex = 7;
            this.labelX_路径.Text = "路径";
            // 
            // labelX_时长
            // 
            this.labelX_时长.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_时长.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_时长.ForeColor = System.Drawing.Color.Black;
            this.labelX_时长.Location = new System.Drawing.Point(6, 189);
            this.labelX_时长.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_时长.Name = "labelX_时长";
            this.labelX_时长.Size = new System.Drawing.Size(75, 23);
            this.labelX_时长.TabIndex = 7;
            this.labelX_时长.Text = "时长";
            // 
            // labelX_TimeLength
            // 
            this.labelX_TimeLength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_TimeLength.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_TimeLength.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labelX_TimeLength.FontBold = true;
            this.labelX_TimeLength.ForeColor = System.Drawing.Color.Black;
            this.labelX_TimeLength.Location = new System.Drawing.Point(101, 189);
            this.labelX_TimeLength.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_TimeLength.Name = "labelX_TimeLength";
            this.labelX_TimeLength.Size = new System.Drawing.Size(92, 23);
            this.labelX_TimeLength.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX_TimeLength.TabIndex = 7;
            this.labelX_TimeLength.Text = "00:00:00:00";
            // 
            // labelX_CardExitPoint
            // 
            this.labelX_CardExitPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_CardExitPoint.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_CardExitPoint.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labelX_CardExitPoint.FontBold = true;
            this.labelX_CardExitPoint.ForeColor = System.Drawing.Color.Black;
            this.labelX_CardExitPoint.Location = new System.Drawing.Point(101, 158);
            this.labelX_CardExitPoint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_CardExitPoint.Name = "labelX_CardExitPoint";
            this.labelX_CardExitPoint.Size = new System.Drawing.Size(92, 23);
            this.labelX_CardExitPoint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX_CardExitPoint.TabIndex = 7;
            this.labelX_CardExitPoint.Text = "00:00:00:00";
            // 
            // labelX_磁带出点
            // 
            this.labelX_磁带出点.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_磁带出点.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_磁带出点.ForeColor = System.Drawing.Color.Black;
            this.labelX_磁带出点.Location = new System.Drawing.Point(6, 158);
            this.labelX_磁带出点.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_磁带出点.Name = "labelX_磁带出点";
            this.labelX_磁带出点.Size = new System.Drawing.Size(75, 23);
            this.labelX_磁带出点.TabIndex = 7;
            this.labelX_磁带出点.Text = "磁带出点";
            // 
            // labelX_CardEnterPoint
            // 
            this.labelX_CardEnterPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_CardEnterPoint.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_CardEnterPoint.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labelX_CardEnterPoint.FontBold = true;
            this.labelX_CardEnterPoint.ForeColor = System.Drawing.Color.Black;
            this.labelX_CardEnterPoint.Location = new System.Drawing.Point(101, 127);
            this.labelX_CardEnterPoint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_CardEnterPoint.Name = "labelX_CardEnterPoint";
            this.labelX_CardEnterPoint.Size = new System.Drawing.Size(92, 23);
            this.labelX_CardEnterPoint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX_CardEnterPoint.TabIndex = 7;
            this.labelX_CardEnterPoint.Text = "00:00:00:00";
            // 
            // labelX_磁带入点
            // 
            this.labelX_磁带入点.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_磁带入点.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_磁带入点.ForeColor = System.Drawing.Color.Black;
            this.labelX_磁带入点.Location = new System.Drawing.Point(6, 127);
            this.labelX_磁带入点.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_磁带入点.Name = "labelX_磁带入点";
            this.labelX_磁带入点.Size = new System.Drawing.Size(75, 23);
            this.labelX_磁带入点.TabIndex = 7;
            this.labelX_磁带入点.Text = "磁带入点";
            // 
            // labelX_磁带名
            // 
            this.labelX_磁带名.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_磁带名.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_磁带名.ForeColor = System.Drawing.Color.Black;
            this.labelX_磁带名.Location = new System.Drawing.Point(6, 96);
            this.labelX_磁带名.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_磁带名.Name = "labelX_磁带名";
            this.labelX_磁带名.Size = new System.Drawing.Size(75, 23);
            this.labelX_磁带名.TabIndex = 7;
            this.labelX_磁带名.Text = "磁带名";
            // 
            // labelX_采集素材存放
            // 
            this.labelX_采集素材存放.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_采集素材存放.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_采集素材存放.ForeColor = System.Drawing.Color.Black;
            this.labelX_采集素材存放.Location = new System.Drawing.Point(6, 65);
            this.labelX_采集素材存放.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_采集素材存放.Name = "labelX_采集素材存放";
            this.labelX_采集素材存放.Size = new System.Drawing.Size(99, 23);
            this.labelX_采集素材存放.TabIndex = 7;
            this.labelX_采集素材存放.Text = "采集素材存放到";
            // 
            // labelX_输入格式
            // 
            this.labelX_输入格式.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_输入格式.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_输入格式.ForeColor = System.Drawing.Color.Black;
            this.labelX_输入格式.Location = new System.Drawing.Point(6, 34);
            this.labelX_输入格式.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_输入格式.Name = "labelX_输入格式";
            this.labelX_输入格式.Size = new System.Drawing.Size(75, 23);
            this.labelX_输入格式.TabIndex = 7;
            this.labelX_输入格式.Text = "输入格式";
            // 
            // groupBox_IPCapSet
            // 
            this.groupBox_IPCapSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.groupBox_IPCapSet.Controls.Add(this.integerInput_Port);
            this.groupBox_IPCapSet.Controls.Add(this.ipAddressInput_IP);
            this.groupBox_IPCapSet.Controls.Add(this.buttonX_Connect);
            this.groupBox_IPCapSet.Controls.Add(this.labelX_Port);
            this.groupBox_IPCapSet.Controls.Add(this.labelX_IP);
            this.groupBox_IPCapSet.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox_IPCapSet.ForeColor = System.Drawing.Color.Black;
            this.groupBox_IPCapSet.Location = new System.Drawing.Point(12, 600);
            this.groupBox_IPCapSet.Name = "groupBox_IPCapSet";
            this.groupBox_IPCapSet.Size = new System.Drawing.Size(403, 90);
            this.groupBox_IPCapSet.TabIndex = 1;
            this.groupBox_IPCapSet.TabStop = false;
            this.groupBox_IPCapSet.Text = "IP采集设置";
            // 
            // integerInput_Port
            // 
            this.integerInput_Port.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.integerInput_Port.BackgroundStyle.Class = "DateTimeInputBackground";
            this.integerInput_Port.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.integerInput_Port.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.integerInput_Port.ForeColor = System.Drawing.Color.Black;
            this.integerInput_Port.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.integerInput_Port.Location = new System.Drawing.Point(78, 54);
            this.integerInput_Port.MinValue = 0;
            this.integerInput_Port.Name = "integerInput_Port";
            this.integerInput_Port.ShowUpDown = true;
            this.integerInput_Port.Size = new System.Drawing.Size(238, 23);
            this.integerInput_Port.TabIndex = 12;
            this.integerInput_Port.Value = 4502;
            // 
            // ipAddressInput_IP
            // 
            this.ipAddressInput_IP.AutoOverwrite = true;
            this.ipAddressInput_IP.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.ipAddressInput_IP.BackgroundStyle.Class = "DateTimeInputBackground";
            this.ipAddressInput_IP.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ipAddressInput_IP.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.ipAddressInput_IP.ButtonFreeText.Visible = true;
            this.ipAddressInput_IP.ForeColor = System.Drawing.Color.Black;
            this.ipAddressInput_IP.Location = new System.Drawing.Point(78, 25);
            this.ipAddressInput_IP.Name = "ipAddressInput_IP";
            this.ipAddressInput_IP.Size = new System.Drawing.Size(318, 23);
            this.ipAddressInput_IP.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ipAddressInput_IP.TabIndex = 11;
            this.ipAddressInput_IP.Value = "127.0.0.1";
            // 
            // buttonX_Connect
            // 
            this.buttonX_Connect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_Connect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_Connect.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.buttonX_Connect.Location = new System.Drawing.Point(324, 54);
            this.buttonX_Connect.Name = "buttonX_Connect";
            this.buttonX_Connect.Size = new System.Drawing.Size(72, 23);
            this.buttonX_Connect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_Connect.TabIndex = 13;
            this.buttonX_Connect.Text = "连接";
            // 
            // labelX_Port
            // 
            this.labelX_Port.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_Port.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_Port.ForeColor = System.Drawing.Color.Black;
            this.labelX_Port.Location = new System.Drawing.Point(6, 54);
            this.labelX_Port.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_Port.Name = "labelX_Port";
            this.labelX_Port.Size = new System.Drawing.Size(66, 23);
            this.labelX_Port.TabIndex = 12;
            this.labelX_Port.Text = "端口";
            // 
            // labelX_IP
            // 
            this.labelX_IP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_IP.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_IP.ForeColor = System.Drawing.Color.Black;
            this.labelX_IP.Location = new System.Drawing.Point(6, 23);
            this.labelX_IP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_IP.Name = "labelX_IP";
            this.labelX_IP.Size = new System.Drawing.Size(66, 23);
            this.labelX_IP.TabIndex = 13;
            this.labelX_IP.Text = "IP";
            // 
            // groupBox_CapControl
            // 
            this.groupBox_CapControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.groupBox_CapControl.Controls.Add(this.progressBarX_CapProgress);
            this.groupBox_CapControl.Controls.Add(this.labelX_DiskVolumn);
            this.groupBox_CapControl.Controls.Add(this.buttonX_AddAllCaps);
            this.groupBox_CapControl.Controls.Add(this.buttonX_CapBegin);
            this.groupBox_CapControl.Controls.Add(this.buttonX_CapPause);
            this.groupBox_CapControl.Controls.Add(this.buttonX_CapStop);
            this.groupBox_CapControl.Controls.Add(this.buttonX_CapDel);
            this.groupBox_CapControl.Controls.Add(this.labelX_CapTime);
            this.groupBox_CapControl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox_CapControl.ForeColor = System.Drawing.Color.Black;
            this.groupBox_CapControl.Location = new System.Drawing.Point(12, 710);
            this.groupBox_CapControl.Name = "groupBox_CapControl";
            this.groupBox_CapControl.Size = new System.Drawing.Size(403, 90);
            this.groupBox_CapControl.TabIndex = 2;
            this.groupBox_CapControl.TabStop = false;
            this.groupBox_CapControl.Text = "采集控制";
            // 
            // progressBarX_CapProgress
            // 
            this.progressBarX_CapProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.progressBarX_CapProgress.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressBarX_CapProgress.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.progressBarX_CapProgress.ForeColor = System.Drawing.Color.Black;
            this.progressBarX_CapProgress.Location = new System.Drawing.Point(78, 23);
            this.progressBarX_CapProgress.Name = "progressBarX_CapProgress";
            this.progressBarX_CapProgress.Size = new System.Drawing.Size(232, 23);
            this.progressBarX_CapProgress.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.progressBarX_CapProgress.TabIndex = 14;
            this.progressBarX_CapProgress.Text = "50%";
            this.progressBarX_CapProgress.TextVisible = true;
            this.progressBarX_CapProgress.Value = 50;
            // 
            // labelX_DiskVolumn
            // 
            this.labelX_DiskVolumn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_DiskVolumn.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_DiskVolumn.ForeColor = System.Drawing.Color.Black;
            this.labelX_DiskVolumn.Location = new System.Drawing.Point(6, 23);
            this.labelX_DiskVolumn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_DiskVolumn.Name = "labelX_DiskVolumn";
            this.labelX_DiskVolumn.Size = new System.Drawing.Size(66, 23);
            this.labelX_DiskVolumn.TabIndex = 13;
            this.labelX_DiskVolumn.Text = "硬盘空间";
            // 
            // buttonX_AddAllCaps
            // 
            this.buttonX_AddAllCaps.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_AddAllCaps.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_AddAllCaps.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.buttonX_AddAllCaps.Location = new System.Drawing.Point(6, 53);
            this.buttonX_AddAllCaps.Name = "buttonX_AddAllCaps";
            this.buttonX_AddAllCaps.Size = new System.Drawing.Size(78, 23);
            this.buttonX_AddAllCaps.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_AddAllCaps.TabIndex = 14;
            this.buttonX_AddAllCaps.Text = "加入批采集";
            // 
            // buttonX_CapBegin
            // 
            this.buttonX_CapBegin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_CapBegin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_CapBegin.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.buttonX_CapBegin.Location = new System.Drawing.Point(90, 53);
            this.buttonX_CapBegin.Name = "buttonX_CapBegin";
            this.buttonX_CapBegin.Size = new System.Drawing.Size(72, 23);
            this.buttonX_CapBegin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_CapBegin.TabIndex = 15;
            this.buttonX_CapBegin.Text = "采集";
            // 
            // buttonX_CapPause
            // 
            this.buttonX_CapPause.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_CapPause.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_CapPause.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.buttonX_CapPause.Location = new System.Drawing.Point(168, 53);
            this.buttonX_CapPause.Name = "buttonX_CapPause";
            this.buttonX_CapPause.Size = new System.Drawing.Size(72, 23);
            this.buttonX_CapPause.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_CapPause.TabIndex = 16;
            this.buttonX_CapPause.Text = "暂停";
            // 
            // buttonX_CapStop
            // 
            this.buttonX_CapStop.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_CapStop.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_CapStop.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.buttonX_CapStop.Location = new System.Drawing.Point(246, 53);
            this.buttonX_CapStop.Name = "buttonX_CapStop";
            this.buttonX_CapStop.Size = new System.Drawing.Size(72, 23);
            this.buttonX_CapStop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_CapStop.TabIndex = 17;
            this.buttonX_CapStop.Text = "停止";
            // 
            // buttonX_CapDel
            // 
            this.buttonX_CapDel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_CapDel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_CapDel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.buttonX_CapDel.Location = new System.Drawing.Point(324, 53);
            this.buttonX_CapDel.Name = "buttonX_CapDel";
            this.buttonX_CapDel.Size = new System.Drawing.Size(72, 23);
            this.buttonX_CapDel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_CapDel.TabIndex = 18;
            this.buttonX_CapDel.Text = "丢弃";
            // 
            // labelX_CapTime
            // 
            this.labelX_CapTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_CapTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_CapTime.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labelX_CapTime.FontBold = true;
            this.labelX_CapTime.ForeColor = System.Drawing.Color.Black;
            this.labelX_CapTime.Location = new System.Drawing.Point(316, 23);
            this.labelX_CapTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_CapTime.Name = "labelX_CapTime";
            this.labelX_CapTime.Size = new System.Drawing.Size(80, 23);
            this.labelX_CapTime.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX_CapTime.TabIndex = 7;
            this.labelX_CapTime.Text = "00:00:00:00";
            // 
            // groupBox_Preview
            // 
            this.groupBox_Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.groupBox_Preview.Controls.Add(this.slider_PreviewTime);
            this.groupBox_Preview.Controls.Add(this.panelEx_Preview);
            this.groupBox_Preview.Controls.Add(this.labelX_PreviewTime);
            this.groupBox_Preview.ForeColor = System.Drawing.Color.Black;
            this.groupBox_Preview.Location = new System.Drawing.Point(431, 2);
            this.groupBox_Preview.Name = "groupBox_Preview";
            this.groupBox_Preview.Size = new System.Drawing.Size(403, 502);
            this.groupBox_Preview.TabIndex = 3;
            this.groupBox_Preview.TabStop = false;
            this.groupBox_Preview.Text = "预览";
            // 
            // slider_PreviewTime
            // 
            this.slider_PreviewTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.slider_PreviewTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.slider_PreviewTime.ForeColor = System.Drawing.Color.Black;
            this.slider_PreviewTime.LabelVisible = false;
            this.slider_PreviewTime.Location = new System.Drawing.Point(0, 473);
            this.slider_PreviewTime.Name = "slider_PreviewTime";
            this.slider_PreviewTime.Size = new System.Drawing.Size(292, 23);
            this.slider_PreviewTime.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.slider_PreviewTime.TabIndex = 2;
            this.slider_PreviewTime.Value = 50;
            // 
            // panelEx_Preview
            // 
            this.panelEx_Preview.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx_Preview.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx_Preview.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx_Preview.Location = new System.Drawing.Point(6, 22);
            this.panelEx_Preview.Name = "panelEx_Preview";
            this.panelEx_Preview.Size = new System.Drawing.Size(391, 443);
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
            this.labelX_PreviewTime.Location = new System.Drawing.Point(305, 472);
            this.labelX_PreviewTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_PreviewTime.Name = "labelX_PreviewTime";
            this.labelX_PreviewTime.Size = new System.Drawing.Size(92, 23);
            this.labelX_PreviewTime.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX_PreviewTime.TabIndex = 7;
            this.labelX_PreviewTime.Text = "00:00:00:00";
            // 
            // CaptureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 814);
            this.Controls.Add(this.groupBox_Preview);
            this.Controls.Add(this.groupBox_CapControl);
            this.Controls.Add(this.groupBox_IPCapSet);
            this.Controls.Add(this.groupBox_SDI采集设置);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CaptureForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "采集";
            this.groupBox_SDI采集设置.ResumeLayout(false);
            this.groupBox_IPCapSet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.integerInput_Port)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipAddressInput_IP)).EndInit();
            this.groupBox_CapControl.ResumeLayout(false);
            this.groupBox_Preview.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_SDI采集设置;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx_FileStorePos;
        private DevComponents.Editors.ComboItem comboItem_硬盘;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx_InputFormat;
        private DevComponents.Editors.ComboItem comboItem_1080;
        private DevComponents.DotNetBar.LabelX labelX_文件名;
        private DevComponents.DotNetBar.LabelX labelX_路径;
        private DevComponents.DotNetBar.LabelX labelX_时长;
        private DevComponents.DotNetBar.LabelX labelX_磁带出点;
        private DevComponents.DotNetBar.LabelX labelX_磁带入点;
        private DevComponents.DotNetBar.LabelX labelX_磁带名;
        private DevComponents.DotNetBar.LabelX labelX_采集素材存放;
        private DevComponents.DotNetBar.LabelX labelX_输入格式;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX_FileName;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX_FilePath;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX_CardName;
        private DevComponents.DotNetBar.LabelX labelX_TimeLength;
        private DevComponents.DotNetBar.LabelX labelX_CardExitPoint;
        private DevComponents.DotNetBar.LabelX labelX_CardEnterPoint;
        private DevComponents.DotNetBar.ButtonX buttonX_AddFileName;
        private DevComponents.DotNetBar.ButtonX buttonX_ScanFilePath;
        private DevComponents.DotNetBar.ButtonX buttonX_CapCardExitPoint;
        private DevComponents.DotNetBar.ButtonX buttonX__CapCardEnterPoint;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX_CapInfos;
        private DevComponents.DotNetBar.ButtonX buttonX_DeviceSet;
        private DevComponents.DotNetBar.ButtonX buttonX_FormatSet;
        private System.Windows.Forms.GroupBox groupBox_IPCapSet;
        private DevComponents.Editors.IntegerInput integerInput_Port;
        private DevComponents.Editors.IpAddressInput ipAddressInput_IP;
        private DevComponents.DotNetBar.ButtonX buttonX_Connect;
        private DevComponents.DotNetBar.LabelX labelX_Port;
        private DevComponents.DotNetBar.LabelX labelX_IP;
        private System.Windows.Forms.GroupBox groupBox_CapControl;
        private DevComponents.DotNetBar.LabelX labelX_DiskVolumn;
        private DevComponents.DotNetBar.LabelX labelX_CapTime;
        private DevComponents.DotNetBar.Controls.ProgressBarX progressBarX_CapProgress;
        private DevComponents.DotNetBar.ButtonX buttonX_AddAllCaps;
        private DevComponents.DotNetBar.ButtonX buttonX_CapBegin;
        private DevComponents.DotNetBar.ButtonX buttonX_CapPause;
        private DevComponents.DotNetBar.ButtonX buttonX_CapStop;
        private DevComponents.DotNetBar.ButtonX buttonX_CapDel;
        private System.Windows.Forms.GroupBox groupBox_Preview;
        private DevComponents.DotNetBar.PanelEx panelEx_Preview;
        private DevComponents.DotNetBar.Controls.Slider slider_PreviewTime;
        private DevComponents.DotNetBar.LabelX labelX_PreviewTime;
    }
}