using Nonogram.Views;

namespace Nonogram
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            InitializeView();

            Main.ChangeView("login", Controls);
        }

        public static void ChangeView(string control, Control.ControlCollection Controls)
        {
            for (int i = 0; i < Controls.Count; i++)
            {
                Controls[i].Visible = false;
                if (Controls[i].Name == control)
                    Controls[i].Visible = true;
            }
        }

        #region Views code
        private void InitializeView()
        {
            login = new LoginControl();
            register = new RegisterControl();
            SuspendLayout();
            ///
            /// login
            ///
            login.Dock = DockStyle.Fill;
            login.Location = new Point(0, 0);
            login.Margin = new Padding(0);
            login.Name = "login";
            login.TabIndex = 0;
            login.Visible = false;
            ///
            /// Register
            ///
            register.Dock = DockStyle.Fill;
            register.Location = new Point(0, 0);
            register.Margin = new Padding(0);
            register.Name = "register";
            register.TabIndex = 0;
            register.Visible = false;
            ///
            /// Main
            ///
            Controls.Add(login);
            Controls.Add(register);
            ResumeLayout(false);
        }

        LoginControl login;
        RegisterControl register;
        #endregion
    }
}
