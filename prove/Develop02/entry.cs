// Porter Hatch 
// Jan 24 2023

using System;
public class Entry
    {
        public string date = "";
        public string entry = "";

        public void GetUserInput()
        {
        Console.Write("Enter date mm/dd/yyyy: ");
        date = Console.ReadLine();

        string newPrompt = Prompt.getPrompt();
        Console.Write(newPrompt);
        entry = Console.ReadLine();
        }
    }