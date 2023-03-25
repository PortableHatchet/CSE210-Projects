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
    public string getPoints()
    {
        //int numPoints = Convert.ToInt32(_phGoalPoint);
        return _phGoalPoint;
    }
    public virtual List<string> CreateGoal(string listName)
    {
        List<string> goalList = new List<string>();
        goalList.Add(listName);
        goalList.Add("[ ]");
        goalList.Add(_phGoalName);
        goalList.Add(_phGoalDescritpion);
        goalList.Add(_phGoalPoint);
        return goalList;
    }

    // checks if the goal is completed, checks a box if completed
    public  virtual void CheckGoal(int goal)
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
    public static void SaveGoal(List<List<string>> goal)
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (List<string> item in goal)
            {
                writer.WriteLine(string.Join(",", item));
            }
        }
    }
    public static List<string> LoadGoals()
    {
        List<string> goalsList = new List<string>();
        using (StreamReader reader = new StreamReader("goals.txt"))
        {
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                goalsList.Add(line);
            }
            
        }
        return goalsList;
    }
}