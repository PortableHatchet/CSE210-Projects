using System;

class Program
{
    static void Main(string[] args)
    {
        string ph_userInput = "0";

        Console.WriteLine("Welcome to your Eternal Quest!");
        
        
        while (ph_userInput != "6")
        {
            Console.WriteLine("Pick and option:");
            Console.WriteLine("1. Create a new goal \n2. List goals \n3. Save goals \n4. Load goals \n5. Record Event \n6. Quit");
            ph_userInput = Console.ReadLine();
            
            if (ph_userInput == "1")
            {
                Console.WriteLine("New Goal");
            }
            else if (ph_userInput == "2")
            {
                Console.WriteLine("List Goals");
            }
            else if (ph_userInput == "3")
            {
                Console.WriteLine("Save Goals");
            }
            else if (ph_userInput == "4")
            {
                Console.WriteLine("Load Goals");
            }
            else if (ph_userInput == "5")
            {
                Console.WriteLine("Record event");
            }
            else if (ph_userInput == "6")
            {
                break;
            }
        }
        
    }
}