//Write a program to convert binary numbers to their
//decimal representation.

using System;

class BinaryToDecimal
{
    static void Main()
    {
        string binaryNumber = null;
        int decimalNumber = 0;

        Console.Write("Please, type the binary number to be converted (the result should be an integer number) and press Enter: ");
        binaryNumber = Console.ReadLine();

        if (binaryNumber[0] != '-')
        {
            for (int i = binaryNumber.Length - 1; i >= 0; i--)
            {
                decimalNumber = decimalNumber + ((int)(double.Parse(binaryNumber[i].ToString()) * Math.Pow(2.0, binaryNumber.Length - 1 - i)));
            }
            Console.WriteLine("The number after convertion is {0}.", decimalNumber);
        }
        else if (binaryNumber[0] == '-')
        {
            for (int i = binaryNumber.Length - 1; i >= 1; i--)
            {
                decimalNumber = decimalNumber + ((int)(double.Parse(binaryNumber[i].ToString()) * Math.Pow(2.0, binaryNumber.Length - 1 - i)));
            }
            Console.WriteLine("The number after convertion is -{0}.", decimalNumber);
        }
    }
}