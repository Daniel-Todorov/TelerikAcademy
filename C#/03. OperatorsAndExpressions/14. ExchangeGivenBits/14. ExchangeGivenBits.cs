//*Write a program that exchanges bits {p, p+1, ..., p+k-1} with bits {q, q+1, ..., q+k-1} of given 32-bit unsigned integer.

using System;

class ExchangeGivenBits
{
    static void Main()
    {
        uint integerNumber;
        uint transformedIntegerNumber;
        uint valueOfFirstBit = 1;
        uint valueOfSecondBit = 1;
        uint mask = 1;
        byte firstBits;
        byte secondBits;
        byte lengthOfSequences;

        Console.WriteLine("Please, type the integer number to be transformed and press Enter:");
        transformedIntegerNumber = integerNumber = uint.Parse(Console.ReadLine());
        Console.WriteLine("Please, type the start position P of the first sequence to be exchanged and press Enter:");
        firstBits = byte.Parse(Console.ReadLine());
        Console.WriteLine("Please, type the start position Q of the second sequence to be exchanged and press Enter:");
        secondBits = byte.Parse(Console.ReadLine());
        Console.WriteLine("Please, type the length of the sequences to be transformed and press Enter:");
        lengthOfSequences = byte.Parse(Console.ReadLine());


        for (byte i = 0; i < lengthOfSequences; i++)
        {
            valueOfFirstBit = valueOfFirstBit << (firstBits + i);
            valueOfFirstBit = valueOfFirstBit & integerNumber;
            valueOfFirstBit = valueOfFirstBit >> (firstBits + i);

            valueOfSecondBit = valueOfSecondBit << (secondBits + i);
            valueOfSecondBit = valueOfSecondBit & integerNumber;
            valueOfSecondBit = valueOfSecondBit >> (secondBits + i);

            if (valueOfFirstBit == 1)
            {
                mask = mask << (secondBits + i);
                transformedIntegerNumber = transformedIntegerNumber | mask;
            }
            else
            {
                mask = mask << (secondBits + i);
                mask = ~mask;
                transformedIntegerNumber = transformedIntegerNumber & mask;
            }

            mask = 1;

            if (valueOfSecondBit == 1)
            {
                mask = mask << (firstBits + i);
                transformedIntegerNumber = transformedIntegerNumber | mask;
            }
            else
            {
                mask = mask << (firstBits + i);
                mask = ~mask;
                transformedIntegerNumber = transformedIntegerNumber & mask;
            }

            mask = 1;
            valueOfFirstBit = 1;
            valueOfSecondBit = 1;
        }

        Console.WriteLine("The number after the exchange of bits is {0}", transformedIntegerNumber);
    }
}
