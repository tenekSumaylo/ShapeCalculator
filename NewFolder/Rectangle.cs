using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator.NewFolder
{
    public class Rectangle : Shape
    {
        public Rectangle() { }

        public Rectangle( double length, double width, double height )
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Length * Width;
        }

        public override double Perimeter()
        {
            return (2 * Length) + (2 * Width);
        }

        public override double Volume()
        {
            return Length * Width * Height;
        }
    }
}
