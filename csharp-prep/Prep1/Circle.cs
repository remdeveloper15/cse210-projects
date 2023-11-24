public class Circle : Shape
{
    private double _radious;

    public override double GetArea()
    {
        return 3.14 * (_radious * _radious);
    }

    public Circle(string color, double radious) : base(color)
    {
        _color = color;
        _radious = radious;
    }
}