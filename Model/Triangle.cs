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
        public double Radius { get; set; } = 0;

        public Triangle() { }

        public Triangle( double edge1, double edge2, double edge3 ) {
            Edge1 = edge1;
            Edge2 = edge2;
        }

        public override double Area() => Math.Round( ((Edge1 * Edge2) / 2), 2 );
        

        public override double Perimeter() => Math.Round(Length + Width + Height, 2 );
      

        public override double Volume() => Math.Round(( ( Math.PI * Math.Pow( Radius, 2 ) * Height ) / 3 ), 2);
        
    }
}
