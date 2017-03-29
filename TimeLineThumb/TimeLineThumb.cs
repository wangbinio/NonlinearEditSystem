using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeLineThumb
{
    [ToolboxBitmap(typeof(TrackBar))]
    [DefaultEvent("MouseMove"), DefaultProperty("ThumbHPos")]
    public partial class TimeLineThumb : UserControl
    {
        public TimeLineThumb()
        {
            InitializeComponent();
        }

        #region Properties

        // 画笔
        private Pen drawPen = new Pen(Color.Black, 1f);

        // 画刷
        private SolidBrush pointBrush = new SolidBrush(Color.Black);

        // 游标中心线的横坐标
        [Description("Set  thumb Horizontal Pos")]
        [Category("Size")]
        [DefaultValue(0)]
        public int ThumbHPos { get; set; } = 8;

        // 游标的宽度
        [Description("Set  thumb Width")]
        [Category("Size")]
        [DefaultValue(16)]
        public int ThumbWidth { get; set; } = 16;

        // 游标所在的矩形区域
        public Rectangle ThumbRectangle { get; set; }

        #endregion

        #region Paint

        /// <summary>
        /// 画游标
        /// </summary>
        /// <param name="g"></param>
        private void DrawThumb(Graphics g)
        {
            // 游标由5个点和1条直线组成(1,2,3,4,5)(3,6)
            // 先确定中心点3的位置
            Point[] thumbPoints = new Point[5];
            int nVPadding = 3 * ThumbWidth / 2;
            thumbPoints[2] = new Point(ThumbHPos, nVPadding);
            thumbPoints[0] = new Point(ThumbHPos - ThumbWidth / 2, 0);
            thumbPoints[1] = new Point(ThumbHPos - ThumbWidth / 2, ThumbWidth / 2);
            thumbPoints[3] = new Point(ThumbHPos + ThumbWidth / 2, ThumbWidth / 2);
            thumbPoints[4] = new Point(ThumbHPos + ThumbWidth / 2, 0);

            // 确定游标所在的rectangle
            ThumbRectangle = new Rectangle(ThumbHPos - ThumbWidth / 2, 0, ThumbWidth, nVPadding);

            Point endPoint = new Point(ThumbHPos, Parent.Height);

            g.FillPolygon(pointBrush, thumbPoints);

            Pen cBulePen = new Pen(Color.Blue);

            g.DrawLine(cBulePen, thumbPoints[2], endPoint);
        }

        #endregion


        private void TimeLineThumb_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            DrawThumb(g);
        }
    }
}
