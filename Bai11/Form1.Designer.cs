namespace Bai11
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
            cmbShape = new ComboBox();
            cmbBrush = new ComboBox();
            txtWidth = new TextBox();
            btnColor = new Button();
            dlgColor = new ColorDialog();
            picDrawing = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)picDrawing).BeginInit();
            SuspendLayout();
            // 
            // cmbShape
            // 
            cmbShape.FormattingEnabled = true;
            cmbShape.Location = new Point(32, 38);
            cmbShape.Name = "cmbShape";
            cmbShape.Size = new Size(177, 33);
            cmbShape.TabIndex = 0;
            // 
            // cmbBrush
            // 
            cmbBrush.FormattingEnabled = true;
            cmbBrush.Location = new Point(32, 99);
            cmbBrush.Name = "cmbBrush";
            cmbBrush.Size = new Size(177, 33);
            cmbBrush.TabIndex = 0;
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(102, 176);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(119, 31);
            txtWidth.TabIndex = 1;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(32, 229);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(107, 43);
            btnColor.TabIndex = 2;
            btnColor.Text = "Chọn màu";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // picDrawing
            // 
            picDrawing.BackColor = Color.White;
            picDrawing.Image = Properties.Resources.trello;
            picDrawing.Location = new Point(282, 12);
            picDrawing.Name = "picDrawing";
            picDrawing.Size = new Size(602, 412);
            picDrawing.TabIndex = 3;
            picDrawing.TabStop = false;
            picDrawing.MouseDown += picDrawing_MouseDown;
            picDrawing.MouseMove += picDrawing_MouseMove;
            picDrawing.MouseUp += picDrawing_MouseUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 176);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 4;
            label1.Text = "Width:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 450);
            Controls.Add(label1);
            Controls.Add(picDrawing);
            Controls.Add(btnColor);
            Controls.Add(txtWidth);
            Controls.Add(cmbBrush);
            Controls.Add(cmbShape);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picDrawing).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbShape;
        private ComboBox cmbBrush;
        private TextBox txtWidth;
        private Button btnColor;
        private ColorDialog dlgColor;
        private PictureBox picDrawing;
        private Label label1;
    }
}
