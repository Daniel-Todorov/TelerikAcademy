//Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

using System;

class ThirdBitOfIntegerFinder
{
    static void Main()
    {
        int numberToCheck;
        int mask;

        Console.WriteLine("Please, type an integer number to be checked:");
        numberToCheck = int.Parse(Console.ReadLine());

        mask = 1;
        mask = mask << 3;

        numberToCheck = numberToCheck & mask;

        if (numberToCheck > 0)
        {
            Console.WriteLine("The third bit of the number IS 1!");
        }
        else {
            Console.WriteLine("The third bit of the number IS NOT 1!");
        }
    }
}
