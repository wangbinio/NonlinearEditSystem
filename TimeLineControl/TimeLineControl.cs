using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using TimeLineControl;

namespace TimeLineControl
{
    [ToolboxBitmap(typeof(TrackBar))]
    [DefaultEvent("Click"), DefaultProperty("nBotmPadding")]
    public partial class TimeLineControl : Control
    {

        #region Properties

        // 画笔
        public Pen drawPen = new Pen(Color.Black, 1f);

        private Pen drawThumbPen = new Pen(SystemColors.HotTrack, 1f);

        // 字符画刷
        private SolidBrush stringBrush = new SolidBrush(Color.Black);

        // 游标画刷
        private SolidBrush thumbBrush = new SolidBrush(SystemColors.HotTrack);

        // 透明画刷
        private TextureBrush transparentBrush = new TextureBrush(Resource.透明图片4);

        // 间隔
        public int NBotmPadding { get; set; } = 3;

        // 每2个刻度之间的间隔距离
        public int NDistanceOfTicks { get; set; } = 15;

        // 大刻度的长度，小刻度为大刻度的一半
        public int NBigTicksLength { get; set; } = 10;

        // 水平轴的大刻度个数
        public int NNumOfBigTicks { get; set; } = 6;

        // 水平轴一共要显示多长时间(单位：s)，要向上取
        public int NNeedShowSeconds { get; set; } = 3600;

        // 游标中心线的横坐标
        public int ThumbHPos { get; set; }

        // 游标所在的矩形区域
        public Rectangle ThumbRectangle { get; set; }

        // 用户鼠标点击两次选择区域
        public List<Rectangle> _userSelectedRectangles  = new List<Rectangle>(10);

        private double _thumbValue;

        public double ThumbValue
        {
            get { return ((double)NNeedShowSeconds / NNumOfBigTicks / 10) * ((double)ThumbHPos / (double)NDistanceOfTicks); }
            private set { _thumbValue = ((double)NNeedShowSeconds / NNumOfBigTicks / 10) * ((double)ThumbHPos / (double)NDistanceOfTicks) ; }
        }


        #endregion


        #region Members

        private bool _mouseInRegion;
        private bool _mouseInThumbRegion;
        private bool _clickedOnce;
        private bool _clickedTwice;
        private Point _clickedOncePoint;
        private Point _clickedTwicePoint;
        private bool _mouseMoved;

        #endregion


        #region Paint

        /// <summary>
        /// 控件自绘函数
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            //DrawBkg(g);
            DrawHorizontalAxis(g);
            DrawTicks(g);
            DrawTimeTag(g);

            DrawSelectRects(g, _userSelectedRectangles);

            DrawThumb(g);

        }

        /// <summary>
        /// 画背景
        /// </summary>
        /// <param name="g"></param>
        private void DrawBkg(Graphics g)
        {
            Point[] bkgPoint = new Point[4];
            bkgPoint[0] = new Point(0, 0);
            bkgPoint[1] = new Point(0, Height);
            bkgPoint[2] = new Point(Width, 0);
            bkgPoint[3] = new Point(Width, Height);
            g.FillPolygon(new SolidBrush(Color.Black), bkgPoint);
        }

        /// <summary>
        /// 画水平轴
        /// </summary>
        /// <param name="g"></param>
        private void DrawHorizontalAxis(Graphics g)
        {
            Point hStartPoint = new Point(0, Height/* - NBotmPadding*/);
            Point hEndPoint = new Point(Width, Height/* - NBotmPadding*/);

            g.DrawLine(drawPen, hStartPoint, hEndPoint);
        }

