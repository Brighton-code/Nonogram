using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nonogram.Models;

namespace Nonogram.Views
{
    public partial class GameControl : UserControl
    {
        private Game _game;
        public GameControl()
        {
            InitializeComponent();

        }

        public void ChangeGrid(int size)
        {
            _game = new Game(size);
            //MessageBox.Show(size.ToString());
        }
        private void inGridSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnSubmitSize_Click(sender, e);
        }

        private void btnSubmitSize_Click(object sender, EventArgs e)
        {
            ChangeGrid((int)inGridSize.Value);
            pnlGame.Refresh();
        }
    }
}
