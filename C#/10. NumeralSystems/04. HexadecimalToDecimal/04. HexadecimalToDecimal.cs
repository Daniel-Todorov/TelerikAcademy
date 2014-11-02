//Write a program to convert hexadecimal numbers
//to their decimal representation.

using System;

class BinaryToDecimal
{
    static double GetHexaNumber(char sign)
    {
        double result = 0.0;

        switch (sign)
        {
            case '0':
                result = 0.0;
                break;
            case '1':
                result = 1.0;
                break;
            case '2':
                result = 2.0;
                break;
            case '3':
                result = 3.0;
                break;
            case '4':
                result = 4.0;
                break;
            case '5':
                result = 5.0;
                break;
            case '6':
                result = 6.0;
                break;
            case '7':
                result = 7.0;
                break;
            case '8':
                result = 8.0;
                break;
            case '9':
                result = 9.0;
                break;
            case 'A':
                result = 10.0;
                break;
            case 'B':
                result = 11.0;
                break;
            case 'C':
                result = 12.0;
                break;
            case 'D':
                result = 13.0;
                break;
            case 'E':
                result = 14.0;
                break;
            case 'F':
                result = 15.0;
                break;
            default:
                break;
        }

        return result;
    }

    static void Main()
    {
        string hexadecimalNumber = null;
        int decimalNumber = 0;

        Console.Write("Please, type the hexadecimal number to be converted (the result should be an integer number) and press Enter: ");
        hexadecimalNumber = Console.ReadLine();

        if (hexadecimalNumber[0] != '-')
        {
            for (int i = hexadecimalNumber.Length - 1; i >= 0; i--)
            {
                decimalNumber = decimalNumber + ((int)(GetHexaNumber(hexadecimalNumber[i]) * Math.Pow(16.0, hexadecimalNumber.Length - 1 - i)));
            }
            Console.WriteLine("The number after convertion is {0}.", decimalNumber);
        }
        else if (hexadecimalNumber[0] == '-')
        {
            for (int i = hexadecimalNumber.Length - 1; i >= 1; i--)
            {
                decimalNumber = decimalNumber + ((int)(GetHexaNumber(hexadecimalNumber[i]) * Math.Pow(16.0, hexadecimalNumber.Length - 1 - i)));
            }
            Console.WriteLine("The number after convertion is -{0}.", decimalNumber);
        }
    }
}