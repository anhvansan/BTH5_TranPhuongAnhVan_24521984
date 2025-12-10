using System.Drawing.Drawing2D;

namespace Bai10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> dashStyles = Enum.GetNames(typeof(System.Drawing.Drawing2D.DashStyle)).ToList();

            dashStyles.Add("Custom");

            cmbDashStyle.DataSource = dashStyles;
            cmbDashStyle.SelectedItem = "Custom";

            cmbLineJoin.DataSource = Enum.GetNames(typeof(System.Drawing.Drawing2D.LineJoin));
            cmbLineJoin.SelectedItem = "Round";

            cmbDashCap.DataSource = Enum.GetNames(typeof(System.Drawing.Drawing2D.DashCap));
            cmbDashCap.SelectedItem = "Triangle";

            cmbStartCap.DataSource = Enum.GetNames(typeof(System.Drawing.Drawing2D.LineCap));
            cmbStartCap.SelectedItem = "ArrowAnchor";

            cmbEndCap.DataSource = Enum.GetNames(typeof(System.Drawing.Drawing2D.LineCap));
            cmbEndCap.SelectedItem = "DiamondAnchor";

            txtWidth.Text = "8";
        }

        private void pnlDrawing_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;


            if (!float.TryParse(txtWidth.Text, out float width))
                width = 1; 

            LineJoin lineJoin = (LineJoin)Enum.Parse(typeof(LineJoin), cmbLineJoin.SelectedItem.ToString());
            DashCap dashCap = (DashCap)Enum.Parse(typeof(DashCap), cmbDashCap.SelectedItem.ToString());

            LineCap startCap = (LineCap)Enum.Parse(typeof(LineCap), cmbStartCap.SelectedItem.ToString());
            LineCap endCap = (LineCap)Enum.Parse(typeof(LineCap), cmbEndCap.SelectedItem.ToString());

            using (Pen pen = new Pen(Color.Red, width))
            {
                pen.LineJoin = lineJoin;
                pen.DashCap = dashCap;
                pen.StartCap = startCap;
                pen.EndCap = endCap;
                string dashStyleName = cmbDashStyle.SelectedItem.ToString();
                if (dashStyleName == "Custom")
                {
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Custom;
                    pen.DashPattern = new float[] { 2, 1, 0.5f, 1 };
                }
                else
                {
                    pen.DashStyle = (System.Drawing.Drawing2D.DashStyle)Enum.Parse(typeof(System.Drawing.Drawing2D.DashStyle), dashStyleName);
                }

                Point[] points = new Point[]
                {
                    new Point(50, 200),
                    new Point(100, 100),
                    new Point(300, 300),
                    new Point(500, 50),
                    new Point(650, 200) 
                };

                g.DrawLines(pen, points);
            }
        }

        private void cmbDashStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlDrawing.Invalidate();
        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {
            pnlDrawing.Invalidate();
        }

        private void cmbLineJoin_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlDrawing.Invalidate();
        }

        private void cmbDashCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlDrawing.Invalidate();
        }

        private void cmbStartCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlDrawing.Invalidate();
        }

        private void cmbEndCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlDrawing.Invalidate();
        }
    }
}
