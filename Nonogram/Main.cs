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
            CenterToScreen();

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
                        if (tag == TagType.Load && control is ILoadType loadControl)
                        {
                            loadControl.LoadType();
                        }

                        if (tag == TagType.Guest && Main.User != null)
                        {
                            Main.ChangeView("menu", Controls);
                            MessageBox.Show("Requires guest user");
                            return;
                        }
                        else if (tag == TagType.Auth && Main.User == null)
                        {
                            Main.ChangeView("menu", Controls);
                            MessageBox.Show("Requires logged in user");
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
            load = new GameLoadControl();
            historySelect = new GameHistorySelectControl();
            game = new GameControl();
            scoreboard = new ScoreboardControl();

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
            /// Load
            /// 
            load.Dock = DockStyle.Fill;
            load.Location = new Point(0, 0);
            load.Margin = new Padding(0);
            load.Name = "load";
            load.TabIndex = 0;
            load.Visible = false;
            load.Tag = new List<TagType>() { TagType.Auth };
            ///
            /// History Select
            /// 
            historySelect.Dock = DockStyle.Fill;
            historySelect.Location = new Point(0, 0);
            historySelect.Margin = new Padding(0);
            historySelect.Name = "historySelect";
            historySelect.TabIndex = 0;
            historySelect.Visible = false;
            historySelect.Tag = new List<TagType>() { TagType.Auth };
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
            /// Scoreboard
            /// 
            scoreboard.Dock = DockStyle.Fill;
            scoreboard.Location = new Point(0, 0);
            scoreboard.Margin = new Padding(0);
            scoreboard.Name = "scoreboard";
            scoreboard.TabIndex = 0;
            scoreboard.Visible = false;
            scoreboard.Tag = new List<TagType>() { TagType.Load };
            ///
            /// Main
            ///
            pnlBody.Controls.Add(menu);
            pnlBody.Controls.Add(login);
            pnlBody.Controls.Add(register);
            pnlBody.Controls.Add(load);
            pnlBody.Controls.Add(historySelect);
            pnlBody.Controls.Add(game);
            pnlBody.Controls.Add(scoreboard);
            ResumeLayout(false);
        }

        MenuControl menu;
        LoginControl login;
        RegisterControl register;
        GameLoadControl load;
        GameHistorySelectControl historySelect;
        GameControl game;
        ScoreboardControl scoreboard;
        #endregion

        private void Main_Resize(object sender, EventArgs e)
        {
            Update();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;

            if (Controls.Find("game", true).First().Visible && !e.Cancel)
                Main.ChangeView("menu", Controls);

            //if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.No)
            //{
            //    e.Cancel = true; // Cancel the close operation
            //}
        }
    }
}
