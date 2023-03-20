using System;

class Program
{
    static void Main(string[] args)
    {
        string phUserInput = "0";

        Console.WriteLine("Welcome to your Eternal Quest!");
        while (phUserInput != "6")
        {
            Console.WriteLine("Pick and option:");
            Console.WriteLine("1. Create a new goal \n2. List goals \n3. Save goals \n4. Load goals \n5. Record Event \n6. Quit");
            phUserInput = Console.ReadLine();
            
            if (phUserInput == "1")
            {
                Console.WriteLine("What type of goal would you like to set? \n1. Simple Goal \n2. Checklist Goal \n3. Eternal Goal");
                string phCNG = Console.ReadLine();

                Console.WriteLine("What is the name of this goal?");
                string name = Console.ReadLine();

                Console.WriteLine("Write a short description for this goal");
                string description = Console.ReadLine();

                Console.WriteLine("How many point should this goal be?");
                string points = Console.ReadLine();
                if (phCNG == "1")
                {
                    List<string> simpleList = new List<string>();
                    SimpleGoal addSimple = new SimpleGoal(name, description, points);
                    simpleList = addSimple.CreateGoal("SimpleList");
                    foreach (string item in simpleList)
                    {
                        addSimple.SaveGoal(simpleList);
                    }
                }
                else if (phCNG == "2")
                {
                    Console.WriteLine("How many times would you like to repeat this goal?");
                    string repeat = Console.ReadLine();
                    Console.WriteLine("How many bonus will there be when you fully accomplish this goal?");
                    string bonusPoints = Console.ReadLine();
                    
                    ChecklistGoal addCheck = new ChecklistGoal(name, description, points, repeat, bonusPoints);
                    List<string> checkList = new List<string>();
                    checkList = addCheck.CreateGoal("CheckList");
                    foreach (string item in checkList)
                    {
                        addCheck.SaveGoal(checkList);
                    }
                    
                }
                else if (phCNG == "3")
                {
                    EternalGoal addEternal = new EternalGoal(name, description, points);
                    List<string> eternalList = new List<string>();
                    eternalList = addEternal.CreateGoal("SimpleList");
                    foreach (string item in eternalList)
                    {
                        addEternal.SaveGoal(eternalList);
                    }
                }
            }
            else if (phUserInput == "2")
            {
                List<string> goalsList = new List<string>();
                goalsList = Goal.ListGoals();
                int listCounter = 1;
                Console.WriteLine("List Goals");
                foreach (string line in goalsList)
                {
                    Console.Write(listCounter + ". ");
                    Console.WriteLine(string.Join(",", line.Split(",")));
                    listCounter++;
                }
            }
            else if (phUserInput == "3")
            {
                Console.WriteLine("Save Goals");
            }
            else if (phUserInput == "4")
            {
                Console.WriteLine("Load Goals");
            }
            else if (phUserInput == "5")
            {
                Console.WriteLine("Record event");
            }
            else if (phUserInput == "6")
            {
                break;
            }
        }
    }
}