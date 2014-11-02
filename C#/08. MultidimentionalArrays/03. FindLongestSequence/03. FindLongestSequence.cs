//We are given a matrix of strings of size N x M. 
//Sequences in the matrix we define as sets of 
//several neighbor elements located on the same 
//line, column or diagonal. Write a program that finds 
//the longest sequence of equal strings in the matrix.

using System;
using System.Collections.Generic;

class FindLongestSequence
{
    static void Main()
    {
        int N = 0;
        int M = 0;
        string[,] matrix;
        int startingRow = 0;
        int startingCol = 0;
        int counter = 1;
        int maxCounter = 0;

        Console.Write("Please, type how many rows N the matrixs should have and press Enter: ");
        N = int.Parse(Console.ReadLine());
        Console.Write("Please, type how many columns M the matrix should have and press Enter: ");
        Console.WriteLine();
        M = int.Parse(Console.ReadLine());
        matrix = new string[N, M];
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("Position {0}, {1}: ", rows, col);
                matrix[rows, col] = Console.ReadLine();
            }
        }

        //We check for max sequence in every line.
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 1; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col].Equals(matrix[row, col - 1]))
                {
                    counter++;
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        startingRow = row;
                        startingCol = col;
                    }
                    else
                    {
                        counter = 1;
                    }
                }
            }
        }

        //We check for max sequence in every column.
        counter = 1;
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 1; row < matrix.GetLength(0); row++)
            {
                if (matrix[row, col].Equals(matrix[row - 1, col]))
                {
                    counter++;
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        startingRow = row;
                        startingCol = col;
                    }
                }
                else
                {
                    counter = 1;
                }
            }
        }

        //In the next 4 nester loops we check each of the diagonals.
        counter = 1;
        for (int row = 0, col = 0; row < matrix.GetLength(0); row++)
        {
            for (int i = 1; row + i < matrix.GetLength(0) && col + i < matrix.GetLength(1); i++)
            {
                if (matrix[row + i, col + i].Equals(matrix[row + i - 1, col + i - 1]))
                {
                    counter++;
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        startingRow = row + i;
                        startingCol = col + i;
                    }
                }
                else
                {
                    counter = 1;
                }
            }
        }

        counter = 1;
        for (int row = 0, col = 0; col < matrix.GetLength(1); col++)
        {
            for (int i = 1; row + i < matrix.GetLength(0) && col + i < matrix.GetLength(1); i++)
            {
                if (matrix[row + i, col + i].Equals(matrix[row + i - 1, col + i - 1]))
                {
                    counter++;
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        startingRow = row + i;
                        startingCol = col + i;
                    }
                }
                else
                {
                    counter = 1;
                }
            }
        }

        counter = 1;
        for (int row = 0, col = 0; row < matrix.GetLength(0); row++)
        {
            for (int i = 1; row - i >= 0 && col + i < matrix.GetLength(1); i++)
            {
                if (matrix[row - i + 1, col + i - 1].Equals(matrix[row - i, col + i]))
                {
                    counter++;
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        startingRow = row - i;
                        startingCol = col + i;
                    }
                }
                else
                {
                    counter = 1;
                }
            }
        }

        counter = 1;
        for (int row = matrix.GetLength(0) - 1, col = 0; col < matrix.GetLength(0); col++)
        {
            for (int i = 1; row - i >= 0 && col + i < matrix.GetLength(1); i++)
            {
                if (matrix[row - i + 1, col + i - 1].Equals(matrix[row - i, col + i]))
                {
                    counter++;
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        startingRow = row - i;
                        startingCol = col + i;
                    }
                }
                else
                {
                    counter = 1;
                }
            }
        }

        //Printing the result.
        Console.WriteLine();
        for (int a = 0; a < maxCounter; a++)
        {
            Console.Write("{0} ", matrix[startingRow, startingCol]);
        }
        Console.WriteLine();
    }
}
