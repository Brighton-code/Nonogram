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
    public partial class GameLoadControl : UserControl
    {
        public GameLoadControl()
        {
            InitializeComponent();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            Main.ChangeView("game", FindForm().Controls);
        }

        private void btnLoadGame_Click(object sender, EventArgs e)
        {
            // Check if history exists
            if (Main.User.History.Count == 0)
            {
                MessageBox.Show("No available game history, create a new game instead!");
            }
            else
            {
                Main.ChangeView("historySelect", FindForm().Controls);
            }
        }
    }
}
