﻿namespace Nonogram.Views
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
            pnlGame = new Panel();
            pnlGameBtns.SuspendLayout();
            pnlSizeChange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inGridSize).BeginInit();
            SuspendLayout();
            // 
            // pnlGameBtns
            // 
            pnlGameBtns.ColumnCount = 2;
            pnlGameBtns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlGameBtns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlGameBtns.Controls.Add(pnlSizeChange, 0, 0);
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
            inGridSize.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inGridSize.Location = new Point(47, 62);
            inGridSize.Margin = new Padding(0);
            inGridSize.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            inGridSize.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            inGridSize.Name = "inGridSize";
            inGridSize.Size = new Size(55, 25);
            inGridSize.TabIndex = 0;
            inGridSize.TextAlign = HorizontalAlignment.Center;
            inGridSize.Value = new decimal(new int[] { 5, 0, 0, 0 });
            inGridSize.KeyPress += inGridSize_KeyPress;
            // 
            // btnSubmitSize
            // 
            btnSubmitSize.Anchor = AnchorStyles.None;
            btnSubmitSize.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmitSize.Location = new Point(135, 62);
            btnSubmitSize.Margin = new Padding(0);
            btnSubmitSize.Name = "btnSubmitSize";
            btnSubmitSize.Size = new Size(79, 25);
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
            lblChange.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChange.Location = new Point(27, 0);
            lblChange.Margin = new Padding(2, 0, 2, 0);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(196, 50);
            lblChange.TabIndex = 2;
            lblChange.Text = "Change Size";
            lblChange.TextAlign = ContentAlignment.BottomCenter;
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
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel pnlGameBtns;
        private Panel pnlGame;
        private NumericUpDown inGridSize;
        private TableLayoutPanel pnlSizeChange;
        private Button btnSubmitSize;
        private Label lblChange;
    }
}
