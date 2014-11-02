//Write a program to convert decimal numbers to
//their binary representation.

using System;

class DecimalToBinary
{
    static string ReverseString(string initialString)
    {
        string reversedString = null;

        for (int i = initialString.Length - 1; i >=0; i--)
        {
            reversedString = reversedString + initialString[i];
        }

        return reversedString;
    }

    static string ExtractSign(int number)
    {
        string sign = null;

        if (number < 0)
        {
            sign = "-";
        }

        return sign;
    }

    static int TurnToPositive(int number)
    {
        if (number < 0)
        {
            number = number * (-1);
        }

        return number;
    }

    static void Main()
    {
        int decimalNumber = 0;
        int leftOver = 0;
        string sign = null;
        string binaryRepresentation = null;

        Console.Write("Please, type an integer number to be converted to binary and press Enter: ");
        decimalNumber = int.Parse(Console.ReadLine());

        sign = ExtractSign(decimalNumber);
        decimalNumber = TurnToPositive(decimalNumber);

        while (decimalNumber != 0)
        {
            leftOver = decimalNumber % 2;
            decimalNumber = decimalNumber / 2;
            binaryRepresentation = binaryRepresentation + leftOver;
        }

        Console.WriteLine("The binary representation of the integer number is: {0}{1}.", sign, ReverseString(binaryRepresentation));
    }
}
