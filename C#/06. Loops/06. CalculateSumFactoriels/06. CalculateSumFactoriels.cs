//Write a program that, for given two integers N and X, calculates the sum:
//S = 1 + 1!/X + 2!/X^2 + ... + N!/X^N

using System;

class CalculateSumFactoriels
{
    static void Main()
    {
        double N = 0;
        double X = 0;
        double sum = 1.0;
        double factoriel = 1.0;
        double powX = 1.0;

        Console.Write("Please, type the first integer N and press Enter: ");
        N = double.Parse(Console.ReadLine());
        Console.Write("Please, type the second integer X and press Enter: ");
        X = double.Parse(Console.ReadLine());

        for (double a = 1; a <= N; a++)
        {
            for (double b = 1; b <= a; b++)
            {
                factoriel = factoriel * b;
            }
            sum = sum + factoriel / Math.Pow(X, a);
            factoriel = 1.0;
        }

        Console.WriteLine("1 + 1!/X + 2!/X^2 + ... + N!/X^N = {0}", sum);
    }
}
