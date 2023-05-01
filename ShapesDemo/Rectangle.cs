using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesDemo
{
    public class Rectangle : GeometricFigure
    {
       // class constructer
        public Rectangle(double h, double w)
            : base(h, w) { }

        //abstract method computing area for rectangle 
        public override double ComputeArea()
        {
            return Height * Width;
        }

        
    }
}
