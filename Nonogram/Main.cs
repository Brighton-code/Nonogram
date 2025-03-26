using Nonogram.Views;

namespace Nonogram
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            InitializeView();

            Main.ChangeView("menu", Controls);
        }

        public static void ChangeView(string control, Control.ControlCollection Controls)
        {
            Control? collectionControl = Controls.Find("pnlBody", false).FirstOrDefault();

            if (collectionControl == null) return;

            for (int i = 0; i < collectionControl.Controls.Count; i++)
            {
                if (collectionControl.Controls[i].Name == control) collectionControl.Controls[i].Visible = true;
                else collectionControl.Controls[i].Visible = false;
            }
        }

        #region Views code
        private void InitializeView()
        {
            menu = new MenuControl();
            login = new LoginControl();
            register = new RegisterControl();
            SuspendLayout();
            ///
            /// menu
            /// 
            menu.Dock = DockStyle.Fill;
            menu.Location = new Point(0, 0);
            menu.Margin = new Padding(0);
            menu.Name = "menu";
            menu.TabIndex = 0;
            menu.Visible = false;
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
            pnlBody.Controls.Add(menu);
            pnlBody.Controls.Add(login);
            pnlBody.Controls.Add(register);
            ResumeLayout(false);
        }

        MenuControl menu;
        LoginControl login;
        RegisterControl register;
        #endregion

        private void NavButton_Menu(object sender, EventArgs e)
        {
            Main.ChangeView("menu", Controls);
        }
    }
}
