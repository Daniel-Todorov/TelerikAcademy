using System;

namespace _01.Shapes
{
    class Triangle : Shape
    {
        //public double Width
        //{
        //    get { return this.width; }
        //    set { this.width = value; }
        //}
        //
        //public double Height
        //{
        //    get { return this.height; }
        //    set { this.height = value; }
        //}

        public override double CalculateSurface()
        {
            double surface = 0.0;

            surface = (this.width * this.height) / 2;

            return surface;
        }

        public Triangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
    }
}
