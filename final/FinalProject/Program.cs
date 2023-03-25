using System;

class Program
{
    static void Main(string[] args)
    {
        List<string>
        string phUserInput = "0"; 
        
        while (phUserInput != "3")
        {
            Console.WriteLine("Welcome to Battle Arena!");
            Console.WriteLine("Would you like to:\n1. Start a game?\n2. Read through the cards?\n3. Quit");
            phUserInput = Console.ReadLine();
            if (phUserInput == "1")
            {
                
                
                bool continueLoop = true;
                while (continueLoop)
                {
                    int playerHealth = 10;
                    int cpuHealth = 10;
                    int mana = 1;
                    if (playerHealth <= 0)
                    {
                        continueLoop = false;
                    }
                    else if (cpuHealth <= 0)
                    {
                        continueLoop = false;
                    }
                    else
                    {
                        Console.ReadLine();
                        mana++;
                    }
                }

            }
            else if (phUserInput == "2")
            {
                using (StreamReader reader = new StreamReader("cards.csv"))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(",");
                    string type = values[0].ToString();

                    Console.Write(values[1] + " | ");
                    Console.Write(values[2] + " | ");
                    Console.Write("Cost: " + values[3] + " | ");
                    Console.Write("Damage: "+ values[4]);
                    if (type == "C")
                    {
                        Console.Write(" | Health: " + values[5]);
                    }
                    Console.WriteLine();
                }
            }
            else if (phUserInput == "3")
            {
                Console.WriteLine("see ya");
            }
            else 
            {
                Console.WriteLine("Sorry that is an incorrect input. Please pick a correct one.");
            }
        }
    }
}