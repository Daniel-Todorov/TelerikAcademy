//Write a program that reads the radius r of a circle and prints its perimeter and area.

using System;

class ReadRadiusAndPrintPerimeterAndArea
{
    static void Main()
    {
        double radius;
        double perimeterOfCircle;
        double areaOfCircle;

        Console.WriteLine("Please, type the radius R of a circle and press Enter:");
        radius = double.Parse(Console.ReadLine());

        perimeterOfCircle = 2 * Math.PI * radius;
        Console.WriteLine("The perimeter of the circle is {0}", perimeterOfCircle);
        areaOfCircle = Math.PI * radius * radius;
        Console.WriteLine("The area of the circle is {0}", areaOfCircle);
    }
}
