public class Rectangle : Shape
{
    private int _width = 0;
    private int _length = 0;

    public Rectangle(string color, int width, int length) : base(color)
    {
        _width = width;
        _length = length;
    } 

    public decimal GetWidth()
    {
        return _width;
    }
    public void SetWidth(int width)
    {
        _width = width;
    }
    public decimal GetLength()
    {
        return _length;
    }

    public void SetLength(int length)
    {
        _length = length;
    }

    public override float GetArea()
    {
        return _length * _width;
    }
}