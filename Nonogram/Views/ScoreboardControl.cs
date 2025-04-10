﻿using Nonogram.Database;
using Nonogram.Interfaces;
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
        private List<int> _allowedGridSizes = new List<int>()
        {
            5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20
        };

        private List<(string user, GameHistory history)> _requestedGameHistories = new List<(string user, GameHistory)>();

        public ScoreboardControl()
        {
            InitializeComponent();
            FillScoreboardDropdown();
            cbSelectScoreboard.SelectedIndex = 0;
            cbSelectScoreboard.SelectedIndexChanged += UpdateScoreboard;
        }

        public void LoadType()
        {
            GetGameHistories();
            SortGameHistories();
            SetAllLabels();
        }

        private void FillScoreboardDropdown()
        {
            foreach(int size in _allowedGridSizes)
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

            _requestedGameHistories.Clear();

            //Get all games with the selected size
            foreach (User user in users)
            {
                foreach (GameHistory history in user.History.Where(h => h.GridSize == _allowedGridSizes.ElementAt(cbSelectScoreboard.SelectedIndex) && h.CompletedAt != null))
                {
                    _requestedGameHistories.Add((user.Name, history));
                }
            }
        }

        private void SortGameHistories()
        {
            if (_requestedGameHistories == null || _requestedGameHistories.Count == 0)
                return; // change label text to no games found

            _requestedGameHistories = _requestedGameHistories
                .OrderBy(gh => gh.history.HintsRequested)
                .ThenBy(gh => gh.history.GameTime)
                .ThenBy(gh => gh.history.CompletedAt)
                .ToList();
        }

        private void SetAllLabels()
        {
            List<(string user, GameHistory history)> gameHistories = _requestedGameHistories.Take(10).ToList();

            foreach (Control control in pnlScoreboardLayout.Controls)
            {
                if(control is Label label)
                {
                    label.Text = "";
                }
            }

            if (_requestedGameHistories == null || _requestedGameHistories.Count == 0)
            {
                lbPosition1.Text = "No completed games at this size.";
                return;
            }

            for (int i = 0; i < gameHistories.Count; i++)
            {
                Label lb = (Label)pnlScoreboardLayout.Controls.Find($"lbPosition{i+1}", false).First();
                lb.Text = 
                    $"{i+1}. Name: {gameHistories[i].user} | " +
                    $"Game time: {gameHistories[i].history.GameTime.ToString(@"mm\:ss\.fff")} | " +
                    $"Hints: {gameHistories[i].history.HintsRequested} | " +
                    $"Completed at: {gameHistories[i].history.CompletedAt}";
            }
        }
    }
}
