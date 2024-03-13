public class Blind
{
    private double _width;
    private double _height;
    private string _color;

    public Blind(double width, double height, string color)
    {
        this._width = width;
        this._height = height;
        this._color = color;
    }
    public void set_color(string color)
    {
        this._color = color;
    }
    static void Main(String[] args)
    {
        Blind front_blind = new Blind(10, 10, "Blue");
        Console.WriteLine($"The color of the front blind is: {front_blind._color}");
    }
}