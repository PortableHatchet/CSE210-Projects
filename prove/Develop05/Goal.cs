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
    public static void CheckGoal(List<List<string>> goalsList, int eventCheck, int totalPoints)
    {
        List<string> selectedGoal = goalsList[eventCheck - 1];
        string goalType = selectedGoal[0];
        selectedGoal[1] = "[X]";
        int goalPoints = Convert.ToInt32(selectedGoal[4]);
        totalPoints += goalPoints;
    }
    public static void SaveGoals(List<List<string>> goal)
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (List<string> item in goal)
            {
                writer.WriteLine(string.Join(",", item));
            }
        }
    }
    public static List<List<string>> LoadGoals()
    {
        List<List<string>> goalsList = new List<List<string>>();
        using (StreamReader reader = new StreamReader("goals.txt"))
        {
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                List<string> lineList = line.Split(",").ToList<string>();
                goalsList.Add(lineList);
            }
            
        }
        return goalsList;
    }
    public static void ListGoals(List<List<string>> goalsList)
    {
        int counter = 1;
        foreach (List<string> innerList in goalsList)
                {
                    
                    Console.Write(counter + ". ");
                    for (int i = 1; i <= 4; i++)
                    {
                        if (i == 3)
                        {
                            Console.Write("(" + innerList[i] + ") ");
                        }
                        else if (i == 4)
                        {
                            Console.Write("Points: " + innerList[i]);
                        }
                        else
                        {
                            Console.Write(innerList[i] + " ");
                        }
                    }
                    Console.WriteLine();
                    counter++;
                }
    }
}