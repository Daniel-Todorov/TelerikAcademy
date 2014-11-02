//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class ExchangeBitValue
{
    static void Main()
    {
        uint integerNumber;
        uint valueOfFirstBit = 1;
        uint valueOfSecondBit = 1;
        uint mask = 1;
        byte firstBits = 3;
        byte secondBits = 24;

        Console.WriteLine("Please, type the integer number to be transformed and press Enter:");
        integerNumber = uint.Parse(Console.ReadLine());

        for (; firstBits < 6; firstBits++)
        {
            valueOfFirstBit = valueOfFirstBit << firstBits;
            valueOfFirstBit = valueOfFirstBit & integerNumber;
            valueOfFirstBit = valueOfFirstBit >> firstBits;

            valueOfSecondBit = valueOfSecondBit << secondBits;
            valueOfSecondBit = valueOfSecondBit & integerNumber;
            valueOfSecondBit = valueOfSecondBit >> secondBits;

            if (valueOfFirstBit == 1)
            {
                mask = mask << secondBits;
                integerNumber = integerNumber | mask;
            }
            else
            {
                mask = mask << secondBits;
                mask = ~mask;
                integerNumber = integerNumber & mask;
            }

            mask = 1;

            if (valueOfSecondBit == 1)
            {
                mask = mask << firstBits;
                integerNumber = integerNumber | mask;
            }
            else
            {
                mask = mask << firstBits;
                mask = ~mask;
                integerNumber = integerNumber & mask;
            }

            mask = 1;
            valueOfFirstBit = 1;
            valueOfSecondBit = 1;
            secondBits++;
        }

        Console.WriteLine("The number after the exchange of bits is {0}", integerNumber);
    }
}