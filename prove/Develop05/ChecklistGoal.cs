public class ChecklistGoal : Goal
{
    private string _phRepeat;
    private string _phBonusPoints;
    public ChecklistGoal(string name, string description, string points, string repeat, string bonusPoints) : base(name, description, points)
    {
        _phRepeat = repeat;
        _phBonusPoints = bonusPoints;
    }

    public override List<string> CreateGoal(string listName)
    {
        List<string> goalList = new List<string>();
        goalList.Add(listName);
        goalList.Add(",[ ]");
        goalList.Add("," + getName());
        goalList.Add("," + getDescription());
        goalList.Add("," + getPoints());
        goalList.Add("," + _phRepeat);
        goalList.Add("," + _phBonusPoints);
        return goalList;
    }

    // Checks how many times that goal has been completed 
    // if completions are fulfilled, check the box
    public override void checkGoal(int goal)
    {
        int phNumber = Convert.ToInt32(_phRepeat);
        
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