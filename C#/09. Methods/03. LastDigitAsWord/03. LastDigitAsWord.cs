//Write a method that returns the last digit of given 
//integer as an English word. Examples: 512 -> 
//"two", 1024 -> "four", 12309 -> "nine".

using System;

class LastDigitAsWord
{
    static string SayLastDigit(int integerNumber)
    {
        int lastDigit = 0;
        string nameOfDigit = null;
        lastDigit = integerNumber % 10;

        switch (lastDigit)
        {
            case 0:
                nameOfDigit = "zero";
                break;
            case 1:
                nameOfDigit = "one";
                break;
            case 2:
                nameOfDigit = "two";
                break;
            case 3:
                nameOfDigit = "three";
                break;
            case 4:
                nameOfDigit = "four";
                break;
            case 5:
                nameOfDigit = "five";
                break;
            case 6:
                nameOfDigit = "six";
                break;
            case 7:
                nameOfDigit = "seven";
                break;
            case 8:
                nameOfDigit = "eight";
                break;
            case 9:
                nameOfDigit = "nine";
                break;

            default:
                break;
        }

        return nameOfDigit;
    }

    static void Main()
    {
        int integerNumber = 0;

        Console.Write("Please, type an integer number and press Enter: ");
        integerNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("The last digit of the integer number is {0}!", SayLastDigit(integerNumber));
    }
}
