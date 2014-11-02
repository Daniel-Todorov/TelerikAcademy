//Write a program to convert from any numeral
//system of given base s to any other numeral 
//system of base d (2 ≤ s, d ≤  16).

//The solution is simple, we just convert to decimal and then from decimal to the numeric system we want.
using System;

class ConvertAnySystem
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

    static int ConvertToDecimal(string specialNumber, double basic)
    {
        int decimalNumber = 0;



        if (specialNumber[0] != '-')
        {
            for (int i = specialNumber.Length - 1; i >= 0; i--)
            {
                decimalNumber = decimalNumber + ((int)(GetHexaNumber(specialNumber[i]) * Math.Pow(basic, specialNumber.Length - 1 - i)));
            }
        }
        else if (specialNumber[0] == '-')
        {
            for (int i = specialNumber.Length - 1; i >= 1; i--)
            {
                decimalNumber = decimalNumber + ((int)(GetHexaNumber(specialNumber[i]) * Math.Pow(basic, specialNumber.Length - 1 - i)));
            }
            decimalNumber = decimalNumber * (-1);
        }

        return decimalNumber;
    }

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

    static string ConvertBack(int decimalNumber, int numericSystem)
    {
        int leftOver = 0;
        string sign = null;
        string specialRepresentation = null;
        string result = null;

        sign = ExtractSign(decimalNumber);
        decimalNumber = TurnToPositive(decimalNumber);

        while (decimalNumber != 0)
        {
            leftOver = decimalNumber % numericSystem;
            decimalNumber = decimalNumber / numericSystem;
            specialRepresentation = specialRepresentation + ConvertLeftover(leftOver);
        }

        result = sign + ReverseString(specialRepresentation);

        return result;
    }

    static void Main()
    {
        string hexadecimalNumber = null;
        double basicNumericSystem = 0.0;
        int decimalNumber = 0;
        int secondaryNumericSystem = 0;
        string endNumber = null;

        Console.Write("Please, type the base numeric system (2 to 16) and press Enter: ");
        basicNumericSystem = double.Parse(Console.ReadLine());
        Console.Write("Please, type the number to be converted and press Enter: ");
        hexadecimalNumber = Console.ReadLine();
        Console.Write("Please, type the numeric system (2 to 16) the number to be converted to and press Enter: ");
        secondaryNumericSystem = int.Parse(Console.ReadLine());

        decimalNumber = ConvertToDecimal(hexadecimalNumber, basicNumericSystem);

        endNumber = ConvertBack(decimalNumber, secondaryNumericSystem);

        Console.WriteLine(endNumber);
    }
}
