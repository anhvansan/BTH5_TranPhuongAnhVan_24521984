namespace Bai06
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
            lstFonts = new ListBox();
            SuspendLayout();
            // 
            // lstFonts
            // 
            lstFonts.Dock = DockStyle.Fill;
            lstFonts.DrawMode = DrawMode.OwnerDrawFixed;
            lstFonts.FormattingEnabled = true;
            lstFonts.ItemHeight = 40;
            lstFonts.Location = new Point(0, 0);
            lstFonts.Name = "lstFonts";
            lstFonts.Size = new Size(678, 450);
            lstFonts.TabIndex = 0;
            lstFonts.DrawItem += lstFonts_DrawItem;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 450);
            Controls.Add(lstFonts);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "All Fonts";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstFonts;
    }
}
