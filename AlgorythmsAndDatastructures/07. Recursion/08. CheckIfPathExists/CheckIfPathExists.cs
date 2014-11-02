//Modify the above program to check whether a path 
//exists between two cells without finding all possible 
//paths. Test it over an empty 100 x 100 matrix.

namespace _08.CheckIfPathExists
{
    using System;
    using System.Collections.Generic;

    public class PathsInLabyrinth
    {
        private static char[,] lab;

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
                TerminateProgramWithSuccess();
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

        private static void TerminateProgramWithSuccess()
        {
            Console.Write("Path found!");
            Console.WriteLine();
            Environment.Exit(100);
        }

        static void Main()
        {
            int size = 100;
            lab = new char[size, size];

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    lab[row, col] = ' ';
                }
            }

            FindPathToExit(0, 0, 99, 99);

            Console.WriteLine("No path found");
        }
    }
}
