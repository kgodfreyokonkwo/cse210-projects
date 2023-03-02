using System;
using System.Collections.Generic;

public class Square : Shape
{
    private int _side = 0;


    public Square(string color, int side) : base(color)
    {
        _side = side;
    }


    public decimal GetSide()
    {
        return _side;
    }

    public void SetSide(int side)
    {
        _side = side;
    }

    public override float GetArea()
    {
        return _side * _side;
    }
}