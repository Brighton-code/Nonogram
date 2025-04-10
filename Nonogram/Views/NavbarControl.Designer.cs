﻿namespace Nonogram.Views
{
    partial class NavbarControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlNav = new TableLayoutPanel();
            btnMenu = new Button();
            cbTheme = new CheckBox();
            btnUser = new Button();
            lblUser = new Label();
            pnlNav.SuspendLayout();
            SuspendLayout();
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.Transparent;
            pnlNav.ColumnCount = 4;
            pnlNav.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 108F));
            pnlNav.ColumnStyles.Add(new ColumnStyle());
            pnlNav.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlNav.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 108F));
            pnlNav.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            pnlNav.Controls.Add(btnMenu, 0, 0);
            pnlNav.Controls.Add(cbTheme, 1, 0);
            pnlNav.Controls.Add(btnUser, 3, 0);
            pnlNav.Controls.Add(lblUser, 2, 0);
            pnlNav.Dock = DockStyle.Fill;
            pnlNav.Location = new Point(0, 0);
            pnlNav.Margin = new Padding(0);
            pnlNav.Name = "pnlNav";
            pnlNav.RowCount = 1;
            pnlNav.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlNav.Size = new Size(500, 100);
            pnlNav.TabIndex = 0;
            // 
            // btnMenu
            // 
            btnMenu.Anchor = AnchorStyles.None;
            btnMenu.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenu.Location = new Point(13, 30);
            btnMenu.Margin = new Padding(0);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(81, 40);
            btnMenu.TabIndex = 1;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // cbTheme
            // 
            cbTheme.Anchor = AnchorStyles.None;
            cbTheme.AutoSize = true;
            cbTheme.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbTheme.Location = new Point(111, 37);
            cbTheme.Name = "cbTheme";
            cbTheme.Size = new Size(110, 25);
            cbTheme.TabIndex = 4;
            cbTheme.Text = "Dark Mode";
            cbTheme.UseVisualStyleBackColor = true;
            // 
            // btnUser
            // 
            btnUser.Anchor = AnchorStyles.None;
            btnUser.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUser.Location = new Point(405, 30);
            btnUser.Margin = new Padding(0);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(81, 40);
            btnUser.TabIndex = 2;
            btnUser.Tag = "login";
            btnUser.Text = "User";
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click;
            // 
            // lblUser
            // 
            lblUser.Anchor = AnchorStyles.Right;
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUser.Location = new Point(330, 37);
            lblUser.Margin = new Padding(0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(62, 25);
            lblUser.TabIndex = 3;
            lblUser.Text = "label1";
            // 
            // NavbarControl
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(pnlNav);
            Margin = new Padding(0);
            Name = "NavbarControl";
            Size = new Size(500, 100);
            pnlNav.ResumeLayout(false);
            pnlNav.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel pnlNav;
        private Button btnMenu;
        private Button btnUser;
        private Label lblUser;
        private CheckBox cbTheme;
    }
}
