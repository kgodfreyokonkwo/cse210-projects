using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Yellow", 10);
        // square.SetColor("Yellow");
        // square.SetSide(10);
        // square.GetArea();
        
        Rectangle rectangle = new Rectangle("Red", 5, 11);
        // rectangle.SetColor("Red");
        // rectangle.SetLength(11);
        // rectangle.SetWidth(5);
        // rectangle.GetArea();

        Circle circle = new Circle("White", 6);
        // circle.SetColor("White");
        // circle.SetRadius(6);
        // circle.GetArea();

        // DisplayShapeInformation(square);
        // DisplayShapeInformation(rectangle);
        // DisplayShapeInformation(circle);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach ( Shape shape in shapes)
        {
            float area = shape.GetArea();
            string color1 = shape.GetColor();

            Console.WriteLine($"The {color1} shape has an area of {area}square meters");
        }

    }
    // public static void DisplayShapeInformation(Shape shape)
    // {
    //     float Area = shape.GetArea();

    // }

}