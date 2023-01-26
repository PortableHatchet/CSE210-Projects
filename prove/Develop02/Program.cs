// Porter Hatch 
// Jan 19 2023
// Journal Program

using System;

class Program
{   
    static void Main(string[] args)
    {

        int menuInput = -1;
        while (menuInput != 0)
        {
            Console.WriteLine("Welcome to your Journal. Please pick an option");
            Console.WriteLine("{0}\n{1}\n{2}\n{3}", 
            "0. Quit.",
            "1. Create a new journal entry.",
            "2. View journal entries.",
            "3. Save journal entry.");
            
            menuInput = int.Parse(Console.ReadLine());
            if (menuInput == 1)
            {
                
                Entry entry1 = new Entry();
                entry1.GetUserInput();
                Console.WriteLine(entry1.date);
                Console.WriteLine(entry1.entry);
            }
            else if (menuInput == 2)
            {
                Journal journal1 = new Journal();
            }
            
            
        }

    }
}
