public class Circle : Shape
{
    private float ph_radius;

    public Circle(string color, float radius) : base (color)
    {
        ph_radius = radius;
    }

    // Notice the use of the override keyword here
    public override double GetArea()
    {
        return ph_radius * ph_radius * Math.PI;
    }
}