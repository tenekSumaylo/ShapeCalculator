using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator.NewFolder
{
    public class Triangle : Shape
    {
        public double Edge1 { get; set; } = 0;
        public double Edge2 { get; set; } = 0;
        public double Edge3 { get; set; } = 0;
        public double Radius { get; set; } 

        public Triangle() { }

        public Triangle( double edge1, double edge2, double edge3 ) {
            Edge1 = edge1;
            Edge2 = edge2;
            Edge3 = edge3;
        }

        public override double Area()
        {
            return (Edge1 * Edge2) / 2;
        }

        public override double Perimeter()
        {
            return Edge1 + Edge2 + Edge3;
        }

        public override double Volume()
        {
            return ( 3.14 * Math.Pow( Radius, 2 ) * Height ) / 3;
        }


    }
}
