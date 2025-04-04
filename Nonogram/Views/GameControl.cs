using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Nonogram.Database;
using Nonogram.Models;

namespace Nonogram.Views
{
    public partial class GameControl : UserControl
    {
        private Game _game;
        private Stopwatch _stopwatch;
        private System.Timers.Timer _timer;

        FontFamily fontFamily = new("Arial");
        Font font;
        Font fontHigh;
        bool showSolution = false;
        public GameControl()
        {
            InitializeComponent();

            pnlGame.Paint += PnlGame_Paint;
            pnlGame.MouseClick += PnlGame_MouseClick;
            pnlGame.Resize += PnlGame_Resize;

            _timer = new System.Timers.Timer();
            _timer.Interval = 10;
            _timer.Elapsed += UpdateTimeLabel;

            _stopwatch = new Stopwatch();

            // https://stackoverflow.com/questions/8046560/how-to-stop-flickering-c-sharp-winforms
            typeof(Panel).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, pnlGame, [true]);
        }

        private void PnlGame_Resize(object? sender, EventArgs e)
        {
            pnlGame.Invalidate();
        }

        private void PnlGame_MouseClick(object? sender, MouseEventArgs e)
        {
            if (_game == null) return;

            if (e.X < _game.GridStart.X || e.X > _game.GridStart.X + (_game.CellSize * _game.GridSize) - 1)
                return;
            if (e.Y < _game.GridStart.Y || e.Y > _game.GridStart.Y + (_game.CellSize * _game.GridSize) - 1)
                return;

            int col = (int)Math.Floor(((float)e.X - _game.GridStart.X) / _game.CellSize);
            int row = (int)Math.Floor(((float)e.Y - _game.GridStart.Y) / _game.CellSize);

            switch (e.Button)
            {
                case MouseButtons.Left:
                    _game.Marked[row, col] = _game.Marked[row, col] != Marked.Done ? Marked.Done : Marked.None;
                    break;
                case MouseButtons.Right:
                    _game.Marked[row, col] = _game.Marked[row, col] != Marked.Wrong ? Marked.Wrong : Marked.None;
                    break;
            }

            pnlGame.Invalidate();

            _game.ValidateGame();
            if (_game.Complete)
            {
                _stopwatch.Stop();
                _timer.Stop();
                MessageBox.Show("Game is complete");

                int indx = Main.User.History.FindIndex(h => h.Seed == _game.Seed);

                if (indx != -1)
                {
                    Main.User.History[indx].GameState = _game.EncodeMarked();
                    Main.User.History[indx].CompletedAt = DateTime.Now;
                    Main.User.History[indx].CreatedAt = DateTime.Now;
                    //Main.User.History[indx].UpdatedAt = DateTime.Now;
                }
                else
                {
                    GameHistory history = new GameHistory();
                    history.Seed = _game.Seed;
                    history.GridSize = _game.GridSize;
                    history.GameState = _game.EncodeMarked();
                    history.CompletedAt = DateTime.Now;
                    history.CreatedAt = DateTime.Now;
                    //history.UpdatedAt = DateTime.Now;
                    Main.User.History.Add(history);
                }

                JsonUserDatabase db = new JsonUserDatabase();
                db.SaveToUser(Main.User, "../../../Database/Users.json");
            }
        }

