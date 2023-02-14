using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string ph_userBook;
        string ph_userChapter;
        string ph_userVerses;
        //List<Reference> ph_referenceList = new List<Reference>();
        List<string> ph_strRefList = new List<string>();
        string ph_scripture = "";
        string menuInput = "0";

        // Intro to the program 
        Console.WriteLine("Welcome to scripture memorizer");
        Console.WriteLine("Would you like to:");
        Console.WriteLine("1. Enter a new scripture to memorize?");
        Console.WriteLine("2. Load a previously entered scripture");
        menuInput = Console.ReadLine();
        // Process for entering a new scripture to memprize 
        if (menuInput == "1") 
        {
            Console.WriteLine("Please enter a scrpture you would like to memorize.");
            
            Console.WriteLine("What book is the scripture in? ");
            ph_userBook = Console.ReadLine();

            Console.WriteLine($"What is the chapter in {ph_userBook}?");
            ph_userChapter = Console.ReadLine();
        
            Console.WriteLine("What is the verse(s)? ");
            ph_userVerses = Console.ReadLine();

            Reference newReference = new Reference(ph_userBook, ph_userChapter, ph_userVerses);
            ph_strRefList.Add(ph_userBook);
            ph_strRefList.Add(ph_userChapter);
            ph_strRefList.Add(ph_userVerses);

            Console.WriteLine("Please type out the specified verse(s)");
            ph_scripture = Console.ReadLine();
            
            List<Scripture> scriptureList = new List<Scripture>();
            Scripture ph_newScripture = new Scripture(ph_strRefList, ph_scripture);
            scriptureList.Add(ph_newScripture);
            
            ph_newScripture.writer(ph_strRefList, ph_scripture); 
            
            List <string> words = new List<string>(ph_scripture.Split(' '));
            List<Word> wordObjects = new List<Word>();

            foreach (string word in words)
            {
                Word w = new Word(word);
                wordObjects.Add(w);
            }
            
            string userInput = "";
            // While loop that hides a word 
            while (userInput != "quit")
            {
            
                foreach (Word w in wordObjects)
                {
                    Console.Write($"{w.toString()} ");
                }
                Random rand = new Random();
                int randomIndex = rand.Next(0, words.Count);
                randomIndex = rand.Next(0, words.Count);
                Word randomWord = wordObjects[randomIndex];
                randomWord.hideWord();
                Console.WriteLine("Press ENTER to continue, type 'quit' to exit the program. ");
                userInput = Console.ReadLine();
            }
        }
        // Pick a scripture that is saved to a csv
        else if (menuInput == "2")
        {
            Console.WriteLine("Which scripture would you like to memorize?");
            List<Scripture> ph_scriptureList = new List<Scripture>();
            Scripture ph_newScripture = new Scripture(ph_strRefList, ph_scripture);
            
            string ph_scriptureSplit = ph_newScripture.reader();

            
            List<string> words = new List<string>(ph_scriptureSplit.Split(','));
            
            
            foreach (string word in words) 
            {
                Word ph_scriptureWord = new Word(word);
                
            }
            
            string userInput = "";
            // loop that hides a word from loaded scripture 
            while (userInput != "quit")
            {
                foreach (string word in words)
                {
                    Console.Write($"{word}");
                }
                Console.WriteLine("Press ENTER to continue or type 'quit' to exit the program");
                userInput = Console.ReadLine();
            }
        }       
        
    }
    
}