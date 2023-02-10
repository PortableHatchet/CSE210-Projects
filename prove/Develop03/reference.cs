// Porter Hatch
// Feb 8 2023

using System;
using System.IO;


public class Reference
{
    private string ph_book;
    private string ph_chapter;
    private string ph_verses;

    private List<string> referenceList;
    
    public Reference(string book, string chapter, string verse)
    {
        ph_book = book;
        ph_chapter = chapter;
        ph_verses = verse;

        
    }
}