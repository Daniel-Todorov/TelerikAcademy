using System;

class Program
{
    static void Main()
    {
        string initialNumber = null;
        long number = 0;
        double power = 0.0;
        long leftover = 0;

        initialNumber = Console.ReadLine();
        number = int.Parse(initialNumber);
        power = initialNumber.Length;

        for (int i = 0; i < 3; i++)
        {
            leftover = number % 10;
            if (leftover == 0)
            {
                power--;
            }
            number = number / 10;
            number = number + leftover  * (long)(Math.Pow(10, power - 1));
        }

        Console.WriteLine(number);
    }
}