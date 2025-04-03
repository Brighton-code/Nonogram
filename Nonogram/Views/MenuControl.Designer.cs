namespace Nonogram.Views
{
    partial class MenuControl
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
            pnlLayout = new Panel();
            btnScoreboard = new Button();
            btnUser = new Button();
            btnPlay = new Button();
            lblMenu = new Label();
            pnlLayout.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLayout
            // 
            pnlLayout.Anchor = AnchorStyles.None;
            pnlLayout.Controls.Add(btnScoreboard);
            pnlLayout.Controls.Add(btnUser);
            pnlLayout.Controls.Add(btnPlay);
            pnlLayout.Controls.Add(lblMenu);
            pnlLayout.Location = new Point(0, 0);
            pnlLayout.Margin = new Padding(0);
            pnlLayout.Name = "pnlLayout";
            pnlLayout.Size = new Size(500, 500);
            pnlLayout.TabIndex = 0;
            // 
            // btnScoreboard
            // 
            btnScoreboard.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold);
            btnScoreboard.Location = new Point(100, 373);
            btnScoreboard.Margin = new Padding(2, 1, 2, 1);
            btnScoreboard.Name = "btnScoreboard";
            btnScoreboard.Size = new Size(300, 90);
            btnScoreboard.TabIndex = 3;
            btnScoreboard.Text = "Scoreboard";
            btnScoreboard.UseVisualStyleBackColor = true;
            // 
            // btnUser
            // 
            btnUser.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold);
            btnUser.Location = new Point(100, 263);
            btnUser.Margin = new Padding(2, 1, 2, 1);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(300, 90);
            btnUser.TabIndex = 2;
            btnUser.Text = "Login";
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click;
            // 
            // btnPlay
            // 
            btnPlay.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold);
            btnPlay.Location = new Point(100, 153);
            btnPlay.Margin = new Padding(2, 1, 2, 1);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(300, 90);
            btnPlay.TabIndex = 1;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Font = new Font("Segoe UI", 52F, FontStyle.Bold);
            lblMenu.Location = new Point(136, 50);
            lblMenu.Margin = new Padding(0);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(229, 93);
            lblMenu.TabIndex = 0;
            lblMenu.Text = "Menu";
            // 
            // MenuControl
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(pnlLayout);
            Margin = new Padding(0);
            Name = "MenuControl";
            Size = new Size(500, 500);
            pnlLayout.ResumeLayout(false);
            pnlLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLayout;
        private Label lblMenu;
        private Button btnScoreboard;
        private Button btnUser;
        private Button btnPlay;
    }
}
