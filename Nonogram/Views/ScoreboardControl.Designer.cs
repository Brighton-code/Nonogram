﻿namespace Nonogram.Views
{
    partial class ScoreboardControl
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
            dataGrid = new DataGridView();
            ColUser = new DataGridViewTextBoxColumn();
            ColSize = new DataGridViewTextBoxColumn();
            ColSeed = new DataGridViewTextBoxColumn();
            colHints = new DataGridViewTextBoxColumn();
            ColTime = new DataGridViewTextBoxColumn();
            ColCompletedAt = new DataGridViewTextBoxColumn();
            ColCreatedAt = new DataGridViewTextBoxColumn();
            lblScoreboard = new Label();
            pnlScoreboardLayout = new TableLayoutPanel();
            pnlLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // pnlLayout
            // 
            pnlLayout.Anchor = AnchorStyles.None;
            pnlLayout.Controls.Add(lblScoreboard);
            pnlLayout.Controls.Add(pnlScoreboardLayout);
            pnlLayout.Controls.Add(dataGrid);
            pnlLayout.Location = new Point(0, 0);
            pnlLayout.Margin = new Padding(0);
            pnlLayout.Name = "pnlLayout";
            pnlLayout.Size = new Size(500, 500);
            pnlLayout.TabIndex = 0;
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.AllowUserToOrderColumns = true;
            dataGrid.Columns.AddRange(new DataGridViewColumn[] { ColUser, ColSize, ColSeed, colHints, ColTime, ColCompletedAt, ColCreatedAt });
            dataGrid.Location = new Point(0, 0);
            dataGrid.Margin = new Padding(0);
            dataGrid.Name = "dataGrid";
            dataGrid.ReadOnly = true;
            dataGrid.RowHeadersWidth = 24;
            dataGrid.Size = new Size(40, 30);
            dataGrid.TabIndex = 2;
            // 
            // ColUser
            // 
            ColUser.HeaderText = "User";
            ColUser.Name = "ColUser";
            ColUser.ReadOnly = true;
            // 
            // ColSize
            // 
            ColSize.HeaderText = "Size";
            ColSize.Name = "ColSize";
            ColSize.ReadOnly = true;
            // 
            // ColSeed
            // 
            ColSeed.HeaderText = "Seed";
            ColSeed.Name = "ColSeed";
            ColSeed.ReadOnly = true;
            // 
            // colHints
            // 
            colHints.HeaderText = "Hints";
            colHints.Name = "colHints";
            colHints.ReadOnly = true;
            // 
            // ColTime
            // 
            ColTime.HeaderText = "Time";
            ColTime.Name = "ColTime";
            ColTime.ReadOnly = true;
            // 
            // ColCompletedAt
            // 
            ColCompletedAt.HeaderText = "CompletedAt";
            ColCompletedAt.Name = "ColCompletedAt";
            ColCompletedAt.ReadOnly = true;
            // 
            // ColCreatedAt
            // 
            ColCreatedAt.HeaderText = "CreatedAt";
            ColCreatedAt.Name = "ColCreatedAt";
            ColCreatedAt.ReadOnly = true;
            // 
            // lblScoreboard
            // 
            lblScoreboard.Anchor = AnchorStyles.None;
            lblScoreboard.AutoSize = true;
            lblScoreboard.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScoreboard.Location = new Point(64, 0);
            lblScoreboard.Margin = new Padding(0);
            lblScoreboard.Name = "lblScoreboard";
            lblScoreboard.Size = new Size(380, 86);
            lblScoreboard.TabIndex = 1;
            lblScoreboard.Text = "Scoreboard";
            // 
            // pnlScoreboardLayout
            // 
            pnlScoreboardLayout.Anchor = AnchorStyles.None;
            pnlScoreboardLayout.ColumnCount = 2;
            pnlScoreboardLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlScoreboardLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlScoreboardLayout.Location = new Point(0, 82);
            pnlScoreboardLayout.Name = "pnlScoreboardLayout";
            pnlScoreboardLayout.RowCount = 11;
            pnlScoreboardLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlScoreboardLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlScoreboardLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlScoreboardLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlScoreboardLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlScoreboardLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlScoreboardLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlScoreboardLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlScoreboardLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlScoreboardLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlScoreboardLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlScoreboardLayout.Size = new Size(500, 418);
            pnlScoreboardLayout.TabIndex = 3;
            // 
            // ScoreboardControl
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(pnlLayout);
            Margin = new Padding(0);
            Name = "ScoreboardControl";
            Size = new Size(500, 500);
            pnlLayout.ResumeLayout(false);
            pnlLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLayout;
        private Label lblScoreboard;
        private DataGridView dataGrid;
        private DataGridViewTextBoxColumn ColUser;
        private DataGridViewTextBoxColumn ColSize;
        private DataGridViewTextBoxColumn ColSeed;
        private DataGridViewTextBoxColumn colHints;
        private DataGridViewTextBoxColumn ColTime;
        private DataGridViewTextBoxColumn ColCompletedAt;
        private DataGridViewTextBoxColumn ColCreatedAt;
        private TableLayoutPanel pnlScoreboardLayout;
    }
}
