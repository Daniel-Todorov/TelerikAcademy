// Refactor and improve the naming in the C# source project “3. Naming-Identifiers-Homework.zip”. 
// You are allowed to make other improvements in the code as well (not only naming) as well as to fix bugs.

// NOTE!!! I couldn't really find bugs :(

namespace MineSweeper
{
    using System;
    using System.Collections.Generic;
    using Minesweeper;

    public class MineSweeper
    {
        public static void Main()
        {
            string playerCommand = string.Empty;
            char[,] mineField = GenerateMineField();
            char[,] mines = PositionMines();
            int counter = 0;
            bool hasSteppedOnMine = false;
            List<Player> topPlayers = new List<Player>(6);
            int row = 0;
            int column = 0;
            bool isNewGameStarting = true;
            const int MAX_NUMBER_OF_CELLS = 35;
            bool hasWon = false;

            do
            {
                if (isNewGameStarting)
                {
                    Console.WriteLine("Let's play “Mines”. Try your luck to find all the fields without mines.");
                    Console.WriteLine("The command 'top' shows the leaderboard, 'restart' begins a new game, 'exit' quits the game!");
                    PrintMineField(mineField);
                    isNewGameStarting = false;
                }

                Console.Write("Type a row followed by a space and then column : ");
                playerCommand = Console.ReadLine().Trim();
                if (playerCommand.Length >= 3)
                {
                    if (int.TryParse(playerCommand[0].ToString(), out row) &&
                        int.TryParse(playerCommand[2].ToString(), out column) &&
                        row <= mineField.GetLength(0) && column <= mineField.GetLength(1))
                    {
                        playerCommand = "turn";
                    }
                }

                switch (playerCommand)
                {
                    case "top":
                        PrintLeaderboard(topPlayers);
                        break;
                    case "restart":
                        mineField = GenerateMineField();
                        mines = PositionMines();
                        PrintMineField(mineField);
                        hasSteppedOnMine = false;
                        isNewGameStarting = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye, bye, bye!");
                        break;
                    case "turn":
                        if (mines[row, column] != '*')
                        {
                            if (mines[row, column] == '-')
                            {
                                MakeTurn(mineField, mines, row, column);
                                counter++;
                            }

                            if (MAX_NUMBER_OF_CELLS == counter)
                            {
                                hasWon = true;
                            }
                            else
                            {
                                PrintMineField(mineField);
                            }
                        }
                        else
                        {
                            hasSteppedOnMine = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nError! Invalid command\n");
                        break;
                }

                if (hasSteppedOnMine)
                {
                    PrintMineField(mines);
                    Console.Write("\nArghhhh! You had a heroic death with {0} points. \nType your nickname for the leaderboard: ", counter);
                    string nickName = Console.ReadLine();
                    Player currentPlayer = new Player(nickName, counter);
                    if (topPlayers.Count < 5)
                    {
                        topPlayers.Add(currentPlayer);
                    }
                    else
                    {
                        for (int i = 0; i < topPlayers.Count; i++)
                        {
                            if (topPlayers[i].Scores < currentPlayer.Scores)
                            {
                                topPlayers.Insert(i, currentPlayer);
                                topPlayers.RemoveAt(topPlayers.Count - 1);
                                break;
                            }
                        }
                    }

                    topPlayers.Sort((Player r1, Player r2) => r2.Name.CompareTo(r1.Name));
                    topPlayers.Sort((Player r1, Player r2) => r2.Scores.CompareTo(r1.Scores));
                    PrintLeaderboard(topPlayers);

                    mineField = GenerateMineField();
                    mines = PositionMines();
                    counter = 0;
                    hasSteppedOnMine = false;
                    isNewGameStarting = true;
                }

                if (hasWon)
                {
                    Console.WriteLine("\nBRAVOOO! You cleared 35 cells without a single drop of blood.");
                    PrintMineField(mines);
                    Console.WriteLine("Type your name for the leaderboard, champion : ");
                    string nickName = Console.ReadLine();
                    Player currentPlayer = new Player(nickName, counter);
                    topPlayers.Add(currentPlayer);
                    PrintLeaderboard(topPlayers);
                    mineField = GenerateMineField();
                    mines = PositionMines();
                    counter = 0;
                    hasWon = false;
                    isNewGameStarting = true;
                }
            }
            while (playerCommand != "exit");
            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("See you again soon.");
            Console.Read();
        }

        private static void PrintLeaderboard(List<Player> topPleayers)
        {
            Console.WriteLine("\nScores:");
            if (topPleayers.Count > 0)
            {
                for (int i = 0; i < topPleayers.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} scores", i + 1, topPleayers[i].Name, topPleayers[i].Scores);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty Leaderboard!\n");
            }
        }

        private static void MakeTurn(
            char[,] cells, char[,] mines, int row, int column)
        {
            char numberOfMines = CalculateNumberOfAjustantMines(mines, row, column);
            mines[row, column] = numberOfMines;
            cells[row, column] = numberOfMines;
        }

        private static void PrintMineField(char[,] field)
        {
            int rows = field.GetLength(0);
            int columns = field.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(string.Format("{0} ", field[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] GenerateMineField()
        {
            int fieldRows = 5;
            int fieldColumns = 10;
            char[,] field = new char[fieldRows, fieldColumns];
            for (int i = 0; i < fieldRows; i++)
            {
                for (int j = 0; j < fieldColumns; j++)
                {
                    field[i, j] = '?';
                }
            }

            return field;
        }

        private static char[,] PositionMines()
        {
            int rows = 5;
            int columns = 10;
            char[,] mineField = new char[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    mineField[i, j] = '-';
                }
            }

            List<int> minePositions = new List<int>();
            while (minePositions.Count < 15)
            {
                Random random = new Random();
                int nextRandom = random.Next(50);
                if (!minePositions.Contains(nextRandom))
                {
                    minePositions.Add(nextRandom);
                }
            }

            foreach (int position in minePositions)
            {
                int col = position / columns;
                int row = position % columns;
                if (row == 0 && position != 0)
                {
                    col--;
                    row = columns;
                }
                else
                {
                    row++;
                }

                mineField[col, row - 1] = '*';
            }

            return mineField;
        }

        private static void GetNumberOfAjustantMines(char[,] mineField)
        {
            int col = mineField.GetLength(0);
            int row = mineField.GetLength(1);

            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (mineField[i, j] != '*')
                    {
                        char numberOfAdjustantMines = CalculateNumberOfAjustantMines(mineField, i, j);
                        mineField[i, j] = numberOfAdjustantMines;
                    }
                }
            }
        }

        private static char CalculateNumberOfAjustantMines(char[,] mineField, int row, int col)
        {
            int number = 0;
            int rows = mineField.GetLength(0);
            int cols = mineField.GetLength(1);

            if (row - 1 >= 0)
            {
                if (mineField[row - 1, col] == '*')
                {
                    number++;
                }
            }

            if (row + 1 < rows)
            {
                if (mineField[row + 1, col] == '*')
                {
                    number++;
                }
            }

            if (col - 1 >= 0)
            {
                if (mineField[row, col - 1] == '*')
                {
                    number++;
                }
            }

            if (col + 1 < cols)
            {
                if (mineField[row, col + 1] == '*')
                {
                    number++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (mineField[row - 1, col - 1] == '*')
                {
                    number++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (mineField[row - 1, col + 1] == '*')
                {
                    number++;
                }
            }

            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (mineField[row + 1, col - 1] == '*')
                {
                    number++;
                }
            }

            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (mineField[row + 1, col + 1] == '*')
                {
                    number++;
                }
            }

            return char.Parse(number.ToString());
        }
    }
}
