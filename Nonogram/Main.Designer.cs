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
            btnUser = new Button();
            btnMenu = new Button();
            pnlBody = new Panel();
            pnlNav = new TableLayoutPanel();
            lblUser = new Label();
            pnlNav.SuspendLayout();
            SuspendLayout();
            // 
            // btnUser
            // 
            btnUser.Anchor = AnchorStyles.None;
            btnUser.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUser.Location = new Point(689, 30);
            btnUser.Margin = new Padding(0);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(81, 40);
            btnUser.TabIndex = 1;
            btnUser.Tag = "login";
            btnUser.Text = "User";
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += NavButton_User;
            // 
            // btnMenu
            // 
            btnMenu.Anchor = AnchorStyles.None;
            btnMenu.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenu.Location = new Point(13, 30);
            btnMenu.Margin = new Padding(0);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(81, 40);
            btnMenu.TabIndex = 0;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += NavButton_Menu;
            // 
            // pnlBody
            // 
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(0, 100);
            pnlBody.Margin = new Padding(0);
            pnlBody.Name = "pnlBody";
            pnlBody.Size = new Size(784, 661);
            pnlBody.TabIndex = 1;
            // 
            // pnlNav
            // 
            pnlNav.ColumnCount = 3;
            pnlNav.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 108F));
            pnlNav.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlNav.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 108F));
            pnlNav.Controls.Add(btnMenu, 0, 0);
            pnlNav.Controls.Add(btnUser, 2, 0);
            pnlNav.Controls.Add(lblUser, 1, 0);
            pnlNav.Dock = DockStyle.Top;
            pnlNav.Location = new Point(0, 0);
            pnlNav.Margin = new Padding(0);
            pnlNav.Name = "pnlNav";
            pnlNav.RowCount = 1;
            pnlNav.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlNav.Size = new Size(784, 100);
            pnlNav.TabIndex = 2;
            // 
            // lblUser
            // 
            lblUser.Anchor = AnchorStyles.Right;
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUser.Location = new Point(614, 37);
            lblUser.Margin = new Padding(0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(62, 25);
            lblUser.TabIndex = 2;
            lblUser.Text = "label1";
            // 
            // Main
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(784, 761);
            Controls.Add(pnlBody);
            Controls.Add(pnlNav);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Main";
            Text = "Nonogram Game";
            pnlNav.ResumeLayout(false);
            pnlNav.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlBody;
        private Button btnUser;
        private Button btnMenu;
        private TableLayoutPanel pnlNav;
        private Label lblUser;
    }
}
