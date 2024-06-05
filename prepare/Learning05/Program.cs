using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("Blue", 5);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("Green", 10, 4);
        shapes.Add(rectangle);

        Circle circle = new Circle("Red", 5);
        shapes.Add(circle);

        foreach(Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has the area of {area}");
        }
    }
}