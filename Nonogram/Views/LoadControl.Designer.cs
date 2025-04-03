namespace Nonogram.Views
{
    partial class LoadControl
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
            btnNewGame = new Button();
            btnLoadGame = new Button();
            lbPickGame = new Label();
            SuspendLayout();
            // 
            // btnNewGame
            // 
            btnNewGame.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewGame.Location = new Point(100, 197);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(300, 90);
            btnNewGame.TabIndex = 0;
            btnNewGame.Text = "New Game";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // btnLoadGame
            // 
            btnLoadGame.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoadGame.Location = new Point(100, 293);
            btnLoadGame.Name = "btnLoadGame";
            btnLoadGame.Size = new Size(300, 90);
            btnLoadGame.TabIndex = 1;
            btnLoadGame.Text = "Load Game";
            btnLoadGame.UseVisualStyleBackColor = true;
            // 
            // lbPickGame
            // 
            lbPickGame.AutoSize = true;
            lbPickGame.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPickGame.Location = new Point(58, 87);
            lbPickGame.Name = "lbPickGame";
            lbPickGame.Size = new Size(376, 65);
            lbPickGame.TabIndex = 2;
            lbPickGame.Text = "Pick your game";
            // 
            // PlayControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbPickGame);
            Controls.Add(btnLoadGame);
            Controls.Add(btnNewGame);
            Name = "PlayControl";
            Size = new Size(500, 500);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNewGame;
        private Button btnLoadGame;
        private Label lbPickGame;
    }
}