        private void PnlGame_Paint(object? sender, PaintEventArgs e)
        {
            Stopwatch sw = Stopwatch.StartNew();
            if (_game == null) return;

            Graphics g = e.Graphics;

            _game.CellSize = Math.Min(pnlGame.ClientSize.Width, pnlGame.ClientSize.Height) / (_game.GridSize + Math.Max(_game.RowHintMax, _game.ColHintMax));
            _game.GridStart = new Point(_game.CellSize * _game.RowHintMax, _game.CellSize * _game.ColHintMax);
            _game.GridArea = _game.CellSize * _game.GridSize;

            // Make scoped?
            font = new Font(fontFamily, Math.Max(_game.CellSize, 1), FontStyle.Bold, GraphicsUnit.Pixel);
            fontHigh = new Font(fontFamily, Math.Max((float)(_game.CellSize - (_game.CellSize / 3.5)), 1), FontStyle.Bold, GraphicsUnit.Pixel);

            Rectangle area = new Rectangle(_game.GridStart.X, _game.GridStart.Y, _game.GridArea, _game.GridArea);

            g.FillRectangle(Brushes.White, area);

            for (int i = 0; i < _game.GridSize; i++)
            {
                g.DrawLine(Pens.Black, _game.GridStart.X, _game.GridStart.Y + i * _game.CellSize, _game.GridStart.X + _game.GridArea, _game.GridStart.Y + i * _game.CellSize);
                g.DrawLine(Pens.Black, _game.GridStart.X + i * _game.CellSize, _game.GridStart.Y, _game.GridStart.X + i * _game.CellSize, _game.GridStart.Y + _game.GridArea);
            }
            g.DrawRectangle(Pens.Black, area);

#if DEBUG
            // Debug
            if (showSolution)
            {
                for (int row = 0; row < _game.Solution.GetLength(0); row++)
                    for (int col = 0; col < _game.Solution.GetLength(1); col++)
                        if (_game.Solution[row, col] == 1)
                            g.FillRectangle(Brushes.Blue, _game.GridStart.X + (col * _game.CellSize + _game.CellPadding.Left), _game.GridStart.Y + (row * _game.CellSize + _game.CellPadding.Top), _game.CellSize - _game.CellPadding.Left - _game.CellPadding.Right, _game.CellSize - _game.CellPadding.Bottom - _game.CellPadding.Top);
            }

            // End Debug
#endif

            // Draw Marked cells
            for (int row = 0; row < _game.Marked.GetLength(0); row++)
                for (int col = 0; col < _game.Marked.GetLength(1); col++)
                    if (_game.Marked[row, col] == Marked.Done)
                        g.FillRectangle(Brushes.Black, _game.GridStart.X + (col * _game.CellSize + _game.CellPadding.Left), _game.GridStart.Y + (row * _game.CellSize + _game.CellPadding.Top), _game.CellSize - _game.CellPadding.Left - _game.CellPadding.Right, _game.CellSize - _game.CellPadding.Bottom - _game.CellPadding.Top);
                    else if (_game.Marked[row, col] == Marked.Wrong)
                        g.DrawString("X", font, Brushes.DarkRed, new Rectangle(_game.GridStart.X + (col * _game.CellSize), _game.GridStart.Y + (row * _game.CellSize), _game.CellSize, _game.CellSize));

            // Draw Horizontal Hints
            for (int i = 0; i < _game.RowHints.Length; i++)
                for (int j = 0; j < _game.RowHints[i].Length; j++)
                    if (_game.RowHints[i][j] < 10)
                        g.DrawString(_game.RowHints[i][j].ToString(), font, Brushes.Black, new Rectangle((_game.GridStart.X - (_game.CellSize * _game.RowHints[i].Length)) + (_game.CellSize * j), _game.GridStart.Y + (_game.CellSize * i), _game.CellSize, _game.CellSize));
                    else
                        g.DrawString(_game.RowHints[i][j].ToString(), fontHigh, Brushes.Black, _game.GridStart.X - (_game.CellSize * _game.RowHints[i].Length) + (_game.CellSize * j), _game.GridStart.Y + (_game.CellSize * i) + (int)(_game.CellSize / 5));

            // Draw Vertical Hints
            for (int i = 0; i < _game.ColHints.Length; i++)
                for (int j = 0; j < _game.ColHints[i].Length; j++)
                    if (_game.ColHints[i][j] < 10)
                        g.DrawString(_game.ColHints[i][j].ToString(), font, Brushes.Black, new Rectangle(_game.GridStart.X + (_game.CellSize * i), (_game.GridStart.Y - (_game.CellSize * _game.ColHints[i].Length)) + (_game.CellSize * j), _game.CellSize, _game.CellSize));
                    else
                        g.DrawString(_game.ColHints[i][j].ToString(), fontHigh, Brushes.Black, _game.GridStart.X + (_game.CellSize * i), _game.GridStart.Y - (_game.CellSize * _game.ColHints[i].Length) + (_game.CellSize * j) + (int)(_game.CellSize / 5));

            sw.Stop();
            //lblStopwatch.Text = sw.Elapsed.ToString();
        }
        public void ChangeGrid(int size)
        {
            _game = new Game(size);
            _timer.Start();
            _stopwatch.Restart();
            lblSeed.Text = _game.Seed.ToString();
            //MessageBox.Show(size.ToString());
        }
        private void UpdateTimeLabel(object? sender, ElapsedEventArgs e)
        {
            if (IsHandleCreated)
            {
                if (InvokeRequired)
                    Invoke(new Action(() =>
                    {
                        lblStopwatch.Text = _stopwatch.Elapsed.ToString(@"mm\:ss\.ff");
                    }));
                else
                    lblStopwatch.Text = _stopwatch.Elapsed.ToString(@"mm\:ss\.ff");
            }
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

        private void btnSolution_Click(object sender, EventArgs e)
        {
            showSolution = !showSolution;
            pnlGame.Invalidate();
        }
    }
}
