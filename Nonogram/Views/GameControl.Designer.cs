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
            pnlSizeChange = new TableLayoutPanel();
            inGridSize = new NumericUpDown();
            btnSubmitSize = new Button();
            lblChange = new Label();
            pnlData = new TableLayoutPanel();
            btnSolution = new Button();
            lblStopwatch = new Label();
            lblSeed = new Label();
            pnlGame = new Panel();
            btnHint = new Button();
            pnlGameBtns.SuspendLayout();
            pnlSizeChange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inGridSize).BeginInit();
            pnlData.SuspendLayout();
            SuspendLayout();
            // 
            // pnlGameBtns
            // 
            pnlGameBtns.ColumnCount = 2;
            pnlGameBtns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlGameBtns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlGameBtns.Controls.Add(pnlSizeChange, 0, 0);
            pnlGameBtns.Controls.Add(pnlData, 1, 0);
            pnlGameBtns.Dock = DockStyle.Bottom;
            pnlGameBtns.Location = new Point(0, 400);
            pnlGameBtns.Margin = new Padding(0);
            pnlGameBtns.Name = "pnlGameBtns";
            pnlGameBtns.RowCount = 1;
            pnlGameBtns.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlGameBtns.Size = new Size(500, 100);
            pnlGameBtns.TabIndex = 0;
            // 
            // pnlSizeChange
            // 
            pnlSizeChange.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pnlSizeChange.ColumnCount = 4;
            pnlSizeChange.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlSizeChange.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            pnlSizeChange.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            pnlSizeChange.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlSizeChange.Controls.Add(inGridSize, 1, 1);
            pnlSizeChange.Controls.Add(btnSubmitSize, 2, 1);
            pnlSizeChange.Controls.Add(lblChange, 1, 0);
            pnlSizeChange.Location = new Point(0, 0);
            pnlSizeChange.Margin = new Padding(0);
            pnlSizeChange.Name = "pnlSizeChange";
            pnlSizeChange.RowCount = 2;
            pnlSizeChange.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            pnlSizeChange.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlSizeChange.Size = new Size(250, 100);
            pnlSizeChange.TabIndex = 1;
            // 
            // inGridSize
            // 
            inGridSize.Anchor = AnchorStyles.None;
            inGridSize.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inGridSize.Location = new Point(40, 58);
            inGridSize.Margin = new Padding(0);
            inGridSize.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            inGridSize.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            inGridSize.Name = "inGridSize";
            inGridSize.Size = new Size(70, 33);
            inGridSize.TabIndex = 0;
            inGridSize.TextAlign = HorizontalAlignment.Center;
            inGridSize.Value = new decimal(new int[] { 5, 0, 0, 0 });
            inGridSize.KeyPress += inGridSize_KeyPress;
            // 
            // btnSubmitSize
            // 
            btnSubmitSize.Anchor = AnchorStyles.None;
            btnSubmitSize.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmitSize.Location = new Point(135, 58);
            btnSubmitSize.Margin = new Padding(0);
            btnSubmitSize.Name = "btnSubmitSize";
            btnSubmitSize.Size = new Size(80, 33);
            btnSubmitSize.TabIndex = 1;
            btnSubmitSize.Text = "Change";
            btnSubmitSize.UseVisualStyleBackColor = true;
            btnSubmitSize.Click += btnSubmitSize_Click;
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            pnlSizeChange.SetColumnSpan(lblChange, 2);
            lblChange.Dock = DockStyle.Fill;
            lblChange.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChange.Location = new Point(27, 0);
            lblChange.Margin = new Padding(2, 0, 2, 0);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(196, 50);
            lblChange.TabIndex = 2;
            lblChange.Text = "Change Size";
            lblChange.TextAlign = ContentAlignment.BottomCenter;
            // 
            // pnlData
            // 
            pnlData.ColumnCount = 2;
            pnlData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlData.Controls.Add(btnSolution, 0, 0);
            pnlData.Controls.Add(lblSeed, 1, 0);
            pnlData.Controls.Add(lblStopwatch, 1, 1);
            pnlData.Controls.Add(btnHint, 0, 1);
            pnlData.Dock = DockStyle.Fill;
            pnlData.Location = new Point(253, 3);
            pnlData.Name = "pnlData";
            pnlData.RowCount = 2;
            pnlData.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlData.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlData.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlData.Size = new Size(244, 94);
            pnlData.TabIndex = 2;
            // 
            // btnSolution
            // 
            btnSolution.Anchor = AnchorStyles.None;
            btnSolution.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSolution.Location = new Point(3, 3);
            btnSolution.Name = "btnSolution";
            btnSolution.Size = new Size(116, 41);
            btnSolution.TabIndex = 2;
            btnSolution.Text = "Solution";
            btnSolution.UseVisualStyleBackColor = true;
            btnSolution.Click += btnSolution_Click;
            // 
            // lblStopwatch
            // 
            lblStopwatch.Anchor = AnchorStyles.None;
            lblStopwatch.AutoSize = true;
            lblStopwatch.Font = new Font("Segoe UI", 14F);
            lblStopwatch.Location = new Point(134, 58);
            lblStopwatch.Name = "lblStopwatch";
            lblStopwatch.Size = new Size(98, 25);
            lblStopwatch.TabIndex = 3;
            lblStopwatch.Text = "Draw time";
            // 
            // lblSeed
            // 
            lblSeed.Anchor = AnchorStyles.None;
            lblSeed.AutoSize = true;
            lblSeed.Font = new Font("Segoe UI", 12F);
            lblSeed.Location = new Point(161, 13);
            lblSeed.Name = "lblSeed";
            lblSeed.Size = new Size(44, 21);
            lblSeed.TabIndex = 4;
            lblSeed.Text = "Seed";
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
            // btnHint
            // 
            btnHint.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHint.Location = new Point(3, 50);
            btnHint.Name = "btnHint";
            btnHint.Size = new Size(116, 38);
            btnHint.TabIndex = 5;
            btnHint.Text = "Give Hint";
            btnHint.UseVisualStyleBackColor = true;
            btnHint.Click += btnHint_Click;
            // 
            // GameControl
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(pnlGame);
            Controls.Add(pnlGameBtns);
            Margin = new Padding(0);
            Name = "GameControl";
            Size = new Size(500, 500);
            pnlGameBtns.ResumeLayout(false);
            pnlSizeChange.ResumeLayout(false);
            pnlSizeChange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)inGridSize).EndInit();
            pnlData.ResumeLayout(false);
            pnlData.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel pnlGameBtns;
        private Panel pnlGame;
        private NumericUpDown inGridSize;
        private TableLayoutPanel pnlSizeChange;
        private Button btnSubmitSize;
        private Label lblChange;
        private Button btnSolution;
        private TableLayoutPanel pnlData;
        private Label lblStopwatch;
        private Label lblSeed;
        private Button btnHint;
    }
}
