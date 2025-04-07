namespace Nonogram.Views
{
    partial class GameHistorySelectControl
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
            btnLoadGame = new Button();
            cbGameHistory = new ComboBox();
            lblGameHistoryMenu = new Label();
            pnlLayout.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLayout
            // 
            pnlLayout.Anchor = AnchorStyles.None;
            pnlLayout.Controls.Add(btnLoadGame);
            pnlLayout.Controls.Add(cbGameHistory);
            pnlLayout.Controls.Add(lblGameHistoryMenu);
            pnlLayout.Location = new Point(0, 0);
            pnlLayout.Margin = new Padding(0);
            pnlLayout.Name = "pnlLayout";
            pnlLayout.Size = new Size(500, 500);
            pnlLayout.TabIndex = 0;
            // 
            // btnLoadGame
            // 
            btnLoadGame.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoadGame.Location = new Point(75, 258);
            btnLoadGame.Margin = new Padding(0);
            btnLoadGame.Name = "btnLoadGame";
            btnLoadGame.Size = new Size(350, 90);
            btnLoadGame.TabIndex = 3;
            btnLoadGame.Text = "Load game";
            btnLoadGame.UseVisualStyleBackColor = true;
            btnLoadGame.Click += btnLoadGame_Click;
            // 
            // cbGameHistory
            // 
            cbGameHistory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbGameHistory.DropDownWidth = 500;
            cbGameHistory.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbGameHistory.FormattingEnabled = true;
            cbGameHistory.Location = new Point(0, 170);
            cbGameHistory.Name = "cbGameHistory";
            cbGameHistory.Size = new Size(500, 38);
            cbGameHistory.TabIndex = 2;
            // 
            // lblGameHistoryMenu
            // 
            lblGameHistoryMenu.AutoSize = true;
            lblGameHistoryMenu.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGameHistoryMenu.Location = new Point(83, 70);
            lblGameHistoryMenu.Name = "lblGameHistoryMenu";
            lblGameHistoryMenu.Size = new Size(335, 65);
            lblGameHistoryMenu.TabIndex = 1;
            lblGameHistoryMenu.Text = "Choose Game";
            // 
            // GameHistorySelectControl
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(pnlLayout);
            Margin = new Padding(0);
            Name = "GameHistorySelectControl";
            Size = new Size(500, 500);
            pnlLayout.ResumeLayout(false);
            pnlLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLayout;
        private Label lblGameHistoryMenu;
        private Button btnLoadGame;
        private ComboBox cbGameHistory;
    }
}
