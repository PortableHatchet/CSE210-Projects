using System;

public class Fraction
{
    private int ph_top;
    private int ph_bottom;

    public Fraction()
    {
        //Default to 1/1
        ph_top = 1;
        ph_bottom = 1;
    }

    public Fraction(int wholenumber)
    {
        ph_top = wholenumber;
        ph_bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        ph_top = top;
        ph_bottom = bottom;
    }

    public string GetFractionString()
    {
        // Notice that this is not stored as a member variable.
        // Is is just a temporary, local variable that will be recomputed each time this is called.
        string text = $"{ph_top}/{ph_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        // Notice that this is not stored as a member variable.
        // Is will be recomputed each time this is called.
        return (double)ph_top / (double)ph_bottom;
    }
}