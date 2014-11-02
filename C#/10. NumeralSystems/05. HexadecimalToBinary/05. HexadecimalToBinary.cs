//Write a program to convert hexadecimal numbers
//to binary numbers (directly).

using System;

class HexadecimalToBinary
{
    static string GetBinaryNumber(char hexaDigit)
    {
        string binarySet = null;

        switch (decimalDigit)
        {
            case '0':
                binarySet = "0000";
                break;
            case '1':
                binarySet = "0001";
                break;
            case '2':
                binarySet = "0010";
                break;
            case '3':
                binarySet = "0011";
                break;
            case '4':
                binarySet = "0100";
                break;
            case '5':
                binarySet = "0101";
                break;
            case '6':
                binarySet = "0110";
                break;
            case '7':
                binarySet = "0111";
                break;
            case '8':
                binarySet = "1000";
                break;
            case '9':
                binarySet = "1001";
                break;
            case 'A':
                binarySet = "1010";
                break;
            case 'a':
                binarySet = "1010";
                break;
            case 'B':
                binarySet = "1011";
                break;
            case 'b':
                binarySet = "1011";
                break;
            case 'C':
                binarySet = "1100";
                break;
            case 'c':
                binarySet = "1100";
                break;
            case 'D':
                binarySet = "1101";
                break;
            case 'd':
                binarySet = "1101";
                break;
            case 'E':
                binarySet = "1110";
                break;
            case 'e':
                binarySet = "1110";
                break;
            case 'F':
                binarySet = "1111";
                break;
            case 'f':
                binarySet = "1111";
                break;
            default:
                break;
        }

        return binarySet;
    }

    static void Main()
    {
        string hexadecimalNumber = null;
        string binaryNumber = null;

        Console.Write("Please, type the hexadecimal number to be converted to binary and press Enter: ");
        hexadecimalNumber = Console.ReadLine();

        if (hexadecimalNumber[0] != '-')
        {
            for (int i = 0; i < hexadecimalNumber.Length; i++)
            {
                binaryNumber = binaryNumber + GetBinaryNumber(hexadecimalNumber[i]);
            }
            Console.WriteLine("The number after convertion is {0}.", binaryNumber.TrimStart('0'));
        }
        else if (hexadecimalNumber[0] == '-')
        {
            for (int i = 0; i < hexadecimalNumber.Length; i++)
            {
                binaryNumber = binaryNumber + GetBinaryNumber(hexadecimalNumber[i]);
            }
            Console.WriteLine("The number after convertion is -{0}.", binaryNumber.TrimStart('0'));
        }
    }
}
