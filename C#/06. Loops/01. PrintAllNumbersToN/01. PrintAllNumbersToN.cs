//Write a program that prints all the numbers from one to N.

using System;

class PrintAllNumbersToN
{
    static void Main()
    {
        int userInput = 0;
        int counter = 1;

        Console.Write("Please, type a number N and press Enter: ");
        userInput = int.Parse(Console.ReadLine());

        while (counter <= userInput)
        {
            Console.Write("{0} ", counter);
            counter++;
        }
    }
}
