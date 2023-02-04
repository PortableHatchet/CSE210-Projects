// Porter Hatch 
// Jan 24 2023

using System;
using System.IO;
using System.Collections.Generic; 
public class Entry
    {
        public string ph_date = "";
        public string ph_entry = "";
        public string ph_newPrompt = "";

        public void GetUserInput()
        {
        Console.Write("Enter date mm/dd/yyyy: ");
        ph_date = Console.ReadLine();

        
        ph_newPrompt = Prompt.getPrompt();
        Console.WriteLine(ph_newPrompt);
        ph_entry = Console.ReadLine();
        }
    }
