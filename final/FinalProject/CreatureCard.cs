public class CreatureCard : Card
{
    private static readonly string[] creatureHealth = {
        "Wolf, 2",
        "Giant Spider, 2"
    };

    private int _phHealth;

    public CreatureCard(string name, string description, int damage, int health) 
        : base(name, description, damage)
    {
    _phHealth = health;
    }
}