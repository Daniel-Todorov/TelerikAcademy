//Write and expression that extracts froma  given integer i the value of  a given bit number b. Example: i=5; b=2 -> value=1.

using System;

class BitAtPositionExtrator
{
    static void Main()
    {
        int numberToCheck = 0;
        byte position = 0;
        int mask = 1;

        Console.WriteLine("Please, type the integer number for extraction and press Enter:");
        numberToCheck = int.Parse(Console.ReadLine());
        Console.WriteLine("Please, type the position of the bit you'd like to extract and press Enter:");
        position = byte.Parse(Console.ReadLine());

        mask = mask << position;
        mask = mask & numberToCheck;
        mask = mask >> position;

        Console.WriteLine("The bit at position {0} is {1}", position, mask);
    }
}
