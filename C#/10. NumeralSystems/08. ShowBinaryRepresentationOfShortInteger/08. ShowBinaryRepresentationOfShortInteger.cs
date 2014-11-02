//Write a program that shows the binary
//representation of given 16-bit signed integer
//number (the C# type short).

using System;

class ShowBinaryRepresentationOfShortInteger
{
    static string ReverseString(string initialString)
    {
        string reversedString = null;

        for (int i = initialString.Length - 1; i >= 0; i--)
        {
            reversedString = reversedString + initialString[i];
        }

        return reversedString;
    }

    static string ConvertToBinary(int decimalNumber)
    {
        int leftOver = 0;
        string binaryRepresentation = null;

        while (decimalNumber != 0)
        {
            leftOver = decimalNumber % 2;
            decimalNumber = decimalNumber / 2;
            binaryRepresentation = binaryRepresentation + leftOver;
        }

        if (String.IsNullOrEmpty(binaryRepresentation))
        {
            binaryRepresentation = "0";
        }

        return ReverseString(binaryRepresentation);
    }

    static void Main()
    {
        int shortInteger = 0;
        int subtractionPart = 0;
        string binaryRepresentation = "0";

        Console.Write("Please, type a 16-bit signed integer and press Enter: ");
        shortInteger = int.Parse(Console.ReadLine());

        if (shortInteger >= 0)
        {
            subtractionPart = shortInteger;
        }
        else if (shortInteger < 0)
        {
            subtractionPart = 128 + shortInteger;
        }

        binaryRepresentation = ConvertToBinary(subtractionPart);
        for (int i = binaryRepresentation.Length; i < 7; i++)
        {
            binaryRepresentation = "0" + binaryRepresentation;
        }

        if (shortInteger >= 0)
        {
            binaryRepresentation = "0" + binaryRepresentation;
        }
        else if (shortInteger < 0)
        {
            binaryRepresentation = "1" + binaryRepresentation;
        }

        Console.WriteLine(binaryRepresentation);
    }
}
