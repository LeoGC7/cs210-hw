using System.Diagnostics.Contracts;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFraction()
    {
        string fraction = $"{_top}/{_bottom}";
        return fraction;
    }

    public double GetDecimal()
    {
        double _decimal = (double) _top/_bottom;
        return _decimal;
    }
}