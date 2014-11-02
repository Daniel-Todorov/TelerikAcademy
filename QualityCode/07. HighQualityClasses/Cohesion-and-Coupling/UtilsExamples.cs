using System;

namespace CohesionAndCoupling
{
    class UtilsExamples
    {
        static void Main()
        {
            Console.WriteLine(Utils.GetFileExtension("example"));
            Console.WriteLine(Utils.GetFileExtension("example.pdf"));
            Console.WriteLine(Utils.GetFileExtension("example.new.pdf"));

            Console.WriteLine(Utils.GetFileNameWithoutExtension("example"));
            Console.WriteLine(Utils.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(Utils.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}",
                DistanceCalculator.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                DistanceCalculator.CalcDistance3D(5, 2, -1, 3, -6, 4));

            Shape3D newShape3D = new Shape3D(3, 4, 5);
            Console.WriteLine("Volume = {0:f2}", newShape3D.CalcVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", newShape3D.CalcDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", newShape3D.CalcDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", newShape3D.CalcDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", newShape3D.CalcDiagonalYZ());
        }
    }
}
