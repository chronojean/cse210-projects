public class Circle : Shape
{
    private double _radius;

    public Circle(double radius) { this._radius = radius; }

    public override double GetArea()
    {
        return Math.PI * (this._radius * this._radius);
    }

}