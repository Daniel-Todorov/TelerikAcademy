//Write methods that calculate the surface of a 
//triangle by given:
//1. side and altitude to it;
//2. three sides;
//3. two sides and an angle between them. 
//Use System.Math.

using System;

class CalculateSurfaceIfTriangle
{
    static double CalculateBySideAndAttitude(double side, double corespondingAttitude)
    {
        double area = 0.0;

        area = (1.0 / 2.0) * side * corespondingAttitude;

        return area;
    }

    static double CalculateByThreeSides(double firstSide, double secondSide, double thirdSide)
    {
        double semiPerimeter = 0.0;
        double area = 0.0;

        semiPerimeter = (firstSide + secondSide + thirdSide) / 2.0;
        area = Math.Sqrt(semiPerimeter * (semiPerimeter - firstSide) * (semiPerimeter - secondSide) * (semiPerimeter - thirdSide));

        return area;
    }

    static double CalculateBySidesAndSin(double firstSide, double secondSide, double angleBetweenSides)
    {
        double area = 0.0;

        area = (1.0 / 2.0) * firstSide * secondSide * Math.Sin(angleBetweenSides * (Math.PI / 180));

        return area;
    }

    static void Main()
    {
        double a = 0.0;
        double b = 0.0;
        double c = 0.0;
        double h = 0.0;
        double angle = 0.0;
        double area = 0.0;

        Console.Write("Please type the length of a triangle's side and press Enter: ");
        a = double.Parse(Console.ReadLine());
        Console.Write("Please type the altitude of the triangle's side and press Enter: ");
        h = double.Parse(Console.ReadLine());
        area = CalculateBySideAndAttitude(a, h);
        Console.WriteLine("The surface of the triangle is {0}.", area);

        Console.WriteLine();

        Console.Write("Please type the length of a triangle's side and press Enter: ");
        a = double.Parse(Console.ReadLine());
        Console.Write("Please type the length of another triangle's side and press Enter: ");
        b = double.Parse(Console.ReadLine());
        Console.Write("Please type the length of the last triangle's side and press Enter: ");
        c = double.Parse(Console.ReadLine());
        area = CalculateByThreeSides(a, b, c);
        Console.WriteLine("The surface of the triangle is {0}.", area);

        Console.WriteLine();

        Console.Write("Please type the length of a triangle's side and press Enter: ");
        a = double.Parse(Console.ReadLine());
        Console.Write("Please type the length of another triangle's side and press Enter: ");
        b = double.Parse(Console.ReadLine());
        Console.Write("Please type the angle between these two sides and press Enter: ");
        angle = double.Parse(Console.ReadLine());
        area = CalculateBySidesAndSin(a, b, angle);
        Console.WriteLine("The surface of the triangle is {0}.", area);
    }
}
