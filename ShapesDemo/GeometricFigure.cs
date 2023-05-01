using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesDemo
{
     public abstract class GeometricFigure
    {
        private double height;
        private double width;


        //contructer class takes in param height and width as h and w
        public GeometricFigure(double h, double w) 
        { 
           setClass(h, w);
        }


        

        //getter and setter for Height as well as checking the width setter will set a value higher than 0 other wise it will be 0 

        public double Height 
        { 
            get { return height; }

            set
            {
                if (value > 0.0) 
                { 
                    height = value; 
                }
                else 
                {
                    height = 0.0; 
                }
            
            }
             
        }

        //getter and setter for width as well as checking the width setter will set a value higher than 0 other wise it will be 0 
        public double Width
        {
            get { return width; }
            
            set 
            {
                if (value > 0.0)
                {
                    width = value;
                }
                else 
                {
                    width = 0.0;
                }
            }
        }
        
       


        
        private void setClass (double h, double w)
        {
            Height = h; 
            
            Width = w;
        }





        //required abstract method
        public abstract double ComputeArea();

    }
}
