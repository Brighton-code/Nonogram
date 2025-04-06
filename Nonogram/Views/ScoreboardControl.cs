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

        List<(string user, GameHistory history)> requestedGameHistories = new List<(string user, GameHistory)>();

        public ScoreboardControl()
        {
            InitializeComponent();
            FillScoreboardDropdown();
            cbSelectScoreboard.SelectedIndexChanged += UpdateScoreboard;
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

        private void UpdateScoreboard(object? sender, EventArgs e)
        {
            GetGameHistories();
            SortGameHistories();
            SetAllLabels();
        }

        private void GetGameHistories()
        {
            JsonUserDatabase db = new JsonUserDatabase();
            List<User> users = db.GetUsers("../../../Database/Users.json");

            requestedGameHistories.Clear();

            //Get all games with the selected size
            foreach (User user in users)
            {
                foreach (GameHistory history in user.History.Where(h => h.GridSize == allowedGridSizes.ElementAt(cbSelectScoreboard.SelectedIndex) && h.CompletedAt != null))
                {
                    requestedGameHistories.Add((user.Name, history));
                }
            }
        }

        private void SortGameHistories()
        {
            if (requestedGameHistories == null || requestedGameHistories.Count == 0)
                return; // change label text to no games found

            requestedGameHistories
                .OrderBy(gh => gh.history.GameTime)
                .ThenBy(gh => gh.history.CompletedAt)
                .ThenBy(gh => gh.history.HintsRequested)
                .ToList();
        }

        private void SetAllLabels()
        {
            List<(string user, GameHistory history)> gameHistories = requestedGameHistories.Take(10).ToList();

            foreach (Control control in pnlScoreboardLayout.Controls)
            {
                if(control is Label label)
                {
                    label.Text = "";
                }
            }

            if (requestedGameHistories == null || requestedGameHistories.Count == 0)
            {
                lbPosition1.Text = "No completed games at this size.";
                return;
            }

            for (int i = 0; i < gameHistories.Count; i++)
            {
                Label lb = (Label)pnlScoreboardLayout.Controls.Find($"lbPosition{i+1}", false).First();
                lb.Text = 
                    $"{i+1}. Name: {gameHistories[i].user} " +
                    $"Game time: {gameHistories[i].history.GameTime.ToString(@"mm\:ss\.fff")} " +
                    $"Hints: {gameHistories[i].history.HintsRequested} " +
                    $"Completed at: {gameHistories[i].history.CompletedAt}";
            }
        }
    }
}
