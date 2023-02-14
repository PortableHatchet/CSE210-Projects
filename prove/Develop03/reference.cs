// Porter Hatch
// Feb 8 2023

using System;
using System.IO;

//takes book, chapter, and verse and puts it in a list to be added eventually to the csv
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
    
}