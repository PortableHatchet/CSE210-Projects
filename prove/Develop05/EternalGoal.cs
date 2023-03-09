public class EternalGoal : Goal
{
    EternalGoal(string name, string description, int points) : base(name, description, points)
    {}

    public override bool checkGoal()
    {
        return base.checkGoal();
    }
}