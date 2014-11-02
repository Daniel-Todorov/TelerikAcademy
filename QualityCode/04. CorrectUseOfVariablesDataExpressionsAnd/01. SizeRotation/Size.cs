//I must admit I have totally no idea what that formula in the method does...
using System;

/// <summary>
/// Contains two demantions of an 2D object and returns it's rotated size
/// </summary>
public class Size
{
    private double width;
    private double height;

    /// <summary>
    /// Default constructor
    /// </summary>
    /// <param name="width">Width of a 2D object</param>
    /// <param name="height">Height of a 2D object</param>
    public Size(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    /// <summary>
    /// Calculate the dimentions of a 2D object by given rotation angle
    /// </summary>
    /// <param name="size">The dimentions of the 2D object</param>
    /// <param name="rotationAngle">The rotation angle</param>
    /// <returns>Returns the dimentions of the D obejct after rotation</returns>
    public static Size GetRotatedSize(Size size, double rotationAngle)
    {
        double absoluteCosOfAngle = Math.Abs(Math.Cos(rotationAngle));
        double absoluteSinOfAngle = Math.Abs(Math.Sin(rotationAngle));
        double newWidth = absoluteCosOfAngle * size.width + absoluteSinOfAngle * size.height;
        double newHeight = absoluteSinOfAngle * size.width + absoluteCosOfAngle * size.height;
        Size rotatedSize = new Size(newWidth, newHeight);

        return rotatedSize;
    }
}
