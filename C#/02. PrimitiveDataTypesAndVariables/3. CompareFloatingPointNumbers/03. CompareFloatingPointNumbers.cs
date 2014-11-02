//Write a program that safely compares foating-point numbers with precision of 0.000001. Example: (5.3; 6.01) -> false; (5.00000001; 5.00000003) -> true

using System;

class CompareFloatingPointNumbers
{
    static void Main()
    {
        Console.WriteLine("Please, write the FIRST real number for comparision and press Enter (the number should be in this format: 1,1)");
        decimal firstNumber = Math.Round(decimal.Parse(Console.ReadLine()), 6);
        Console.WriteLine(firstNumber);

        Console.WriteLine("Please, write the SECOND real number for comparision and press Enter (the number should be in this format: 1,1)");
        decimal secondNumber = Math.Round(decimal.Parse(Console.ReadLine()), 6);
        Console.WriteLine(secondNumber);

        if (firstNumber == secondNumber)
        {
            Console.WriteLine("It's TRUE! The numbers are equal with precision of 0.000001");
        }
        else
        {
            Console.WriteLine("Oh no! Those numbers are not equal at all");
        }

    }
}
