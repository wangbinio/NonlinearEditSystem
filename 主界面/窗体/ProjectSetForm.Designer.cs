namespace 主界面.窗体
{
    partial class ProjectSetForm
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
            this.groupBox_视频设置 = new System.Windows.Forms.GroupBox();
            this.labelX_帧率 = new DevComponents.DotNetBar.LabelX();
            this.labelX_扫描模式 = new DevComponents.DotNetBar.LabelX();
            this.comboBoxEx_帧率 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem_25fps = new DevComponents.Editors.ComboItem();
            this.comboBoxEx_上场优先 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem_上场优先 = new DevComponents.Editors.ComboItem();
            this.buttonX_PreferSetCancel = new DevComponents.DotNetBar.ButtonX();
            this.buttonX_PreferSetOK = new DevComponents.DotNetBar.ButtonX();
            this.groupBox_音频设置 = new System.Windows.Forms.GroupBox();
            this.comboBoxEx_采样位 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem_采样位 = new DevComponents.Editors.ComboItem();
            this.comboBoxEx_采样频率 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem_采样频率 = new DevComponents.Editors.ComboItem();
            this.labelX_采样位 = new DevComponents.DotNetBar.LabelX();
            this.labelX_采样频率 = new DevComponents.DotNetBar.LabelX();
            this.labelX_通道类型 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.comboBoxEx_通道类型 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem_通道类型 = new DevComponents.Editors.ComboItem();
            this.comboBoxEx5 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem5 = new DevComponents.Editors.ComboItem();
            this.groupBox_视频设置.SuspendLayout();
            this.groupBox_音频设置.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_视频设置
            // 
            this.groupBox_视频设置.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.groupBox_视频设置.Controls.Add(this.comboBoxEx_上场优先);
            this.groupBox_视频设置.Controls.Add(this.comboBoxEx_帧率);
            this.groupBox_视频设置.Controls.Add(this.labelX_扫描模式);
            this.groupBox_视频设置.Controls.Add(this.labelX_帧率);
            this.groupBox_视频设置.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_视频设置.ForeColor = System.Drawing.Color.Black;
            this.groupBox_视频设置.Location = new System.Drawing.Point(12, 12);
            this.groupBox_视频设置.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_视频设置.Name = "groupBox_视频设置";
            this.groupBox_视频设置.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_视频设置.Size = new System.Drawing.Size(274, 229);
            this.groupBox_视频设置.TabIndex = 0;
            this.groupBox_视频设置.TabStop = false;
            this.groupBox_视频设置.Text = "视频设置";
            // 
            // labelX_帧率
            // 
            this.labelX_帧率.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_帧率.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_帧率.ForeColor = System.Drawing.Color.Black;
            this.labelX_帧率.Location = new System.Drawing.Point(19, 34);
            this.labelX_帧率.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_帧率.Name = "labelX_帧率";
            this.labelX_帧率.Size = new System.Drawing.Size(75, 23);
            this.labelX_帧率.TabIndex = 0;
            this.labelX_帧率.Text = "帧率";
            // 
            // labelX_扫描模式
            // 
            this.labelX_扫描模式.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_扫描模式.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_扫描模式.ForeColor = System.Drawing.Color.Black;
            this.labelX_扫描模式.Location = new System.Drawing.Point(19, 78);
            this.labelX_扫描模式.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_扫描模式.Name = "labelX_扫描模式";
            this.labelX_扫描模式.Size = new System.Drawing.Size(75, 23);
            this.labelX_扫描模式.TabIndex = 0;
            this.labelX_扫描模式.Text = "扫描模式";
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
            this.comboBoxEx_帧率.Location = new System.Drawing.Point(100, 33);
            this.comboBoxEx_帧率.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxEx_帧率.Name = "comboBoxEx_帧率";
            this.comboBoxEx_帧率.Size = new System.Drawing.Size(140, 24);
            this.comboBoxEx_帧率.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx_帧率.TabIndex = 6;
            this.comboBoxEx_帧率.Text = "25.00 fps";
            // 
            // comboItem_25fps
            // 
            this.comboItem_25fps.Text = "25.00 fps";
            // 
            // comboBoxEx_上场优先
            // 
            this.comboBoxEx_上场优先.DisplayMember = "Text";
            this.comboBoxEx_上场优先.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx_上场优先.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEx_上场优先.FormattingEnabled = true;
            this.comboBoxEx_上场优先.ItemHeight = 18;
            this.comboBoxEx_上场优先.Items.AddRange(new object[] {
            this.comboItem_上场优先});
            this.comboBoxEx_上场优先.Location = new System.Drawing.Point(100, 77);
            this.comboBoxEx_上场优先.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxEx_上场优先.Name = "comboBoxEx_上场优先";
            this.comboBoxEx_上场优先.Size = new System.Drawing.Size(140, 24);
            this.comboBoxEx_上场优先.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx_上场优先.TabIndex = 6;
            this.comboBoxEx_上场优先.Text = "上场优先";
            // 
            // comboItem_上场优先
            // 
            this.comboItem_上场优先.Text = "上场优先";
            // 
            // buttonX_PreferSetCancel
            // 
            this.buttonX_PreferSetCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_PreferSetCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_PreferSetCancel.Location = new System.Drawing.Point(498, 263);
            this.buttonX_PreferSetCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonX_PreferSetCancel.Name = "buttonX_PreferSetCancel";
            this.buttonX_PreferSetCancel.Size = new System.Drawing.Size(82, 28);
            this.buttonX_PreferSetCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_PreferSetCancel.TabIndex = 6;
            this.buttonX_PreferSetCancel.TabStop = false;
            this.buttonX_PreferSetCancel.Text = "取消";
            // 
            // buttonX_PreferSetOK
            // 
            this.buttonX_PreferSetOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_PreferSetOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_PreferSetOK.Location = new System.Drawing.Point(410, 263);
            this.buttonX_PreferSetOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonX_PreferSetOK.Name = "buttonX_PreferSetOK";
            this.buttonX_PreferSetOK.Size = new System.Drawing.Size(82, 28);
            this.buttonX_PreferSetOK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_PreferSetOK.TabIndex = 7;
            this.buttonX_PreferSetOK.TabStop = false;
            this.buttonX_PreferSetOK.Text = "确认";
            // 
            // groupBox_音频设置
            // 
            this.groupBox_音频设置.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.groupBox_音频设置.Controls.Add(this.comboBoxEx5);
            this.groupBox_音频设置.Controls.Add(this.comboBoxEx_采样位);
            this.groupBox_音频设置.Controls.Add(this.comboBoxEx_通道类型);
            this.groupBox_音频设置.Controls.Add(this.comboBoxEx_采样频率);
            this.groupBox_音频设置.Controls.Add(this.labelX4);
            this.groupBox_音频设置.Controls.Add(this.labelX_通道类型);
            this.groupBox_音频设置.Controls.Add(this.labelX_采样位);
            this.groupBox_音频设置.Controls.Add(this.labelX_采样频率);
            this.groupBox_音频设置.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_音频设置.ForeColor = System.Drawing.Color.Black;
            this.groupBox_音频设置.Location = new System.Drawing.Point(306, 12);
            this.groupBox_音频设置.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_音频设置.Name = "groupBox_音频设置";
            this.groupBox_音频设置.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_音频设置.Size = new System.Drawing.Size(274, 229);
            this.groupBox_音频设置.TabIndex = 0;
            this.groupBox_音频设置.TabStop = false;
            this.groupBox_音频设置.Text = "视频设置";
            // 
            // comboBoxEx_采样位
            // 
            this.comboBoxEx_采样位.DisplayMember = "Text";
            this.comboBoxEx_采样位.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx_采样位.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEx_采样位.FormattingEnabled = true;
            this.comboBoxEx_采样位.ItemHeight = 18;
            this.comboBoxEx_采样位.Items.AddRange(new object[] {
            this.comboItem_采样位});
            this.comboBoxEx_采样位.Location = new System.Drawing.Point(100, 75);
            this.comboBoxEx_采样位.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxEx_采样位.Name = "comboBoxEx_采样位";
            this.comboBoxEx_采样位.Size = new System.Drawing.Size(140, 24);
            this.comboBoxEx_采样位.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx_采样位.TabIndex = 6;
            this.comboBoxEx_采样位.Text = "采样位";
            // 
            // comboItem_采样位
            // 
            this.comboItem_采样位.Text = "采样位";
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
            this.comboBoxEx_采样频率.Location = new System.Drawing.Point(100, 33);
            this.comboBoxEx_采样频率.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxEx_采样频率.Name = "comboBoxEx_采样频率";
            this.comboBoxEx_采样频率.Size = new System.Drawing.Size(140, 24);
            this.comboBoxEx_采样频率.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx_采样频率.TabIndex = 6;
            this.comboBoxEx_采样频率.Text = "采样频率";
            // 
            // comboItem_采样频率
            // 
            this.comboItem_采样频率.Text = "采样频率";
            // 
            // labelX_采样位
            // 
            this.labelX_采样位.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_采样位.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_采样位.ForeColor = System.Drawing.Color.Black;
            this.labelX_采样位.Location = new System.Drawing.Point(19, 78);
            this.labelX_采样位.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_采样位.Name = "labelX_采样位";
            this.labelX_采样位.Size = new System.Drawing.Size(75, 23);
            this.labelX_采样位.TabIndex = 0;
            this.labelX_采样位.Text = "采样位";
            // 
            // labelX_采样频率
            // 
            this.labelX_采样频率.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_采样频率.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_采样频率.ForeColor = System.Drawing.Color.Black;
            this.labelX_采样频率.Location = new System.Drawing.Point(19, 34);
            this.labelX_采样频率.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_采样频率.Name = "labelX_采样频率";
            this.labelX_采样频率.Size = new System.Drawing.Size(75, 23);
            this.labelX_采样频率.TabIndex = 0;
            this.labelX_采样频率.Text = "采样频率";
            // 
            // labelX_通道类型
            // 
            this.labelX_通道类型.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX_通道类型.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_通道类型.ForeColor = System.Drawing.Color.Black;
            this.labelX_通道类型.Location = new System.Drawing.Point(19, 122);
            this.labelX_通道类型.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX_通道类型.Name = "labelX_通道类型";
            this.labelX_通道类型.Size = new System.Drawing.Size(75, 23);
            this.labelX_通道类型.TabIndex = 0;
            this.labelX_通道类型.Text = "通道类型";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(19, 166);
            this.labelX4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 0;
            this.labelX4.Text = "扫描模式";
            // 
            // comboBoxEx_通道类型
            // 
            this.comboBoxEx_通道类型.DisplayMember = "Text";
            this.comboBoxEx_通道类型.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx_通道类型.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEx_通道类型.FormattingEnabled = true;
            this.comboBoxEx_通道类型.ItemHeight = 18;
            this.comboBoxEx_通道类型.Items.AddRange(new object[] {
            this.comboItem_通道类型});
            this.comboBoxEx_通道类型.Location = new System.Drawing.Point(100, 121);
            this.comboBoxEx_通道类型.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxEx_通道类型.Name = "comboBoxEx_通道类型";
            this.comboBoxEx_通道类型.Size = new System.Drawing.Size(140, 24);
            this.comboBoxEx_通道类型.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx_通道类型.TabIndex = 6;
            this.comboBoxEx_通道类型.Text = "通道类型";
            // 
            // comboItem_通道类型
            // 
            this.comboItem_通道类型.Text = "通道类型";
            // 
            // comboBoxEx5
            // 
            this.comboBoxEx5.DisplayMember = "Text";
            this.comboBoxEx5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx5.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEx5.FormattingEnabled = true;
            this.comboBoxEx5.ItemHeight = 18;
            this.comboBoxEx5.Items.AddRange(new object[] {
            this.comboItem5});
            this.comboBoxEx5.Location = new System.Drawing.Point(100, 165);
            this.comboBoxEx5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxEx5.Name = "comboBoxEx5";
            this.comboBoxEx5.Size = new System.Drawing.Size(140, 24);
            this.comboBoxEx5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx5.TabIndex = 6;
            this.comboBoxEx5.Text = "淡入淡出";
            // 
            // comboItem5
            // 
            this.comboItem5.Text = "淡入淡出";
            // 
            // ProjectSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 304);
            this.Controls.Add(this.buttonX_PreferSetCancel);
            this.Controls.Add(this.buttonX_PreferSetOK);
            this.Controls.Add(this.groupBox_音频设置);
            this.Controls.Add(this.groupBox_视频设置);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProjectSetForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "工程设置";
            this.groupBox_视频设置.ResumeLayout(false);
            this.groupBox_音频设置.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_视频设置;
        private DevComponents.DotNetBar.LabelX labelX_扫描模式;
        private DevComponents.DotNetBar.LabelX labelX_帧率;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx_上场优先;
        private DevComponents.Editors.ComboItem comboItem_上场优先;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx_帧率;
        private DevComponents.Editors.ComboItem comboItem_25fps;
        private DevComponents.DotNetBar.ButtonX buttonX_PreferSetCancel;
        private DevComponents.DotNetBar.ButtonX buttonX_PreferSetOK;
        private DevComponents.DotNetBar.LabelX labelX_采样频率;
        private DevComponents.DotNetBar.LabelX labelX_采样位;
        private System.Windows.Forms.GroupBox groupBox_音频设置;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx5;
        private DevComponents.Editors.ComboItem comboItem5;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx_采样位;
        private DevComponents.Editors.ComboItem comboItem_采样位;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx_通道类型;
        private DevComponents.Editors.ComboItem comboItem_通道类型;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx_采样频率;
        private DevComponents.Editors.ComboItem comboItem_采样频率;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX_通道类型;
    }
}