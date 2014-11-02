//Write a program that reads two positive integer numbers and prints how many numbers p exist between them 
//such that the remainder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.

using System;

class CheckDevisionByFive
{
    static void Main()
    {
        int firstInteger = 0;
        int secondInteger = 0;
        int numbersP = 0;

        Console.WriteLine("Please, type the first integer number and press Enter:");
        firstInteger = int.Parse(Console.ReadLine());
        Console.WriteLine("Please, type the second integer number and press Enter:");
        secondInteger = int.Parse(Console.ReadLine());

        for (; firstInteger <= secondInteger; firstInteger++)
        {
            if (firstInteger % 5 == 0)
            {
                numbersP = numbersP + 1;
            }
        }

        Console.WriteLine("The value of the numbers P is {0}", numbersP);
    }
}
