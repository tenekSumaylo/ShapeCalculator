using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShapeCalculator.NewFolder
{
    public class Circle : Shape
    {

        public double Radius {  get; set; }
        public Circle() { }

        public override double Area() => Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
        

        public override double Perimeter() => Math.Round( Math.PI * 2 * Radius, 2 );
        

        public override double Volume() => Math.Round( ( 4 * Math.PI * Math.Pow( Radius, 3 ) ) / 3, 2);
   
    }
}
