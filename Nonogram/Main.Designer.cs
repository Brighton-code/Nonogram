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
            pnlNav = new Panel();
            btnUser = new Button();
            btnMenu = new Button();
            pnlBody = new Panel();
            pnlNav.SuspendLayout();
            SuspendLayout();
            // 
            // pnlNav
            // 
            pnlNav.Controls.Add(btnUser);
            pnlNav.Controls.Add(btnMenu);
            pnlNav.Dock = DockStyle.Top;
            pnlNav.Location = new Point(0, 0);
            pnlNav.Margin = new Padding(0);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(774, 100);
            pnlNav.TabIndex = 0;
            // 
            // btnUser
            // 
            btnUser.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUser.Location = new Point(604, 25);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(150, 50);
            btnUser.TabIndex = 1;
            btnUser.Text = "User";
            btnUser.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            btnMenu.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenu.Location = new Point(20, 25);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(150, 50);
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
            pnlBody.Size = new Size(774, 629);
            pnlBody.TabIndex = 1;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 729);
            Controls.Add(pnlBody);
            Controls.Add(pnlNav);
            Name = "Main";
            Text = "Nonogram Game";
            pnlNav.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlNav;
        private Panel pnlBody;
        private Button btnUser;
        private Button btnMenu;
    }
}
