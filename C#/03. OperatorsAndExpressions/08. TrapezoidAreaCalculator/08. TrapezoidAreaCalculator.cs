//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class TrapezoidAreaCalculator
{
    static void Main()
    {
        double firstSide;
        double secondSide;
        double height;
        double area;

        Console.WriteLine("Please, type the length of the trapezoid's first side:");
        firstSide = double.Parse(Console.ReadLine());
        Console.WriteLine("Please, type the length of the trapezoid's second side:");
        secondSide = double.Parse(Console.ReadLine());
        Console.WriteLine("Please, type the length of the trapezoid's height:");
        height = double.Parse(Console.ReadLine());

        area = (firstSide + secondSide) * (height / 2);

        Console.WriteLine("The area of the trapezoid is {0}", area);
    }
}
