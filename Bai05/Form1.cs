namespace Bai05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            string text = "ĐH CNTT";
            Point startPoint = new Point(50, 50);
            Font font1 = new Font("Arial", 20, FontStyle.Bold); 
            Font font2 = new Font("Arial", 30, FontStyle.Bold); 
            Font font3 = new Font("Arial", 50, FontStyle.Bold);

            SolidBrush brush1 = new SolidBrush(Color.FromArgb(120, Color.DarkSlateBlue));
            SolidBrush brush2 = new SolidBrush(Color.FromArgb(180, Color.DarkMagenta)); 
            SolidBrush brush3 = new SolidBrush(Color.FromArgb(255, Color.DeepPink));

            g.DrawString(text, font1, new SolidBrush(Color.DarkRed), startPoint.X + 1, startPoint.Y - 5);

            g.DrawString(text, font2, brush1, startPoint.X, startPoint.Y + 50);

            g.DrawString(text, font2, brush2, startPoint.X, startPoint.Y + 120);

            g.DrawString(text, font3, brush3, startPoint.X, startPoint.Y + 180);
            font1.Dispose();
            font2.Dispose();
            font3.Dispose();
            brush1.Dispose();
            brush2.Dispose();
            brush3.Dispose();
        }
    }
}
