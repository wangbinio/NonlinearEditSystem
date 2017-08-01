using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;
using TimeLineControl;

namespace TimeLineControl
{
    /// <summary>
    /// 类说明：自绘时间线控件
    /// 日期：2017-03-17
    /// 作者：szwb
    /// 修改：2017-03-18 szwb
    /// 修改：2017-04-23 szwb 随着视频的播放，游标自动移动
    /// 修改：2017-05-19 szwb 时间刻度分类
    /// 修改：2017-06-15 szwb 添加出点入点区域,右键点击生成区域废除
    /// 修改：2017-06-22 szwb 时间线的缩放拖拉基本完成
    /// </summary>
    [ToolboxBitmap(typeof(TrackBar))]
    [DefaultEvent("Click"), DefaultProperty("nBotmPadding")]
    public partial class TimeLineControl : Control
    {

        #region Properties

        /// 画笔
        public Pen drawPen = new Pen(Color.FromArgb(239, 239, 242), 1f);

        public Pen drawIntervalPen = new Pen(Color.Orange, 1f);

        private Pen drawThumbPen = new Pen(SystemColors.Highlight, 1f);

        /// 字符画刷
        private SolidBrush stringBrush = new SolidBrush(Color.FromArgb(239, 239, 242));

        /// 游标画刷
        private SolidBrush thumbBrush = new SolidBrush(SystemColors.Highlight);

        /// 透明画刷
        private TextureBrush transparentBrush = new TextureBrush(Resource.透明图片4);

        private TextureBrush transparentBrush2 = new TextureBrush(Resource._0140230_50);

        /// 间隔
        public int NBotmPadding { get; set; } = 3;

        /// 每2个刻度之间的间隔距离
        public int NDistanceOfTicks { get; set; } = 15;

        /// 大刻度的长度，小刻度为大刻度的一半
        public int NBigTicksLength { get; set; } = 10;

        /// 水平轴的大刻度个数
        public int NNumOfBigTicks { get; set; } = 24;

        /// 水平轴一共要显示多长时间(单位：s)，要向上取
        public int NNeedShowSeconds { get; set; } = 7200;

        /// 每一小格的时间间隔（秒），对应的大格为10s,30s,1min,2min,5min,10min,20min
        public readonly int[] SecondsEveryTicks = new[] { 1, 3, 6, 12, 30, 60, 120};

        /// 当前一小格的时间值，SecondsEveryTicks[IndexOfSecEveryTicks]
        public int IndexOfSecEveryTicks { get; set; } = 3;

        /// 游标中心线的横坐标
        public int ThumbHPos { get; set; } = 500;

        /// 游标所在的矩形区域
        public Rectangle ThumbRectangle { get; set; }

        /// 用户鼠标点击两次选择区域
        public List<Rectangle> _userSelectedRectangles = new List<Rectangle>(10);

        /// 游标位置时间值
        public double ThumbValue => (SecondsEveryTicks[IndexOfSecEveryTicks] * (double)ThumbHPos / (double)NDistanceOfTicks);

        // 入点和出点横坐标
        public int enterPos = 100;
        public int exitPos = 900;

        // 出点和入点的时间
        public double enterValue => (SecondsEveryTicks[IndexOfSecEveryTicks] * (double)enterPos / (double)NDistanceOfTicks);
        public double exitValue => (SecondsEveryTicks[IndexOfSecEveryTicks] * (double)exitPos / (double)NDistanceOfTicks);

        // 关联时间线控件,当自身改变的时候,关联的也做相应改变
        public TimeLineControl RelativeTimeLineControl;


        /// <summary>
        /// 每一秒的距离间隔
        /// </summary>
        //public double IntervalEverySec
        //{
        //    get { return NDistanceOfTicks / (NNeedShowSeconds / NNumOfBigTicks / 10.0); }
        //}


        #endregion


        #region EventMembers

        // 鼠标是否在区域中
        private bool _mouseInRegion;
        private bool _mouseInThumbRegion;

