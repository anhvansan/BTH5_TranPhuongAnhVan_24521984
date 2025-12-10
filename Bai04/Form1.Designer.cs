namespace Bai04
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
            cmbFont = new ComboBox();
            cmbSize = new ComboBox();
            ckbBold = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            ckbItalic = new CheckBox();
            ckbUnderline = new CheckBox();
            label3 = new Label();
            colorDialog1 = new ColorDialog();
            groupBox1 = new GroupBox();
            rdoRight = new RadioButton();
            rdoCenter = new RadioButton();
            rdoLeft = new RadioButton();
            btnColor = new Button();
            txtOutput = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbFont
            // 
            cmbFont.FormattingEnabled = true;
            cmbFont.Location = new Point(126, 59);
            cmbFont.Name = "cmbFont";
            cmbFont.Size = new Size(182, 33);
            cmbFont.TabIndex = 0;
            cmbFont.SelectedIndexChanged += cmbFont_SelectedIndexChanged;
            // 
            // cmbSize
            // 
            cmbSize.FormattingEnabled = true;
            cmbSize.Items.AddRange(new object[] { "8", "10", "12", "14", "18", "24", "28", "36" });
            cmbSize.Location = new Point(518, 59);
            cmbSize.Name = "cmbSize";
            cmbSize.Size = new Size(182, 33);
            cmbSize.TabIndex = 0;
            cmbSize.SelectedIndexChanged += cmbSize_SelectedIndexChanged;
            cmbSize.TextChanged += cmbSize_TextChanged;
            // 
            // ckbBold
            // 
            ckbBold.AutoSize = true;
            ckbBold.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ckbBold.Location = new Point(70, 129);
            ckbBold.Name = "ckbBold";
            ckbBold.Size = new Size(55, 36);
            ckbBold.TabIndex = 1;
            ckbBold.Text = "B";
            ckbBold.UseVisualStyleBackColor = true;
            ckbBold.CheckedChanged += ckbBold_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 58);
            label1.Name = "label1";
            label1.Size = new Size(56, 30);
            label1.TabIndex = 2;
            label1.Text = "Font";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(460, 58);
            label2.Name = "label2";
            label2.Size = new Size(52, 30);
            label2.TabIndex = 2;
            label2.Text = "Size";
            // 
            // ckbItalic
            // 
            ckbItalic.AutoSize = true;
            ckbItalic.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ckbItalic.Location = new Point(166, 129);
            ckbItalic.Name = "ckbItalic";
            ckbItalic.Size = new Size(46, 36);
            ckbItalic.TabIndex = 1;
            ckbItalic.Text = "I";
            ckbItalic.UseVisualStyleBackColor = true;
            ckbItalic.CheckedChanged += ckbItalic_CheckedChanged;
            // 
            // ckbUnderline
            // 
            ckbUnderline.AutoSize = true;
            ckbUnderline.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            ckbUnderline.Location = new Point(253, 129);
            ckbUnderline.Name = "ckbUnderline";
            ckbUnderline.Size = new Size(56, 36);
            ckbUnderline.TabIndex = 1;
            ckbUnderline.Text = "U";
            ckbUnderline.UseVisualStyleBackColor = true;
            ckbUnderline.CheckedChanged += ckbUnderline_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(460, 129);
            label3.Name = "label3";
            label3.Size = new Size(66, 30);
            label3.TabIndex = 2;
            label3.Text = "Color";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoRight);
            groupBox1.Controls.Add(rdoCenter);
            groupBox1.Controls.Add(rdoLeft);
            groupBox1.Location = new Point(72, 199);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(219, 150);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Align Text";
            // 
            // rdoRight
            // 
            rdoRight.AutoSize = true;
            rdoRight.Location = new Point(16, 108);
            rdoRight.Name = "rdoRight";
            rdoRight.Size = new Size(79, 29);
            rdoRight.TabIndex = 0;
            rdoRight.TabStop = true;
            rdoRight.Text = "Right";
            rdoRight.UseVisualStyleBackColor = true;
            rdoRight.CheckedChanged += rdoRight_CheckedChanged;
            // 
            // rdoCenter
            // 
            rdoCenter.AutoSize = true;
            rdoCenter.Location = new Point(16, 73);
            rdoCenter.Name = "rdoCenter";
            rdoCenter.Size = new Size(88, 29);
            rdoCenter.TabIndex = 0;
            rdoCenter.TabStop = true;
            rdoCenter.Text = "Center";
            rdoCenter.UseVisualStyleBackColor = true;
            rdoCenter.CheckedChanged += rdoCenter_CheckedChanged;
            // 
            // rdoLeft
            // 
            rdoLeft.AutoSize = true;
            rdoLeft.Checked = true;
            rdoLeft.Location = new Point(16, 38);
            rdoLeft.Name = "rdoLeft";
            rdoLeft.Size = new Size(66, 29);
            rdoLeft.TabIndex = 0;
            rdoLeft.TabStop = true;
            rdoLeft.Text = "Left";
            rdoLeft.UseVisualStyleBackColor = true;
            rdoLeft.CheckedChanged += rdoLeft_CheckedChanged;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(543, 131);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(112, 34);
            btnColor.TabIndex = 4;
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // txtOutput
            // 
            txtOutput.BackColor = Color.White;
            txtOutput.Location = new Point(414, 235);
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(300, 31);
            txtOutput.TabIndex = 5;
            txtOutput.Text = "Hello";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtOutput);
            Controls.Add(btnColor);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ckbUnderline);
            Controls.Add(ckbItalic);
            Controls.Add(ckbBold);
            Controls.Add(cmbSize);
            Controls.Add(cmbFont);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbFont;
        private ComboBox cmbSize;
        private CheckBox ckbBold;
        private Label label1;
        private Label label2;
        private CheckBox ckbItalic;
        private CheckBox ckbUnderline;
        private Label label3;
        private ColorDialog colorDialog1;
        private GroupBox groupBox1;
        private RadioButton rdoRight;
        private RadioButton rdoCenter;
        private RadioButton rdoLeft;
        private Button btnColor;
        private TextBox txtOutput;
    }
}
