using System.Drawing;
namespace Bai06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
                lstFonts.Items.Add(font.Name);
        }

        private void lstFonts_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            string fontName = lstFonts.Items[e.Index].ToString();
            Font currentFont;
            try
            {
                currentFont = new Font(fontName, 14);
            }
            catch
            {
                currentFont = new Font("Arial", 18);
            }
            Brush textBrush = Brushes.Black;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(SystemBrushes.Highlight, e.Bounds);
                textBrush = Brushes.White;
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(lstFonts.BackColor), e.Bounds);
            }
            e.Graphics.DrawString(fontName, currentFont, textBrush, e.Bounds.X + 2, e.Bounds.Y);

            currentFont.Dispose();

            e.DrawFocusRectangle();
        }
    }
}
