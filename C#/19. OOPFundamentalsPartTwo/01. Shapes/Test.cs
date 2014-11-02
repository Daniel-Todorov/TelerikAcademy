using System;
using System.Collections.Generic;

namespace _01.Shapes
{
    class Test
    {
        static void Main()
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Triangle(4, 5));
            shapes.Add(new Rectangle(4, 5));
            shapes.Add(new Circle(4.5));

            foreach (Shape shape in shapes)
            {
                Console.WriteLine("The surface: {0}", shape.CalculateSurface());
            }
        }
    }
}
