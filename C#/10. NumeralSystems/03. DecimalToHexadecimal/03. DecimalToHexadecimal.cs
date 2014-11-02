//Write a program to convert decimal numbers to
//their hexadecimal representation.

using System;

class DecimalToHexadecimal
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

    static string ConvertLeftover(int leftOver)
    {
        string result = null;
        switch (leftOver)
        {
            case 0:
                result = result + "0";
                break;
            case 1:
                result = result + "1";
                break;
            case 2:
                result = result + "2";
                break;
            case 3:
                result = result + "3";
                break;
            case 4:
                result = result + "4";
                break;
            case 5:
                result = result + "5";
                break;
            case 6:
                result = result + "6";
                break;
            case 7:
                result = result + "7";
                break;
            case 8:
                result = result + "8";
                break;
            case 9:
                result = result + "9";
                break;
            case 10:
                result = result + "A";
                break;
            case 11:
                result = result + "B";
                break;
            case 12:
                result = result + "C";
                break;
            case 13:
                result = result + "D";
                break;
            case 14:
                result = result + "E";
                break;
            case 15:
                result = result + "F";
                break;
            default:
                break;
        }

        return result;
    }

    static void Main()
    {
        int decimalNumber = 0;
        int leftOver = 0;
        string sign = null;
        string hexadecimalRepresentation = null;

        Console.Write("Please, type an integer number to be converted to hexadecimal and press Enter: ");
        decimalNumber = int.Parse(Console.ReadLine());

        sign = ExtractSign(decimalNumber);
        decimalNumber = TurnToPositive(decimalNumber);

        while (decimalNumber != 0)
        {
            leftOver = decimalNumber % 16;
            decimalNumber = decimalNumber / 16;
            hexadecimalRepresentation = hexadecimalRepresentation + ConvertLeftover(leftOver);
        }

        Console.WriteLine("The hexidecimal representation of the integer number is: {0}{1}.", sign, ReverseString(hexadecimalRepresentation));
    }
}