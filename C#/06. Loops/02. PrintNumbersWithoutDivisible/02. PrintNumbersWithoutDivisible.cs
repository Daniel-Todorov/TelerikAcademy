//Write a program that prints all the numbers from one to N, that are not divisible by 3 and 7 at the same time.

using System;

class PrintNumbersWithoutDivisible
{
    static void Main()
    {
        int userInput = 0;
        int counter = 1;

        Console.Write("Please, type a number N and press Enter: ");
        userInput = int.Parse(Console.ReadLine());

        while (counter <= userInput)
        {
            if (counter % 3 != 0 && counter % 7 != 0)
            {
                Console.Write("{0} ", counter);
            }
            counter++;
        }
    }
}

