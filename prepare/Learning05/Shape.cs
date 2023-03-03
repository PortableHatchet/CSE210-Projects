using System;

public abstract class Shape 
{
    private string ph_color;

    public Shape(string color)
    {
        ph_color = color;
    }
    public string GetColor()
    {
        return ph_color;
    }
    public void SetColor(string color)
    {
        ph_color = color;
    }
    public virtual double GetArea()
    {
        return 0;
    }
}