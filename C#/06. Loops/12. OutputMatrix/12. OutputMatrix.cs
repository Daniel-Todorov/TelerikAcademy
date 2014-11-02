//Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix like the following:
//N = 3             N = 4
//1 2 3             1 2 3 4
//2 3 4             2 3 4 5
//3 4 5             3 4 5 6
//                  4 5 6 7

using System;

class OutputMatrix
{
    static void Main()
    {
        int N = 0;
        int columnCounter = 0;
        int rowCounter = 1;

        Console.Write("Please, write a positive integer number N and press Enter: ");
        N = int.Parse(Console.ReadLine());

        for (; columnCounter < N; columnCounter++)
        {
            rowCounter = columnCounter + 1;
            for (; rowCounter <= N + columnCounter; rowCounter++)
            {
                Console.Write("{0} ", rowCounter);
            }
            Console.WriteLine("");
        }
    }
}