        // 右键点击的次数
        private bool _clickedOnce;
        private bool _clickedTwice;

        // 鼠标第一次右击的点和第二次右击的点
        private Point _clickedOncePoint;
        private Point _clickedTwicePoint;

        /// <summary>
        /// 鼠标是否移动
        /// </summary>
        private bool _mouseMoved;

        /// <summary>
        /// 是否点击选中游标
        /// </summary>
        public bool _chooseThumb;

        /// <summary>
        /// 是否点击选中入点
        /// </summary>
        private bool _chooseEntrePoint;

        /// <summary>
        /// 是否点击选中出点
        /// </summary>
        private bool _chooseExitPoint;

        /// <summary>
        /// 用于表示鼠标点击误差范围
        /// </summary>
        private float fClickDelta = 5.0f;

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

            // 不再画右键点击生成的矩形区域
            // DrawSelectRects(g, _userSelectedRectangles);


            DrawInterval(g);
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
                //int iTimeValue = i * NNeedShowSeconds / NNumOfBigTicks;
                int iTimeValue = i * SecondsEveryTicks[IndexOfSecEveryTicks] * 10;
                string sTimeString = ChangeTimeValueToString(iTimeValue);

                // 得到字符串的尺寸
                SizeF sizeOfString = g.MeasureString(sTimeString, Font);

                // 设置字符串的位置
                //float nHPos = i * 10 * NDistanceOfTicks - 2.55f * NDistanceOfTicks;
                float nHPos = i * 10 * NDistanceOfTicks - sizeOfString.Width / 2;
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
            thumbPoints[2] = new Point((int)ThumbHPos, nVPadding);
            thumbPoints[0] = new Point((int)ThumbHPos - NDistanceOfTicks / 2, 0);
            thumbPoints[1] = new Point((int)ThumbHPos - NDistanceOfTicks / 2, NDistanceOfTicks / 2);
            thumbPoints[3] = new Point((int)ThumbHPos + NDistanceOfTicks / 2, NDistanceOfTicks / 2);
            thumbPoints[4] = new Point((int)ThumbHPos + NDistanceOfTicks / 2, 0);

            Point endPoint = new Point((int)ThumbHPos, Parent.Height);

            // 确定游标所在的rectangle
            ThumbRectangle = new Rectangle((int)ThumbHPos - NDistanceOfTicks / 2, 0, NDistanceOfTicks, 3 * NBigTicksLength / 2);

            g.FillPolygon(/*transparentBrush*/thumbBrush, thumbPoints);

            g.DrawLine(drawThumbPen, thumbPoints[2], endPoint);
        }


