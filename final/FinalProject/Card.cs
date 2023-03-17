public class Card 
{
    private string _phCardName;
    private string _phCardDescription;
    private int _phCardDamage;
    

    public Card(string name, string description, int damage)
    {
        _phCardName = name;
        _phCardDescription = description;
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
}