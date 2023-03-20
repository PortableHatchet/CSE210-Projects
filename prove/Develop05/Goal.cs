using System.IO;
using System;

public abstract class Goal
{
    private string _phGoalName;
    private string _phGoalDescritpion;
    private string _phGoalPoint;

    // Constructor for name, description and points for the Goal classes
    public Goal(string name, string description, string point)
    {
        _phGoalName = name;
        _phGoalDescritpion = description;
        _phGoalPoint = point;
    }

    // gets and returns the name
    public string getName()
    {   
        return _phGoalName;
    }
    
    // gets and returns the description
    public string getDescription()
    {
        return _phGoalDescritpion;
    }

    // gets and returns the points
    public int getPoints()
    {
        
        int numPoints = Convert.ToInt32(_phGoalPoint);
        return numPoints;
    }
    public virtual List<string> CreateGoal(string listName)
    {
        List<string> goalList = new List<string>();
        goalList.Add(listName);
        goalList.Add(",[ ]");
        goalList.Add("," + _phGoalName);
        goalList.Add("," + _phGoalDescritpion);
        goalList.Add("," + _phGoalPoint);
        return goalList;
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
    public virtual void SaveGoal(List<string> goal)
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (string item in goal)
            {
                writer.Write(item);
            }
        }
    }
}