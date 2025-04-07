using System.Text;
using System.Text.Json;

namespace Nonogram.Models
{
    public enum Marked
    {
        None = 0,
        Done = 1,
        Wrong = 2
    }

    public class Game
    {
        public int GridSize { get; private set; }
        public int[,] Solution { get; private set; }
        public Marked[,] GameState { get; set; }
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
        public bool Complete { get; private set; }
        public CustomStopwatch Stopwatch { get; private set; }

        public Game(int size)
        {
            GridSize = size;
            (Solution, Seed) = Grid.GenerateGrid(GridSize);
            (RowHints, ColHints) = Grid.CountSumsHorizontal(Solution);
            GameState = new Marked[GridSize, GridSize];
            Stopwatch = new CustomStopwatch();
        }

        public Game(int size, int seed)
        {
            GridSize = size;
            (Solution, Seed) = Grid.GenerateGrid(GridSize, seed);
            (RowHints, ColHints) = Grid.CountSumsHorizontal(Solution);
            GameState = new Marked[GridSize, GridSize];
            Stopwatch = new CustomStopwatch();
        }

        public void ValidateGame()
        {
            int[,] tmp = new int[GridSize, GridSize];
            for (int row = 0; row < GameState.GetLength(0); row++)
                for (int col = 0; col < GameState.GetLength(1); col++)
                    if (GameState[row, col] == Models.Marked.Done)
                        tmp[row, col] = 1;

            (int[][] hor, int[][] ver) = Grid.CountSumsHorizontal(tmp);

            if (AreJaggedArraysEqual(_rowHints, hor) && AreJaggedArraysEqual(_colHints, ver))
                Complete = true;
            else Complete = false;
        }

        public string EncodeMarked()
        {
            string jsonString = JsonSerializer.Serialize(Flatten(GameState));
            return jsonString;
        }

        static bool AreJaggedArraysEqual(int[][] array1, int[][] array2)
        {
            // Check if both arrays are null or not
            if (array1 == null || array2 == null)
                return array1 == array2;

            // Check if the outer arrays have the same length
            if (array1.Length != array2.Length)
                return false;

            // Check if each inner array has the same length and same content
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] == null || array2[i] == null)
                    return array1[i] == array2[i]; // both must be null

                if (array1[i].Length != array2[i].Length)
                    return false;

                for (int j = 0; j < array1[i].Length; j++)
                {
                    if (array1[i][j] != array2[i][j])
                        return false;
                }
            }

            return true;
        }

        public static T[] Flatten<T>(T[,] arr)
        {
            return [.. arr.Cast<T>()];
            // The code above is a shortened version of the code below.
            //T[] result = new T[arr.Length];
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        result[i * arr.GetLength(1) + j] = arr[i, j];
            //    }
            //}
            //return result;
        }

        public static byte[] SerializeArray<T>(T arr)
        {
            string jsonString = JsonSerializer.Serialize(arr);

            return Encoding.UTF8.GetBytes(jsonString);
        }

        public void ConvertGameStateTo2Darray(string savedGameState)
        {
            Marked[] gameState;

            try
            {
                gameState = JsonSerializer.Deserialize<Marked[]>(savedGameState);
            }
            catch { return; } // If you arrive here you corrupted the gameState file. You cheated ;)

            if(gameState.Length != GridSize * GridSize) return;

            int enumLength = Enum.GetValues(typeof(Marked)).Length;

            for (int i = 0; i < GridSize; i++)
            {
                for (int j = 0; j < GridSize; j++)
                {
                    GameState[i, j] = Enum.IsDefined(typeof(Marked), gameState[i * GridSize + j]) ? (Marked)gameState[i * GridSize + j] : 0;
                }
            }
        }

        public List<Point> GetPossibleHints()
        {
            List<Point> hints = new List<Point>();

            for (int i = 0; i < GridSize; i++)
            {
                for (int j = 0; j < GridSize; j++)
                {
                    //Skip if user used X to mark a tile that is empty in the solution
                    if (GameState[i, j] == Marked.Wrong && (Marked)Solution[i, j] == Marked.None)
                        continue;

                    if (GameState[i,j] != (Marked)Solution[i,j])
                        hints.Add(new Point(i, j));
                }
            }

            return hints;
        }
    }
}
