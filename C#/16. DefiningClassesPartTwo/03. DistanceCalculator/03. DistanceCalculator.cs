//Write a static class with a static method to calculate the distance between two points in the 3D space.

using System;

public static class DistanceCalculator
{
    public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
    {
        double result = 0.0;

        result = Math.Sqrt(Math.Pow((firstPoint.X - secondPoint.X), 2) + Math.Pow((firstPoint.Y - secondPoint.Y), 2) + Math.Pow((firstPoint.Z - secondPoint.Z), 2));

        return result;
    }
}

//A quick test class.
class Test
{
    public static void Main()
    {
        Point3D firstPoint = new Point3D(1, 2, 3);
        Point3D secondPoint = new Point3D(3, 1, -4);

        Console.WriteLine(DistanceCalculator.CalculateDistance(firstPoint, secondPoint));
    }
}