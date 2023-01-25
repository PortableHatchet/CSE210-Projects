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
            string[] promptList = {
            "How was your day today", 
            "What was the most interesting interaction you had today?",
            "What is something new that you learned today?", 
            "What opportunities did you take to serve other today?",
            "What is something that happened today that made you feel grateful"
            };
            
            Random rand = new Random();
            int prompt = rand.Next(0, promptList.Length);
            
            Console.WriteLine("Welcome to your Journal. Please pick an option");
            Console.WriteLine("{0}\n{1}\n{2}\n{3}", 
            "0. Quit.",
            "1. Create a new journal entry.",
            "2. View journal entries.",
            "3. Save journal entry.");
            
            menuInput = int.Parse(Console.ReadLine());
            if (menuInput == 1)
            {
                Console.WriteLine(prompt);
                Entry entry1 = new Entry();
            }
            else if (menuInput == 2)
            {
                Journal journal1 = new Journal();
            }
            
            
        }

    }
}
