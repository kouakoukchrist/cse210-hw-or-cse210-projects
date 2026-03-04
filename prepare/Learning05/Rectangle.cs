using System;

public class Rectangle : Shape
{
    private float _width;
    private float _height;

    public Rectangle(string color, float height, float width) : base(color)
    {
        _height = height;
        _width = width;
    }

    public override float GetArea()
    {
        return _height * _width;
    }
}