//Write a program that reads a rectangular matrix of 
//size N x M and finds in it the square 3 x 3 that has 
//maximal sum of its elements.

using System;
using System.Collections.Generic;

class FindSquareWithMaxSum
{
    static void Main()
    {
        int N = 0;
        int M = 0;
        int[,] matrix;
        int maxSum = 0;
        int startRow = 0;
        int startCol = 0;
        int currentSum = 0;

        //Read N and M, inicializing the matrix and filling it with values.
        Console.Write("Please, type the number of rows N [N >= 3] in the matrix and press Enter: ");
        N = int.Parse(Console.ReadLine());
        Console.Write("Please, type the number of columns M [M >= 3] in the matrix and press Enter: ");
        M = int.Parse(Console.ReadLine());
        matrix = new int[N, M];
        for (int row = 0; row < N; row++)
        {
            for (int col = 0; col < M; col++)
            {
                Console.Write("matrix [{0},{1}] -> ", row, col);
                matrix[row, col] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
        }

        //The nested loops which actually do the job.
        //This is modified version of the demo from the presentation.
        for (int row = 0; row < N - 2; row++)
        {
            for (int col = 0; col < M - 2; col++)
            {
                for (int currentRow = row; currentRow < row + 3; currentRow++)
                {
                    for (int currentCol = col; currentCol < col + 3; currentCol++)
                    {
                        currentSum = currentSum + matrix[currentRow, currentCol];
                    }
                }

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    startRow = row;
                    startCol = col;
                }
                currentSum = 0;
            }
        }

        //Print the 3x3 part of the matrix
        for (int row = startRow; row < startRow + 3; row++)
        {
            for (int col = startCol; col < startCol + 3; col++)
            {
                Console.Write("{0,3} ", matrix[row,col]);
            }
            Console.WriteLine();
        }
    }
}
