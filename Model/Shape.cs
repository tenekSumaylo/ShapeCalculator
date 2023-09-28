using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator.NewFolder
{
    public abstract class Shape
    {
        public double Length {  get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public abstract double Area();
        public abstract double Perimeter();
        public abstract double Volume();
    }
}
