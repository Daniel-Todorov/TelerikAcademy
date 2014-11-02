//We are given a matrix of passable and non-passable 
//cells. Write a recursive program for finding all paths 
//between two cells in the matrix.

namespace _07.FindAllPathsBetweenCellsInMatrix
{
    using System;
    using System.Collections.Generic;

    public class PathsInLabyrinth
    {
        private static char[,] lab = 
            {
                {' ', ' ', ' ', '*', ' ', ' ', ' '},
                {'*', '*', ' ', '*', ' ', '*', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', '*', '*', '*', '*', '*', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' '},
            };

        private static List<Tuple<int, int>> path = new List<Tuple<int, int>>();

        private static bool InRange(int row, int col)
        {
            bool rowInRange = row >= 0 && row < lab.GetLength(0);
            bool colInRange = col >= 0 && col < lab.GetLength(1);
            return rowInRange && colInRange;
        }

        private static void FindPathToExit(int row, int col, int endRow, int endCol)
        {
            lab[endRow, endCol] = 'e';

            if (!InRange(row, col))
            {
                return;
            }

            if (lab[row, col] == 'e')
            {
                PrintPath(row, col);
            }

            if (lab[row, col] != ' ')
            {
                return;
            }

            lab[row, col] = 's';
            path.Add(new Tuple<int, int>(row, col));

            FindPathToExit(row, col - 1, endRow, endCol); // left
            FindPathToExit(row - 1, col, endRow, endCol); // up
            FindPathToExit(row, col + 1, endRow, endCol); // right
            FindPathToExit(row + 1, col, endRow, endCol); // down

            lab[row, col] = ' ';
            path.RemoveAt(path.Count - 1);
        }

        private static void PrintPath(int finalRow, int finalCol)
        {
            Console.Write("Found the exit: ");
            foreach (var cell in path)
            {
                Console.Write("({0},{1}) -> ", cell.Item1, cell.Item2);
            }
            Console.WriteLine("({0},{1})", finalRow, finalCol);
            Console.WriteLine();
        }

        static void Main()
        {
            FindPathToExit(0, 0, 4, 6);
        }
    }
}
