//Write a program that finds the biggest of three integers using nested if statements.

using System;

class BiggerOfThreeIntegers
{
    static void Main()
    {
        int firstInteger = 0;
        int secondInteger = 0;
        int thirdInteger = 0;

        Console.Write("Please, type the first integer number to compare and press Enter: ");
        firstInteger = int.Parse(Console.ReadLine());
        Console.Write("Please, type the second integer number to compare and press Enter: ");
        secondInteger = int.Parse(Console.ReadLine());
        Console.Write("Please, type the third integer number to compare and press Enter: ");
        thirdInteger = int.Parse(Console.ReadLine());

        if (firstInteger > secondInteger)
        {
            if (firstInteger > thirdInteger)
            {
                Console.WriteLine("The first integer number is the biggest");
            }
        }
        if (secondInteger > firstInteger)
        {
            if (secondInteger > thirdInteger)
            {
                Console.WriteLine("The second integer number is the biggest");
            }
        }
        if (thirdInteger > firstInteger)
        {
            if (thirdInteger > secondInteger)
            {
                Console.WriteLine("The third integer number is the biggest");
            }
        }
    }
}
