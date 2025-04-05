namespace Nonogram
{
    partial class Main
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
            pnlBody = new Panel();
            Navbar = new Nonogram.Views.NavbarControl();
            SuspendLayout();
            // 
            // pnlBody
            // 
            pnlBody.BackColor = Color.Transparent;
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(0, 100);
            pnlBody.Margin = new Padding(0);
            pnlBody.Name = "pnlBody";
            pnlBody.Size = new Size(784, 661);
            pnlBody.TabIndex = 1;
            // 
            // Navbar
            // 
            Navbar.BackColor = Color.Transparent;
            Navbar.Dock = DockStyle.Top;
            Navbar.Location = new Point(0, 0);
            Navbar.Margin = new Padding(0);
            Navbar.Name = "Navbar";
            Navbar.Size = new Size(784, 100);
            Navbar.TabIndex = 0;
            // 
            // Main
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Control;
            ClientSize = new Size(784, 761);
            Controls.Add(pnlBody);
            Controls.Add(Navbar);
            DoubleBuffered = true;
            Margin = new Padding(2, 1, 2, 1);
            Name = "Main";
            Text = "Nonogram Game";
            FormClosing += Main_FormClosing;
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlBody;
        private Views.NavbarControl Navbar;
    }
}
