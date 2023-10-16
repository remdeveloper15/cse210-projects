using System;

public class Franction 
{
    private int _top;
    private int _bottom;

    public Franction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Franction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Franction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }


    public string GetFranctionString()
    {
         string text = $"{_top}/{_bottom}";
         return text;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom; 
    }

}