        /// <summary>
        /// 画区间,入点,出点
        /// </summary>
        /// <param name="g"></param>
        private void DrawInterval(Graphics g)
        {
            Point[] intervalPoint = new Point[10];
            intervalPoint[0] = new Point(enterPos, 2);
            intervalPoint[1] = new Point(enterPos + 5, 2);
            intervalPoint[2] = new Point(exitPos - 5, 2);
            intervalPoint[3] = new Point(exitPos, 2);

            intervalPoint[4] = new Point(enterPos, Height - 2);
            intervalPoint[5] = new Point(enterPos + 5, Height - 2);
            intervalPoint[6] = new Point(exitPos - 5, Height - 2);
            intervalPoint[7] = new Point(exitPos, Height - 2);

            g.DrawLine(drawIntervalPen, intervalPoint[0], intervalPoint[1]);
            g.DrawLine(drawIntervalPen, intervalPoint[0], intervalPoint[4]);
            g.DrawLine(drawIntervalPen, intervalPoint[5], intervalPoint[4]);

            g.DrawLine(drawIntervalPen, intervalPoint[3], intervalPoint[2]);
            g.DrawLine(drawIntervalPen, intervalPoint[3], intervalPoint[7]);
            g.DrawLine(drawIntervalPen, intervalPoint[6], intervalPoint[7]);

            //g.DrawRectangle(drawThumbPen, enterPos, 0, exitPos-enterPos, Height-2);
            g.FillRectangle(transparentBrush2, enterPos + 1, 2, exitPos - enterPos - 2, Height - 4);
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
            return;

            if (!_mouseInRegion) return;

            if (e.Delta > 0)
            {
                //NNeedShowSeconds += 300 * NNumOfBigTicks;

                if (IndexOfSecEveryTicks < SecondsEveryTicks.Length - 1)
                {
                    IndexOfSecEveryTicks++;
                }
            }
            else if (e.Delta < 0)
            {
                //NNeedShowSeconds -= 300 * NNumOfBigTicks;
                if (IndexOfSecEveryTicks > 0)
                {
                    IndexOfSecEveryTicks--;
                }
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

                // 点击的时候要确定是点击到了游标区域,还是出入点区域
                // 1.如果点击的位置,离游标很近,则表示想移动游标
                // 2.如果点击在出入点区域,那么表示想移动出入点
                if (Math.Abs((float)e.X - (float)ThumbHPos) < fClickDelta)
                {
                    _chooseThumb = true;
                }
                else if (Math.Abs((float)e.X - (float)enterPos) < fClickDelta)
                {
                    _chooseEntrePoint = true;
                }
                else if (Math.Abs((float)e.X - (float)exitPos) < fClickDelta)
                {
                    _chooseExitPoint = true;
                }


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
            _chooseThumb = false;
            _chooseEntrePoint = false;
            _chooseExitPoint = false;

            if (RelativeTimeLineControl != null)
            {
                RelativeTimeLineControl.SetPosByValue(enterValue, TimeLinePos.Pos_Enter);
                RelativeTimeLineControl.SetPosByValue(exitValue, TimeLinePos.Pos_Exit);
                RelativeTimeLineControl.SetPosByValue(ThumbValue, TimeLinePos.Pos_Thumb);

                RelativeTimeLineControl.Invalidate();
            }

        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            Point mousePoint = e.Location;

            //_mouseInThumbRegion = IsPointInRect(mousePoint, ThumbRectangle);
            if (Capture && e.Button == MouseButtons.Left)
            {
                // 设置鼠标移动为true
                _mouseMoved = true;

                if (_chooseThumb)
                {
                    // 设置游标新位置
                    ThumbHPos = mousePoint.X > 0 ? mousePoint.X : 0;
                }
                else if (_chooseEntrePoint)
                {
                    // 设置入点新位置
                    enterPos = mousePoint.X;
                    if (enterPos <= 0)
                    {
                        enterPos = 0;
                    }
                    // 设置一个值,让入点不要被拖过出点, 两者间距至少一格
                    if (enterPos > exitPos - NDistanceOfTicks)
                    {
                        enterPos = exitPos - NDistanceOfTicks;
                    }
                }
                else if (_chooseExitPoint)
                {
                    // 设置出点新位置,两者间距至少一格
                    exitPos = mousePoint.X;
                    // 设置一个值,让入点不要被拖过出点
                    if (enterPos > exitPos - NDistanceOfTicks)
                    {
                        exitPos = enterPos + NDistanceOfTicks;
                    }
                }
                else
                {
                    _mouseMoved = false;
                }

                Invalidate();

                if (RelativeTimeLineControl != null)
                {
                    RelativeTimeLineControl.SetPosByValue(enterValue, TimeLinePos.Pos_Enter);
                    RelativeTimeLineControl.SetPosByValue(exitValue, TimeLinePos.Pos_Exit);
                    RelativeTimeLineControl.SetPosByValue(ThumbValue, TimeLinePos.Pos_Thumb);

                    RelativeTimeLineControl.Invalidate();
                }
            }

            base.OnMouseMove(e);

        }

        protected override void OnClick(EventArgs e)
        {
            MouseEventArgs mouseEventArgs = (MouseEventArgs)e;
            
            // 1.判断是左键点击还是右键点击
            if (_mouseMoved) return;
            if (mouseEventArgs.Button == MouseButtons.Left)
            {
                ThumbHPos = mouseEventArgs.X;
            }

            Invalidate();

            base.OnClick(e);
        }


        /// <summary>
        /// 右键点击事件,现已弃用
        /// </summary>
        /// <param name="e"></param>
        protected void OnClick_RightButton(EventArgs e)
        {
            base.OnClick(e);

            // 1.确认是点击是否在MouseMove之后，是否是右键点击
            if (_mouseMoved) return;
            MouseEventArgs mouseEventArgs = (MouseEventArgs)e;
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
                _userSelectedRectangles.RemoveAt(_userSelectedRectangles.Count - 1);
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
            //TODO:sizechagne();
            return;
            // 如果当前控件的宽度比刻度的总长度要大，那么增加刻度
            int nDeltaWidth = Width - NNumOfBigTicks * 10 * NDistanceOfTicks;
            if (nDeltaWidth > 0)
            {
                int nDeltaTicks = nDeltaWidth / (NDistanceOfTicks * 10) + nDeltaWidth % (NDistanceOfTicks * 10) > 0 ? 1 : 0;
                NNumOfBigTicks += nDeltaTicks;
                //NNeedShowSeconds += nDeltaTicks * 600;

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

        /// <summary>
        /// 入点,出点,游标枚举
        /// </summary>
        public enum TimeLinePos
        {
            Pos_Enter,
            Pos_Exit,
            Pos_Thumb
        }

        /// <summary>
        /// 通过时间值设置入点,出点,游标的位置
        /// </summary>
        /// <param name="dValue"></param>
        /// <param name="ePos"></param>
        public void SetPosByValue(double dValue, TimeLinePos ePos)
        {
            switch (ePos)
            {
                case TimeLinePos.Pos_Enter:
                    enterPos = (int)(dValue / SecondsEveryTicks[IndexOfSecEveryTicks] * NDistanceOfTicks);
                    break;
                case TimeLinePos.Pos_Exit:
                    exitPos = (int)(dValue / SecondsEveryTicks[IndexOfSecEveryTicks] * NDistanceOfTicks);
                    break;
                case TimeLinePos.Pos_Thumb:
                    ThumbHPos = (int)(dValue / SecondsEveryTicks[IndexOfSecEveryTicks] * NDistanceOfTicks);
                    break;
                default:
                    break;
            }

            Invalidate();
        }

        /// <summary>
        /// 设置关联的时间线控件
        /// </summary>
        /// <param name="otherTimelineControl"></param>
        public void SetRelativeControl(TimeLineControl otherTimelineControl)
        {
            if (otherTimelineControl != null)
            {
                RelativeTimeLineControl = otherTimelineControl;
                RelativeTimeLineControl.IndexOfSecEveryTicks = IndexOfSecEveryTicks;
                RelativeTimeLineControl.SetPosByValue(enterValue, TimeLinePos.Pos_Enter);
                RelativeTimeLineControl.SetPosByValue(exitValue, TimeLinePos.Pos_Exit);
                RelativeTimeLineControl.SetPosByValue(ThumbValue, TimeLinePos.Pos_Thumb);

                RelativeTimeLineControl.Invalidate();
            }
        }


        /// <summary>
        /// 设置刻度间隔
        /// </summary>
        /// <param name="bAdd">true为加, false为减</param>
        public bool ChangeIndexOfSecEveryTicks(bool bAdd)
        {
            // 0.每次改变之前先判断能不能变,如果不能,则退出,提高效率
            if (bAdd && IndexOfSecEveryTicks == 0 || !bAdd && IndexOfSecEveryTicks == SecondsEveryTicks.Length - 1)
            {
                return false;
            }

            // 1.在改变之前保存入点,出点,游标点的值
            double tempEnter = enterValue;
            double tempExit = exitValue;
            double tempThumb = ThumbValue;

            // 2.变换刻度的同时,整个时间条需要显示的时间也需改变,长度也需要改变
            if (bAdd)
            {
                if (IndexOfSecEveryTicks > 0)
                {
                    IndexOfSecEveryTicks--;

                    /*NNeedShowSeconds = NNeedShowSeconds * SecondsEveryTicks[IndexOfSecEveryTicks] /
                                       SecondsEveryTicks[IndexOfSecEveryTicks + 1];*/

                    Width = Width * SecondsEveryTicks[IndexOfSecEveryTicks + 1] / SecondsEveryTicks[IndexOfSecEveryTicks];
                }
            }
            else
            {
                if (IndexOfSecEveryTicks < SecondsEveryTicks.Length - 1)
                {
                    IndexOfSecEveryTicks++;

                    NNeedShowSeconds = NNeedShowSeconds * SecondsEveryTicks[IndexOfSecEveryTicks] /
                                      SecondsEveryTicks[IndexOfSecEveryTicks - 1];

                    Width = Width * SecondsEveryTicks[IndexOfSecEveryTicks - 1] / SecondsEveryTicks[IndexOfSecEveryTicks];
                }
            }

            // 防止出现太长或者太短的情况,2个小时到4个小时
            if (NNeedShowSeconds < 2 * 3600)
            {
                NNeedShowSeconds = 2 * 3600;
            }
            else if (NNeedShowSeconds > 4 * 3600)
            {
                NNeedShowSeconds = 4 * 3600;
            }

            NNumOfBigTicks = NNeedShowSeconds / SecondsEveryTicks[IndexOfSecEveryTicks] / 10;

            // 最少12个刻度
            if (NNumOfBigTicks < 12)
            {
                NNumOfBigTicks = 12;
            }

            // 最多2 * 60 * 6 个刻度,2个小时.
            if (NNumOfBigTicks > 2 * 60 * 6)
            {
                NNumOfBigTicks = 2 * 60 * 6;
            }

            // 如果比大面板小,则设置为大面板的大小
            if (Width < Parent.Parent.Width)
            {
                Width = Parent.Parent.Width;
            }

            // 如果太长,则设置为最大长度
            if (Width > NDistanceOfTicks * 10 * NNumOfBigTicks)
            {
                Width = NDistanceOfTicks * 10 * NNumOfBigTicks;
            }



            // 3.修改变换刻度之后的入点,出点,游标位置
            SetPosByValue(tempEnter, TimeLinePos.Pos_Enter);
            SetPosByValue(tempExit, TimeLinePos.Pos_Exit);
            SetPosByValue(tempThumb, TimeLinePos.Pos_Thumb);

            Invalidate();

            if (RelativeTimeLineControl != null)
            {
                if (IndexOfSecEveryTicks >= SecondsEveryTicks.Length / 2 && IndexOfSecEveryTicks <= SecondsEveryTicks.Length - 2)
                {
                    RelativeTimeLineControl.IndexOfSecEveryTicks = IndexOfSecEveryTicks + 1;
                }
                RelativeTimeLineControl.IndexOfSecEveryTicks = IndexOfSecEveryTicks;
                RelativeTimeLineControl.SetPosByValue(tempEnter, TimeLinePos.Pos_Enter);
                RelativeTimeLineControl.SetPosByValue(tempExit, TimeLinePos.Pos_Exit);
                RelativeTimeLineControl.SetPosByValue(tempThumb, TimeLinePos.Pos_Thumb);
                RelativeTimeLineControl.Invalidate();
            }

            return true;

        }


        /// <summary>
        /// 通过传入一个位置,得到位置的时间
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        public double GetTimeValueByPos(int pos)
        {
            return (SecondsEveryTicks[IndexOfSecEveryTicks] * pos / (double)NDistanceOfTicks);
        }


        /// <summary>
        /// 通过值得到位置
        /// </summary>
        /// <param name="dValue"></param>
        /// <returns></returns>
        public int GetPosByTimeValue(double dValue)
        {
            return (int)(dValue / SecondsEveryTicks[IndexOfSecEveryTicks] * NDistanceOfTicks);
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
