public class CreatureCard : Card
{
    private int _phHealth;

    public CreatureCard(string name, string description, int damage, int health) 
        : base(name, description, damage)
    {
    _phHealth = health;
    }
}