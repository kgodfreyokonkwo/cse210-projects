using System;
using System.Collections.Generic;

public class Circle : Shape
{
    private int _radius = 0;
    float pi = (float)Math.PI;

    public Circle(string color, int radius) : base(color)
    {
        _radius = radius;
    }
	
    public decimal GetRadius()
    {
        return _radius;
    }
    public void SetRadius(int radius)
    {
        _radius = radius;
    }

    public override float GetArea()
    {
        return pi * _radius *_radius;
    }
}