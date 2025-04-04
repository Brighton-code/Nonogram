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
            lblGameHistoryMenu = new Label();
            pnlLayout.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLayout
            // 
            pnlLayout.Anchor = AnchorStyles.None;
            pnlLayout.Controls.Add(lblGameHistoryMenu);
            pnlLayout.Location = new Point(0, 0);
            pnlLayout.Margin = new Padding(0);
            pnlLayout.Name = "pnlLayout";
            pnlLayout.Size = new Size(500, 500);
            pnlLayout.TabIndex = 0;
            // 
            // lblGameHistoryMenu
            // 
            lblGameHistoryMenu.AutoSize = true;
            lblGameHistoryMenu.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGameHistoryMenu.Location = new Point(213, 88);
            lblGameHistoryMenu.Name = "lblGameHistoryMenu";
            lblGameHistoryMenu.Size = new Size(59, 32);
            lblGameHistoryMenu.TabIndex = 1;
            lblGameHistoryMenu.Text = "Test";
            // 
            // GameHistorySelectControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
    }
}
