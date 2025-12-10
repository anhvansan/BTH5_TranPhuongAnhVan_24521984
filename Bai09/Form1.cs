namespace Bai09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbbShapes.SelectedIndex = 0;
        }

        private void cbbShapes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (cbbShapes.SelectedIndex == null) return;
            Graphics g = e.Graphics;
            string selectedShape = cbbShapes.SelectedItem.ToString();

            Pen borderPen = new Pen(Color.DarkSalmon, 3);
            Brush fillBrush = new SolidBrush(Color.Maroon);

            int size = 200;
            int x = (this.ClientSize.Width - size) / 2;
            int y = (this.ClientSize.Height - size) / 2;
            Rectangle rec = new Rectangle(x, y, size, size);

            int widthEllipse = 300;
            int heightEllipse = 150;
            int xEllipse = (this.ClientSize.Width - widthEllipse) / 2;
            int yEllipse = (this.ClientSize.Height - heightEllipse) / 2;
            Rectangle rectEllipse = new Rectangle(xEllipse, yEllipse, widthEllipse, heightEllipse);

            switch (selectedShape)
            {
                case "Circle":
                    g.DrawEllipse(borderPen, rec); break;
                case "Ellipse":
                    g.DrawEllipse(borderPen, rectEllipse); break;
                case "Square":
                    g.DrawRectangle(borderPen, rec); break;
                case "Pie":
                    g.DrawPie(borderPen, rec, 0, 270); break;
                case "Filled Circle":
                    g.FillEllipse(fillBrush, rec); break;
                case "Filled Ellipse":
                    g.FillEllipse(fillBrush, rectEllipse); break;
                case "Filled Square":
                    g.FillRectangle(fillBrush, rec); break;
                case "Filled Pie":
                    g.FillPie(fillBrush, rec, 0, 270); break;
                default:
                    g.Clear(this.BackColor); break;
            }
            borderPen.Dispose();
            fillBrush.Dispose();
        }
    }
}
