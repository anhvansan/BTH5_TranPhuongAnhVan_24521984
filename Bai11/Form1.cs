using System.Drawing.Drawing2D;

namespace Bai11
{
    public partial class Form1 : Form
    {
        private Bitmap drawingBitmap;
        private Point startPoint;
        private Point endPoint;
        private bool isDrawing = false;
        private Color penColor = Color.Black;
        private Graphics g;
        public Form1()
        {
            InitializeComponent();
            drawingBitmap = new Bitmap(picDrawing.Width, picDrawing.Height);
            picDrawing.Image = drawingBitmap;
            g = Graphics.FromImage(drawingBitmap);
            g.Clear(Color.White);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbShape.Items.Add("Line");
            cmbShape.Items.Add("Rectangle");
            cmbShape.Items.Add("Ellipse");
            cmbShape.SelectedIndex = 0;

            cmbBrush.Items.Add("SolidBrush");
            cmbBrush.Items.Add("HatchBrush");
            cmbBrush.Items.Add("TextureBrush");
            cmbBrush.Items.Add("LinearGradientBrush");
            cmbBrush.SelectedIndex = 0;
            txtWidth.Text = "5";
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                penColor = dlgColor.Color;
                btnColor.BackColor = penColor;
            }
        }

        private void picDrawing_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                startPoint = e.Location;
            }
        }

        private void picDrawing_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                isDrawing = false;
                endPoint = e.Location;
                DrawFinalShape(g);
                picDrawing.Invalidate();
            }
        }

        private void picDrawing_MouseMove(object sender, MouseEventArgs e)
        {

        }
        private void DrawFinalShape(Graphics g)
        {
            int x = Math.Min(startPoint.X, endPoint.X);
            int y = Math.Min(startPoint.Y, endPoint.Y);
            int w = Math.Abs(startPoint.X - endPoint.X);
            int h = Math.Abs(startPoint.Y - endPoint.Y);
            Rectangle rect = new Rectangle(x, y, w, h);

            if (!float.TryParse(txtWidth.Text, out float penWidth))
                penWidth = 1;

            string selectedShape = cmbShape.SelectedItem.ToString();
            string selectedBrush = cmbBrush.SelectedItem.ToString();

            if (selectedShape == "Line")
            {
                using (Pen pen = new Pen(penColor, penWidth))
                {
                    g.DrawLine(pen, startPoint, endPoint);
                }
                return;
            }

            Brush brush = null;

            switch (selectedBrush)
            {
                case "SolidBrush":
                    brush = new SolidBrush(penColor);
                    break;

                case "HatchBrush":
                    brush = new HatchBrush(
                        HatchStyle.Horizontal,
                        Color.Blue,
                        Color.Green
                    );
                    break;

                case "TextureBrush":
                    Image textureImage = global::Bai11.Properties.Resources.trello;
                    brush = textureImage != null ? new TextureBrush(textureImage) : Brushes.Gray;
                    break;

                case "LinearGradientBrush":
                    brush = new LinearGradientBrush(
                        rect,
                        Color.Red,
                        Color.Green,
                        LinearGradientMode.Vertical
                    );
                    break;
            }

            if (brush != null)
            {
                if (selectedShape == "Rectangle")
                    g.FillRectangle(brush, rect);
                else if (selectedShape == "Ellipse")
                    g.FillEllipse(brush, rect);

                if (brush is IDisposable d)
                    d.Dispose();
            }
        }

    }
}
