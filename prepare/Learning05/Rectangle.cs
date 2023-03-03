public class Rectangle : Shape
{
    private float ph_length;
    private float ph_width;

    public Rectangle(string color, float length, float width) : base (color)
    {
        ph_length = length;
        ph_width = width;
    }
    public override double GetArea()
    {
        return ph_length * ph_width;
    }
}