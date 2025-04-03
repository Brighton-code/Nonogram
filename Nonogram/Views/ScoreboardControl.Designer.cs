namespace Nonogram.Views
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
            lblScoreboard = new Label();
            dataGrid = new DataGridView();
            ColUser = new DataGridViewTextBoxColumn();
            ColSize = new DataGridViewTextBoxColumn();
            ColSeed = new DataGridViewTextBoxColumn();
            ColTime = new DataGridViewTextBoxColumn();
            ColCompletedAt = new DataGridViewTextBoxColumn();
            ColStartedAt = new DataGridViewTextBoxColumn();
            pnlLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // pnlLayout
            // 
            pnlLayout.Anchor = AnchorStyles.None;
            pnlLayout.Controls.Add(dataGrid);
            pnlLayout.Controls.Add(lblScoreboard);
            pnlLayout.Location = new Point(0, 0);
            pnlLayout.Margin = new Padding(0);
            pnlLayout.Name = "pnlLayout";
            pnlLayout.Size = new Size(500, 500);
            pnlLayout.TabIndex = 0;
            // 
            // lblScoreboard
            // 
            lblScoreboard.AutoSize = true;
            lblScoreboard.Font = new Font("Segoe UI", 52F, FontStyle.Bold);
            lblScoreboard.Location = new Point(42, 40);
            lblScoreboard.Margin = new Padding(0);
            lblScoreboard.Name = "lblScoreboard";
            lblScoreboard.Size = new Size(416, 93);
            lblScoreboard.TabIndex = 1;
            lblScoreboard.Text = "Scoreboard";
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.AllowUserToOrderColumns = true;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Columns.AddRange(new DataGridViewColumn[] { ColUser, ColSize, ColSeed, ColTime, ColCompletedAt, ColStartedAt });
            dataGrid.Enabled = false;
            dataGrid.Location = new Point(50, 153);
            dataGrid.Margin = new Padding(0);
            dataGrid.Name = "dataGrid";
            dataGrid.ReadOnly = true;
            dataGrid.RowHeadersWidth = 24;
            dataGrid.Size = new Size(400, 300);
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
            // ColStartedAt
            // 
            ColStartedAt.HeaderText = "StartedAt";
            ColStartedAt.Name = "ColStartedAt";
            ColStartedAt.ReadOnly = true;
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
        private DataGridViewTextBoxColumn ColTime;
        private DataGridViewTextBoxColumn ColCompletedAt;
        private DataGridViewTextBoxColumn ColStartedAt;
    }
}
