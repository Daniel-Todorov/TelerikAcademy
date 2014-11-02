//Write and expression that checks for given point (x, y) if it is within the circle K((1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

class PointOutsideCircleAndRectangle
{
    static void Main()
    {
        int xCoordinate;
        int yCoordinate;
        bool isInsideCircle;
        bool isOutsideRectangle;

        Console.WriteLine("Please, type the X coordinate of the point and press Enter:");
        xCoordinate = int.Parse(Console.ReadLine()) - 1;
        Console.WriteLine("Please, type the Y coordinate of the point and press Enter:");
        yCoordinate = int.Parse(Console.ReadLine()) - 1;

        isInsideCircle = (xCoordinate * xCoordinate) + (yCoordinate * yCoordinate) <= 9;
        Console.WriteLine(isInsideCircle);
        isOutsideRectangle = !((xCoordinate >= -1 && xCoordinate <= 5) && (yCoordinate <= 1 && yCoordinate >= -1));
        Console.WriteLine(isOutsideRectangle);

        if (isInsideCircle && isOutsideRectangle)
        {
            Console.WriteLine("The point IS inside the circle K ((1,1), 3) and out of the rectangle R (top = 1, left = -1, width = 6, height = 2");
        }
        else {
            Console.WriteLine("The point is either NOT inside the circle K ((1,1), 3) or NOT out of the rectangle R (top = 1, left = -1, width = 6, height = 2");
        }
    }
}
