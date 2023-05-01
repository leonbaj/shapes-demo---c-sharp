using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesDemo
{
    public class Square :  GeometricFigure
    {

        //class contructor taking in only height as h
        public Square(double h)
            : base(h, h) { }
        
        //abstract method for Square 
        public override double ComputeArea()
        {
            return Height * Height;
        }
    }
}
