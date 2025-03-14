using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nonogram.Models;

namespace Nonogram.Views
{
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Main.ChangeView("register", FindForm().Controls);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string password = tbPassword.Text;

            if (!HandleInput(name) || !HandleInput(password))
            {
                MessageBox.Show("Error with inputs", "Error Message");
                return;
            }

            //User.VerifyPassword(password);
        }

        // Make Input handler class
        private bool HandleInput(string text)
        {
            if (string.IsNullOrEmpty(text))
                return false;
            return true;
        }
    }
}
