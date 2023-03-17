using System.IO;
using System;

public abstract class Goal
{
    private string ph_goalName;
    private string ph_goalDescritpion;
    private string ph_goalPoint;

    // Constructor for name, description and points for the Goal classes
    public Goal(string name, string description, string point)
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
    public int getPoints(string point)
    {
        
        int numPoints = Convert.ToInt32(ph_goalPoint);
        return numPoints;
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
            writer.WriteLine(goal);
        }
    }
}