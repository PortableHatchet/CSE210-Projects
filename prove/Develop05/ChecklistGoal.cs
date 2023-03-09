public class ChecklistGoal : Goal
{
    ChecklistGoal(string name, string description, int points) : base(name, description, points)
    {}
    // Checks how many times that goal has been completed 
    // if completions are fulfilled, check the box
    public override bool checkGoal()
    {
        return base.checkGoal();
    }
}