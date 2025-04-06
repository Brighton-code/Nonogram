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
            cbSelectScoreboard = new ComboBox();
            pnlScoreboardLayout = new TableLayoutPanel();
            lbPosition1 = new Label();
            lblScoreboard = new Label();
            lbPosition2 = new Label();
            lbPosition3 = new Label();
            lbPosition4 = new Label();
            lbPosition5 = new Label();
            lbPosition6 = new Label();
            lbPosition7 = new Label();
            lbPosition8 = new Label();
            lbPosition9 = new Label();
            lbPosition10 = new Label();
            pnlLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            pnlScoreboardLayout.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLayout
            // 
            pnlLayout.Anchor = AnchorStyles.None;
            pnlLayout.Controls.Add(dataGrid);
            pnlLayout.Controls.Add(cbSelectScoreboard);
            pnlLayout.Controls.Add(pnlScoreboardLayout);
            pnlLayout.Controls.Add(lblScoreboard);
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
            // cbSelectScoreboard
            // 
            cbSelectScoreboard.FormattingEnabled = true;
            cbSelectScoreboard.Location = new Point(112, 70);
            cbSelectScoreboard.Name = "cbSelectScoreboard";
            cbSelectScoreboard.Size = new Size(293, 23);
            cbSelectScoreboard.TabIndex = 4;
            // 
            // pnlScoreboardLayout
            // 
            pnlScoreboardLayout.Anchor = AnchorStyles.None;
            pnlScoreboardLayout.ColumnCount = 3;
            pnlScoreboardLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnlScoreboardLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            pnlScoreboardLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnlScoreboardLayout.Controls.Add(lbPosition1, 1, 0);
            pnlScoreboardLayout.Controls.Add(lbPosition2, 1, 1);
            pnlScoreboardLayout.Controls.Add(lbPosition3, 1, 2);
            pnlScoreboardLayout.Controls.Add(lbPosition4, 1, 3);
            pnlScoreboardLayout.Controls.Add(lbPosition5, 1, 4);
            pnlScoreboardLayout.Controls.Add(lbPosition6, 1, 5);
            pnlScoreboardLayout.Controls.Add(lbPosition7, 1, 6);
            pnlScoreboardLayout.Controls.Add(lbPosition8, 1, 7);
            pnlScoreboardLayout.Controls.Add(lbPosition9, 1, 8);
            pnlScoreboardLayout.Controls.Add(lbPosition10, 1, 9);
            pnlScoreboardLayout.Location = new Point(0, 99);
            pnlScoreboardLayout.Name = "pnlScoreboardLayout";
            pnlScoreboardLayout.RowCount = 10;
            pnlScoreboardLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 9.728863F));
            pnlScoreboardLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 9.756812F));
            pnlScoreboardLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10.06429F));
            pnlScoreboardLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10.06429F));
            pnlScoreboardLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10.06429F));
            pnlScoreboardLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10.06429F));
            pnlScoreboardLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10.06429F));
            pnlScoreboardLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10.06429F));
            pnlScoreboardLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10.06429F));
            pnlScoreboardLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10.06429F));
            pnlScoreboardLayout.Size = new Size(500, 401);
            pnlScoreboardLayout.TabIndex = 3;
            // 
            // lbPosition1
            // 
            lbPosition1.Anchor = AnchorStyles.None;
            lbPosition1.AutoSize = true;
            lbPosition1.Location = new Point(243, 12);
            lbPosition1.Name = "lbPosition1";
            lbPosition1.Size = new Size(13, 15);
            lbPosition1.TabIndex = 0;
            lbPosition1.Text = "1";
            // 
            // lblScoreboard
            // 
            lblScoreboard.Anchor = AnchorStyles.None;
            lblScoreboard.AutoSize = true;
            lblScoreboard.Font = new Font("Segoe UI", 42F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScoreboard.Location = new Point(96, 0);
            lblScoreboard.Margin = new Padding(0);
            lblScoreboard.Name = "lblScoreboard";
            lblScoreboard.Size = new Size(331, 74);
            lblScoreboard.TabIndex = 1;
            lblScoreboard.Text = "Scoreboard";
            // 
            // lbPosition2
            // 
            lbPosition2.Anchor = AnchorStyles.None;
            lbPosition2.AutoSize = true;
            lbPosition2.Location = new Point(243, 51);
            lbPosition2.Name = "lbPosition2";
            lbPosition2.Size = new Size(13, 15);
            lbPosition2.TabIndex = 1;
            lbPosition2.Text = "2";
            // 
            // lbPosition3
            // 
            lbPosition3.Anchor = AnchorStyles.None;
            lbPosition3.AutoSize = true;
            lbPosition3.Location = new Point(243, 90);
            lbPosition3.Name = "lbPosition3";
            lbPosition3.Size = new Size(13, 15);
            lbPosition3.TabIndex = 2;
            lbPosition3.Text = "3";
            // 
            // lbPosition4
            // 
            lbPosition4.Anchor = AnchorStyles.None;
            lbPosition4.AutoSize = true;
            lbPosition4.Location = new Point(243, 130);
            lbPosition4.Name = "lbPosition4";
            lbPosition4.Size = new Size(13, 15);
            lbPosition4.TabIndex = 3;
            lbPosition4.Text = "4";
            // 
            // lbPosition5
            // 
            lbPosition5.Anchor = AnchorStyles.None;
            lbPosition5.AutoSize = true;
            lbPosition5.Location = new Point(243, 170);
            lbPosition5.Name = "lbPosition5";
            lbPosition5.Size = new Size(13, 15);
            lbPosition5.TabIndex = 4;
            lbPosition5.Text = "5";
            // 
            // lbPosition6
            // 
            lbPosition6.Anchor = AnchorStyles.None;
            lbPosition6.AutoSize = true;
            lbPosition6.Location = new Point(243, 210);
            lbPosition6.Name = "lbPosition6";
            lbPosition6.Size = new Size(13, 15);
            lbPosition6.TabIndex = 5;
            lbPosition6.Text = "6";
            // 
            // lbPosition7
            // 
            lbPosition7.Anchor = AnchorStyles.None;
            lbPosition7.AutoSize = true;
            lbPosition7.Location = new Point(243, 250);
            lbPosition7.Name = "lbPosition7";
            lbPosition7.Size = new Size(13, 15);
            lbPosition7.TabIndex = 6;
            lbPosition7.Text = "7";
            // 
            // lbPosition8
            // 
            lbPosition8.Anchor = AnchorStyles.None;
            lbPosition8.AutoSize = true;
            lbPosition8.Location = new Point(243, 290);
            lbPosition8.Name = "lbPosition8";
            lbPosition8.Size = new Size(13, 15);
            lbPosition8.TabIndex = 7;
            lbPosition8.Text = "8";
            // 
            // lbPosition9
            // 
            lbPosition9.Anchor = AnchorStyles.None;
            lbPosition9.AutoSize = true;
            lbPosition9.Location = new Point(243, 330);
            lbPosition9.Name = "lbPosition9";
            lbPosition9.Size = new Size(13, 15);
            lbPosition9.TabIndex = 8;
            lbPosition9.Text = "9";
            // 
            // lbPosition10
            // 
            lbPosition10.Anchor = AnchorStyles.None;
            lbPosition10.AutoSize = true;
            lbPosition10.Location = new Point(240, 372);
            lbPosition10.Name = "lbPosition10";
            lbPosition10.Size = new Size(19, 15);
            lbPosition10.TabIndex = 9;
            lbPosition10.Text = "10";
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
            pnlScoreboardLayout.ResumeLayout(false);
            pnlScoreboardLayout.PerformLayout();
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
        private ComboBox cbSelectScoreboard;
        private Label lbPosition1;
        private Label lbPosition2;
        private Label lbPosition3;
        private Label lbPosition4;
        private Label lbPosition5;
        private Label lbPosition6;
        private Label lbPosition7;
        private Label lbPosition8;
        private Label lbPosition9;
        private Label lbPosition10;
    }
}
