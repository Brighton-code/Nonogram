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
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cbDifficulty
            // 
            cbDifficulty.FormattingEnabled = true;
            cbDifficulty.Location = new Point(99, 226);
            cbDifficulty.Name = "cbDifficulty";
            cbDifficulty.Size = new Size(300, 23);
            cbDifficulty.TabIndex = 0;
            // 
            // tbSeed
            // 
            tbSeed.Location = new Point(99, 255);
            tbSeed.Name = "tbSeed";
            tbSeed.PlaceholderText = "Optional: enter seed";
            tbSeed.Size = new Size(300, 23);
            tbSeed.TabIndex = 1;
            // 
            // lbDifficultyMenu
            // 
            lbDifficultyMenu.AutoSize = true;
            lbDifficultyMenu.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDifficultyMenu.Location = new Point(24, 116);
            lbDifficultyMenu.Name = "lbDifficultyMenu";
            lbDifficultyMenu.Size = new Size(455, 65);
            lbDifficultyMenu.TabIndex = 3;
            lbDifficultyMenu.Text = "Pick your difficulty";
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.Location = new Point(189, 284);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(109, 45);
            btnStart.TabIndex = 4;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(lbDifficultyMenu);
            panel1.Controls.Add(btnStart);
            panel1.Controls.Add(cbDifficulty);
            panel1.Controls.Add(tbSeed);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 500);
            panel1.TabIndex = 5;
            // 
            // DifficultyControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "DifficultyControl";
            Size = new Size(500, 500);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbDifficulty;
        private TextBox tbSeed;
        private Label lbDifficultyMenu;
        private Button btnStart;
        private Panel panel1;
    }
}
