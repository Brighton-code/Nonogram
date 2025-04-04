using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Nonogram.Models
{
    public class Game
    {
        public int GridSize { get; private set; }
        public int[,] Solution { get; private set; }
        public Marked[,] Marked { get; set; }
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

        public Game(int size)
        {
            GridSize = size;
            (Solution, Seed) = Grid.GenerateGrid(GridSize);
            (RowHints, ColHints) = Grid.CountSumsHorizontal(Solution);
            Marked = new Marked[GridSize, GridSize];
        }

        public Game(int size, int seed)
        {
            GridSize = size;
            (Solution, Seed) = Grid.GenerateGrid(GridSize, seed);
            (RowHints, ColHints) = Grid.CountSumsHorizontal(Solution);
            Marked = new Marked[GridSize, GridSize];
        }

        public void ValidateGame()
        {
            int[,] tmp = new int[GridSize, GridSize];
            for (int row = 0; row < Marked.GetLength(0); row++)
                for (int col = 0; col < Marked.GetLength(1); col++)
                    if (Marked[row, col] == Models.Marked.Done)
                        tmp[row, col] = 1;

            (int[][] hor, int[][] ver) = Grid.CountSumsHorizontal(tmp);

            if (AreJaggedArraysEqual(_rowHints, hor) && AreJaggedArraysEqual(_colHints, ver))
                Complete = true;
            else Complete = false;
        }

        public string EncodeMarked()
        {
            string jsonString = JsonSerializer.Serialize(Flatten(Marked));
            return jsonString;
            //return Base64EncodeArr(Flatten(Marked));
        }

        static string Base64EncodeArr<T>(T arr)
        {
            byte[] byteArr = SerializeArray(arr);
            return Convert.ToBase64String(byteArr);
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
            T[] result = new T[arr.Length];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    result[i * arr.GetLength(1) + j] = arr[i, j];
                }
            }
            return result;
        }

        public static byte[] SerializeArray<T>(T arr)
        {
            string jsonString = JsonSerializer.Serialize(arr);

            return Encoding.UTF8.GetBytes(jsonString);
        }
    }

    public enum Marked
    {
        None,
        Done,
        Wrong
    }
}
