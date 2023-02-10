using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string ph_userBook;
        string ph_userChapter;
        string ph_userVerses;
        public List<List<string>> ph_referenceList;

        Console.WriteLine("Welcome to scripture memorizer");
        Console.WriteLine("Please enter a scrpture you would like to memorize.");
        
        Console.WriteLine("What book is the scripture in? ");
        ph_userBook = Console.ReadLine();

        Console.WriteLine($"What is the chapter in {ph_userBook}?");
        ph_userChapter = Console.ReadLine();
       
        Console.WriteLine("What is the verse(s)? ");
        ph_userVerses = Console.ReadLine();
        
        Console.WriteLine("Please type out the specified verse(s)");
        string ph_scripture = Console.ReadLine();
        
        //Scripture ph_newScripture = new Scripture(ph_newReference, ph_scripture);
        
        List <string> words = new List<string>(ph_scripture.Split(' '));
        
        foreach (string word in words) 
        {
            Word ph_scriptureWord = new Word(word);
            //Console.WriteLine(ph_scriptureWord.getValue());
        }
    }
    
}