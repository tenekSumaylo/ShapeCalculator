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

        public override double Area() => Math.Round( Length * Width, 2 );
    

        public override double Perimeter() => Math.Round((2 * Length) + (2 * Width), 2 );
     

        public override double Volume() => Math.Round( Length * Width * Height, 2 );
      
    }
}
