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
    public partial class DifficultyControl : UserControl
    {
        //Store difficulties to select
        string[] textDifficulties =
            [
                "5x5, no time limit",
                "6x6, no time limit",
                "7x7, no time limit",
                "8x8, no time limit",
                "9x9, no time limit",
                "10x10, 5 minute timer",
                "15x15, 5 minute timer",
                "20x20, 5 minute timer",
            ];

        public DifficultyControl()
        {
            InitializeComponent();

            if(cbDifficulty.Items != null && cbDifficulty.Items.Count == 0)
            {
                cbDifficulty.Text = "Please pick a difficulty";
                cbDifficulty.Items.AddRange(textDifficulties);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            GameControl gc = (GameControl)FindForm().Controls.Find("game", true).FirstOrDefault();
            if(gc != null)
            {
                gc.ChangeGrid(10);
            }

            Main.ChangeView("game", FindForm().Controls);
        }
    }
}
