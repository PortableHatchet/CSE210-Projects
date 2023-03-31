using System;

class Program
{
    static void Main(string[] args)
    {
        List<List<string>> readCards = new List<List<string>>();

        List<Card> playerDeck = new List<Card>();

        readCards = Card.ReadCards();

        foreach (List<string> card in readCards)
        {   
            //foreach (string cardPart in card)
            {
                string cardType = card[0];

                string name = card[1];
                //string nameString = name.ToString();

                string description = card[2];
                //string descriptionString = description.ToString();

                string cost = card[3];
                int costInt = Convert.ToInt32(cost);

                string damage = card[4];
                int damageInt = Convert.ToInt32(damage);
                
                int healthInt = 0;
                if (card.Count >= 6)
                {
                    string health = card[5];
                    healthInt = Convert.ToInt32(health);
                }
                switch (cardType)
                {
                    case "C":
                        playerDeck.Add(new CreatureCard(name, description, costInt, damageInt, healthInt));
                        break;
                    case "S":
                        playerDeck.Add(new SpellCard(name, description, costInt, damageInt));
                        break;
                    case "E":
                        playerDeck.Add(new EnhancementCard(name, description, costInt, damageInt));
                        break;
                    default:
                        throw new ArgumentException($"Unknown card type: {cardType}");
                }
            }
        }
        string phUserInput = "0"; 
        
        while (phUserInput != "3")
        {
            Console.WriteLine("Welcome to Battle Arena!");
            Console.WriteLine("Would you like to:\n1. Start a game?\n2. Read through the cards?\n3. Quit");
            phUserInput = Console.ReadLine();
            if (phUserInput == "1")
            {        
                List<Card> oppCreatureOnBoard = new List<Card>();
                List<Card> creatureOnBoard = new List<Card>();

                List<Card> playerHand = new List<Card>();
                Random rng = new Random();

                int handCount = 0;
                while (playerDeck.Count > 0)
                {
                    int index = rng.Next(playerDeck.Count);
                    Card item = playerDeck[index];
                    playerHand.Add(item);
                    playerDeck.RemoveAt(index);
                    handCount++;
                    if (handCount == 4)
                    {
                        break;
                    }
                }

                bool gameLoop = true;
                int playerHealth = 10;
                int cpuHealth = 10;
                int mana = 1;
                while (gameLoop)
                {
                    
                    if (playerHealth <= 0)
                    {
                        gameLoop = false;
                    }
                    else if (cpuHealth <= 0)
                    {
                        gameLoop = false;
                    }
                    else
                    {
                        Console.WriteLine("Lifetotal: " + playerHealth);
                        Console.WriteLine("Opponent Lifetotal: " + cpuHealth);
                        Console.WriteLine("Mana: " + mana);
                        Console.WriteLine();
                        Console.WriteLine("Board: ");
                        Console.WriteLine("     Opponent: " + oppCreatureOnBoard);
                        Console.WriteLine("     Yours: " + creatureOnBoard);
                        Console.WriteLine("Cards in Hand: ");
                        Player.ShowHand(playerHand);
                    }
                    Console.ReadLine();
                    int index = rng.Next(playerDeck.Count);
                    Card item = playerDeck[index];
                    playerHand.Add(item);
                    playerDeck.RemoveAt(index);
                    mana++;
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