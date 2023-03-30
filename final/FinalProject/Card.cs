public class Card 
{
    private string _phCardName;
    private string _phCardDescription;
    private int _phCost;
    private int _phCardDamage;
    

    public Card(string name, string description, int cost, int damage)
    {
        _phCardName = name;
        _phCardDescription = description;
        _phCost = cost;
        _phCardDamage = damage;
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
        int newPlayerHealth = 0;
        int newCreatureHealth = 0;
        if (target == 1)
        {
            newPlayerHealth = target - damage;
            return newPlayerHealth;
        }
        else if (target == 2)
        {
            newCreatureHealth = target - damage;
            return newCreatureHealth;
        }
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
}