public class Player
{
   public static void ShowHand(List<Card> playerHand)
   {
        int handListCount = 1;
        foreach (Card card in playerHand)
        {
            Console.WriteLine(handListCount + ". " + card.GetName() + " (" + card.GetDescription() + ") " + "Cost: " + card.GetCost() + " mana");
            handListCount++;
        }
   }
}