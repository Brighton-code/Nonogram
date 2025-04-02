using Nonogram.Views;
using Nonogram.Models;
using System.Text.RegularExpressions;

namespace Nonogram
{
    public partial class Main : Form
    {
        public static User? User = null;
        public Main()
        {
            InitializeComponent();
            InitializeView();

            Main.ChangeNavUser(Controls);
            Main.ChangeView("menu", Controls);
            //MessageBox.Show($"{Width}, {Height}");
        }

        public static void ChangeView(string controlName, Control.ControlCollection Controls)
        {
            Control? collectionControl = Controls.Find("pnlBody", false).FirstOrDefault();

            if (collectionControl == null) return;

            for (int i = 0; i < collectionControl.Controls.Count; i++)
            {
                Control control = collectionControl.Controls[i];
                if (control.Name != controlName)
                    control.Visible = false;
                else
                {
                    foreach (TagType tag in control.Tag as List<TagType>)
                    {
                        if (tag == TagType.Guest && Main.User != null)
                        {
                            Main.ChangeView("menu", Controls);
                            return;
                        }
                        else if (tag == TagType.Auth && Main.User == null)
                        {
                            Main.ChangeView("menu", Controls);
                            return;
                        }
                    }
                    control.Visible = true;
                }
            }
        }

        public static void ChangeNavUser(Control.ControlCollection Controls)
        {
            Control? collectionControl = Controls.Find("pnlNav", true).FirstOrDefault();
            if (collectionControl == null) return;

            if (Main.User == null)
            {
                for (int i = 0; i < collectionControl.Controls.Count; i++)
                {
                    Control control = collectionControl.Controls[i];
                    if (control.Name == "lblUser") control.Visible = false;
                    else if (control.Name == "btnUser")
                    {
                        control.Text = "login";
                        control.Tag = "login";
                    }
                }
            }
            else
            {
                for (int i = 0; i < collectionControl.Controls.Count; i++)
                {
                    Control control = collectionControl.Controls[i];

                    if (control.Name == "lblUser")
                    {
                        control.Visible = true;
                        control.Text = Main.User.Name;
                    }
                    else if (control.Name == "btnUser")
                    {
                        control.Text = "logout";
                        control.Tag = "logout";
                    }
                }
            }
        }

        #region Views code
        private void InitializeView()
        {
            menu = new MenuControl();
            login = new LoginControl();
            register = new RegisterControl();
            game = new GameControl();
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
            menu.Tag = new List<TagType>();
            ///
            /// login
            ///
            login.Dock = DockStyle.Fill;
            login.Location = new Point(0, 0);
            login.Margin = new Padding(0);
            login.Name = "login";
            login.TabIndex = 0;
            login.Visible = false;
            login.Tag = new List<TagType>() { TagType.Guest };
            ///
            /// Register
            ///
            register.Dock = DockStyle.Fill;
            register.Location = new Point(0, 0);
            register.Margin = new Padding(0);
            register.Name = "register";
            register.TabIndex = 0;
            register.Visible = false;
            register.Tag = new List<TagType>() { TagType.Guest };
            ///
            /// Game
            /// 
            game.Dock = DockStyle.Fill;
            game.Location = new Point(0, 0);
            game.Margin = new Padding(0);
            game.Name = "game";
            game.TabIndex = 0;
            game.Visible = false;
            game.Tag = new List<TagType>() { TagType.Auth };
            ///
            /// Main
            ///
            pnlBody.Controls.Add(menu);
            pnlBody.Controls.Add(login);
            pnlBody.Controls.Add(register);
            pnlBody.Controls.Add(game);
            ResumeLayout(false);
        }

        MenuControl menu;
        LoginControl login;
        RegisterControl register;
        GameControl game;
        #endregion

        //private void NavButton_Menu(object sender, EventArgs e)
        //{
        //    Main.ChangeView("menu", Controls);
        //}

        //private void NavButton_User(object sender, EventArgs e)
        //{
        //    Button btn = (Button)sender;

        //    switch (btn.Tag)
        //    {
        //        case "logout":
        //            Main.User = null;
        //            ChangeNavUser(Controls);
        //            break;
        //        case "login":
        //            Main.ChangeView("login", Controls);
        //            break;
        //    }
        //}

        private void Main_Resize(object sender, EventArgs e)
        {
            Update();
        }
    }
}
