//Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}. 
//Add a static property to return the point O.

using System;

public struct Point3D
{
    private static readonly Point3D startPoint = new Point3D(0, 0, 0);

    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }
    public static Point3D StartPoint
    {
        get { return startPoint;}
    }

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
        Console.WriteLine(Point3D.StartPoint);
    }
}