        /// <summary>
        /// 画刻度
        /// </summary>
        /// <param name="g"></param>
        private void DrawTicks(Graphics g)
        {
            // 1个长的10，9个短的4，两两相隔15
            // 计算可得每一大格的距离是150
            // 先画6个
            for (int i = 0; i <= NNumOfBigTicks; i++)
            {
                // 1.先画1个长刻度
                int nHbigTick = i * 10 * NDistanceOfTicks;
                int nVbigTick = Height/* - NBotmPadding*/;

                Point bigStartPoint = new Point(nHbigTick, nVbigTick);
                Point bigEndPoint = new Point(nHbigTick, nVbigTick - NBigTicksLength);
                g.DrawLine(drawPen, bigStartPoint, bigEndPoint);

                // 2.再画9个短刻度
                for (int j = 1; j < 10; j++)
                {
                    Point littleStarPoint = new Point(nHbigTick + j * NDistanceOfTicks, nVbigTick);
                    Point littleEndPoint = new Point(nHbigTick + j * NDistanceOfTicks, nVbigTick - NBigTicksLength / 2);
                    g.DrawLine(drawPen, littleStarPoint, littleEndPoint);
                }
            }

        }

        /// <summary>
        /// 画时间刻度
        /// </summary>
        /// <param name="g"></param>
        private void DrawTimeTag(Graphics g)
        {
            // 每个大刻度上方都有一个时间刻度
            // 两个时间刻度之间的间隔为 nNeedShowSeconds/nNumOfBigTicks
            for (int i = 0; i <= NNumOfBigTicks; i++)
            {
                int iTimeValue = i * NNeedShowSeconds / NNumOfBigTicks;
                string sTimeString = ChangeTimeValueToString(iTimeValue);

                // 得到字符串的尺寸
                SizeF sizeOfString = g.MeasureString(sTimeString, Font);

                // 设置字符串的位置
                //float nHPos = i * 10 * NDistanceOfTicks - 2.55f * NDistanceOfTicks;
                float nHPos = i * 10 * NDistanceOfTicks - sizeOfString.Width/2;
                float nVPos = Height - /*2 * */ NBotmPadding - NBigTicksLength - Font.Height;

                g.DrawString(sTimeString, Font, stringBrush, nHPos, nVPos);
            }

        }

        /// <summary>
        /// 画游标
        /// </summary>
        /// <param name="g"></param>
        private void DrawThumb(Graphics g)
        {
            // 游标由5个点和1条直线组成(1,2,3,4,5)(3,6)
            // 先确定中心点3的位置
            Point[] thumbPoints = new Point[5];
            int nVPadding = 3 * NBigTicksLength / 2;
            thumbPoints[2] = new Point(ThumbHPos, nVPadding);
            thumbPoints[0] = new Point(ThumbHPos - NDistanceOfTicks / 2, 0);
            thumbPoints[1] = new Point(ThumbHPos - NDistanceOfTicks / 2, NDistanceOfTicks / 2);
            thumbPoints[3] = new Point(ThumbHPos + NDistanceOfTicks / 2, NDistanceOfTicks / 2);
            thumbPoints[4] = new Point(ThumbHPos + NDistanceOfTicks / 2, 0);

            Point endPoint = new Point(ThumbHPos, Parent.Height);

            // 确定游标所在的rectangle
            ThumbRectangle = new Rectangle(ThumbHPos - NDistanceOfTicks / 2, 0, NDistanceOfTicks, 3 * NBigTicksLength / 2);

            g.FillPolygon(/*transparentBrush*/thumbBrush, thumbPoints);

            g.DrawLine(drawThumbPen, thumbPoints[2], endPoint);
        }

        /// <summary>
        /// 画时间线上鼠标选中区域
        /// </summary>
        /// <param name="g"></param>
        /// <param name="rects"></param>
        private void DrawSelectRects(Graphics g, List<Rectangle> rects)
        {
            foreach (var rect in rects)
            {
                g.DrawImage(Resource._0140230_50, rect);
            }
        }

        #endregion


        #region Overided events

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            _mouseInRegion = true;
            //Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            _mouseInRegion = false;

            //Invalidate();
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            base.OnMouseWheel(e);

            if (!_mouseInRegion) return;

