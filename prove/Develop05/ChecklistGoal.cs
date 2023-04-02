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
        goalList.Add("[ ]");
        goalList.Add(getName());
        goalList.Add(getDescription());
        goalList.Add(getPoints());
        goalList.Add(_phRepeat);
        goalList.Add(_phBonusPoints);
        return goalList;
    }

    // Checks how many times that goal has been completed 
    // if completions are fulfilled, check the box
    public  virtual void CheckGoal(List<List<string>> goalsList, int eventCheck, int points, int bonusPoints)
    {
        List<string> selectedGoal = goalsList[eventCheck];
        string goalType = selectedGoal[0];
        int repeat = Convert.ToInt32(selectedGoal[5]);
        int goalPoints = Convert.ToInt32(selectedGoal[4]);

        if (goalType == "CheckList")
        {
            if (repeat > 1)
            {
                repeat -= 1;
                points += goalPoints;
                selectedGoal[5] = Convert.ToString(repeat);

            }
            else
            {
                repeat = 0;
                selectedGoal[1] = "[X]";
                selectedGoal[5] = Convert.ToString(repeat);
            }
        }

       
        
        
    }
}