namespace Nonogram.Views
{
    partial class GameControl
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
            pnlGameBtns = new TableLayoutPanel();
            pnlGame = new Panel();
            SuspendLayout();
            // 
            // pnlGameBtns
            // 
            pnlGameBtns.ColumnCount = 2;
            pnlGameBtns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlGameBtns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlGameBtns.Dock = DockStyle.Bottom;
            pnlGameBtns.Location = new Point(0, 400);
            pnlGameBtns.Margin = new Padding(0);
            pnlGameBtns.Name = "pnlGameBtns";
            pnlGameBtns.RowCount = 1;
            pnlGameBtns.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlGameBtns.Size = new Size(500, 100);
            pnlGameBtns.TabIndex = 0;
            // 
            // pnlGame
            // 
            pnlGame.Dock = DockStyle.Fill;
            pnlGame.Location = new Point(0, 0);
            pnlGame.Margin = new Padding(0);
            pnlGame.Name = "pnlGame";
            pnlGame.Size = new Size(500, 400);
            pnlGame.TabIndex = 1;
            // 
            // GameControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlGame);
            Controls.Add(pnlGameBtns);
            Margin = new Padding(0);
            Name = "GameControl";
            Size = new Size(500, 500);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel pnlGameBtns;
        private Panel pnlGame;
    }
}
