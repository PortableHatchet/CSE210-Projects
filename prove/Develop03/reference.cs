// Porter Hatch
// Feb 8 2023

using System;
using System.IO;


public class Reference
{
    private string ph_book;
    private string ph_chapter;
    private string ph_verse;


    public Reference()
    {
        ph_book = "";
        ph_chapter = "";
        ph_verse = "";
    }

    public Reference(string book, string chapter, string verse)
    {
        ph_book = book;
        ph_chapter = chapter;
        ph_verse = verse;
    }
    /*
    public string getBook()
    {
        return ph_book;
    }
    public string getChapter()
    {
        return ph_chapter;
    }
    public string getVerse()
    {
        return ph_verse;
    }
    */
}