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
        private GameHistory _history;
        private System.Timers.Timer _timer;

        private Font _font;
        private Font _fontHigh;
        private FontFamily _fontFamily = new("Arial");
        private bool _showSolution = false;

        public GameControl()
        {
            InitializeComponent();

            VisibleChanged += GameControl_VisibleChanged;

            pnlGame.Paint += PnlGame_Paint;
            pnlGame.MouseClick += PnlGame_MouseClick;
            pnlGame.Resize += PnlGame_Resize;

            _timer = new System.Timers.Timer();
            _timer.Interval = 10;
            _timer.Elapsed += UpdateTimeLabel;

            // https://stackoverflow.com/questions/8046560/how-to-stop-flickering-c-sharp-winforms
            typeof(Panel).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, pnlGame, [true]);
        }

        private bool MarkedIsChanged()
        {
            return Game.Flatten(_game.GameState).SequenceEqual(new Marked[_game.GridSize * _game.GridSize]);
        }

        private void GameControl_VisibleChanged(object? sender, EventArgs e)
        {
            if (_game == null) return;
            if (Main.User == null) return;

            if (!MarkedIsChanged())
                StoreStateToHistory();

            _game.Stopwatch.Reset();
            _timer.Stop();

            _game = null;
            _history = null;
            lblSeed.Text = "Seed";
            lblStopwatch.Text = "Time elapsed";
        }

        private void StoreStateToHistory()
        {
            if (_game == null) return;
            if (Main.User == null) return;

            _history.GameState = _game.EncodeMarked();
            _history.GameTime = _game.Stopwatch.Elapsed;
            _history.UpdatedAt = DateTime.Now;

            if (_game.Complete)
                _history.CompletedAt = _history.UpdatedAt;

            int index = Main.User.History.FindIndex(h => h.Seed == _game.Seed && h.GridSize == _game.GridSize);

            if (index != -1)
                Main.User.History[index] = _history;
            else
                Main.User.History.Add(_history);

            JsonUserDatabase db = new JsonUserDatabase();
            db.SaveToUser(Main.User, "../../../Database/Users.json");
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
                    _game.GameState[row, col] = _game.GameState[row, col] != Marked.Done ? Marked.Done : Marked.None;
                    break;
                case MouseButtons.Right:
                    _game.GameState[row, col] = _game.GameState[row, col] != Marked.Wrong ? Marked.Wrong : Marked.None;
                    break;
            }

            pnlGame.Invalidate();

            _game.ValidateGame();
            StoreStateToHistory();
            if (_game.Complete)
            {
                _game.Stopwatch.Stop();
                _timer.Stop();
                MessageBox.Show("Game is complete");
            }
        }

        private void PnlGame_Paint(object? sender, PaintEventArgs e)
        {
            if (_game == null) return;

            Graphics g = e.Graphics;

            _game.CellSize = Math.Min(pnlGame.ClientSize.Width, pnlGame.ClientSize.Height) / (_game.GridSize + Math.Max(_game.RowHintMax, _game.ColHintMax));
            _game.GridStart = new Point(_game.CellSize * _game.RowHintMax, _game.CellSize * _game.ColHintMax);
            _game.GridArea = _game.CellSize * _game.GridSize;

            // Make scoped?
            _font = new Font(_fontFamily, Math.Max(_game.CellSize, 1), FontStyle.Bold, GraphicsUnit.Pixel);
            _fontHigh = new Font(_fontFamily, Math.Max((float)(_game.CellSize - (_game.CellSize / 3.5)), 1), FontStyle.Bold, GraphicsUnit.Pixel);

            Rectangle area = new Rectangle(_game.GridStart.X, _game.GridStart.Y, _game.GridArea, _game.GridArea);

            g.FillRectangle(Brushes.White, area);

            for (int i = 0; i < _game.GridSize; i++)
            {
                g.DrawLine(Pens.Black, _game.GridStart.X, _game.GridStart.Y + i * _game.CellSize, _game.GridStart.X + _game.GridArea, _game.GridStart.Y + i * _game.CellSize);
                g.DrawLine(Pens.Black, _game.GridStart.X + i * _game.CellSize, _game.GridStart.Y, _game.GridStart.X + i * _game.CellSize, _game.GridStart.Y + _game.GridArea);
            }
            g.DrawRectangle(Pens.Black, area);

            // Draw Marked cells
            for (int row = 0; row < _game.GameState.GetLength(0); row++)
                for (int col = 0; col < _game.GameState.GetLength(1); col++)
                    if (_game.GameState[row, col] == Marked.Done)
                        g.FillRectangle(Brushes.Black, _game.GridStart.X + (col * _game.CellSize + _game.CellPadding.Left), _game.GridStart.Y + (row * _game.CellSize + _game.CellPadding.Top), _game.CellSize - _game.CellPadding.Left - _game.CellPadding.Right, _game.CellSize - _game.CellPadding.Bottom - _game.CellPadding.Top);
                    else if (_game.GameState[row, col] == Marked.Wrong)
                        g.DrawString("X", _font, Brushes.DarkRed, new Rectangle(_game.GridStart.X + (col * _game.CellSize), _game.GridStart.Y + (row * _game.CellSize), _game.CellSize, _game.CellSize));

            // TODO:
            if (_showSolution)
                for (int row = 0; row < _game.Solution.GetLength(0); row++)
                    for (int col = 0; col < _game.Solution.GetLength(1); col++)
                        if (_game.Solution[row, col] == 1)
                        {

                            if (_game.GameState[row, col] == Marked.None)
                                g.FillRectangle(Brushes.Blue, _game.GridStart.X + (col * _game.CellSize + _game.CellPadding.Left), _game.GridStart.Y + (row * _game.CellSize + _game.CellPadding.Top), _game.CellSize - _game.CellPadding.Left - _game.CellPadding.Right, _game.CellSize - _game.CellPadding.Bottom - _game.CellPadding.Top);
                            else if (_game.GameState[row, col] == Marked.Wrong)
                                g.FillRectangle(Brushes.Red, _game.GridStart.X + (col * _game.CellSize + _game.CellPadding.Left), _game.GridStart.Y + (row * _game.CellSize + _game.CellPadding.Top), _game.CellSize - _game.CellPadding.Left - _game.CellPadding.Right, _game.CellSize - _game.CellPadding.Bottom - _game.CellPadding.Top);
                            else if (_game.GameState[row, col] == Marked.Done)
                                g.FillRectangle(Brushes.Green, _game.GridStart.X + (col * _game.CellSize + _game.CellPadding.Left), _game.GridStart.Y + (row * _game.CellSize + _game.CellPadding.Top), _game.CellSize - _game.CellPadding.Left - _game.CellPadding.Right, _game.CellSize - _game.CellPadding.Bottom - _game.CellPadding.Top);
                        }
                        else
                            if (_game.GameState[row, col] == Marked.Done)
                            g.FillRectangle(Brushes.Red, _game.GridStart.X + (col * _game.CellSize + _game.CellPadding.Left), _game.GridStart.Y + (row * _game.CellSize + _game.CellPadding.Top), _game.CellSize - _game.CellPadding.Left - _game.CellPadding.Right, _game.CellSize - _game.CellPadding.Bottom - _game.CellPadding.Top);

            // Draw Horizontal Hints
            for (int i = 0; i < _game.RowHints.Length; i++)
                for (int j = 0; j < _game.RowHints[i].Length; j++)
                    if (_game.RowHints[i][j] < 10)
                        g.DrawString(_game.RowHints[i][j].ToString(), _font, Brushes.Black, new Rectangle((_game.GridStart.X - (_game.CellSize * _game.RowHints[i].Length)) + (_game.CellSize * j), _game.GridStart.Y + (_game.CellSize * i), _game.CellSize, _game.CellSize));
                    else
                        g.DrawString(_game.RowHints[i][j].ToString(), _fontHigh, Brushes.Black, _game.GridStart.X - (_game.CellSize * _game.RowHints[i].Length) + (_game.CellSize * j), _game.GridStart.Y + (_game.CellSize * i) + (int)(_game.CellSize / 5));

            // Draw Vertical Hints
            for (int i = 0; i < _game.ColHints.Length; i++)
                for (int j = 0; j < _game.ColHints[i].Length; j++)
                    if (_game.ColHints[i][j] < 10)
                        g.DrawString(_game.ColHints[i][j].ToString(), _font, Brushes.Black, new Rectangle(_game.GridStart.X + (_game.CellSize * i), (_game.GridStart.Y - (_game.CellSize * _game.ColHints[i].Length)) + (_game.CellSize * j), _game.CellSize, _game.CellSize));
                    else
                        g.DrawString(_game.ColHints[i][j].ToString(), _fontHigh, Brushes.Black, _game.GridStart.X + (_game.CellSize * i), _game.GridStart.Y - (_game.CellSize * _game.ColHints[i].Length) + (_game.CellSize * j) + (int)(_game.CellSize / 5));

        }

        public void ChangeGrid(int size)
        {
            _game = new Game(size);
            _history = new GameHistory();
            _history.Seed = _game.Seed;
            _history.GridSize = _game.GridSize;
            _history.CreatedAt = DateTime.Now;

            _timer.Start();
            _game.Stopwatch.StartOffset = TimeSpan.Zero;
            _game.Stopwatch.Restart();
            lblSeed.Text = _game.Seed.ToString();
            lblHintsRequested.Text = $"Hints: {_history.HintsRequested}";
        }

        public void LoadHistory(GameHistory gameHistory)
        {
            _game = new Game(gameHistory.GridSize, gameHistory.Seed);
            _game.ConvertGameStateTo2Darray(gameHistory.GameState);
            _history = gameHistory;
            _game.Stopwatch.StartOffset = gameHistory.GameTime;
            _game.Stopwatch.Start();
            _timer.Start();
            lblSeed.Text = _game.Seed.ToString();
            lblHintsRequested.Text = $"Hints: {_history.HintsRequested}";
            pnlGame.Refresh();
        }

        private void UpdateTimeLabel(object? sender, ElapsedEventArgs e)
        {
            if (IsHandleCreated)
            {
                if (InvokeRequired)
                    Invoke(new Action(() =>
                    {
                        if (_game != null)
                            lblStopwatch.Text = _game.Stopwatch.Elapsed.ToString(@"mm\:ss\.ff");
                    }));
                else
                    lblStopwatch.Text = _game.Stopwatch.Elapsed.ToString(@"mm\:ss\.ff");
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
            _showSolution = !_showSolution;
            pnlGame.Invalidate();
        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            if (_game == null)
                return;

            List<Point> hints = _game.GetPossibleHints();
            Point hint = hints.ElementAtOrDefault(Random.Shared.Next(0, hints.Count));

            _history.HintsRequested++;
            StoreStateToHistory();
            lblHintsRequested.Text = $"Hints: {_history.HintsRequested}";
            MessageBox.Show($"The tile on row {hint.X+1} and column {hint.Y+1} is current incorrect!");
        }
    }
}
