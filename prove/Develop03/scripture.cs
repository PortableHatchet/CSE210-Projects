//Porter Hatch 
//Feb 8 2023

using System;
using System.IO;
public class Scripture
{
    // A list to hold the scritpure that can be displayed
    private List<List<string>> ph_scripture; // = new List<List<string>>();

    public Scripture(List<string> reference, List<string> verse) 
    {
        ph_scripture.Add(reference);
        ph_scripture.Add(verse);
        //ph_scripture.writer();

    }
    public void writer()
        {
            using (StreamWriter writer = new StreamWriter("scriptures.csv"))
            {
            foreach (List<string> row in ph_scripture)
                {
                    writer.WriteLine(string.Join(",", row));
                }
            }
        }

    
}
