public class Player
{
   public static void ShowHand(List<Card> playerHand)
   {
        int handListCount = 0;
        foreach (Card card in playerHand)
        {
            Console.WriteLine(handListCount + ". " + card.GetName() + " (" + card.GetDescription() + ") " + "Cost: " + card.GetCost() + " mana");
            handListCount++;
        }
   }
   public static void ShowBoard(List<Card> creatureOnBoard)
   {
        int handListCount = 0;
        foreach (Card card in creatureOnBoard)
        {
            Console.WriteLine(handListCount + ". " + card.GetName() + " Damage: " + card.GetDamage() + ") " + "Health: " + card.GetHealth());
            handListCount++;
        }
   }
   public static void PlayCard(int cost, int mana, List<Card> playerHand, int index)
    {
        if (cost <= mana)
        {
            playerHand.RemoveAt(index);
        }
        
    }
}