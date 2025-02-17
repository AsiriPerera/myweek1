
using Week1ObjectOriented.Interfaces;

namespace Week1ObjectOriented.Classes
{
    public class Square : Shape, IFaces, IShape
    {
        private int side;

        public Square(int s) 
        {
            
            if (s > 10)
            {
                throw new Exception("Cannot be greater then 10");
            }

            side = s;
        }

        public Square() { }

        public void SetSide(int s)
        {
            side = s;
        }

        //from the abstract class
        //public override double GetArea()
        //{
        //    return side * side; 
        //}

        //from the IShape interface
        public double GetArea()
        {
            return side * side;
        }

        public int GetFaces()
        {
            throw new NotImplementedException();
        }

        public readonly int Sides;

    }
}
