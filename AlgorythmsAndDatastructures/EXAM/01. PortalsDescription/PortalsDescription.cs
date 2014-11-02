

namespace _01.PortalsDescription
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class PortalsDescription
    {
        private static int maxValue = int.MinValue;
        static void Main()
        {
            var startingPointCoords = Console.ReadLine().Split(' ').Select(item => int.Parse(item)).ToArray();
            //int[] startingPointCoords = {0, 0};

            var dimentionsOfMatrix = Console.ReadLine().Split(' ').Select(item => int.Parse(item)).ToArray();
            var matrix = new Cell[dimentionsOfMatrix[0], dimentionsOfMatrix[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var line = Console.ReadLine().Split(' ');

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = new Cell() { Row = row, Col = col, Value = line[col] };
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col].Children = GetChildren(matrix, matrix[row, col]);
                }
            }

            var startingPoint = matrix[startingPointCoords[0], startingPointCoords[1]];

            DFS(startingPoint, 0);

            Console.WriteLine(maxValue);
        }

        private static List<Cell> GetChildren(Cell[,] matrix, Cell startingCell)
        {
            var children = new List<Cell>();

            if (startingCell.Value == "#")
            {
                return children;
            }

            if (startingCell.Row - int.Parse(startingCell.Value) >= 0 && matrix[startingCell.Row - int.Parse(startingCell.Value), startingCell.Col].Value != "#")
            {
                children.Add(matrix[startingCell.Row - int.Parse(startingCell.Value), startingCell.Col]);
            }
            if (startingCell.Row + int.Parse(startingCell.Value) < matrix.GetLength(0) && matrix[startingCell.Row + int.Parse(startingCell.Value), startingCell.Col].Value != "#")
            {
                children.Add(matrix[startingCell.Row + int.Parse(startingCell.Value), startingCell.Col]);
            }
            if (startingCell.Col - int.Parse(startingCell.Value) >= 0 && matrix[startingCell.Row, startingCell.Col - int.Parse(startingCell.Value)].Value != "#")
            {
                children.Add(matrix[startingCell.Row, startingCell.Col - int.Parse(startingCell.Value)]);
            }
            if (startingCell.Col + int.Parse(startingCell.Value) < matrix.GetLength(1) && matrix[startingCell.Row, startingCell.Col + int.Parse(startingCell.Value)].Value != "#")
            {
                children.Add(matrix[startingCell.Row, startingCell.Col + int.Parse(startingCell.Value)]);
            }

            return children;
        }

        private static void DFS(Cell cell, int totalResult)
        {
            if (cell.Children.Count == 0 || cell.Value == "#")
            {
                if (totalResult > maxValue)
                {
                    maxValue = totalResult;
                }

                return;
            }

            totalResult += int.Parse(cell.Value);

            foreach (var child in cell.Children)
            {
                var originalValue = cell.Value;
                cell.Value = "#";
                DFS(child, totalResult);
                cell.Value = originalValue;
            }
        }

        private static Cell BuildTree(Cell[,] matrix, Cell startingCell)
        {
            if (startingCell.Row - int.Parse(startingCell.Value) >= 0 && matrix[startingCell.Row - int.Parse(startingCell.Value), startingCell.Col].Value != "#")
            {
                startingCell.Children.Add(matrix[startingCell.Row - int.Parse(startingCell.Value), startingCell.Col]);
            }
            if (startingCell.Row + int.Parse(startingCell.Value) < matrix.GetLength(0) && matrix[startingCell.Row + int.Parse(startingCell.Value), startingCell.Col].Value != "#")
            {
                startingCell.Children.Add(matrix[startingCell.Row + int.Parse(startingCell.Value), startingCell.Col]);
            }
            if (startingCell.Col - int.Parse(startingCell.Value) >= 0 && matrix[startingCell.Row, startingCell.Col - int.Parse(startingCell.Value)].Value != "#")
            {
                startingCell.Children.Add(matrix[startingCell.Row, startingCell.Col - int.Parse(startingCell.Value)]);
            }
            if (startingCell.Col + int.Parse(startingCell.Value) < matrix.GetLength(1) && matrix[startingCell.Row, startingCell.Col + int.Parse(startingCell.Value)].Value != "#")
            {
                startingCell.Children.Add(matrix[startingCell.Row, startingCell.Col + int.Parse(startingCell.Value)]);
            }

            foreach (var child in startingCell.Children)
            {
                string originalValue = startingCell.Value;
                startingCell.Value = "#";
                BuildTree(matrix, child);
                startingCell.Value = originalValue;
            }

            return startingCell;
        }
    }

    class Cell
    {
        public Cell()
        {
            this.Children = new List<Cell>();
        }

        public int Row { get; set; }

        public int Col { get; set; }

        public string Value { get; set; }

        public List<Cell> Children { get; set; }
    }
}