            if (e.Delta > 0)
            {
                NNeedShowSeconds += 300 * NNumOfBigTicks;
            }
            else if (e.Delta < 0)
            {
                NNeedShowSeconds -= 300 * NNumOfBigTicks;
            }

            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            // 鼠标按下的时候让控件获取焦点
            bool bFocused = Focus();

            if (e.Button == MouseButtons.Left)
            {
                Capture = true;

                // 鼠标按下的时候，还未移动
                _mouseMoved = false;
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            Capture = false;

            // 鼠标松开
            _mouseMoved = false;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            Point mousePoint = e.Location;

            _mouseInThumbRegion = IsPointInRect(mousePoint, ThumbRectangle);
            if (Capture && e.Button == MouseButtons.Left)
            {
                // 设置游标新位置
                ThumbHPos = mousePoint.X;

                // 设置鼠标移动为true
                _mouseMoved = true;

                Invalidate();
            }
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            // 1.确认是点击是否在MouseMove之后，是否是右键点击
            if (_mouseMoved) return;
            MouseEventArgs mouseEventArgs = (MouseEventArgs) e;
            if (mouseEventArgs.Button != MouseButtons.Right) return;

            // 2.确认是第一次点击还是第二次点击
            if (!_clickedOnce && !_clickedTwice)
            {   
                // 3.第一次点击
                _clickedOnce = true;

                // 3.1.确定矩形区域，矩形的宽度为1，显示为一条线
                _clickedOncePoint = mouseEventArgs.Location;

                _userSelectedRectangles.Add(new Rectangle(_clickedOncePoint.X, 0, 1, Height));

                Invalidate();
            }
            else if (_clickedOnce && !_clickedTwice)
            {
                // 4.第二次点击
                _clickedOnce = false;

                // 4.1.确定矩形区域，矩形的宽度为第一次与第二次的坐标差
                _clickedTwicePoint = mouseEventArgs.Location;
                _userSelectedRectangles.RemoveAt(_userSelectedRectangles.Count-1);
                _userSelectedRectangles.Add(new Rectangle(Math.Min(_clickedOncePoint.X, _clickedTwicePoint.X), 0, Math.Abs(_clickedOncePoint.X - _clickedTwicePoint.X), Height));

                Invalidate();
            }
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            // 如果当前控件的宽度比刻度的总长度要大，那么增加刻度
            int nDeltaWidth = Width - NNumOfBigTicks*10*NDistanceOfTicks;
            if (nDeltaWidth > 0)
            {
                int nDeltaTicks = nDeltaWidth/(NDistanceOfTicks*10) + nDeltaWidth%(NDistanceOfTicks*10) > 0 ? 1 : 0;
                NNumOfBigTicks += nDeltaTicks;
                NNeedShowSeconds += nDeltaTicks * 600;

                Invalidate();
            }
        }

        #endregion


        #region Help Method

        /// <summary>
        /// 将秒转为字符串格式显示 00：00：00：00
        /// </summary>
        /// <param name="iTimeValue"></param>
        /// <returns></returns>
        public static string ChangeTimeValueToString(int iTimeValue)
        {
            int hour = iTimeValue / 3600;
            int minute = iTimeValue % 3600 / 60;
            int second = iTimeValue % 3600 % 60;

            return $"{hour,2:00}:{minute,2:00}:{second,2:00}:00";
        }

        /// <summary>
        /// 判断点是否处于区域类
        /// </summary>
        /// <param name="pt"></param>
        /// <param name="rect"></param>
        /// <returns></returns>
        public static bool IsPointInRect(Point pt, Rectangle rect)
        {
            if (pt.X > rect.Left & pt.X < rect.Right & pt.Y > rect.Top & pt.Y < rect.Bottom)
                return true;
            else return false;
        }

        #endregion


        public TimeLineControl()
        {
            InitializeComponent();

            //SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);

            ThumbHPos = Width / 3;
        }
    }
}
