//Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

using System;

class DividableOfFiveOrSevenChecker
{
    static void Main()
    {
        int numberToCheck;

        Console.WriteLine("Please, type an integer number to check if it can be divided without remainder by 7 and 5 at the same time");
        numberToCheck = int.Parse(Console.ReadLine());

        if (numberToCheck % 5 == 0 && numberToCheck % 7 == 0)
        {
            Console.WriteLine("The number CAN be divided without remaninder");
        }
        else
        {
            Console.WriteLine("The number CANNOT be divided without remainder");
        }
    }
}
