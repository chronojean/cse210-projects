public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = _bottom = 1;
    }
    public Fraction(int t)
    {
        _top = t;
        _bottom = 1;
    }
    public Fraction(int t, int b)
    {
        _top = t;
        _bottom = b;
    }

    public int GetTop()
    {
        return _top;
    }
    public int GetBottom()
    {
        return _bottom;
    }
    public void SetTop(int t)
    {
        _top = t;
    }
    public void SetBottom(int b)
    {
        _bottom = b;
    }
    public string GetFractionString()
    {
        return _top + "/" + _bottom;
    }
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }

}