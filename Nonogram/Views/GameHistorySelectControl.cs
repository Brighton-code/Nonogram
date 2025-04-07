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
        private List<GameHistory> _userHistory;

        public GameHistorySelectControl()
        {
            InitializeComponent();
            VisibleChanged += OnVisibleChanged;
        }

        private void OnVisibleChanged(object? sender, EventArgs e)
        {
            if (!Visible) return;

            cbGameHistory.Items.Clear();

            _userHistory = Main.User.History.Where(h => h.CompletedAt == null).ToList();

            // Display available unfinished games
            foreach (GameHistory history in _userHistory)
            {
                cbGameHistory.Items.Add($"Game size: {history.GridSize}x{history.GridSize}, Playtime: {history.GameTime.ToString(@"hh\:mm\:ss\.ff")}, Started at: {history.CreatedAt.Value.ToString(@"dd-MM-yyyy")}");
            }

            if (cbGameHistory.Items.Count > 0) cbGameHistory.SelectedIndex = 0;
        }

        private void btnLoadGame_Click(object sender, EventArgs e)
        {
            GameControl gc = (GameControl)FindForm().Controls.Find("game", true).FirstOrDefault();

            Main.ChangeView("game", FindForm().Controls);

            if (gc != null)
            {
                gc.LoadHistory(_userHistory[cbGameHistory.SelectedIndex]);
            }
        }
    }
}
