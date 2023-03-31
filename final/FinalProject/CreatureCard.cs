public class CreatureCard : Card
{
    private int _phHealth;

    public CreatureCard(string type, string name, string description, int cost, int damage, int health) 
        : base(type, name, description, cost, damage)
    {
    _phHealth = health;
    }
}