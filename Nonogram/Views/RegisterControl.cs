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
using Nonogram.Database;
using Nonogram.Interfaces;

namespace Nonogram.Views
{
    public partial class RegisterControl : UserControl, IHandlerInput
    {
        public RegisterControl()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Main.ChangeView("login", FindForm().Controls);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string password = tbPassword1.Text;
            string confirmPassword = tbPassword2.Text;

            if (!HandleInput(name) || !HandleInput(password) || !HandleInput(confirmPassword))
            {
                MessageBox.Show("Error with inputs", "Error Message");
                return;
            }

            JsonUserDatabase db = new JsonUserDatabase();
            List<User> users = db.GetUsers("../../../Database/Users.json");

            User dbUser = users.Where(u => u.Name == name).FirstOrDefault();

            if (dbUser != null)
            {
                MessageBox.Show(string.Format("User: {0} already exists", name));
                return;
            }

            // Check if password matches confirmPassword.
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            User user = new User(name, User.HashPassword(password), []);
            db.SaveNewUser(user, "../../../Database/Users.json");
            MessageBox.Show("Succefully created a account");

            // Change to login screen.
            Main.ChangeView("login", FindForm().Controls);
        }

        public bool HandleInput(string text)
        {
            if (string.IsNullOrEmpty(text))
                return false;
            return true;
        }
    }
}
