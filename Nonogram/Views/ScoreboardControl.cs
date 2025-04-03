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
        public ScoreboardControl()
        {
            InitializeComponent();
            LoadType();
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
                    dataGrid.Rows.Add([user.Name, history.GridSize, history.Seed, history.GameTime, history.CompletedAt, history.CreatedAt]);
                }
            }
        }
    }
}
