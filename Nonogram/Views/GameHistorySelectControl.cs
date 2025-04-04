using System;
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
            VisibleChanged += OnVisibleChanged;
        }

        private void OnVisibleChanged(object? sender, EventArgs e)
        {
            if (!Visible) return;

            cbGameHistory.Items.Clear();

            foreach (GameHistory history in Main.User.History)
            {
                if(history.CompletedAt == null) cbGameHistory.Items.Add($"Game size: {history.GridSize}x{history.GridSize}, Playtime: {history.GameTime.ToString(@"hh\:mm\:ss\.ff")}, Started at: {history.CreatedAt.Value.ToString(@"dd-MM-yyyy")}");
            }
        }

        private void btnLoadGame_Click(object sender, EventArgs e)
        {
            Main.ChangeView("game", FindForm().Controls);
        }
    }
}
