//Write a program to convert binary numbers to
//hexadecimal numbers (directly).

using System;

class BinaryToHexadecimal
{
    static string GetHexaNumber(string hexaDigit)
    {
        string binarySet = null;

        switch (hexaDigit)
        {
            case "0000":
                binarySet = "0";
                break;
            case "1":
                binarySet = "1";
                break;
            case "10":
                binarySet = "2";
                break;
            case "11":
                binarySet = "3";
                break;
            case "100":
                binarySet = "4";
                break;
            case "101":
                binarySet = "5";
                break;
            case "110":
                binarySet = "6";
                break;
            case "111":
                binarySet = "7";
                break;
            case "1000":
                binarySet = "8";
                break;
            case "1001":
                binarySet = "9";
                break;
            case "1010":
                binarySet = "A";
                break;
            case "1011":
                binarySet = "B";
                break;
            case "1100":
                binarySet = "C";
                break;
            case "1101":
                binarySet = "D";
                break;
            case "1110":
                binarySet = "E";
                break;
            case "1111":
                binarySet = "F";
                break;
            default:
                binarySet = "0";
                break;
        }

        return binarySet;
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

    static void Main()
    {
        string binaryNumber = null;
        string hexadecimalNumber = null;

        Console.Write("Please, type the binary number to be converted to hexadecimal and press Enter: ");
        binaryNumber = Console.ReadLine();
        while (binaryNumber.Length % 4 != 0)
        {
            binaryNumber = "0" + binaryNumber;

        }

        for (int i = binaryNumber.Length - 1; i >= 0; i = i - 4)
        {
                hexadecimalNumber = hexadecimalNumber + GetHexaNumber(binaryNumber.Substring(i - 3, 4).TrimStart('0'));
        }

        Console.WriteLine(ReverseString(hexadecimalNumber));
    }
}
