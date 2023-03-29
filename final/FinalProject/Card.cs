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
    public virtual void DealDamage(int target, int damage)
    {  
        int newPlayerHealth;
        int newCreatureHealth;
        if (target == 1)
        {
            newPlayerHealth = target - damage;
        }
        else if (target == 2)
        {
            newCreatureHealth = target - damage;
        }
    }
    public static List<string[]> ReadCards()
    {
        List<string[]> cardDeck = new List<string[]>();
        using (StreamReader reader = new StreamReader("cards.csv"))
        {
             while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(",");
                    string type = values[0].ToString();

                    cardDeck.Add(values);
                }
        }
        return cardDeck;
    }
}