// See https://aka.ms/new-console-template for more information
using Week1ObjectOriented.Classes;

//var square = new Square(10);

//try
//{


//    square.SetArea(2);


//    Console.WriteLine("The area is " + square.GetArea());
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}


try
{
    var circle = new Circle(4);
    Console.WriteLine("Random Colour of the circle is:" + ShapeColourHelper.AddRandomColour(circle).Colour);
    Console.WriteLine("The area of the circle is: " + circle.GetArea());

    var square = new Square(4);
    Console.WriteLine("Random Colour of the square is:" + ShapeColourHelper.AddRandomColour(square).Colour);
    Console.WriteLine("The area of the square is: " + square.GetArea());

    var triangle = new Triangle();
    Console.WriteLine("Random Colour of the triangle is:" + ShapeColourHelper.AddRandomColour(triangle).Colour);
    Console.WriteLine("The area of the triangle is: " + triangle.GetArea());
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}



//ShapeColourHelper.AddColour(circle);


//ShapeColourHelper.AddColour(square);

//Console.WriteLine(square.Colour);

//ShapeColourHelper.ChangeColour(square);

//Console.WriteLine(square.Colour);


Console.ReadLine();




