//Write a program that finds the greatest of given 5 variables.

using System;

class FindGreatestOfFiveVariables
{
    static void Main()
    {
        double firstVarialbe = 0.0;
        double secondVarialbe = 0.0;
        double thirdVarialbe = 0.0;
        double forthVarialbe = 0.0;
        double fifthVarialbe = 0.0;

        Console.Write("Please, type a number and press Enter: ");
        firstVarialbe = double.Parse(Console.ReadLine());
        Console.Write("Please, type a number and press Enter: ");
        secondVarialbe = double.Parse(Console.ReadLine());
        Console.Write("Please, type a number and press Enter: ");
        thirdVarialbe = double.Parse(Console.ReadLine());
        Console.Write("Please, type a number and press Enter: ");
        forthVarialbe = double.Parse(Console.ReadLine());
        Console.Write("Please, type a number and press Enter: ");
        fifthVarialbe = double.Parse(Console.ReadLine());

        if (firstVarialbe > secondVarialbe && firstVarialbe > thirdVarialbe && firstVarialbe > forthVarialbe && firstVarialbe > fifthVarialbe)
        {
            Console.WriteLine("The first number is greatest!");
        }
        else if (secondVarialbe > firstVarialbe && secondVarialbe > thirdVarialbe && secondVarialbe > forthVarialbe && secondVarialbe > fifthVarialbe)
        {
            Console.WriteLine("The second number is greatest!");
        }
        else if (thirdVarialbe > firstVarialbe && thirdVarialbe > secondVarialbe && thirdVarialbe > forthVarialbe && thirdVarialbe > fifthVarialbe)
        {
            Console.WriteLine("The third number is greatest!");
        }
        else if (forthVarialbe > firstVarialbe && forthVarialbe > secondVarialbe && forthVarialbe > thirdVarialbe && forthVarialbe > fifthVarialbe)
        {
            Console.WriteLine("The forth number is greatest!");
        }
        else if (fifthVarialbe > firstVarialbe && fifthVarialbe > secondVarialbe && fifthVarialbe > thirdVarialbe && fifthVarialbe > forthVarialbe)
        {
            Console.WriteLine("The fifth number is greatest!");
        }
    }
}
