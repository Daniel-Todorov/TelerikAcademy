//Write a program that reads a text file containing a
//square matrix of numbers and finds in the matrix 
//an area of size 2 x 2 with a maximal sum of its 
//elements. The first line in the input file contains the 
//size of matrix N. Each of the next N lines contain 
//N numbers separated by space. The output 
//should be a single number in a separate text file.

using System;
using System.IO;

class FindMaxtrixInTextFile
{
    static void Main()
    {
        string matrixFile = "matrix.txt";
        string resultFile = "result.txt";
        int N = 0;
        int maxSum = 0;
        int currentSum = 0;
        int[,] matrix;
        string line = null;
        string[] numbers;

        try
        {
            StreamReader reader = new StreamReader(matrixFile);
            StreamWriter writer = new StreamWriter(resultFile);

            using (reader)
            {
                N = int.Parse(reader.ReadLine());
                matrix = new int[N, N];
                numbers = new string[N];

                for (int row = 0; row < N; row++)
                {
                    line = reader.ReadLine();
                    numbers = line.Split(' ');
                    for (int col = 0; col < N; col++)
                    {
                        matrix[row, col] = int.Parse(numbers[col]);
                    }
                }

                for (int row = 0; row < N - 1; row++)
                {
                    for (int col = 0; col < N - 1; col++)
                    {
                        currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                        if (currentSum > maxSum)
                        {
                            maxSum = currentSum;
                        }
                    }
                }
                using (writer)
                {
                    writer.WriteLine("{0}", maxSum);
                }
            }
        }
        catch (IOException a)
        {
            Console.WriteLine("An error occured while reading or writing the files. {0}", a.Message);
        }

        Console.WriteLine("It is done. Check the default folder!");
    }
}