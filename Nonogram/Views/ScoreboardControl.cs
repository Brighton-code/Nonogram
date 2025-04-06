using Nonogram.Database;
using Nonogram.Models;
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
    public partial class ScoreboardControl : UserControl, ILoadType
    {
        List<int> allowedGridSizes = new List<int>()
        {
            5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20
        };

        public ScoreboardControl()
        {
            InitializeComponent();
            FillScoreboardDropdown();
            cbSelectScoreboard.SelectedIndexChanged += GetGameHistories;
            //LoadType();
        }

        public void LoadType()
        {
            dataGrid.Rows.Clear();
            JsonUserDatabase db = new JsonUserDatabase();
            List<User> users = db.GetUsers("../../../Database/Users.json");

            foreach (User user in users)
            {
                foreach (GameHistory history in user.History)
                {
                    dataGrid.Rows.Add([user.Name, history.GridSize, history.Seed, history.HintsRequested ,history.GameTime, history.CompletedAt, history.CreatedAt]);
                }
            }
        }

        private void FillScoreboardDropdown()
        {
            foreach(int size in allowedGridSizes)
            {
                cbSelectScoreboard.Items.Add($"{size}x{size} difficulty");
            }
        }

        private List<GameHistory> GetGameHistories(object? sender, EventArgs e)
        {
            //int a = cbSelectScoreboard.SelectedIndex; 0 on 5x5
            JsonUserDatabase db = new JsonUserDatabase();
            List<User> users = db.GetUsers("../../../Database/Users.json");

            List<GameHistory> allGames = new List<GameHistory>();

            //Get all games
            foreach (User user in users)
            {
                foreach (GameHistory history in user.History.Where(h => h.GridSize == allowedGridSizes.ElementAt(cbSelectScoreboard.SelectedIndex)))
                {
                    allGames.Add(history);
                }
            }

            int a = 1;
            return allGames;
        }


    }
}
