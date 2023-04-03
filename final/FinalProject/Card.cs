public class Card 
{
    private string _phCardType;
    private string _phCardName;
    private string _phCardDescription;
    private int _phCost;
    private int _phCardDamage;
    

    public Card(string type, string name, string description, int cost, int damage)
    {
        _phCardType = type;
        _phCardName = name;
        _phCardDescription = description;
        _phCost = cost;
        _phCardDamage = damage;
    }

    public string GetCardType()
    {
        return _phCardType;
    }
    public string GetName()
    {
        return _phCardName;
    }
    public string GetDescription()
    {
        return _phCardDescription;
    }
    public int GetCost()
    {
        return _phCost;
    }
    public int GetDamage()
    {
        return _phCardDamage;
    }
    public virtual int DealDamage(int target, int damage)
    {  
        int newCPUHealth;
        newCPUHealth = target - damage;
        return newCPUHealth;
    }
    public virtual int GetHealth()
    {
        return 0;
    }
    public static List<List<string>> ReadCards()
    {
        
        List<List<string>> cardDeck = new List<List<string>>();
        using (StreamReader reader = new StreamReader("cards.csv"))
        {
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                List<string> cardRow = line.Split(',').ToList();
                cardDeck.Add(cardRow);
            }
        }
        return cardDeck;
    }

    public virtual void PlayCard(int cost, int mana, List<Card> playerHand, int index)
    {
        if (cost <= mana)
        {
            playerHand.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("Sorry you do not have enough mana for that card");
        }
    }
}