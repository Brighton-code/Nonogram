namespace Nonogram.Views
{
    partial class DifficultyControl
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
            cbDifficulty = new ComboBox();
            tbSeed = new TextBox();
            lbDifficultyMenu = new Label();
            btnStart = new Button();
            SuspendLayout();
            // 
            // cbDifficulty
            // 
            cbDifficulty.FormattingEnabled = true;
            cbDifficulty.Location = new Point(100, 191);
            cbDifficulty.Name = "cbDifficulty";
            cbDifficulty.Size = new Size(300, 23);
            cbDifficulty.TabIndex = 0;
            // 
            // tbSeed
            // 
            tbSeed.Location = new Point(100, 220);
            tbSeed.Name = "tbSeed";
            tbSeed.PlaceholderText = "Optional: enter seed";
            tbSeed.Size = new Size(300, 23);
            tbSeed.TabIndex = 1;
            // 
            // lbDifficultyMenu
            // 
            lbDifficultyMenu.AutoSize = true;
            lbDifficultyMenu.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDifficultyMenu.Location = new Point(25, 81);
            lbDifficultyMenu.Name = "lbDifficultyMenu";
            lbDifficultyMenu.Size = new Size(455, 65);
            lbDifficultyMenu.TabIndex = 3;
            lbDifficultyMenu.Text = "Pick your difficulty";
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.Location = new Point(190, 249);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(109, 45);
            btnStart.TabIndex = 4;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // DifficultyControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnStart);
            Controls.Add(lbDifficultyMenu);
            Controls.Add(tbSeed);
            Controls.Add(cbDifficulty);
            Name = "DifficultyControl";
            Size = new Size(500, 500);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbDifficulty;
        private TextBox tbSeed;
        private Label lbDifficultyMenu;
        private Button btnStart;
    }
}
