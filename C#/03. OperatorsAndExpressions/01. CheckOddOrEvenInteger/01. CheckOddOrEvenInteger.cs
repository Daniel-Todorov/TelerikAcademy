//Write and expression that checks if given integer is odd or even.

using System;

class OddOrEvenIntegerChecker
{
    static void Main()
    {
        int numberToCheck;

        Console.WriteLine("Please, wirte down an integer number to check and press Enter:");
        numberToCheck = int.Parse(Console.ReadLine());

        if (numberToCheck % 2 == 0)
        {
            Console.WriteLine("The integer number is EVEN!");
        }
        else
        {
            Console.WriteLine("The integer number is ODD!");
        }
    }
}
