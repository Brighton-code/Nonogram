using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nonogram.Models
{
    public class GameSettings
    {
        public int gridSize;
        public int seed;
        public bool isTimerEnabled;


        public GameSettings(int a, int b, bool c) 
        {
            gridSize = a;
            seed = b;
            isTimerEnabled = c;
        }
    }
}
