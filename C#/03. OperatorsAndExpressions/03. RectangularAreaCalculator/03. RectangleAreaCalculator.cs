//Write an expression that calculates rectangle's area by given width and height.

using System;

class RectangleAreaCalculator
{
    static void Main()
    {
        double rectangleHeight;
        double rectangleWidth;
        double rectangleArea;

        Console.WriteLine("Please, type the HEIGHT of the rectagle and press Enter: ");
        rectangleHeight = double.Parse(Console.ReadLine());
        Console.WriteLine("Please, type the WIDTH of the rectangle and press Enter: ");
        rectangleWidth = double.Parse(Console.ReadLine());

        rectangleArea = rectangleHeight * rectangleWidth;

        Console.WriteLine("The area of the rectangle is {0}!", rectangleArea);
    }
}
