﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Nonogram.Database;
using Nonogram.Models;

namespace Nonogram.Views
{
    public partial class GameHistorySelectControl : UserControl
    {
        public GameHistorySelectControl()
        {
            InitializeComponent();
        }


        private void btnLoadGame_Click(object sender, EventArgs e)
        {
            Main.ChangeView("game", FindForm().Controls);
        }
    }
}
