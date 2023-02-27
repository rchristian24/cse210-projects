using System;
public class Circle : Shape
{
    private double _radius;
    public Circle(String color, double radius) : base(color)
    {
        _radius = radius;
    }
    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}