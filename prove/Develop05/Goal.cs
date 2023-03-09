public abstract class Goal
{
    private string ph_goalName;
    private string ph_goalDescritpion;
    private int ph_goalPoint;

    // Constructor for name, description and points for the Goal classes
    public Goal(string name, string description, int point)
    {
        ph_goalName = name;
        ph_goalDescritpion = description;
        ph_goalPoint = point;
    }

    // gets and returns the name
    public string getName(string name)
    {   
        return ph_goalName;
    }
    
    // gets and returns the description
    public string getDescription(string description)
    {
        return ph_goalDescritpion;
    }

    // gets and returns the points
    public int getPoints(int point)
    {
        return ph_goalPoint;
    }

    // checks if the goal is completed, checks a box if completed
    public  virtual void checkGoal(int goal)
    {
        if (goal == 1)
        {
            Console.Write("[X]");
        }

        else
        {
            Console.Write("[ ]");
        }
    }
}