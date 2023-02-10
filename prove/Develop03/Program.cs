using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to scripture memorizer");

        
        Console.WriteLine("Please type out the specified verse(s)");
        string ph_scripture = Console.ReadLine();
        
        List<List<string>> ph_referenceList = new List<List<string>>();
        
        List <string> words = new List<string>(ph_scripture.Split(' '));
        
        foreach (string word in words) {
            
            Word ph_scriptureWord = new Word(word);
        

            Console.WriteLine(ph_scriptureWord.getValue());
         }
    }
}