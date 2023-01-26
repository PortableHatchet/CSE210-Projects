// Porter Hatch 
// Jan 24 2023

using System;
public class Entry
    {
        public string phDate = "";
        public string phEntry = "";

        public void GetUserInput()
        {
        Console.Write("Enter date mm/dd/yyyy: ");
        phDate = Console.ReadLine();

        string newPrompt = Prompt.getPrompt();
        Console.Write(newPrompt);
        phEntry = Console.ReadLine();
        }
    }
