//Write an expression that checks if given point (x, y) is within a circle K(0, 5).

using System;

    class CheckIfPointIsWithinCircle
    {
        static void Main()
        {
            int xCoordinate;
            int yCoordinate;

            Console.WriteLine("Please, type the X coordinate of the point:");
            xCoordinate = int.Parse(Console.ReadLine());
            Console.WriteLine("please, type the Y coordinate of the point:");
            yCoordinate = int.Parse(Console.ReadLine());

            if ((xCoordinate * xCoordinate) + (yCoordinate * yCoordinate) <= 25)
            {
                Console.WriteLine("The point IS within a circle K (0,5)!");
            }
            else {
                Console.WriteLine("The point IS NOT within a circle K (0,5)");
            }
        }
    }
