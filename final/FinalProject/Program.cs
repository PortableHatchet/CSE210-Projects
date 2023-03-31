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
                string type = card[0];

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
                switch (type)
                {
                    case "C":
                        playerDeck.Add(new CreatureCard(type, name, description, costInt, damageInt, healthInt));
                        break;
                    case "S":
                        playerDeck.Add(new SpellCard(type, name, description, costInt, damageInt));
                        break;
                    case "E":
                        playerDeck.Add(new EnhancementCard(type, name, description, costInt, damageInt));
                        break;
                    default:
                        throw new ArgumentException($"Unknown card type: {type}");
                }
            }
        }
        string phUserInput = "0"; 
        
        while (phUserInput != "3")
        {
        Console.WriteLine("Welcome to Battle Arena!");
        Console.WriteLine("Would you like to:\n1. Start a game?\n2. Read through the cards?\n3. Quit");
            phUserInput =Console.ReadLine();
            if (phUserInput == "1")
            {        
                List<Card> oppCreatureOnBoard = new List<Card>();
                List<Card> creatureOnBoard = new List<Card>();

                List<Card> playerHand = new List<Card>();
                Random rng = new Random();

                bool gameLoop = true;
                int playerHealth = 10;
                int cpuHealth = 10;
                int mana = 1;

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

                while (gameLoop)
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

                    Console.WriteLine("What card would you like to play?");
                    int playIndex = Convert.ToInt32(Console.ReadLine());
                    Card playCard = playerHand[playIndex];
                    string cardType = playCard.GetCardType();
                    if (cardType == "C")
                    {
                        creatureOnBoard.Add(playCard);
                    }
                    else
                    {
                        cpuHealth = playCard.DealDamage(cpuHealth, playCard.GetDamage());
                    }
                    
                    playCard.PlayCard(playCard.GetCost(), mana, playerHand, playIndex);

                    int index = rng.Next(playerDeck.Count);
                    Card item = playerDeck[index];
                    playerHand.Add(item);
                    playerDeck.RemoveAt(index);
                    mana++;
                    if (playerHealth <= 0)
                    {
                        Console.WriteLine("Sorry you lost!");
                        Console.WriteLine();

                        gameLoop = false;
                    }
                    else if (cpuHealth <= 0)
                    {
                        Console.WriteLine("Congratulations you won!");
                        Console.WriteLine();
                        gameLoop = false;
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