using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to scripture memorizer");
        Console.WriteLine("Please enter a scrpture you would like to memorize.");
        string scripture = Console.ReadLine();

        List <string> words = new List<string>(scripture.Split(' '));
        
        foreach (string word in words) {
            Console.WriteLine(word);
         }
    }
}