//Write an expression that checks if given positive integer number n (n <= 100) is prime. E. g. 37 is prime.

using System;

class PrimeNumberChecker
{
    static void Main()
    {
        byte numberToCheck = 0;
        byte divider = 1;
        byte count = 0;

        Console.WriteLine("Please, type an integer number <= 100 and press Enter:");
        numberToCheck = byte.Parse(Console.ReadLine());

        while (divider < 101)
        {
            if (numberToCheck % divider == 0)
            {
                count++;
            }
            divider++;
        }

        if (count < 3)
        {
            Console.WriteLine("{0} IS a prime number", numberToCheck);
        } else {
            Console.WriteLine("{0} IS NOT a prime bumber", numberToCheck);
        }

    }
}
