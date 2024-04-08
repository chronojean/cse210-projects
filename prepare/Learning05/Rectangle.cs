public class Rectangle : Shape
{
    private double _length;
    private double _width;
    public Rectangle(double largo, double ancho) { this._length = largo; this._width = ancho; }

    public override double GetArea()
    {
        return this._length * this._width;
    }

}