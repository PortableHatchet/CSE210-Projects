using System;

public class Square: Shape
{
    private float ph_side;

    public Square(string color, float side) : base (color)
    {
       ph_side = side;
    }

    public override double GetArea()
    {
        return ph_side * ph_side;
    }


}