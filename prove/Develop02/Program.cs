// Porter Hatch 
// Jan 19 2023
// Journal Program

using System;

class Program
{   
    static void Main(string[] args)
    {

        int phMenuInput = -1;
        while (phMenuInput != 0)
        {
            Console.WriteLine("Welcome to your Journal. Please pick an option");
            Console.WriteLine("{0}\n{1}\n{2}\n{3}", 
            "0. Quit.",
            "1. Create a new journal entry.",
            "2. View journal entries.",
            "3. Save journal entry.");
            
            phMenuInput = int.Parse(Console.ReadLine());
            if (phMenuInput == 1)
            {
                
                Entry phEntry1 = new Entry();
                phEntry1.GetUserInput();
                Console.WriteLine(phEntry1.phDate);
                Console.WriteLine(phEntry1.phEntry);
            }
            else if (phMenuInput == 2)
            {
                Journal journal1 = new Journal();
            }
            
            
        }

    }
}
