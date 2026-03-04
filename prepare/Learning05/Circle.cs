using System;

public class Circle : Shape
{
    private const float PI = 3.14f;
    private float _ray;

    public Circle(string color, float ray) : base(color)
    {
        _ray = ray;
    }

    public override float GetArea()
    {
        return _ray * _ray * PI;
    }
}