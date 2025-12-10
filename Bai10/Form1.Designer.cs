namespace Bai10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            txtWidth = new TextBox();
            cmbEndCap = new ComboBox();
            cmbStartCap = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            cmbDashCap = new ComboBox();
            label4 = new Label();
            cmbLineJoin = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            cmbDashStyle = new ComboBox();
            label1 = new Label();
            pnlDrawing = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaShell;
            panel1.Controls.Add(txtWidth);
            panel1.Controls.Add(cmbEndCap);
            panel1.Controls.Add(cmbStartCap);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cmbDashCap);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cmbLineJoin);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cmbDashStyle);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 450);
            panel1.TabIndex = 0;
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(130, 112);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(167, 31);
            txtWidth.TabIndex = 2;
            txtWidth.TextChanged += txtWidth_TextChanged;
            // 
            // cmbEndCap
            // 
            cmbEndCap.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEndCap.FormattingEnabled = true;
            cmbEndCap.Location = new Point(130, 375);
            cmbEndCap.Name = "cmbEndCap";
            cmbEndCap.Size = new Size(167, 33);
            cmbEndCap.TabIndex = 1;
            cmbEndCap.SelectedIndexChanged += cmbEndCap_SelectedIndexChanged;
            // 
            // cmbStartCap
            // 
            cmbStartCap.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStartCap.FormattingEnabled = true;
            cmbStartCap.Location = new Point(130, 315);
            cmbStartCap.Name = "cmbStartCap";
            cmbStartCap.Size = new Size(167, 33);
            cmbStartCap.TabIndex = 1;
            cmbStartCap.SelectedIndexChanged += cmbStartCap_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 378);
            label6.Name = "label6";
            label6.Size = new Size(82, 25);
            label6.TabIndex = 0;
            label6.Text = "End Cap:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 318);
            label5.Name = "label5";
            label5.Size = new Size(88, 25);
            label5.TabIndex = 0;
            label5.Text = "Start Cap:";
            // 
            // cmbDashCap
            // 
            cmbDashCap.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDashCap.FormattingEnabled = true;
            cmbDashCap.Location = new Point(130, 251);
            cmbDashCap.Name = "cmbDashCap";
            cmbDashCap.Size = new Size(167, 33);
            cmbDashCap.TabIndex = 1;
            cmbDashCap.SelectedIndexChanged += cmbDashCap_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 254);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 0;
            label4.Text = "Dash Cap:";
            // 
            // cmbLineJoin
            // 
            cmbLineJoin.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLineJoin.FormattingEnabled = true;
            cmbLineJoin.Location = new Point(130, 178);
            cmbLineJoin.Name = "cmbLineJoin";
            cmbLineJoin.Size = new Size(167, 33);
            cmbLineJoin.TabIndex = 1;
            cmbLineJoin.SelectedIndexChanged += cmbLineJoin_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 181);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 0;
            label3.Text = "Line Join:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 112);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 0;
            label2.Text = "Width:";
            // 
            // cmbDashStyle
            // 
            cmbDashStyle.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDashStyle.FormattingEnabled = true;
            cmbDashStyle.Location = new Point(130, 46);
            cmbDashStyle.Name = "cmbDashStyle";
            cmbDashStyle.Size = new Size(167, 33);
            cmbDashStyle.TabIndex = 1;
            cmbDashStyle.SelectedIndexChanged += cmbDashStyle_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 49);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 0;
            label1.Text = "Dash Style:";
            // 
            // pnlDrawing
            // 
            pnlDrawing.BackColor = Color.White;
            pnlDrawing.Dock = DockStyle.Fill;
            pnlDrawing.Location = new Point(350, 0);
            pnlDrawing.Name = "pnlDrawing";
            pnlDrawing.Size = new Size(628, 450);
            pnlDrawing.TabIndex = 1;
            pnlDrawing.Paint += pnlDrawing_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 450);
            Controls.Add(pnlDrawing);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtWidth;
        private ComboBox cmbStartCap;
        private Label label5;
        private ComboBox cmbDashCap;
        private Label label4;
        private ComboBox cmbLineJoin;
        private Label label3;
        private Label label2;
        private ComboBox cmbDashStyle;
        private Label label1;
        private ComboBox cmbEndCap;
        private Label label6;
        private Panel pnlDrawing;
    }
}
