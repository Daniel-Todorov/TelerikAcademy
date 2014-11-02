//Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number V has value of 1. Example: v=5; p=1 -> false

using System;

class CheckIfBitIsOne
{
    static void Main()
    {
        int integerNumber;
        byte position;
        int mask = 1;

        Console.WriteLine("Please, type the integer to be checked:");
        integerNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Please, type the bit's position to check:");
        position = byte.Parse(Console.ReadLine());

        mask = mask << position;
        mask = integerNumber & mask;
        mask = mask >> position;

        if (mask == 1)
        {
            Console.WriteLine("The bit at position {0} IS 1!", position);
        }
        else {
            Console.WriteLine("The bit at position {0} is NOT 1!", position);
        }
    }
}
