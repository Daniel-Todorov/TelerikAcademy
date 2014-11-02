//Write a program that gets a number n and after that gets more numbers and calculates and prints their sum.

using System;

class ReadAndSumNumbers
{
    static void Main()
    {
        double numberN = 0.0;
        double sum = 0.0;
        ConsoleKeyInfo addNumberKey;

        do
        {
            Console.WriteLine("Please, type a number to add to the total sum and press Enter:");
            numberN = double.Parse(Console.ReadLine());
            sum = sum + numberN;
            Console.WriteLine("The total sum sofar is {0}. Press \"+\" if you want to add more numbers to the sum.", sum);

            addNumberKey = Console.ReadKey();
            Console.WriteLine(" ");
        }

        while (addNumberKey.Key == ConsoleKey.Add);
    }
}
