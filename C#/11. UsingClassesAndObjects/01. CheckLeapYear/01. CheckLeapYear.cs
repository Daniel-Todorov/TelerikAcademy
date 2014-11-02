//Write a program that reads a year from the console
//and checks whether it is a leap. Use DateTime.

using System;

class CheckLeapYear
{
    static void Main()
    {
        int year = 0;

        Console.Write("Please, type the year and press Enter: ");
        year = int.Parse(Console.ReadLine());

        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("{0} is leap year!", year);
        }
        else
        {
            Console.WriteLine("{0} is not leap year!", year);
        }
    }
}