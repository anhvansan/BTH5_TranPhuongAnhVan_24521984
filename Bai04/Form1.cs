using System.Drawing;
namespace Bai04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ckbBold_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFont();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
                cmbFont.Items.Add(font.Name);
            cmbFont.Text = "Arial";
            cmbSize.Text = "28";
            txtOutput.ForeColor = btnColor.BackColor;
        }

        private void UpdateFont()
        {
            if (!float.TryParse(cmbSize.Text, out float size))
                size = 28;
            FontStyle style = FontStyle.Regular;
            if (ckbBold.Checked)
                style |= FontStyle.Bold;
            if (ckbItalic.Checked)
                style |= FontStyle.Italic;
            if (ckbUnderline.Checked)
                style |= FontStyle.Underline;
            try
            {
                txtOutput.Font = new Font(cmbFont.Text, size, style);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi chọn Font!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdoLeft_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoLeft.Checked)
                txtOutput.TextAlign = HorizontalAlignment.Left;
        }

        private void ckbItalic_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFont();
        }

        private void ckbUnderline_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFont();
        }

        private void cmbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFont();
        }

        private void cmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFont();
        }

        private void cmbSize_TextChanged(object sender, EventArgs e)
        {
            UpdateFont();
        }

        private void rdoCenter_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCenter.Checked)
                txtOutput.TextAlign = HorizontalAlignment.Center;
        }

        private void rdoRight_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoRight.Checked)
                txtOutput.TextAlign = HorizontalAlignment.Right;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtOutput.ForeColor = colorDialog1.Color;
                btnColor.BackColor = colorDialog1.Color;
            }
        }
    }
}
