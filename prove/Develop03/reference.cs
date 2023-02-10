// Porter Hatch
// Feb 8 2023

using System;

public class Reference
{
    private string ph_book;
    private string ph_chapter;
    private string ph_verses;
    public Reference()
    {
        Console.WriteLine("Please enter a scrpture you would like to memorize.");

        Console.WriteLine("What book is the scripture in? ");
        ph_book = Console.ReadLine();
        
        Console.WriteLine($"What is the chapter in {ph_book}?");
        ph_chapter = Console.ReadLine();

        Console.WriteLine("What is the verse(s)? ");
        ph_verses = Console.ReadLine();

        List<string> ph_reference = new List<string>();
        ph_reference.Add(ph_book);
        ph_reference.Add(ph_chapter);
        ph_reference.Add(ph_verses);
    }
}