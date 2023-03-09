public class ChecklistGoal : Goal
{
    ChecklistGoal(string name, string description, int points) : base(name, description, points)
    {}

    public override bool checkGoal()
    {
        return base.checkGoal();
    }
}