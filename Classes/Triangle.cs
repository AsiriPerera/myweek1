using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1ObjectOriented.Interfaces;

namespace Week1ObjectOriented.Classes
{
    public class Triangle : Shape, IFaces, IShape
    {
        //from the abstract class
        //public override double GetArea()
        //{
        //    throw new NotImplementedException();
        //}

        //from the IShape interface
        public double GetArea()
        {
            throw new NotImplementedException();
        }

        public int GetFaces()
        {
            throw new NotImplementedException();
        }
    }
}
