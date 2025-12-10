using System.Drawing.Drawing2D;

namespace Bai08
{
    public partial class Form1 : Form
    {
        private const int MaxRadius = 150;
        private Point Center;
        public Form1()
        {
            InitializeComponent();
        }

        private Point AngleToCoordinate(int angle, int radius, Point center)
        {
            double rad = angle * Math.PI / 180;
            int x = (int)(center.X + radius * Math.Cos(rad - Math.PI / 2));
            int y = (int)(center.Y + radius * Math.Sin(rad - Math.PI / 2));

            return new Point(x, y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            DateTime now = DateTime.Now;
            Center = new Point(this.ClientSize.Width / 2, this.ClientSize.Height / 2);
            int radius = Math.Min(Center.X, Center.Y) - 20; 
            Brush whiteBrush = Brushes.Black;

            for (int i = 1; i <= 60; i++)
            {
                int angle = i * 6;
                Point outer = AngleToCoordinate(angle, radius, Center);

                if (i % 5 == 0) 
                {
                    g.FillEllipse(whiteBrush, outer.X - 8, outer.Y - 8, 16, 16);
                }
                else
                {
                    g.FillEllipse(whiteBrush, outer.X - 3, outer.Y - 3, 6, 6);
                }
            }

            int hourAngle = (int)(360.0 / (12.0 * 60.0) * (now.Hour % 12 * 60 + now.Minute));
            int hourRadius = (int)(radius * 0.5);
            int minuteAngle = (int)(360.0 / 60.0 * (now.Minute + now.Second / 60.0));
            int minuteRadius = (int)(radius * 0.7);
            int secondAngle = now.Second * 6;
            int secondRadius = (int)(radius * 0.9);

            Pen hourPen = new Pen(Color.Red, 5);
            Pen minutePen = new Pen(Color.Blue, 3);
            Pen secondPen = new Pen(Color.DarkGreen, 1);

            Point hourTip = AngleToCoordinate(hourAngle, hourRadius, Center);
            g.DrawLine(hourPen, Center, hourTip);

            Point minuteTip = AngleToCoordinate(minuteAngle, minuteRadius, Center);
            g.DrawLine(minutePen, Center, minuteTip);

            Point secondTip = AngleToCoordinate(secondAngle, secondRadius, Center);
            g.DrawLine(secondPen, Center, secondTip);

            g.FillEllipse(Brushes.White, Center.X - 5, Center.Y - 5, 10, 10);

            hourPen.Dispose();
            minutePen.Dispose();
            secondPen.Dispose();
        }
    }
}
