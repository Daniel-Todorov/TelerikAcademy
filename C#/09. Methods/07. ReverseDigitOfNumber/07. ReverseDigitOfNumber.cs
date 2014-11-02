//Write a method that reverses the digits of given 
//decimal number. Example: 256 -> 652

using System;

class ReverseDigitOfNumber
{
    static int[] ReverseNumber(string number)
    {
        int[] reversedNumber = new int[number.Length];

        for (int i = 0; i < number.Length; i++)
        {
            reversedNumber[i] = int.Parse(number[number.Length - 1 - i].ToString());
        }

        return reversedNumber;
    }

    static void Main()
    {
        string decimalNumber = null;
        int[] reversedNumber;

        Console.WriteLine("Please, type the decimal number to be reversed and press Enter: ");
        decimalNumber = Console.ReadLine();

        reversedNumber = ReverseNumber(decimalNumber);

        Console.Write("The revered number is: ");
        foreach (var item in reversedNumber)
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }
}
