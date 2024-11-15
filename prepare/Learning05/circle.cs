public class Circle : Shape
{
    private float _radius;

    public Circle(string color, float radius) : base(color)
    {
        _radius = radius;
    }

    public override float GetArea()
    {
        return MathF.PI * _radius * _radius;
    }
}