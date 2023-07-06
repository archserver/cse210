using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square theSquare = new Square();
        shapes.Add(theSquare);

        Rectangle theRectangle = new Rectangle();
        shapes.Add(theRectangle);
        Circle theCircle = new Circle();
        shapes.Add(theCircle);


        foreach (Shape item in shapes)
        {

            item.SetColor();
            double a = item.GetArea();

            Console.WriteLine($"The area is : {a} and the color is {item.GetColor()}");
            
        }
        
    }
}