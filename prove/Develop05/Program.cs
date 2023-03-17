using System;

class Program
{
    static void Main(string[] args)
    {
        string phUserInput = "0";

        Console.WriteLine("Welcome to your Eternal Quest!");
        
        List<List<string>> goalsList;
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
                    SimpleGoal addSimple = new SimpleGoal(name, description, points);
                    List<string> simpleList = new List<string>();
                    simpleList.Add(name);
                    simpleList.Add("," + description);
                    simpleList.Add("," + points);
                    foreach (string item in simpleList)
                    {
                        Console.Write(item);
                    }
                }
                else if (phCNG == "2")
                {
                    Console.WriteLine("How many times would you like to repeat this goal?");
                    string repeat = Console.ReadLine();
                    Console.WriteLine("How many bonus will there be when you fully accomplish this goal?");
                    string bonusPoints = Console.ReadLine();
                    //ChecklistGoal addCheck = new ChecklistGoal(name, description, points, repeat, bonusPoints);
                    List<string> checkList = new List<string>();
                    checkList.Add("Checklist Goal,");
                    checkList.Add("," + name);
                    checkList.Add("," + description);
                    checkList.Add("," + points);
                    checkList.Add("," + repeat);
                    checkList.Add("," + bonusPoints);
                }
                else if (phCNG == "3")
                {
                    //EternalGoal addEternal = new EternalGoal(name, description, points);
                }
            }
            else if (phUserInput == "2")
            {
                Console.WriteLine("List Goals");
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