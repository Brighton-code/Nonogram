﻿using System;
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
            if (e.X < _game.GridStart.X || e.X - _game.GridStart.X > _game.GridStart.X + (_game.CellSize * _game.GridSize))
                return;
            if (e.Y < _game.GridStart.Y || e.Y - _game.GridStart.Y > _game.GridStart.Y + (_game.CellSize * _game.GridSize))
                return;

            int col = (int)Math.Floor(((float)e.X - _game.GridStart.X) / _game.CellSize);
            int row = (int)Math.Floor(((float)e.Y - _game.GridStart.Y) / _game.CellSize);

            MessageBox.Show($"{col}, {row}");


            if (_game.Marked[row, col] == 0) _game.Marked[row, col] = 1;
            else _game.Marked[row, col] = 0;


            pnlGame.Invalidate();
        }

        private void PnlGame_Paint(object? sender, PaintEventArgs e)
        {
            if (_game == null) return;

            //pnlGame.SuspendLayout();

            Graphics g = e.Graphics;

            _game.CellSize = Math.Min(pnlGame.ClientSize.Width, pnlGame.ClientSize.Height) / (_game.GridSize + Math.Max(_game.RowHintMax, _game.ColHintMax));
            _game.GridStart = new Point(_game.CellSize * _game.RowHintMax, _game.CellSize * _game.ColHintMax);
            _game.GridArea = _game.CellSize * _game.GridSize;

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
            for (int row = 0; row < _game.Solution.GetLength(0); row++)
                for (int col = 0; col < _game.Solution.GetLength(1); col++)
                    if (_game.Solution[row, col] == 1)
                        g.FillRectangle(Brushes.Red, _game.GridStart.X + (col * _game.CellSize + _game.CellPadding.Left), _game.GridStart.Y + (row * _game.CellSize + _game.CellPadding.Top), _game.CellSize - _game.CellPadding.Left - _game.CellPadding.Right, _game.CellSize - _game.CellPadding.Bottom - _game.CellPadding.Top);
            // End Debug
#endif

            for (int row = 0; row < _game.Marked.GetLength(0); row++)
            {
                for (int col = 0; col < _game.Marked.GetLength(1); col++)
                {
                    if (_game.Marked[row, col] == 1)
                        g.FillRectangle(Brushes.Black, _game.GridStart.X + (col * _game.CellSize + _game.CellPadding.Left), _game.GridStart.Y + (row * _game.CellSize + _game.CellPadding.Top), _game.CellSize - _game.CellPadding.Left - _game.CellPadding.Right, _game.CellSize - _game.CellPadding.Bottom - _game.CellPadding.Top);
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
