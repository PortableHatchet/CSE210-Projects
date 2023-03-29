public class CreatureCard : Card
{
    private int _phHealth;

    public CreatureCard(string name, string description, int cost, int damage, int health) 
        : base(name, description, cost, damage)
    {
    _phHealth = health;
    }
}