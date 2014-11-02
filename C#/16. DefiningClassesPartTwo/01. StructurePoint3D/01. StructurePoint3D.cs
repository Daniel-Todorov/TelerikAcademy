//Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
//Implement the ToString() to enable printing a 3D point.

using System;

public struct Point3D
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    public Point3D(int x, int y, int z)
        : this()
    {
        this.X = x;
        this.Y = y;
        this.Z = z;
    }

    public override string ToString()
    {
        string result = string.Format("X:{0}; Y:{1}; Z:{2}", this.X, this.Y, this.Z);
        return result;
    }
}

//A quick test class.
class Test
{
    public static void Main()
    {
        Point3D a = new Point3D(1, 2, 3);
        Console.WriteLine(a);
    }
}