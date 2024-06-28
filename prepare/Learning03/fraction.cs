using System;
using System.Diagnostics.Contracts;

public class Fraction
{
    private int _top;
    private int _buttom;

    public Fraction()
    {
        _top = 1;
        _buttom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _buttom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _buttom = bottom;
    }

    public string GetFractionString()
    {
        string text = $"{_top}/{_buttom}";
        return text;
    }
    public double GetDecimalValue()
    {
        return (double)_top / (double)_buttom;
    }
   
}
