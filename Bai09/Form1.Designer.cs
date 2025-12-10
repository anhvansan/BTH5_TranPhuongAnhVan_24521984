namespace Bai09
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
            cbbShapes = new ComboBox();
            SuspendLayout();
            // 
            // cbbShapes
            // 
            cbbShapes.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbShapes.FormattingEnabled = true;
            cbbShapes.Items.AddRange(new object[] { "Circle", "Square", "Ellipse", "Pie", "Filled Circle", "Filled Square", "Filled Ellipse", "Filled Pie" });
            cbbShapes.Location = new Point(72, 37);
            cbbShapes.Name = "cbbShapes";
            cbbShapes.Size = new Size(182, 33);
            cbbShapes.TabIndex = 0;
            cbbShapes.SelectedIndexChanged += cbbShapes_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbbShapes);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Paint += Form1_Paint;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbbShapes;
    }
}
