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

            cbTheme.CheckedChanged += CbTheme_CheckedChanged;
        }

        private void CbTheme_CheckedChanged(object? sender, EventArgs e)
        {
            Form form = FindForm();
            List<Button> buttons = Main.GetAllButtons(form);
            List<Label> labels = Main.GetAllLabels(form);

            Color color = cbTheme.Checked ? ColorTranslator.FromHtml("#2D2D30") : ColorTranslator.FromHtml("#F0F0F0");
            Color colorCom = Main.GetComplementaryColor(color);
            form.BackColor = color;

            foreach (Button button in buttons)
            {
                button.BackColor = color;
                button.ForeColor = colorCom;
            }

            foreach (Label label in labels) 
            {
                label.ForeColor = colorCom;
            }
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
                    Main.ChangeView("menu", FindForm().Controls);
                    Main.User = null;
                    Main.ChangeNavUser(FindForm().Controls);
                    break;
                case "login":
                    Main.ChangeView("login", FindForm().Controls);
                    break;
            }
        }
    }
}
