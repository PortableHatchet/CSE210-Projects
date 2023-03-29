using System;

class Program
{
    static void Main(string[] args)
    {
        List<string[]> readCards = new List<string[]>();
        List<Card> playerDeck = new List<Card>();

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
                        readCards = Card.ReadCards();
                        foreach (string[] cardArray in readCards)
                        {    
                            foreach (string cardString in cardArray)
                            {
                                char cardType = cardString[0];

                                char name = cardString[1];
                                string nameString = name.ToString();

                                char description = cardString[2];
                                string descriptionString = description.ToString();

                                char cost = cardString[3];
                                int costInt = Convert.ToInt32(cost);

                                char damage = cardString[4];
                                int damageInt = Convert.ToInt32(damage);

                                char health = cardString[5];
                                int healthInt = Convert.ToInt32(health);

                                switch (cardType)
                                {
                                    case 'c':
                                        playerDeck.Add(new CreatureCard(nameString, descriptionString, costInt, damageInt, healthInt));
                                        break;
                                    case 's':
                                        playerDeck.Add(new SpellCard(nameString, descriptionString, costInt, damageInt));
                                        break;
                                    case 'e':
                                        playerDeck.Add(new EnhancementCard(nameString, descriptionString, costInt, damageInt));
                                        break;
                                    default:
                                        throw new ArgumentException($"Unknown card type: {cardType}");
                                }
                            }
                        }
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