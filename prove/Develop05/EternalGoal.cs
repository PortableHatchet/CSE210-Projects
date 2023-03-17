public class EternalGoal : Goal
{
    EternalGoal(string name, string description, string points) : base(name, description, points)
    {}
    
    // Ensures the box never gets checked no matter the amount of 
    public override void checkGoal(int goal)
    {
        if (goal < 1000000)
        {
            Console.Write("[ ]");
        }
    }
}