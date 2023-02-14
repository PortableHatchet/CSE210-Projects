// Porter Hatch
// Feb 8 2023

using System; 
using System.IO;

// takes word nd sets hideWord() as false
public class Word
{
    private string ph_word;
    bool hideword;
    public Word()
    {
        ph_word= "";
        hideword = false;
    }
    public Word(string word)
    {
        ph_word = word;
        hideword = false;
    }
    // sets hideWord() as true which will turn the word into '*****'
    public void hideWord()
    {
        hideword = true;
    }
    public void showWord()
    {
        hideword = false;
    }
    public string toString(){
        if (hideword)
        {
            return "******";
        }
        else 
        {
            return ph_word;
        }
    }
}