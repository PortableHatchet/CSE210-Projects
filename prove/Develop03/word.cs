// Porter Hatch
// Feb 8 2023

using System; 

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
        
    }
    public string getValue() 
    {
        return ph_word;
    }
    public void hideWord()
    {
        hideword = true;
    }

    public void showWord()
    {
        hideword = false;
    }
    public string to_string(){
        if (hideword)
        {
            return ph_word;
        }else {
            return "******";
        }
    }
}