using System;

class Program
{
    static void Main(string[] args)
    {
        // Set up player names
        string player1 = "Player 1";
        string player2 = "Player 2";

        // Set up player health
        int player1Health = 20;
        int player2Health = 20;

        // Set up player hands
        string[] player1Hand = { "Card 1", "Card 2", "Card 3" };
        string[] player2Hand = { "Card 1", "Card 2", "Card 3" };

        // Set up player boards
        string[] player1Board = new string[5];
        string[] player2Board = new string[5];

        // Display initial game state
        Console.WriteLine($"{player1}'s Health: {player1Health}");
        Console.WriteLine($"Hand: {string.Join(", ", player1Hand)}");
        Console.WriteLine("Board:");
        Console.WriteLine(string.Join(" | ", player1Board));
        Console.WriteLine();
        Console.WriteLine($"{player2}'s Health: {player2Health}");
        Console.WriteLine($"Hand: {string.Join(", ", player2Hand)}");
        Console.WriteLine("Board:");
        Console.WriteLine(string.Join(" | ", player2Board));

        // Wait for user input
        Console.ReadLine();
    }
}