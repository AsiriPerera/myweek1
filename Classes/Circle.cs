using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1ObjectOriented.Classes
{
    public class Circle : Shape, IShape
    {
        private int radius = 0;

        public Circle(int Radius) 
        {
            //get the value of the radius using constructors
            radius = Radius;
        }

        //from the abstract class
        //public override double GetArea()
        //{
        //    //return the area
        //    return Math.PI * radius * radius;
        //}

        //from the IShape interface
        public double GetArea()
        {
            //return the area
            return Math.PI * radius * radius;
        }
    }

}
