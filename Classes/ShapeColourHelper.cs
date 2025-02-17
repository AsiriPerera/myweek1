
using Week1ObjectOriented.Interfaces;

namespace Week1ObjectOriented.Classes
{
    public static class ShapeColourHelper
    {

        public static Shape AddColour(Shape s)
        {
            s.Colour = "Red";

            return s;
        }

        public static Shape ChangeColour(Shape s)
        {
            s.Colour = "Blue";

            return s;
        }

        //new method for random colours
        public static Shape AddRandomColour(Shape s)
        {
            string[] colours = { "Yellow", "Red", "Blue", "Green", "Orange" };
            Random randomcolour = new Random();
            int index = randomcolour.Next(colours.Length);
            s.Colour = colours[index];
            return s;
        }

    }
}
