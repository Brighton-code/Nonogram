using Nonogram.Views;

namespace Nonogram
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            InitializeView();
        }

        #region Views code
        private void InitializeView()
        {
            login = new LoginControl();
            SuspendLayout();
            ///
            /// login
            ///
            login.Dock = DockStyle.Fill;
            login.Location = new Point(0, 0);
            login.Margin = new Padding(0);
            login.Name = "login";
            login.TabIndex = 0;
            ///
            /// Main
            ///
            Controls.Add(login);
            ResumeLayout(false);
        }

        LoginControl login;
        #endregion
    }
}
