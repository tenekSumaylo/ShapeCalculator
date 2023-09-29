using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator.NewFolder
{
    public class Square : Shape
    {
        public double Side { get; set; }
        public Square() { }
        public override double Area() => Math.Round( Math.Pow( Side, 2 ), 2 );

        public override double Perimeter() => Math.Round(4 * Side, 2);

        public override double Volume() => Math.Round(Math.Pow( Side, 3  ), 2);
    }
}
