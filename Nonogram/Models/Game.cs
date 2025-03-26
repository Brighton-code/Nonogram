using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nonogram.Models
{
    public class Game
    {
        private int _gridSize;
        public int GridSize 
        {
            get => _gridSize;
            set
            {
                (Solution, Seed) = Grid.GenerateGrid(value);
                (RowHints, ColHints) = Grid.CountSumsHorizontal(Solution);
                _gridSize = value;
                Marked = new int[_gridSize, _gridSize];
            }
        }

        public int[,] Solution { get; private set; }
        public int[,] Marked { get; set; }
        public int Seed { get; private set; }

        private int[][] _rowHints;
        public int[][] RowHints 
        { 
            get => _rowHints;
            private set
            {
                _rowHints = value;
                for (int i = 0; i < _rowHints.Length; i++)
                    if (RowHintMax < _rowHints[i].Length)
                        RowHintMax = _rowHints[i].Length;
            }
        }
        public int RowHintMax { get; private set; }

        private int[][] _colHints;
        public int[][] ColHints 
        {
            get => _colHints;
            private set
            {
                _colHints = value;
                for (int i = 0; i < _colHints.Length; i++)
                    if (ColHintMax < _colHints[i].Length)
                        ColHintMax = _colHints[i].Length;
            }
        }
        public int ColHintMax { get; private set; }

        public int CellSize;
        public Padding CellPadding = new Padding(4);
        public Point GridStart;
        public int GridArea;

        public Game(int size)
        {
            GridSize = size;
        }
    }
}
