using System;

namespace _01.Shapes
{
    class Circle : Shape
    {
        public override double CalculateSurface()
        {
            double surface = 0.0;

            surface = this.width * this.height * Math.PI;

            return surface;
        }

        public Circle(double radius)
        {
            this.width = radius;
            this.height = radius;
        }
    }
}
