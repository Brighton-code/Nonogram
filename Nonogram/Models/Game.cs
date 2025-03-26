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
            }
        }

        public int[,] Solution { get; private set; }
        public int Seed { get; private set; }

        public int[][] RowHints { get; private set; }
        public int[][] ColHints { get; private set; }

        public int _cellSize;

        public Game(int size)
        {
            GridSize = size;
        }
    }
}
