using System.Net.NetworkInformation;
using System.Transactions;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFracNum()
    {
        string retText = $"{_top}/{_bottom}";
        return retText;
    } 
    public double GetDecNum()
    {
        return (double)_top / (double)_bottom;
    }
}