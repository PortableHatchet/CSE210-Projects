public abstract class Goal
{
    private string ph_goalName;
    private string ph_goalDescritpion;
    private int ph_goalPoint;

    public Goal(string name, string description, int point)
    {
        ph_goalName = name;
        ph_goalDescritpion = description;
        ph_goalPoint = point;
    }
    public string getName(string name)
    {   
        return ph_goalName;
    }
    public string getDescription(string description)
    {
        return ph_goalDescritpion;
    }
    public int getPoints(int point)
    {
        return ph_goalPoint;
    }
    public virtual bool checkGoal()
    {
        return false;
    }
}