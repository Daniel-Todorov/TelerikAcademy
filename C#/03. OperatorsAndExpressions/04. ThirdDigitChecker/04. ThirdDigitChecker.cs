//Write an expression that checks for given integer if it's third digit (right-to-left) is 7. E. g. 1732 -> true.

using System;

class ThirdDigitChecker
{
    static void Main()
    {
        int numberToCheck;
        int thirdDigit;

        Console.WriteLine("Please, type an integer number to be checked:");
        numberToCheck = int.Parse(Console.ReadLine());

        thirdDigit = numberToCheck / 100;
        thirdDigit = thirdDigit % 10;

        if (thirdDigit == 7)
        {
            Console.WriteLine("The third digit from right to left IS 7!");
        }
        else
        {
            Console.WriteLine("The third digit from right to left is NOT 7!");
        }
    }
}
