using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesDemo
{
    public class Triangle : GeometricFigure
    {
        
        //constructing Class trangle. base refering back geometricfigure 
        public Triangle(double h, double w)
            : base(h, w) { }

        //abstract method, computing area for triangle class. 
        public override double ComputeArea()
        {
            return (Height * Width * .5);
        }




    }
}
