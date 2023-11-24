using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Red", 4);
        Rectangle rectangle = new Rectangle("Blue", 4, 5);
        Circle circle = new Circle("Black", 6);
        DisplayShapeInfo(square);
        DisplayShapeInfo(rectangle);
        DisplayShapeInfo(circle);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shap in shapes)
        {
            double shape = shap.GetArea();
            string color = shap.GetColor();
            Console.WriteLine(shape + color);
        }
    }

    public static void DisplayShapeInfo(Shape shape)
    {
        double area = shape.GetArea();
        Console.WriteLine($"Color: {shape.GetColor()} Area: {area} ");
    }
}
