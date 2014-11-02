//Write a program that enters the coefficients a, b and c of a quardratic equation a*x*x + b*x + c = 0 and
//calculates and prints its real roots. Note that quadric equations may have 0, 1 or 2 real roots.

using System;

class FindRealRootOfQuadraticEquation
{
    static void Main()
    {
        double a = 0.0;
        double b = 0.0;
        double c = 0.0;
        double x = 0.0;
        double x1 = 0.0;
        double x2 = 0.0;

        Console.WriteLine("Please, type the coefficient A and press Enter:");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Please, type the coefficient B and press Enter:");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("Please, type the coefficient C and press Enter:");
        c = double.Parse(Console.ReadLine());

        if ((b * b) - (4 * c * a) > 0)
        {
            x1 = (-1 * b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            x2 = (-1 * b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            Console.WriteLine("The quadratic equation has two real roots: {0} and {1}.", x1, x2);
        }
        else if ((b * b) - (4 * c * a) == 0)
        {
            x = -1 * (b / (2 * a));
            Console.WriteLine("The only real root of the quedratic equation is {0}", x);
        }
        else
        {
            Console.WriteLine("The quadratic equation has no real roots");
        }
    }
}