namespace 主界面
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl_Project = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel_Project = new DevComponents.DotNetBar.TabControlPanel();
            this.listView_Files = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList_Files = new System.Windows.Forms.ImageList(this.components);
            this.label_FileInfo = new DevComponents.DotNetBar.LabelX();
            this.tabItem_Project = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItemTemplate = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItem_SpecialEffect = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControl_Sequence = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel_Seq = new DevComponents.DotNetBar.TabControlPanel();
            this.PanelEx_Sequence = new DevComponents.DotNetBar.PanelEx();
            this.timeLineControl_Sequence = new TimeLineControl.TimeLineControl();
            this.tabItem_Sequence = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel_Segment = new DevComponents.DotNetBar.TabControlPanel();
            this.panelEx_Segment = new DevComponents.DotNetBar.PanelEx();
            this.timeLineControl_Segment = new TimeLineControl.TimeLineControl();
            this.tabItem_Segment = new DevComponents.DotNetBar.TabItem(this.components);
            this.工程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.偏好设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工程设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.导入工程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入序列ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入AAFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入配音序列ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.删除未引用的素材ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.工程整理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工程信息统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.最近打开工程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szwbprjToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.撤销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重做ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.配音DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.显示第二效果监视器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.缓存管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.输入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.导入P2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入XDCAMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入SxStoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入E2toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入PPTtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.采集ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打包输出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.录制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设备输出设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.光盘刻录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.输出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainmenuStrip = new System.Windows.Forms.MenuStrip();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.styleManagerAmbient1 = new DevComponents.DotNetBar.StyleManagerAmbient(this.components);
            this.tabControl_TimeLine = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel4 = new DevComponents.DotNetBar.TabControlPanel();
            this.panelEx_TrackContent = new DevComponents.DotNetBar.PanelEx();
            this.panelEx_AudioTrackConment2 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx_AudioTrackConment1 = new DevComponents.DotNetBar.PanelEx();
            this.timeLineControl_MainTL = new TimeLineControl.TimeLineControl();
            this.panelEx_VideoTrackConment2 = new DevComponents.DotNetBar.PanelEx();
            this.VideoFile1 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx_VideoTrackConment1 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx_TrackName = new DevComponents.DotNetBar.PanelEx();
            this.panelEx_VideoName = new DevComponents.DotNetBar.PanelEx();
            this.panelEx_VideoTrackName2 = new DevComponents.DotNetBar.PanelEx();
            this.bar_VideoTrackButtonBar2 = new DevComponents.DotNetBar.Bar();
            this.VideoTrackB2BI_See = new DevComponents.DotNetBar.ButtonItem();
            this.VideoTrackB2BI_Lock = new DevComponents.DotNetBar.ButtonItem();
            this.VideoTrackB2BI_Play = new DevComponents.DotNetBar.ButtonItem();
            this.VideoTrackB2BI_MoveDown = new DevComponents.DotNetBar.ButtonItem();
            this.VideoTrackB2BI_TrackNickName = new DevComponents.DotNetBar.ButtonItem();
            this.panelEx_VideoTrackName1 = new DevComponents.DotNetBar.PanelEx();
            this.bar_VideoTrackButtonBar1 = new DevComponents.DotNetBar.Bar();
            this.VideoTrackB1BI_See = new DevComponents.DotNetBar.ButtonItem();
            this.VideoTrackB1BI_Lock = new DevComponents.DotNetBar.ButtonItem();
            this.VideoTrackB1BI_Play = new DevComponents.DotNetBar.ButtonItem();
            this.VideoTrackB1BI_MoveDown = new DevComponents.DotNetBar.ButtonItem();
            this.VideoTrackB1BI_TrackNickName = new DevComponents.DotNetBar.ButtonItem();
            this.bar_TrackNameToolBar = new DevComponents.DotNetBar.Bar();
            this.buttonItem_DeleteTrack = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem_StoreTrack = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem_TwoToOne = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem_CurrentTime = new DevComponents.DotNetBar.LabelItem();
            this.panelEx_AudioName = new DevComponents.DotNetBar.PanelEx();
            this.panelEx_AudioTrackName2 = new DevComponents.DotNetBar.PanelEx();
            this.bar_AudioTrackButtonBar2 = new DevComponents.DotNetBar.Bar();
            this.AudioTrackB2BI_Listen = new DevComponents.DotNetBar.ButtonItem();
            this.AudioTrackB2BI_Volume = new DevComponents.DotNetBar.ButtonItem();
            this.AudioTrackB2BI_Lock = new DevComponents.DotNetBar.ButtonItem();
            this.AudioTrackB2BI_Play = new DevComponents.DotNetBar.ButtonItem();
            this.AudioTrackB2BI_MoveDown = new DevComponents.DotNetBar.ButtonItem();
            this.AudioTrackB2BI_TrackNickName = new DevComponents.DotNetBar.ButtonItem();
            this.panelEx_AudioTrackName1 = new DevComponents.DotNetBar.PanelEx();
            this.bar_AudioTrackButtonBar1 = new DevComponents.DotNetBar.Bar();
            this.AudioTrackB1BI_Listen = new DevComponents.DotNetBar.ButtonItem();
            this.AudioTrackB1BI_Volume = new DevComponents.DotNetBar.ButtonItem();
            this.AudioTrackB1BI_Lock = new DevComponents.DotNetBar.ButtonItem();
            this.AudioTrackB1BI_Play = new DevComponents.DotNetBar.ButtonItem();
            this.AudioTrackB1BI_MoveDown = new DevComponents.DotNetBar.ButtonItem();
            this.AudioTrackB1BI_TrackNickName = new DevComponents.DotNetBar.ButtonItem();
            this.tabItem_TimeLine = new DevComponents.DotNetBar.TabItem(this.components);
            this.timer_Segment = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl_Project)).BeginInit();
            this.tabControl_Project.SuspendLayout();
            this.tabControlPanel_Project.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl_Sequence)).BeginInit();
            this.tabControl_Sequence.SuspendLayout();
            this.tabControlPanel_Seq.SuspendLayout();
            this.tabControlPanel_Segment.SuspendLayout();
            this.MainmenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl_TimeLine)).BeginInit();
            this.tabControl_TimeLine.SuspendLayout();
            this.tabControlPanel4.SuspendLayout();
            this.panelEx_TrackContent.SuspendLayout();
            this.panelEx_VideoTrackConment2.SuspendLayout();
            this.panelEx_TrackName.SuspendLayout();
            this.panelEx_VideoName.SuspendLayout();
            this.panelEx_VideoTrackName2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar_VideoTrackButtonBar2)).BeginInit();
            this.panelEx_VideoTrackName1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar_VideoTrackButtonBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar_TrackNameToolBar)).BeginInit();
            this.panelEx_AudioName.SuspendLayout();
            this.panelEx_AudioTrackName2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar_AudioTrackButtonBar2)).BeginInit();
            this.panelEx_AudioTrackName1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar_AudioTrackButtonBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_Project
            // 
            this.tabControl_Project.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.tabControl_Project.CanReorderTabs = true;
            this.tabControl_Project.Controls.Add(this.tabControlPanel_Project);
            this.tabControl_Project.Controls.Add(this.tabControlPanel2);
            this.tabControl_Project.Controls.Add(this.tabControlPanel1);
            this.tabControl_Project.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl_Project.ForeColor = System.Drawing.Color.Black;
            this.tabControl_Project.Location = new System.Drawing.Point(0, 25);
            this.tabControl_Project.Name = "tabControl_Project";
            this.tabControl_Project.Padding = new System.Windows.Forms.Padding(3);
            this.tabControl_Project.SelectedTabFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl_Project.SelectedTabIndex = 0;
            this.tabControl_Project.Size = new System.Drawing.Size(773, 403);
            this.tabControl_Project.Style = DevComponents.DotNetBar.eTabStripStyle.Metro;
            this.tabControl_Project.TabIndex = 1;
            this.tabControl_Project.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl_Project.Tabs.Add(this.tabItem_Project);
            this.tabControl_Project.Tabs.Add(this.tabItem_SpecialEffect);
            this.tabControl_Project.Tabs.Add(this.tabItemTemplate);
            this.tabControl_Project.Text = "tabControl_Project";
            // 
            // tabControlPanel_Project
            // 
            this.tabControlPanel_Project.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.tabControlPanel_Project.Controls.Add(this.listView_Files);
            this.tabControlPanel_Project.Controls.Add(this.label_FileInfo);
            this.tabControlPanel_Project.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanel_Project.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel_Project.Location = new System.Drawing.Point(0, 28);
            this.tabControlPanel_Project.Name = "tabControlPanel_Project";
            this.tabControlPanel_Project.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel_Project.Size = new System.Drawing.Size(773, 375);
            this.tabControlPanel_Project.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.tabControlPanel_Project.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel_Project.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(198)))));
            this.tabControlPanel_Project.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel_Project.Style.GradientAngle = 90;
            this.tabControlPanel_Project.TabIndex = 1;
            this.tabControlPanel_Project.TabItem = this.tabItem_Project;
            // 
            // listView_Files
            // 
            this.listView_Files.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.listView_Files.Border.Class = "ListViewBorder";
            this.listView_Files.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.listView_Files.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView_Files.DisabledBackColor = System.Drawing.Color.Empty;
            this.listView_Files.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_Files.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.listView_Files.ForeColor = System.Drawing.Color.Black;
            this.listView_Files.FullRowSelect = true;
            this.listView_Files.Location = new System.Drawing.Point(1, 65);
            this.listView_Files.Name = "listView_Files";
            this.listView_Files.Size = new System.Drawing.Size(771, 309);
            this.listView_Files.SmallImageList = this.imageList_Files;
            this.listView_Files.TabIndex = 1;
            this.listView_Files.UseCompatibleStateImageBehavior = false;
            this.listView_Files.View = System.Windows.Forms.View.Details;
            this.listView_Files.VirtualListSize = 20;
            this.listView_Files.SelectedIndexChanged += new System.EventHandler(this.listView_Files_SelectedIndexChanged);
            this.listView_Files.DoubleClick += new System.EventHandler(this.listView_Files_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "名称";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "类型";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "文件路径";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "状态";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "视频格式";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "时长";
            this.columnHeader6.Width = 80;
            // 
            // imageList_Files
            // 
            this.imageList_Files.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_Files.ImageStream")));
            this.imageList_Files.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_Files.Images.SetKeyName(0, "folder_open_32px_14438_easyicon.net.ico");
            this.imageList_Files.Images.SetKeyName(1, "video_32px_1167445_easyicon.net.ico");
            this.imageList_Files.Images.SetKeyName(2, "TextFile.ico");
            this.imageList_Files.Images.SetKeyName(3, "docs.ico");
            // 
            // label_FileInfo
            // 
            this.label_FileInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.label_FileInfo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label_FileInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_FileInfo.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label_FileInfo.ForeColor = System.Drawing.Color.Black;
            this.label_FileInfo.Location = new System.Drawing.Point(1, 1);
            this.label_FileInfo.Name = "label_FileInfo";
            this.label_FileInfo.SingleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.label_FileInfo.Size = new System.Drawing.Size(771, 64);
            this.label_FileInfo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.label_FileInfo.Symbol = "";
            this.label_FileInfo.TabIndex = 0;
            this.label_FileInfo.WordWrap = true;
            // 
            // tabItem_Project
            // 
            this.tabItem_Project.AttachedControl = this.tabControlPanel_Project;
            this.tabItem_Project.Name = "tabItem_Project";
            this.tabItem_Project.Text = "工程浏览器";
            // 
            // tabControlPanel2
            // 
            this.tabControlPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel2.Location = new System.Drawing.Point(0, 28);
            this.tabControlPanel2.Name = "tabControlPanel2";
            this.tabControlPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel2.Size = new System.Drawing.Size(773, 375);
            this.tabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.tabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(198)))));
            this.tabControlPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel2.Style.GradientAngle = 90;
            this.tabControlPanel2.TabIndex = 9;
            this.tabControlPanel2.TabItem = this.tabItemTemplate;
            // 
            // tabItemTemplate
            // 
            this.tabItemTemplate.AttachedControl = this.tabControlPanel2;
            this.tabItemTemplate.Name = "tabItemTemplate";
            this.tabItemTemplate.Text = "模板库";
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 28);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(773, 375);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(198)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 5;
            this.tabControlPanel1.TabItem = this.tabItem_SpecialEffect;
            // 
            // tabItem_SpecialEffect
            // 
            this.tabItem_SpecialEffect.AttachedControl = this.tabControlPanel1;
            this.tabItem_SpecialEffect.Name = "tabItem_SpecialEffect";
            this.tabItem_SpecialEffect.Text = "特技控制";
            // 
            // tabControl_Sequence
            // 
            this.tabControl_Sequence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.tabControl_Sequence.CanReorderTabs = true;
            this.tabControl_Sequence.Controls.Add(this.tabControlPanel_Seq);
            this.tabControl_Sequence.Controls.Add(this.tabControlPanel_Segment);
            this.tabControl_Sequence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Sequence.ForeColor = System.Drawing.Color.Black;
            this.tabControl_Sequence.Location = new System.Drawing.Point(773, 25);
            this.tabControl_Sequence.Name = "tabControl_Sequence";
            this.tabControl_Sequence.Padding = new System.Windows.Forms.Padding(3);
            this.tabControl_Sequence.SelectedTabFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl_Sequence.SelectedTabIndex = 0;
            this.tabControl_Sequence.Size = new System.Drawing.Size(563, 403);
            this.tabControl_Sequence.Style = DevComponents.DotNetBar.eTabStripStyle.Metro;
            this.tabControl_Sequence.TabIndex = 1;
            this.tabControl_Sequence.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl_Sequence.Tabs.Add(this.tabItem_Sequence);
            this.tabControl_Sequence.Tabs.Add(this.tabItem_Segment);
            this.tabControl_Sequence.Text = "tabControl_Sequence";
            // 
            // tabControlPanel_Seq
            // 
            this.tabControlPanel_Seq.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.tabControlPanel_Seq.Controls.Add(this.PanelEx_Sequence);
            this.tabControlPanel_Seq.Controls.Add(this.timeLineControl_Sequence);
            this.tabControlPanel_Seq.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanel_Seq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel_Seq.Location = new System.Drawing.Point(0, 28);
            this.tabControlPanel_Seq.Name = "tabControlPanel_Seq";
            this.tabControlPanel_Seq.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel_Seq.Size = new System.Drawing.Size(563, 375);
            this.tabControlPanel_Seq.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.tabControlPanel_Seq.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel_Seq.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(198)))));
            this.tabControlPanel_Seq.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel_Seq.Style.GradientAngle = 90;
            this.tabControlPanel_Seq.TabIndex = 1;
            this.tabControlPanel_Seq.TabItem = this.tabItem_Sequence;
            // 
            // PanelEx_Sequence
            // 
            this.PanelEx_Sequence.CanvasColor = System.Drawing.SystemColors.Control;
            this.PanelEx_Sequence.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.PanelEx_Sequence.DisabledBackColor = System.Drawing.Color.Empty;
            this.PanelEx_Sequence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelEx_Sequence.Location = new System.Drawing.Point(1, 1);
            this.PanelEx_Sequence.Name = "PanelEx_Sequence";
            this.PanelEx_Sequence.Size = new System.Drawing.Size(561, 343);
            this.PanelEx_Sequence.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PanelEx_Sequence.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PanelEx_Sequence.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PanelEx_Sequence.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PanelEx_Sequence.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PanelEx_Sequence.Style.GradientAngle = 90;
            this.PanelEx_Sequence.TabIndex = 2;
            this.PanelEx_Sequence.Text = "序列监视器面板";
            // 
            // timeLineControl_Sequence
            // 
            this.timeLineControl_Sequence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.timeLineControl_Sequence.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.timeLineControl_Sequence.Font = new System.Drawing.Font("Consolas", 8.75F);
            this.timeLineControl_Sequence.ForeColor = System.Drawing.Color.Black;
            this.timeLineControl_Sequence.Location = new System.Drawing.Point(1, 344);
            this.timeLineControl_Sequence.Name = "timeLineControl_Sequence";
            this.timeLineControl_Sequence.NBigTicksLength = 10;
            this.timeLineControl_Sequence.NBotmPadding = 3;
            this.timeLineControl_Sequence.NDistanceOfTicks = 10;
            this.timeLineControl_Sequence.NNeedShowSeconds = 4200;
            this.timeLineControl_Sequence.NNumOfBigTicks = 7;
            this.timeLineControl_Sequence.Size = new System.Drawing.Size(561, 30);
            this.timeLineControl_Sequence.TabIndex = 6;
            this.timeLineControl_Sequence.ThumbHPos = 333;
            this.timeLineControl_Sequence.ThumbRectangle = new System.Drawing.Rectangle(328, 0, 10, 15);
            // 
            // tabItem_Sequence
            // 
            this.tabItem_Sequence.AttachedControl = this.tabControlPanel_Seq;
            this.tabItem_Sequence.Name = "tabItem_Sequence";
            this.tabItem_Sequence.Text = "序列监视器";
            // 
            // tabControlPanel_Segment
            // 
            this.tabControlPanel_Segment.Controls.Add(this.panelEx_Segment);
            this.tabControlPanel_Segment.Controls.Add(this.timeLineControl_Segment);
            this.tabControlPanel_Segment.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanel_Segment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel_Segment.Location = new System.Drawing.Point(0, 28);
            this.tabControlPanel_Segment.Name = "tabControlPanel_Segment";
            this.tabControlPanel_Segment.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel_Segment.Size = new System.Drawing.Size(563, 375);
            this.tabControlPanel_Segment.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.tabControlPanel_Segment.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel_Segment.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(198)))));
            this.tabControlPanel_Segment.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel_Segment.Style.GradientAngle = 90;
            this.tabControlPanel_Segment.TabIndex = 5;
            this.tabControlPanel_Segment.TabItem = this.tabItem_Segment;
            // 
            // panelEx_Segment
            // 
            this.panelEx_Segment.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx_Segment.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx_Segment.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx_Segment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx_Segment.Location = new System.Drawing.Point(1, 1);
            this.panelEx_Segment.Name = "panelEx_Segment";
            this.panelEx_Segment.Size = new System.Drawing.Size(561, 343);
            this.panelEx_Segment.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx_Segment.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx_Segment.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx_Segment.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx_Segment.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx_Segment.Style.GradientAngle = 90;
            this.panelEx_Segment.TabIndex = 6;
            this.panelEx_Segment.Text = "片段监视器面板";
            // 
            // timeLineControl_Segment
            // 
            this.timeLineControl_Segment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.timeLineControl_Segment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.timeLineControl_Segment.Font = new System.Drawing.Font("Consolas", 8.75F);
            this.timeLineControl_Segment.ForeColor = System.Drawing.Color.Black;
            this.timeLineControl_Segment.Location = new System.Drawing.Point(1, 344);
            this.timeLineControl_Segment.Name = "timeLineControl_Segment";
            this.timeLineControl_Segment.NBigTicksLength = 10;
            this.timeLineControl_Segment.NBotmPadding = 3;
            this.timeLineControl_Segment.NDistanceOfTicks = 15;
            this.timeLineControl_Segment.NNeedShowSeconds = 3600;
            this.timeLineControl_Segment.NNumOfBigTicks = 6;
            this.timeLineControl_Segment.Size = new System.Drawing.Size(561, 30);
            this.timeLineControl_Segment.TabIndex = 10;
            this.timeLineControl_Segment.ThumbHPos = 333;
            this.timeLineControl_Segment.ThumbRectangle = new System.Drawing.Rectangle(326, 0, 15, 15);
            // 
            // tabItem_Segment
            // 
            this.tabItem_Segment.AttachedControl = this.tabControlPanel_Segment;
            this.tabItem_Segment.Name = "tabItem_Segment";
            this.tabItem_Segment.Text = "片段监视器";
            // 
            // 工程ToolStripMenuItem
            // 
            this.工程ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.打开ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.另存为ToolStripMenuItem,
            this.关闭ToolStripMenuItem,
            this.toolStripSeparator1,
            this.偏好设置ToolStripMenuItem,
            this.工程设置ToolStripMenuItem,
            this.toolStripSeparator2,
            this.导入工程ToolStripMenuItem,
            this.导入序列ToolStripMenuItem,
            this.导入AAFToolStripMenuItem,
            this.导入配音序列ToolStripMenuItem,
            this.toolStripSeparator3,
            this.删除未引用的素材ToolStripMenuItem,
            this.toolStripSeparator4,
            this.工程整理ToolStripMenuItem,
            this.工程信息统计ToolStripMenuItem,
            this.最近打开工程ToolStripMenuItem,
            this.toolStripSeparator5,
            this.退出ToolStripMenuItem});
            this.工程ToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.工程ToolStripMenuItem.Name = "工程ToolStripMenuItem";
            this.工程ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.工程ToolStripMenuItem.Text = "工程";
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.新建ToolStripMenuItem.Text = "新建(&N)";
            this.新建ToolStripMenuItem.Click += new System.EventHandler(this.新建ToolStripMenuItem_Click);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.打开ToolStripMenuItem.Text = "打开(&O)";
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.保存ToolStripMenuItem.Text = "保存(&S)";
            // 
            // 另存为ToolStripMenuItem
            // 
            this.另存为ToolStripMenuItem.Name = "另存为ToolStripMenuItem";
            this.另存为ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.另存为ToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.另存为ToolStripMenuItem.Text = "另存为(&A)";
            // 
            // 关闭ToolStripMenuItem
            // 
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.关闭ToolStripMenuItem.Text = "关闭(&C)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(203, 6);
            // 
            // 偏好设置ToolStripMenuItem
            // 
            this.偏好设置ToolStripMenuItem.Name = "偏好设置ToolStripMenuItem";
            this.偏好设置ToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.偏好设置ToolStripMenuItem.Text = "偏好设置";
            this.偏好设置ToolStripMenuItem.Click += new System.EventHandler(this.偏好设置ToolStripMenuItem_Click);
            // 
            // 工程设置ToolStripMenuItem
            // 
            this.工程设置ToolStripMenuItem.Name = "工程设置ToolStripMenuItem";
            this.工程设置ToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.工程设置ToolStripMenuItem.Text = "工程设置";
            this.工程设置ToolStripMenuItem.Click += new System.EventHandler(this.工程设置ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(203, 6);
            // 
            // 导入工程ToolStripMenuItem
            // 
            this.导入工程ToolStripMenuItem.Name = "导入工程ToolStripMenuItem";
            this.导入工程ToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.导入工程ToolStripMenuItem.Text = "导入工程";
            // 
            // 导入序列ToolStripMenuItem
            // 
            this.导入序列ToolStripMenuItem.Name = "导入序列ToolStripMenuItem";
            this.导入序列ToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.导入序列ToolStripMenuItem.Text = "导入序列";
            // 
            // 导入AAFToolStripMenuItem
            // 
            this.导入AAFToolStripMenuItem.Name = "导入AAFToolStripMenuItem";
            this.导入AAFToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.导入AAFToolStripMenuItem.Text = "导入AAF";
            // 
            // 导入配音序列ToolStripMenuItem
            // 
            this.导入配音序列ToolStripMenuItem.Name = "导入配音序列ToolStripMenuItem";
            this.导入配音序列ToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.导入配音序列ToolStripMenuItem.Text = "导入配音序列";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(203, 6);
            // 
            // 删除未引用的素材ToolStripMenuItem
            // 
            this.删除未引用的素材ToolStripMenuItem.Name = "删除未引用的素材ToolStripMenuItem";
            this.删除未引用的素材ToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.删除未引用的素材ToolStripMenuItem.Text = "删除未引用的素材";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(203, 6);
            // 
            // 工程整理ToolStripMenuItem
            // 
            this.工程整理ToolStripMenuItem.Name = "工程整理ToolStripMenuItem";
            this.工程整理ToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.工程整理ToolStripMenuItem.Text = "工程整理";
            // 
            // 工程信息统计ToolStripMenuItem
            // 
            this.工程信息统计ToolStripMenuItem.Name = "工程信息统计ToolStripMenuItem";
            this.工程信息统计ToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.工程信息统计ToolStripMenuItem.Text = "工程信息统计";
            // 
            // 最近打开工程ToolStripMenuItem
            // 
            this.最近打开工程ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szwbprjToolStripMenuItem});
            this.最近打开工程ToolStripMenuItem.Name = "最近打开工程ToolStripMenuItem";
            this.最近打开工程ToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.最近打开工程ToolStripMenuItem.Text = "最近打开工程";
            // 
            // szwbprjToolStripMenuItem
            // 
            this.szwbprjToolStripMenuItem.Name = "szwbprjToolStripMenuItem";
            this.szwbprjToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.szwbprjToolStripMenuItem.Text = "szwb.prj";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(203, 6);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.退出ToolStripMenuItem.Text = "退出(&X)";
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.撤销ToolStripMenuItem,
            this.重做ToolStripMenuItem,
            this.toolStripSeparator6,
            this.配音DToolStripMenuItem,
            this.toolStripSeparator7,
            this.显示第二效果监视器ToolStripMenuItem,
            this.toolStripSeparator8,
            this.缓存管理ToolStripMenuItem});
            this.编辑ToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 撤销ToolStripMenuItem
            // 
            this.撤销ToolStripMenuItem.Name = "撤销ToolStripMenuItem";
            this.撤销ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.撤销ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.撤销ToolStripMenuItem.Text = "撤销(&U)";
            // 
            // 重做ToolStripMenuItem
            // 
            this.重做ToolStripMenuItem.Name = "重做ToolStripMenuItem";
            this.重做ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.重做ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.重做ToolStripMenuItem.Text = "重做(&R)";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(181, 6);
            // 
            // 配音DToolStripMenuItem
            // 
            this.配音DToolStripMenuItem.Name = "配音DToolStripMenuItem";
            this.配音DToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.配音DToolStripMenuItem.Text = "配音(&D)";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(181, 6);
            // 
            // 显示第二效果监视器ToolStripMenuItem
            // 
            this.显示第二效果监视器ToolStripMenuItem.Name = "显示第二效果监视器ToolStripMenuItem";
            this.显示第二效果监视器ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.显示第二效果监视器ToolStripMenuItem.Text = "显示第二效果监视器";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(181, 6);
            // 
            // 缓存管理ToolStripMenuItem
            // 
            this.缓存管理ToolStripMenuItem.Name = "缓存管理ToolStripMenuItem";
            this.缓存管理ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.缓存管理ToolStripMenuItem.Text = "缓存管理";
            // 
            // 输入ToolStripMenuItem
            // 
            this.输入ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导入ToolStripMenuItem,
            this.toolStripSeparator10,
            this.导入P2ToolStripMenuItem,
            this.导入XDCAMToolStripMenuItem,
            this.导入SxStoolStripMenuItem,
            this.导入E2toolStripMenuItem,
            this.导入PPTtoolStripMenuItem,
            this.toolStripSeparator9,
            this.采集ToolStripMenuItem,
            this.打包输出ToolStripMenuItem,
            this.录制ToolStripMenuItem,
            this.设备输出设置ToolStripMenuItem,
            this.光盘刻录ToolStripMenuItem});
            this.输入ToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.输入ToolStripMenuItem.Name = "输入ToolStripMenuItem";
            this.输入ToolStripMenuItem.Size = new System.Drawing.Size(73, 21);
            this.输入ToolStripMenuItem.Text = "输入/输出";
            // 
            // 导入ToolStripMenuItem
            // 
            this.导入ToolStripMenuItem.Name = "导入ToolStripMenuItem";
            this.导入ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.导入ToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.导入ToolStripMenuItem.Text = "导入(&I)";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(183, 6);
            // 
            // 导入P2ToolStripMenuItem
            // 
            this.导入P2ToolStripMenuItem.Name = "导入P2ToolStripMenuItem";
            this.导入P2ToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.导入P2ToolStripMenuItem.Text = "导入P2文件";
            // 
            // 导入XDCAMToolStripMenuItem
            // 
            this.导入XDCAMToolStripMenuItem.Name = "导入XDCAMToolStripMenuItem";
            this.导入XDCAMToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.导入XDCAMToolStripMenuItem.Text = "导入XDCAM文件";
            // 
            // 导入SxStoolStripMenuItem
            // 
            this.导入SxStoolStripMenuItem.Name = "导入SxStoolStripMenuItem";
            this.导入SxStoolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.导入SxStoolStripMenuItem.Text = "导入SxS文件";
            // 
            // 导入E2toolStripMenuItem
            // 
            this.导入E2toolStripMenuItem.Name = "导入E2toolStripMenuItem";
            this.导入E2toolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.导入E2toolStripMenuItem.Text = "导入E2文件";
            // 
            // 导入PPTtoolStripMenuItem
            // 
            this.导入PPTtoolStripMenuItem.Name = "导入PPTtoolStripMenuItem";
            this.导入PPTtoolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.导入PPTtoolStripMenuItem.Text = "导入PPT文件";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(183, 6);
            // 
            // 采集ToolStripMenuItem
            // 
            this.采集ToolStripMenuItem.Name = "采集ToolStripMenuItem";
            this.采集ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.采集ToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.采集ToolStripMenuItem.Text = "采集(&C)";
            // 
            // 打包输出ToolStripMenuItem
            // 
            this.打包输出ToolStripMenuItem.Name = "打包输出ToolStripMenuItem";
            this.打包输出ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.打包输出ToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.打包输出ToolStripMenuItem.Text = "打包输出(&E)";
            // 
            // 录制ToolStripMenuItem
            // 
            this.录制ToolStripMenuItem.Name = "录制ToolStripMenuItem";
            this.录制ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.录制ToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.录制ToolStripMenuItem.Text = "录制(&R)";
            // 
            // 设备输出设置ToolStripMenuItem
            // 
            this.设备输出设置ToolStripMenuItem.Name = "设备输出设置ToolStripMenuItem";
            this.设备输出设置ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.设备输出设置ToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.设备输出设置ToolStripMenuItem.Text = "设备输出设置(&D)";
            // 
            // 光盘刻录ToolStripMenuItem
            // 
            this.光盘刻录ToolStripMenuItem.Name = "光盘刻录ToolStripMenuItem";
            this.光盘刻录ToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.光盘刻录ToolStripMenuItem.Text = "光盘刻录";
            // 
            // 输出ToolStripMenuItem
            // 
            this.输出ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.输出ToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.输出ToolStripMenuItem.Name = "输出ToolStripMenuItem";
            this.输出ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.输出ToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // MainmenuStrip
            // 
            this.MainmenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.MainmenuStrip.ForeColor = System.Drawing.Color.Black;
            this.MainmenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.工程ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.输入ToolStripMenuItem,
            this.输出ToolStripMenuItem});
            this.MainmenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainmenuStrip.Name = "MainmenuStrip";
            this.MainmenuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.MainmenuStrip.Size = new System.Drawing.Size(1336, 25);
            this.MainmenuStrip.TabIndex = 0;
            this.MainmenuStrip.Text = "主菜单";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Light;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204))))));
            // 
            // tabControl_TimeLine
            // 
            this.tabControl_TimeLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.tabControl_TimeLine.CanReorderTabs = true;
            this.tabControl_TimeLine.Controls.Add(this.tabControlPanel4);
            this.tabControl_TimeLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl_TimeLine.ForeColor = System.Drawing.Color.Black;
            this.tabControl_TimeLine.Location = new System.Drawing.Point(0, 428);
            this.tabControl_TimeLine.Name = "tabControl_TimeLine";
            this.tabControl_TimeLine.Padding = new System.Windows.Forms.Padding(3);
            this.tabControl_TimeLine.SelectedTabFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl_TimeLine.SelectedTabIndex = 0;
            this.tabControl_TimeLine.Size = new System.Drawing.Size(1336, 355);
            this.tabControl_TimeLine.Style = DevComponents.DotNetBar.eTabStripStyle.Metro;
            this.tabControl_TimeLine.TabIndex = 2;
            this.tabControl_TimeLine.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl_TimeLine.Tabs.Add(this.tabItem_TimeLine);
            this.tabControl_TimeLine.Text = "片段监视器面板";
            // 
            // tabControlPanel4
            // 
            this.tabControlPanel4.Controls.Add(this.panelEx_TrackContent);
            this.tabControlPanel4.Controls.Add(this.panelEx_TrackName);
            this.tabControlPanel4.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel4.Location = new System.Drawing.Point(0, 28);
            this.tabControlPanel4.Name = "tabControlPanel4";
            this.tabControlPanel4.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel4.Size = new System.Drawing.Size(1336, 327);
            this.tabControlPanel4.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.tabControlPanel4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel4.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(198)))));
            this.tabControlPanel4.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel4.Style.GradientAngle = 90;
            this.tabControlPanel4.TabIndex = 1;
            this.tabControlPanel4.TabItem = this.tabItem_TimeLine;
            // 
            // panelEx_TrackContent
            // 
            this.panelEx_TrackContent.AutoScroll = true;
            this.panelEx_TrackContent.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx_TrackContent.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx_TrackContent.Controls.Add(this.panelEx_AudioTrackConment2);
            this.panelEx_TrackContent.Controls.Add(this.panelEx_AudioTrackConment1);
            this.panelEx_TrackContent.Controls.Add(this.timeLineControl_MainTL);
            this.panelEx_TrackContent.Controls.Add(this.panelEx_VideoTrackConment2);
            this.panelEx_TrackContent.Controls.Add(this.panelEx_VideoTrackConment1);
            this.panelEx_TrackContent.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx_TrackContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx_TrackContent.Location = new System.Drawing.Point(249, 1);
            this.panelEx_TrackContent.Name = "panelEx_TrackContent";
            this.panelEx_TrackContent.Size = new System.Drawing.Size(1086, 325);
            this.panelEx_TrackContent.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx_TrackContent.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx_TrackContent.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx_TrackContent.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx_TrackContent.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx_TrackContent.Style.GradientAngle = 90;
            this.panelEx_TrackContent.TabIndex = 4;
            this.panelEx_TrackContent.Text = "轨道内容面板";
            // 
            // panelEx_AudioTrackConment2
            // 
            this.panelEx_AudioTrackConment2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEx_AudioTrackConment2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx_AudioTrackConment2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx_AudioTrackConment2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx_AudioTrackConment2.Location = new System.Drawing.Point(0, 221);
            this.panelEx_AudioTrackConment2.Name = "panelEx_AudioTrackConment2";
            this.panelEx_AudioTrackConment2.Size = new System.Drawing.Size(1297, 34);
            this.panelEx_AudioTrackConment2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx_AudioTrackConment2.Style.BackColor1.Color = System.Drawing.SystemColors.ActiveBorder;
            this.panelEx_AudioTrackConment2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx_AudioTrackConment2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx_AudioTrackConment2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx_AudioTrackConment2.Style.GradientAngle = 90;
            this.panelEx_AudioTrackConment2.StyleMouseOver.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx_AudioTrackConment2.StyleMouseOver.BackColor1.Color = System.Drawing.SystemColors.Highlight;
            this.panelEx_AudioTrackConment2.TabIndex = 0;
            this.panelEx_AudioTrackConment2.Text = "音频轨道内容2";
            // 
            // panelEx_AudioTrackConment1
            // 
            this.panelEx_AudioTrackConment1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEx_AudioTrackConment1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx_AudioTrackConment1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx_AudioTrackConment1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx_AudioTrackConment1.Location = new System.Drawing.Point(0, 187);
            this.panelEx_AudioTrackConment1.Name = "panelEx_AudioTrackConment1";
            this.panelEx_AudioTrackConment1.Size = new System.Drawing.Size(1297, 34);
            this.panelEx_AudioTrackConment1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx_AudioTrackConment1.Style.BackColor1.Color = System.Drawing.SystemColors.ActiveBorder;
            this.panelEx_AudioTrackConment1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx_AudioTrackConment1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx_AudioTrackConment1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx_AudioTrackConment1.Style.GradientAngle = 90;
            this.panelEx_AudioTrackConment1.StyleMouseOver.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx_AudioTrackConment1.StyleMouseOver.BackColor1.Color = System.Drawing.SystemColors.Highlight;
            this.panelEx_AudioTrackConment1.TabIndex = 0;
            this.panelEx_AudioTrackConment1.Text = "音频轨道内容1";
            // 
            // timeLineControl_MainTL
            // 
            this.timeLineControl_MainTL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.timeLineControl_MainTL.Dock = System.Windows.Forms.DockStyle.Top;
            this.timeLineControl_MainTL.Font = new System.Drawing.Font("Consolas", 8.75F);
            this.timeLineControl_MainTL.ForeColor = System.Drawing.Color.Black;
            this.timeLineControl_MainTL.Location = new System.Drawing.Point(0, 0);
            this.timeLineControl_MainTL.Name = "timeLineControl_MainTL";
            this.timeLineControl_MainTL.NBigTicksLength = 10;
            this.timeLineControl_MainTL.NBotmPadding = 3;
            this.timeLineControl_MainTL.NDistanceOfTicks = 15;
            this.timeLineControl_MainTL.NNeedShowSeconds = 5400;
            this.timeLineControl_MainTL.NNumOfBigTicks = 9;
            this.timeLineControl_MainTL.Size = new System.Drawing.Size(1086, 34);
            this.timeLineControl_MainTL.TabIndex = 11;
            this.timeLineControl_MainTL.ThumbHPos = 222;
            this.timeLineControl_MainTL.ThumbRectangle = new System.Drawing.Rectangle(215, 0, 15, 15);
            this.timeLineControl_MainTL.Click += new System.EventHandler(this.timeLineControl1_Click);
            // 
            // panelEx_VideoTrackConment2
            // 
            this.panelEx_VideoTrackConment2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEx_VideoTrackConment2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx_VideoTrackConment2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx_VideoTrackConment2.Controls.Add(this.VideoFile1);
            this.panelEx_VideoTrackConment2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx_VideoTrackConment2.Location = new System.Drawing.Point(0, 119);
            this.panelEx_VideoTrackConment2.Name = "panelEx_VideoTrackConment2";
            this.panelEx_VideoTrackConment2.Size = new System.Drawing.Size(1297, 34);
            this.panelEx_VideoTrackConment2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx_VideoTrackConment2.Style.BackColor1.Color = System.Drawing.SystemColors.ActiveBorder;
            this.panelEx_VideoTrackConment2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx_VideoTrackConment2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx_VideoTrackConment2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx_VideoTrackConment2.Style.GradientAngle = 90;
            this.panelEx_VideoTrackConment2.StyleMouseOver.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx_VideoTrackConment2.StyleMouseOver.BackColor1.Color = System.Drawing.SystemColors.Highlight;
            this.panelEx_VideoTrackConment2.TabIndex = 8;
            this.panelEx_VideoTrackConment2.Text = "视频轨道内容2";
            // 
            // VideoFile1
            // 
            this.VideoFile1.CanvasColor = System.Drawing.SystemColors.Control;
            this.VideoFile1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.VideoFile1.DisabledBackColor = System.Drawing.Color.Empty;
            this.VideoFile1.Location = new System.Drawing.Point(196, 0);
            this.VideoFile1.Name = "VideoFile1";
            this.VideoFile1.Size = new System.Drawing.Size(233, 48);
            this.VideoFile1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.VideoFile1.Style.BackColor1.Color = System.Drawing.SystemColors.ActiveCaption;
            this.VideoFile1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.VideoFile1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.VideoFile1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.VideoFile1.Style.GradientAngle = 90;
            this.VideoFile1.StyleMouseDown.Alignment = System.Drawing.StringAlignment.Center;
            this.VideoFile1.StyleMouseDown.BackgroundImage = global::主界面.Properties.Resources.透明图片6;
            this.VideoFile1.StyleMouseOver.Alignment = System.Drawing.StringAlignment.Center;
            this.VideoFile1.StyleMouseOver.BackgroundImage = global::主界面.Properties.Resources.透明图片7;
            this.VideoFile1.TabIndex = 0;
            this.VideoFile1.Text = "视频素材1";
            // 
            // panelEx_VideoTrackConment1
            // 
            this.panelEx_VideoTrackConment1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEx_VideoTrackConment1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx_VideoTrackConment1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx_VideoTrackConment1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx_VideoTrackConment1.Location = new System.Drawing.Point(0, 153);
            this.panelEx_VideoTrackConment1.Name = "panelEx_VideoTrackConment1";
            this.panelEx_VideoTrackConment1.Size = new System.Drawing.Size(1294, 34);
            this.panelEx_VideoTrackConment1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx_VideoTrackConment1.Style.BackColor1.Color = System.Drawing.SystemColors.ActiveBorder;
            this.panelEx_VideoTrackConment1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx_VideoTrackConment1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx_VideoTrackConment1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx_VideoTrackConment1.Style.GradientAngle = 90;
            this.panelEx_VideoTrackConment1.StyleMouseOver.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx_VideoTrackConment1.StyleMouseOver.BackColor1.Color = System.Drawing.SystemColors.Highlight;
            this.panelEx_VideoTrackConment1.TabIndex = 4;
            this.panelEx_VideoTrackConment1.Text = "视频轨道内容1";
            // 
            // panelEx_TrackName
            // 
            this.panelEx_TrackName.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx_TrackName.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx_TrackName.Controls.Add(this.panelEx_VideoName);
            this.panelEx_TrackName.Controls.Add(this.bar_TrackNameToolBar);
            this.panelEx_TrackName.Controls.Add(this.panelEx_AudioName);
            this.panelEx_TrackName.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx_TrackName.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEx_TrackName.Location = new System.Drawing.Point(1, 1);
            this.panelEx_TrackName.Name = "panelEx_TrackName";
            this.panelEx_TrackName.Size = new System.Drawing.Size(248, 325);
            this.panelEx_TrackName.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx_TrackName.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx_TrackName.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx_TrackName.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx_TrackName.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx_TrackName.Style.GradientAngle = 90;
            this.panelEx_TrackName.TabIndex = 0;
            this.panelEx_TrackName.Text = "轨道名称面板";
            // 
            // panelEx_VideoName
            // 
            this.panelEx_VideoName.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx_VideoName.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx_VideoName.Controls.Add(this.panelEx_VideoTrackName2);
            this.panelEx_VideoName.Controls.Add(this.panelEx_VideoTrackName1);
            this.panelEx_VideoName.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx_VideoName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx_VideoName.Location = new System.Drawing.Point(0, 34);
            this.panelEx_VideoName.Name = "panelEx_VideoName";
            this.panelEx_VideoName.Size = new System.Drawing.Size(248, 153);
            this.panelEx_VideoName.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx_VideoName.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx_VideoName.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx_VideoName.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx_VideoName.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx_VideoName.Style.GradientAngle = 90;
            this.panelEx_VideoName.TabIndex = 0;
            this.panelEx_VideoName.Text = "视频轨道名称面板";
            // 
            // panelEx_VideoTrackName2
            // 
            this.panelEx_VideoTrackName2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx_VideoTrackName2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx_VideoTrackName2.Controls.Add(this.bar_VideoTrackButtonBar2);
            this.panelEx_VideoTrackName2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx_VideoTrackName2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx_VideoTrackName2.Location = new System.Drawing.Point(0, 85);
            this.panelEx_VideoTrackName2.Name = "panelEx_VideoTrackName2";
            this.panelEx_VideoTrackName2.Size = new System.Drawing.Size(248, 34);
            this.panelEx_VideoTrackName2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx_VideoTrackName2.Style.BackColor1.Color = System.Drawing.SystemColors.ActiveBorder;
            this.panelEx_VideoTrackName2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx_VideoTrackName2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx_VideoTrackName2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx_VideoTrackName2.Style.GradientAngle = 90;
            this.panelEx_VideoTrackName2.TabIndex = 8;
            // 
            // bar_VideoTrackButtonBar2
            // 
            this.bar_VideoTrackButtonBar2.AntiAlias = true;
            this.bar_VideoTrackButtonBar2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bar_VideoTrackButtonBar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar_VideoTrackButtonBar2.DockSide = DevComponents.DotNetBar.eDockSide.Bottom;
            this.bar_VideoTrackButtonBar2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bar_VideoTrackButtonBar2.IsMaximized = false;
            this.bar_VideoTrackButtonBar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.VideoTrackB2BI_See,
            this.VideoTrackB2BI_Lock,
            this.VideoTrackB2BI_Play,
            this.VideoTrackB2BI_MoveDown,
            this.VideoTrackB2BI_TrackNickName});
            this.bar_VideoTrackButtonBar2.Location = new System.Drawing.Point(0, 0);
            this.bar_VideoTrackButtonBar2.Name = "bar_VideoTrackButtonBar2";
            this.bar_VideoTrackButtonBar2.Size = new System.Drawing.Size(248, 30);
            this.bar_VideoTrackButtonBar2.Stretch = true;
            this.bar_VideoTrackButtonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar_VideoTrackButtonBar2.TabIndex = 0;
            this.bar_VideoTrackButtonBar2.TabStop = false;
            this.bar_VideoTrackButtonBar2.Text = "VideoTrackButtonBar2";
            // 
            // VideoTrackB2BI_See
            // 
            this.VideoTrackB2BI_See.Icon = ((System.Drawing.Icon)(resources.GetObject("VideoTrackB2BI_See.Icon")));
            this.VideoTrackB2BI_See.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.VideoTrackB2BI_See.Name = "VideoTrackB2BI_See";
            this.VideoTrackB2BI_See.Text = "观看";
            // 
            // VideoTrackB2BI_Lock
            // 
            this.VideoTrackB2BI_Lock.Icon = ((System.Drawing.Icon)(resources.GetObject("VideoTrackB2BI_Lock.Icon")));
            this.VideoTrackB2BI_Lock.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.VideoTrackB2BI_Lock.Name = "VideoTrackB2BI_Lock";
            this.VideoTrackB2BI_Lock.Text = "锁定";
            this.VideoTrackB2BI_Lock.MouseLeave += new System.EventHandler(this.TrackName_BtnMouseLeave);
            this.VideoTrackB2BI_Lock.MouseHover += new System.EventHandler(this.TrackName_BtnMouseHover);
            // 
            // VideoTrackB2BI_Play
            // 
            this.VideoTrackB2BI_Play.Icon = ((System.Drawing.Icon)(resources.GetObject("VideoTrackB2BI_Play.Icon")));
            this.VideoTrackB2BI_Play.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.VideoTrackB2BI_Play.Name = "VideoTrackB2BI_Play";
            this.VideoTrackB2BI_Play.Text = "播放";
            // 
            // VideoTrackB2BI_MoveDown
            // 
            this.VideoTrackB2BI_MoveDown.Icon = ((System.Drawing.Icon)(resources.GetObject("VideoTrackB2BI_MoveDown.Icon")));
            this.VideoTrackB2BI_MoveDown.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.VideoTrackB2BI_MoveDown.Name = "VideoTrackB2BI_MoveDown";
            this.VideoTrackB2BI_MoveDown.Text = "下移";
            // 
            // VideoTrackB2BI_TrackNickName
            // 
            this.VideoTrackB2BI_TrackNickName.FontBold = true;
            this.VideoTrackB2BI_TrackNickName.HotFontBold = true;
            this.VideoTrackB2BI_TrackNickName.HotFontUnderline = true;
            this.VideoTrackB2BI_TrackNickName.HotForeColor = System.Drawing.SystemColors.HotTrack;
            this.VideoTrackB2BI_TrackNickName.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.VideoTrackB2BI_TrackNickName.Name = "VideoTrackB2BI_TrackNickName";
            this.VideoTrackB2BI_TrackNickName.Text = "V2";
            // 
            // panelEx_VideoTrackName1
            // 
            this.panelEx_VideoTrackName1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx_VideoTrackName1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx_VideoTrackName1.Controls.Add(this.bar_VideoTrackButtonBar1);
            this.panelEx_VideoTrackName1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx_VideoTrackName1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx_VideoTrackName1.Location = new System.Drawing.Point(0, 119);
            this.panelEx_VideoTrackName1.Name = "panelEx_VideoTrackName1";
            this.panelEx_VideoTrackName1.Size = new System.Drawing.Size(248, 34);
            this.panelEx_VideoTrackName1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx_VideoTrackName1.Style.BackColor1.Color = System.Drawing.SystemColors.ActiveBorder;
            this.panelEx_VideoTrackName1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx_VideoTrackName1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx_VideoTrackName1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx_VideoTrackName1.Style.GradientAngle = 90;
            this.panelEx_VideoTrackName1.TabIndex = 4;
            // 
            // bar_VideoTrackButtonBar1
            // 
            this.bar_VideoTrackButtonBar1.AntiAlias = true;
            this.bar_VideoTrackButtonBar1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bar_VideoTrackButtonBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar_VideoTrackButtonBar1.DockSide = DevComponents.DotNetBar.eDockSide.Bottom;
            this.bar_VideoTrackButtonBar1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bar_VideoTrackButtonBar1.IsMaximized = false;
            this.bar_VideoTrackButtonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.VideoTrackB1BI_See,
            this.VideoTrackB1BI_Lock,
            this.VideoTrackB1BI_Play,
            this.VideoTrackB1BI_MoveDown,
            this.VideoTrackB1BI_TrackNickName});
            this.bar_VideoTrackButtonBar1.Location = new System.Drawing.Point(0, 0);
            this.bar_VideoTrackButtonBar1.Name = "bar_VideoTrackButtonBar1";
            this.bar_VideoTrackButtonBar1.Size = new System.Drawing.Size(248, 30);
            this.bar_VideoTrackButtonBar1.Stretch = true;
            this.bar_VideoTrackButtonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar_VideoTrackButtonBar1.TabIndex = 0;
            this.bar_VideoTrackButtonBar1.TabStop = false;
            this.bar_VideoTrackButtonBar1.Text = "VideoTrackButtonBar1";
            // 
            // VideoTrackB1BI_See
            // 
            this.VideoTrackB1BI_See.Icon = ((System.Drawing.Icon)(resources.GetObject("VideoTrackB1BI_See.Icon")));
            this.VideoTrackB1BI_See.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.VideoTrackB1BI_See.Name = "VideoTrackB1BI_See";
            this.VideoTrackB1BI_See.Text = "观看";
            // 
            // VideoTrackB1BI_Lock
            // 
            this.VideoTrackB1BI_Lock.Icon = ((System.Drawing.Icon)(resources.GetObject("VideoTrackB1BI_Lock.Icon")));
            this.VideoTrackB1BI_Lock.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.VideoTrackB1BI_Lock.Name = "VideoTrackB1BI_Lock";
            this.VideoTrackB1BI_Lock.Text = "锁定";
            this.VideoTrackB1BI_Lock.MouseLeave += new System.EventHandler(this.TrackName_BtnMouseLeave);
            this.VideoTrackB1BI_Lock.MouseHover += new System.EventHandler(this.TrackName_BtnMouseHover);
            // 
            // VideoTrackB1BI_Play
            // 
            this.VideoTrackB1BI_Play.Icon = ((System.Drawing.Icon)(resources.GetObject("VideoTrackB1BI_Play.Icon")));
            this.VideoTrackB1BI_Play.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.VideoTrackB1BI_Play.Name = "VideoTrackB1BI_Play";
            this.VideoTrackB1BI_Play.Text = "播放";
            // 
            // VideoTrackB1BI_MoveDown
            // 
            this.VideoTrackB1BI_MoveDown.Icon = ((System.Drawing.Icon)(resources.GetObject("VideoTrackB1BI_MoveDown.Icon")));
            this.VideoTrackB1BI_MoveDown.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.VideoTrackB1BI_MoveDown.Name = "VideoTrackB1BI_MoveDown";
            this.VideoTrackB1BI_MoveDown.Text = "下移";
            // 
            // VideoTrackB1BI_TrackNickName
            // 
            this.VideoTrackB1BI_TrackNickName.FontBold = true;
            this.VideoTrackB1BI_TrackNickName.HotFontBold = true;
            this.VideoTrackB1BI_TrackNickName.HotFontUnderline = true;
            this.VideoTrackB1BI_TrackNickName.HotForeColor = System.Drawing.SystemColors.HotTrack;
            this.VideoTrackB1BI_TrackNickName.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.VideoTrackB1BI_TrackNickName.Name = "VideoTrackB1BI_TrackNickName";
            this.VideoTrackB1BI_TrackNickName.Text = "V1";
            // 
            // bar_TrackNameToolBar
            // 
            this.bar_TrackNameToolBar.AntiAlias = true;
            this.bar_TrackNameToolBar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bar_TrackNameToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar_TrackNameToolBar.DockSide = DevComponents.DotNetBar.eDockSide.Left;
            this.bar_TrackNameToolBar.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.bar_TrackNameToolBar.IsMaximized = false;
            this.bar_TrackNameToolBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem_DeleteTrack,
            this.buttonItem_StoreTrack,
            this.buttonItem_TwoToOne,
            this.labelItem_CurrentTime});
            this.bar_TrackNameToolBar.Location = new System.Drawing.Point(0, 0);
            this.bar_TrackNameToolBar.Name = "bar_TrackNameToolBar";
            this.bar_TrackNameToolBar.Size = new System.Drawing.Size(248, 34);
            this.bar_TrackNameToolBar.Stretch = true;
            this.bar_TrackNameToolBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar_TrackNameToolBar.TabIndex = 7;
            this.bar_TrackNameToolBar.TabStop = false;
            this.bar_TrackNameToolBar.Text = "bar1";
            // 
            // buttonItem_DeleteTrack
            // 
            this.buttonItem_DeleteTrack.ImagePaddingHorizontal = 6;
            this.buttonItem_DeleteTrack.Name = "buttonItem_DeleteTrack";
            this.buttonItem_DeleteTrack.Symbol = "";
            this.buttonItem_DeleteTrack.Text = "删除";
            // 
            // buttonItem_StoreTrack
            // 
            this.buttonItem_StoreTrack.ImagePaddingHorizontal = 6;
            this.buttonItem_StoreTrack.Name = "buttonItem_StoreTrack";
            this.buttonItem_StoreTrack.Symbol = "";
            this.buttonItem_StoreTrack.Text = "存储";
            // 
            // buttonItem_TwoToOne
            // 
            this.buttonItem_TwoToOne.ImagePaddingHorizontal = 6;
            this.buttonItem_TwoToOne.Name = "buttonItem_TwoToOne";
            this.buttonItem_TwoToOne.Symbol = "";
            this.buttonItem_TwoToOne.Text = "合并";
            // 
            // labelItem_CurrentTime
            // 
            this.labelItem_CurrentTime.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelItem_CurrentTime.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.labelItem_CurrentTime.FontBold = true;
            this.labelItem_CurrentTime.ForeColor = System.Drawing.Color.White;
            this.labelItem_CurrentTime.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.labelItem_CurrentTime.Name = "labelItem_CurrentTime";
            this.labelItem_CurrentTime.Text = "00:00:00:00";
            this.labelItem_CurrentTime.TextAlignment = System.Drawing.StringAlignment.Center;
            this.labelItem_CurrentTime.Width = 90;
            // 
            // panelEx_AudioName
            // 
            this.panelEx_AudioName.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx_AudioName.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx_AudioName.Controls.Add(this.panelEx_AudioTrackName2);
            this.panelEx_AudioName.Controls.Add(this.panelEx_AudioTrackName1);
            this.panelEx_AudioName.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx_AudioName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx_AudioName.Location = new System.Drawing.Point(0, 187);
            this.panelEx_AudioName.Name = "panelEx_AudioName";
            this.panelEx_AudioName.Size = new System.Drawing.Size(248, 138);
            this.panelEx_AudioName.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx_AudioName.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx_AudioName.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx_AudioName.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx_AudioName.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx_AudioName.Style.GradientAngle = 90;
            this.panelEx_AudioName.TabIndex = 0;
            this.panelEx_AudioName.Text = "音频轨道名称面板";
            // 
            // panelEx_AudioTrackName2
            // 
            this.panelEx_AudioTrackName2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx_AudioTrackName2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx_AudioTrackName2.Controls.Add(this.bar_AudioTrackButtonBar2);
            this.panelEx_AudioTrackName2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx_AudioTrackName2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx_AudioTrackName2.Location = new System.Drawing.Point(0, 34);
            this.panelEx_AudioTrackName2.Name = "panelEx_AudioTrackName2";
            this.panelEx_AudioTrackName2.Size = new System.Drawing.Size(248, 34);
            this.panelEx_AudioTrackName2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx_AudioTrackName2.Style.BackColor1.Color = System.Drawing.SystemColors.ActiveBorder;
            this.panelEx_AudioTrackName2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx_AudioTrackName2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx_AudioTrackName2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx_AudioTrackName2.Style.GradientAngle = 90;
            this.panelEx_AudioTrackName2.TabIndex = 4;
            // 
            // bar_AudioTrackButtonBar2
            // 
            this.bar_AudioTrackButtonBar2.AccessibleDescription = "AudioTrackButtonBar2 (bar_AudioTrackButtonBar2)";
            this.bar_AudioTrackButtonBar2.AccessibleName = "AudioTrackButtonBar2";
            this.bar_AudioTrackButtonBar2.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.bar_AudioTrackButtonBar2.AntiAlias = true;
            this.bar_AudioTrackButtonBar2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bar_AudioTrackButtonBar2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bar_AudioTrackButtonBar2.DockSide = DevComponents.DotNetBar.eDockSide.Top;
            this.bar_AudioTrackButtonBar2.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.bar_AudioTrackButtonBar2.IsMaximized = false;
            this.bar_AudioTrackButtonBar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.AudioTrackB2BI_Listen,
            this.AudioTrackB2BI_Volume,
            this.AudioTrackB2BI_Lock,
            this.AudioTrackB2BI_Play,
            this.AudioTrackB2BI_MoveDown,
            this.AudioTrackB2BI_TrackNickName});
            this.bar_AudioTrackButtonBar2.Location = new System.Drawing.Point(0, 0);
            this.bar_AudioTrackButtonBar2.Name = "bar_AudioTrackButtonBar2";
            this.bar_AudioTrackButtonBar2.Size = new System.Drawing.Size(248, 30);
            this.bar_AudioTrackButtonBar2.Stretch = true;
            this.bar_AudioTrackButtonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar_AudioTrackButtonBar2.TabIndex = 1;
            this.bar_AudioTrackButtonBar2.TabStop = false;
            this.bar_AudioTrackButtonBar2.Text = "AudioTrackButtonBar2";
            // 
            // AudioTrackB2BI_Listen
            // 
            this.AudioTrackB2BI_Listen.Icon = ((System.Drawing.Icon)(resources.GetObject("AudioTrackB2BI_Listen.Icon")));
            this.AudioTrackB2BI_Listen.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.AudioTrackB2BI_Listen.Name = "AudioTrackB2BI_Listen";
            this.AudioTrackB2BI_Listen.Text = "试听";
            // 
            // AudioTrackB2BI_Volume
            // 
            this.AudioTrackB2BI_Volume.Icon = ((System.Drawing.Icon)(resources.GetObject("AudioTrackB2BI_Volume.Icon")));
            this.AudioTrackB2BI_Volume.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.AudioTrackB2BI_Volume.Name = "AudioTrackB2BI_Volume";
            this.AudioTrackB2BI_Volume.Text = "音量";
            // 
            // AudioTrackB2BI_Lock
            // 
            this.AudioTrackB2BI_Lock.Icon = ((System.Drawing.Icon)(resources.GetObject("AudioTrackB2BI_Lock.Icon")));
            this.AudioTrackB2BI_Lock.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.AudioTrackB2BI_Lock.Name = "AudioTrackB2BI_Lock";
            this.AudioTrackB2BI_Lock.Text = "锁定";
            this.AudioTrackB2BI_Lock.MouseLeave += new System.EventHandler(this.TrackName_BtnMouseLeave);
            this.AudioTrackB2BI_Lock.MouseHover += new System.EventHandler(this.TrackName_BtnMouseHover);
            // 
            // AudioTrackB2BI_Play
            // 
            this.AudioTrackB2BI_Play.Icon = ((System.Drawing.Icon)(resources.GetObject("AudioTrackB2BI_Play.Icon")));
            this.AudioTrackB2BI_Play.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.AudioTrackB2BI_Play.Name = "AudioTrackB2BI_Play";
            this.AudioTrackB2BI_Play.Text = "播放";
            // 
            // AudioTrackB2BI_MoveDown
            // 
            this.AudioTrackB2BI_MoveDown.Icon = ((System.Drawing.Icon)(resources.GetObject("AudioTrackB2BI_MoveDown.Icon")));
            this.AudioTrackB2BI_MoveDown.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.AudioTrackB2BI_MoveDown.Name = "AudioTrackB2BI_MoveDown";
            this.AudioTrackB2BI_MoveDown.Text = "下移";
            // 
            // AudioTrackB2BI_TrackNickName
            // 
            this.AudioTrackB2BI_TrackNickName.FontBold = true;
            this.AudioTrackB2BI_TrackNickName.HotFontBold = true;
            this.AudioTrackB2BI_TrackNickName.HotFontUnderline = true;
            this.AudioTrackB2BI_TrackNickName.HotForeColor = System.Drawing.SystemColors.HotTrack;
            this.AudioTrackB2BI_TrackNickName.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.AudioTrackB2BI_TrackNickName.Name = "AudioTrackB2BI_TrackNickName";
            this.AudioTrackB2BI_TrackNickName.Text = "A2";
            // 
            // panelEx_AudioTrackName1
            // 
            this.panelEx_AudioTrackName1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx_AudioTrackName1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx_AudioTrackName1.Controls.Add(this.bar_AudioTrackButtonBar1);
            this.panelEx_AudioTrackName1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx_AudioTrackName1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx_AudioTrackName1.Location = new System.Drawing.Point(0, 0);
            this.panelEx_AudioTrackName1.Name = "panelEx_AudioTrackName1";
            this.panelEx_AudioTrackName1.Size = new System.Drawing.Size(248, 34);
            this.panelEx_AudioTrackName1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx_AudioTrackName1.Style.BackColor1.Color = System.Drawing.SystemColors.ActiveBorder;
            this.panelEx_AudioTrackName1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx_AudioTrackName1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx_AudioTrackName1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx_AudioTrackName1.Style.GradientAngle = 90;
            this.panelEx_AudioTrackName1.TabIndex = 0;
            // 
            // bar_AudioTrackButtonBar1
            // 
            this.bar_AudioTrackButtonBar1.AntiAlias = true;
            this.bar_AudioTrackButtonBar1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bar_AudioTrackButtonBar1.DockSide = DevComponents.DotNetBar.eDockSide.Top;
            this.bar_AudioTrackButtonBar1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bar_AudioTrackButtonBar1.IsMaximized = false;
            this.bar_AudioTrackButtonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.AudioTrackB1BI_Listen,
            this.AudioTrackB1BI_Volume,
            this.AudioTrackB1BI_Lock,
            this.AudioTrackB1BI_Play,
            this.AudioTrackB1BI_MoveDown,
            this.AudioTrackB1BI_TrackNickName});
            this.bar_AudioTrackButtonBar1.Location = new System.Drawing.Point(0, 0);
            this.bar_AudioTrackButtonBar1.Name = "bar_AudioTrackButtonBar1";
            this.bar_AudioTrackButtonBar1.Size = new System.Drawing.Size(248, 30);
            this.bar_AudioTrackButtonBar1.Stretch = true;
            this.bar_AudioTrackButtonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar_AudioTrackButtonBar1.TabIndex = 0;
            this.bar_AudioTrackButtonBar1.TabStop = false;
            this.bar_AudioTrackButtonBar1.Text = "AudioTrackButtonBar1";
            // 
            // AudioTrackB1BI_Listen
            // 
            this.AudioTrackB1BI_Listen.Icon = ((System.Drawing.Icon)(resources.GetObject("AudioTrackB1BI_Listen.Icon")));
            this.AudioTrackB1BI_Listen.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.AudioTrackB1BI_Listen.Name = "AudioTrackB1BI_Listen";
            this.AudioTrackB1BI_Listen.Text = "试听";
            // 
            // AudioTrackB1BI_Volume
            // 
            this.AudioTrackB1BI_Volume.Icon = ((System.Drawing.Icon)(resources.GetObject("AudioTrackB1BI_Volume.Icon")));
            this.AudioTrackB1BI_Volume.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.AudioTrackB1BI_Volume.Name = "AudioTrackB1BI_Volume";
            this.AudioTrackB1BI_Volume.Text = "音量";
            // 
            // AudioTrackB1BI_Lock
            // 
            this.AudioTrackB1BI_Lock.Icon = ((System.Drawing.Icon)(resources.GetObject("AudioTrackB1BI_Lock.Icon")));
            this.AudioTrackB1BI_Lock.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.AudioTrackB1BI_Lock.Name = "AudioTrackB1BI_Lock";
            this.AudioTrackB1BI_Lock.Text = "锁定";
            this.AudioTrackB1BI_Lock.MouseLeave += new System.EventHandler(this.TrackName_BtnMouseLeave);
            this.AudioTrackB1BI_Lock.MouseHover += new System.EventHandler(this.TrackName_BtnMouseHover);
            // 
            // AudioTrackB1BI_Play
            // 
            this.AudioTrackB1BI_Play.Icon = ((System.Drawing.Icon)(resources.GetObject("AudioTrackB1BI_Play.Icon")));
            this.AudioTrackB1BI_Play.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.AudioTrackB1BI_Play.Name = "AudioTrackB1BI_Play";
            this.AudioTrackB1BI_Play.Text = "播放";
            // 
            // AudioTrackB1BI_MoveDown
            // 
            this.AudioTrackB1BI_MoveDown.Icon = ((System.Drawing.Icon)(resources.GetObject("AudioTrackB1BI_MoveDown.Icon")));
            this.AudioTrackB1BI_MoveDown.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.AudioTrackB1BI_MoveDown.Name = "AudioTrackB1BI_MoveDown";
            this.AudioTrackB1BI_MoveDown.Text = "下移";
            // 
            // AudioTrackB1BI_TrackNickName
            // 
            this.AudioTrackB1BI_TrackNickName.FontBold = true;
            this.AudioTrackB1BI_TrackNickName.HotFontBold = true;
            this.AudioTrackB1BI_TrackNickName.HotFontUnderline = true;
            this.AudioTrackB1BI_TrackNickName.HotForeColor = System.Drawing.SystemColors.HotTrack;
            this.AudioTrackB1BI_TrackNickName.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.AudioTrackB1BI_TrackNickName.Name = "AudioTrackB1BI_TrackNickName";
            this.AudioTrackB1BI_TrackNickName.Text = "A1";
            // 
            // tabItem_TimeLine
            // 
            this.tabItem_TimeLine.AttachedControl = this.tabControlPanel4;
            this.tabItem_TimeLine.Name = "tabItem_TimeLine";
            this.tabItem_TimeLine.Text = "时间线";
            // 
            // timer_Segment
            // 
            this.timer_Segment.Interval = 1000;
            this.timer_Segment.Tick += new System.EventHandler(this.timer_Segment_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1336, 783);
            this.Controls.Add(this.tabControl_Sequence);
            this.Controls.Add(this.tabControl_Project);
            this.Controls.Add(this.tabControl_TimeLine);
            this.Controls.Add(this.MainmenuStrip);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.MainMenuStrip = this.MainmenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "时间线桌面";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl_Project)).EndInit();
            this.tabControl_Project.ResumeLayout(false);
            this.tabControlPanel_Project.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl_Sequence)).EndInit();
            this.tabControl_Sequence.ResumeLayout(false);
            this.tabControlPanel_Seq.ResumeLayout(false);
            this.tabControlPanel_Segment.ResumeLayout(false);
            this.MainmenuStrip.ResumeLayout(false);
            this.MainmenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl_TimeLine)).EndInit();
            this.tabControl_TimeLine.ResumeLayout(false);
            this.tabControlPanel4.ResumeLayout(false);
            this.panelEx_TrackContent.ResumeLayout(false);
            this.panelEx_VideoTrackConment2.ResumeLayout(false);
            this.panelEx_TrackName.ResumeLayout(false);
            this.panelEx_VideoName.ResumeLayout(false);
            this.panelEx_VideoTrackName2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar_VideoTrackButtonBar2)).EndInit();
            this.panelEx_VideoTrackName1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar_VideoTrackButtonBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar_TrackNameToolBar)).EndInit();
            this.panelEx_AudioName.ResumeLayout(false);
            this.panelEx_AudioTrackName2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar_AudioTrackButtonBar2)).EndInit();
            this.panelEx_AudioTrackName1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar_AudioTrackButtonBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevComponents.DotNetBar.TabControl tabControl_Project;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel_Project;
        private DevComponents.DotNetBar.TabItem tabItem_Project;
        private DevComponents.DotNetBar.TabControl tabControl_Sequence;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel_Seq;
        private DevComponents.DotNetBar.TabItem tabItem_Sequence;
        private System.Windows.Forms.ToolStripMenuItem 工程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 输入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 输出ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip MainmenuStrip;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.LabelX label_FileInfo;
        private DevComponents.DotNetBar.StyleManagerAmbient styleManagerAmbient1;
        private DevComponents.DotNetBar.Controls.ListViewEx listView_Files;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private DevComponents.DotNetBar.TabControl tabControl_TimeLine;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel4;
        private DevComponents.DotNetBar.TabItem tabItem_TimeLine;
        private DevComponents.DotNetBar.PanelEx PanelEx_Sequence;
        private DevComponents.DotNetBar.PanelEx panelEx_TrackContent;
        private DevComponents.DotNetBar.PanelEx panelEx_TrackName;
        private DevComponents.DotNetBar.PanelEx panelEx_VideoName;
        private DevComponents.DotNetBar.PanelEx panelEx_AudioName;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 撤销ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重做ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 采集ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 录制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打包输出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设备输出设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList_Files;
        private System.Windows.Forms.Timer timer_Segment;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel_Segment;
        private DevComponents.DotNetBar.PanelEx panelEx_Segment;
        private DevComponents.DotNetBar.TabItem tabItem_Segment;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.TabItem tabItem_SpecialEffect;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
        private DevComponents.DotNetBar.TabItem tabItemTemplate;
        private DevComponents.DotNetBar.Bar bar_AudioTrackButtonBar1;
        private DevComponents.DotNetBar.ButtonItem AudioTrackB1BI_Listen;
        private DevComponents.DotNetBar.ButtonItem AudioTrackB1BI_Volume;
        private DevComponents.DotNetBar.ButtonItem AudioTrackB1BI_Lock;
        private DevComponents.DotNetBar.ButtonItem AudioTrackB1BI_Play;
        private DevComponents.DotNetBar.ButtonItem AudioTrackB1BI_MoveDown;
        private DevComponents.DotNetBar.ButtonItem AudioTrackB1BI_TrackNickName;
        private DevComponents.DotNetBar.Bar bar_AudioTrackButtonBar2;
        private DevComponents.DotNetBar.ButtonItem AudioTrackB2BI_Listen;
        private DevComponents.DotNetBar.ButtonItem AudioTrackB2BI_Volume;
        private DevComponents.DotNetBar.ButtonItem AudioTrackB2BI_Lock;
        private DevComponents.DotNetBar.ButtonItem AudioTrackB2BI_Play;
        private DevComponents.DotNetBar.ButtonItem AudioTrackB2BI_MoveDown;
        private DevComponents.DotNetBar.ButtonItem AudioTrackB2BI_TrackNickName;
        private DevComponents.DotNetBar.PanelEx panelEx_AudioTrackName2;
        private DevComponents.DotNetBar.PanelEx panelEx_AudioTrackName1;
        private DevComponents.DotNetBar.PanelEx panelEx_VideoTrackName2;
        private DevComponents.DotNetBar.Bar bar_VideoTrackButtonBar2;
        private DevComponents.DotNetBar.ButtonItem VideoTrackB2BI_See;
        private DevComponents.DotNetBar.ButtonItem VideoTrackB2BI_Lock;
        private DevComponents.DotNetBar.ButtonItem VideoTrackB2BI_Play;
        private DevComponents.DotNetBar.ButtonItem VideoTrackB2BI_MoveDown;
        private DevComponents.DotNetBar.ButtonItem VideoTrackB2BI_TrackNickName;
        private DevComponents.DotNetBar.PanelEx panelEx_VideoTrackName1;
        private DevComponents.DotNetBar.Bar bar_VideoTrackButtonBar1;
        private DevComponents.DotNetBar.ButtonItem VideoTrackB1BI_See;
        private DevComponents.DotNetBar.ButtonItem VideoTrackB1BI_Lock;
        private DevComponents.DotNetBar.ButtonItem VideoTrackB1BI_Play;
        private DevComponents.DotNetBar.ButtonItem VideoTrackB1BI_MoveDown;
        private DevComponents.DotNetBar.ButtonItem VideoTrackB1BI_TrackNickName;
        private DevComponents.DotNetBar.PanelEx panelEx_AudioTrackConment1;
        private DevComponents.DotNetBar.PanelEx panelEx_AudioTrackConment2;
        private DevComponents.DotNetBar.PanelEx panelEx_VideoTrackConment2;
        private DevComponents.DotNetBar.PanelEx panelEx_VideoTrackConment1;
        private DevComponents.DotNetBar.Bar bar_TrackNameToolBar;
        private DevComponents.DotNetBar.LabelItem labelItem_CurrentTime;
        private DevComponents.DotNetBar.ButtonItem buttonItem_DeleteTrack;
        private DevComponents.DotNetBar.ButtonItem buttonItem_StoreTrack;
        private DevComponents.DotNetBar.ButtonItem buttonItem_TwoToOne;
        private DevComponents.DotNetBar.PanelEx VideoFile1;
        private TimeLineControl.TimeLineControl timeLineControl_MainTL;
        private TimeLineControl.TimeLineControl timeLineControl_Sequence;
        private TimeLineControl.TimeLineControl timeLineControl_Segment;
        private System.Windows.Forms.ToolStripMenuItem 另存为ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 偏好设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工程设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 导入工程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入序列ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入AAFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入配音序列ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 删除未引用的素材ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem 工程整理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工程信息统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 最近打开工程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szwbprjToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem 配音DToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem 显示第二效果监视器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem 缓存管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem 导入P2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入XDCAMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入SxStoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入E2toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入PPTtoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem 光盘刻录ToolStripMenuItem;
    }
}