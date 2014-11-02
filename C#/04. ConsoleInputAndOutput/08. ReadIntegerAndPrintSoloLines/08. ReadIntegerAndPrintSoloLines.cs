//Write a prgram that reads an integer number N from the console and prints all the numbers in the interval [1..n], each on a single line.

using System;

class ReadIntegerAndPrintSoloLines
{
    static void Main()
    {
        int integerNumber = 0;

        Console.WriteLine("Please, type the integer number N to set the interval of numbers to print and press Enter:");
        integerNumber = int.Parse(Console.ReadLine());

        for (int i = 1; i < integerNumber + 1; i++)
        {
            Console.WriteLine(i);
        }
    }
}
