using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }
    }
}
