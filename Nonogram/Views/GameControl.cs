using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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

            DoubleBuffered = true;
            pnlGame.Paint += PnlGame_Paint;
            pnlGame.MouseClick += PnlGame_MouseClick;
            pnlGame.Resize += PnlGame_Resize;
        }

        private void PnlGame_Resize(object? sender, EventArgs e)
        {
            pnlGame.Invalidate();
        }

        private void PnlGame_MouseClick(object? sender, MouseEventArgs e)
        {
            if (e.X < 0 || e.X > _game.CellSize * _game.GridSize)
                return;
            if (e.Y < 0 || e.Y > _game.CellSize * _game.GridSize)
                return;

            int col = (int)Math.Floor((float)e.X / _game.CellSize);
            int row = (int)Math.Floor((float)e.Y / _game.CellSize);

            if (_game.Marked[row, col] == 0) _game.Marked[row, col] = 1;
            else _game.Marked[row, col] = 0;

            pnlGame.Invalidate();
        }

        private void PnlGame_Paint(object? sender, PaintEventArgs e)
        {
            if (_game == null) return;

            //pnlGame.SuspendLayout();

            Graphics g = e.Graphics;

            _game.CellSize = Math.Min(pnlGame.ClientSize.Width, pnlGame.ClientSize.Height) / _game.GridSize;
            Rectangle area = new Rectangle(0, 0, _game.CellSize * _game.GridSize, _game.CellSize * _game.GridSize);

            g.FillRectangle(Brushes.White, area);

            for (int i = 0; i < _game.GridSize; i++)
            {
                g.DrawLine(Pens.Black, 0, i * _game.CellSize, _game.CellSize * _game.GridSize, i * _game.CellSize);
                g.DrawLine(Pens.Black, i * _game.CellSize, 0, i * _game.CellSize, _game.CellSize * _game.GridSize);
            }
            g.DrawRectangle(Pens.Black, area);

#if DEBUG
            // Debug
            for (int row = 0; row < _game.Solution.GetLength(0); row++)
                for (int col = 0; col < _game.Solution.GetLength(1); col++)
                    if (_game.Solution[row, col] == 1)
                        g.FillRectangle(Brushes.Red, col * _game.CellSize + _game.CellPadding.Left, row * _game.CellSize + _game.CellPadding.Top, _game.CellSize - _game.CellPadding.Left - _game.CellPadding.Right, _game.CellSize - _game.CellPadding.Bottom - _game.CellPadding.Top);
            // End Debug
#endif

            for (int row = 0; row < _game.Marked.GetLength(0); row++)
            {
                for (int col = 0; col < _game.Marked.GetLength(1); col++)
                {
                    if (_game.Marked[row, col] == 1)
                        g.FillRectangle(Brushes.Black, col * _game.CellSize + _game.CellPadding.Left, row * _game.CellSize + _game.CellPadding.Top, _game.CellSize - _game.CellPadding.Left - _game.CellPadding.Right, _game.CellSize - _game.CellPadding.Bottom - _game.CellPadding.Top);
                }
            }

            //pnlGame.ResumeLayout(false);
        }
        public void ChangeGrid(int size)
        {
            _game = new Game(size);
            //MessageBox.Show(size.ToString());
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
    }
}
