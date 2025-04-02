using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nonogram.Views
{
    public partial class NavbarControl : UserControl
    {
        public NavbarControl()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Main.ChangeView("menu", FindForm().Controls);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            switch (btn.Tag)
            {
                case "logout":
                    Main.User = null;
                    Main.ChangeNavUser(FindForm().Controls);
                    Main.ChangeView("menu", FindForm().Controls);
                    break;
                case "login":
                    Main.ChangeView("login", FindForm().Controls);
                    break;
            }
        }
    }
}
