using System;

class Program
{
    static void Main(string[] args)
    {
        List<List<string>> goalsList = new List<List<string>>();

        string phUserInput = "0";
        int totalPoints = 0;
        Console.WriteLine("Welcome to your Eternal Quest!");
        while (phUserInput != "6")
        {
            Console.WriteLine("Pick and option:");
            Console.WriteLine("Points: " + totalPoints);
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
                    goalsList.Add(simpleList);
                    //foreach (string item in simpleList)
                    //{
                    //    addSimple.SaveGoal(simpleList);
                    //}
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
                    goalsList.Add(checkList);
                    //foreach (string item in checkList)
                    //{
                        //addCheck.SaveGoal(checkList);
                    //}
                    
                }
                else if (phCNG == "3")
                {
                    EternalGoal addEternal = new EternalGoal(name, description, points);
                    List<string> eternalList = new List<string>();
                    eternalList = addEternal.CreateGoal("EternalList");
                    goalsList.Add(eternalList);
                    //foreach (string item in eternalList)
                    //{
                    //    addEternal.SaveGoal(eternalList);
                    //}
                }
            }
            else if (phUserInput == "2")
            {
                Console.WriteLine("List Goals");
                Goal.ListGoals(goalsList);
            }
            else if (phUserInput == "3")
            {
                Goal.SaveGoals(goalsList);
                Console.WriteLine("Goals Saved!");
                Console.WriteLine();
            }
            else if (phUserInput == "4")
            {
                Console.WriteLine("Load Goals: ");
                goalsList = Goal.LoadGoals();
            }
            else if (phUserInput == "5")
            {
                int eventCheck = 0;
                Console.WriteLine("Record event");
                Goal.ListGoals(goalsList);
                Console.WriteLine("What goal would you like to record?");
                eventCheck = Convert.ToInt32(Console.ReadLine());
                List<string> selectedGoal = goalsList[eventCheck];
                string goalType = selectedGoal[0];
                Goal.CheckGoal(goalsList, eventCheck, totalPoints);
            }
            else if (phUserInput == "6")
            {
                break;
            }
        }
    }
}