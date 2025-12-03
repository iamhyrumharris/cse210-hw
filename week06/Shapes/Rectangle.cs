public class Rectangle : Shape
{
    private double _width;
    private double _length;

    public Rectangle(string color, double width, double height) : base(color)
    {
        _width = width;
        _length = height;
    }

    public override double GetArea()
    {
        return _width * _length;
    }
}