public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {}
    
    // Ensures the box never gets checked no matter the amount of 
    public virtual void CheckGoal(List<List<string>> goalsList, int eventCheck, int points)
    {
        List<string> selectedGoal = goalsList[eventCheck];
        int goalPoints = Convert.ToInt32(selectedGoal[4]);
        points += goalPoints;
    }
}