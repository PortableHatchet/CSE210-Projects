// Porter Hatch 
// Jan 19 2023
// Journal Program

using System;

class Program
{   
    static void Main(string[] args)
    {

        List<string> ph_entryList = new List<string>();

        int ph_menuInput = -1;
        while (ph_menuInput != 0)
        {
            Console.WriteLine("Welcome to your Journal. Please pick an option");
            Console.WriteLine("{0}\n{1}\n{2}\n{3}", 
            "0. Quit.",
            "1. Create a new journal entry.",
            "2. View journal entries.",
            "3. Save journal entry.");
            
            ph_menuInput = int.Parse(Console.ReadLine());
            if (ph_menuInput == 1)
            {
                List<string> add_entry = new List<string>();
                
                Entry ph_entry1 = new Entry();
                ph_entry1.GetUserInput();
                add_entry.Add(ph_entry1.ph_date);
                add_entry.Add(ph_entry1.ph_newPrompt);
                add_entry.Add(ph_entry1.ph_entry);

                
                ph_entryList.AddRange(add_entry);

            }
            else if (ph_menuInput == 2)
            {
                Journal journal1 = new Journal();
            }
            
            
        }

    }
}
