public class ChecklistGoal : Goal
{
    private string phNumGoal;
    ChecklistGoal(string name, string description, int points, string numGoal) : base(name, description, points)
    {
        phNumGoal = numGoal;
    }

    // Checks how many times that goal has been completed 
    // if completions are fulfilled, check the box
    public override void checkGoal(int goal)
    {
        int phNumber = Convert.ToInt32(phNumGoal);
        
        if (phNumber > goal)
        {
            Console.Write("[ ]");
        }
        else 
        {
            Console.Write("[X]");
        }
    }
}