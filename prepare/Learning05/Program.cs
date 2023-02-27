using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        List<Shape> shapes = new List<Shape>();
        Square shape1 = new Square("blue", 2);
        shapes.Add(shape1);

        Rectangle shape2 = new Rectangle("green", 3, 2);
        shapes.Add(shape2);

        Circle shapes3 = new Circle("red", 3);
        shapes.Add(shapes3);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
    public static void DisplayShape(Shape shape)
    {

    }
}