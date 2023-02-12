//Porter Hatch 
//Feb 8 2023

using System;
using System.IO;
using System.Text;
public class Scripture
{
    // A list to hold the scritpure that can be displayed
    private List<string> ph_refScripture = new List<string>();
    private string ph_scripture = "";

    public Scripture(List<string> reference, string verse) 
    {
        ph_refScripture = reference;
        ph_scripture = verse;
    }
    public void writer(List<string> reference, string verse)
        {
            using (StreamWriter writer = new StreamWriter("scriptures.csv", true))
            {
                writer.WriteLine(string.Join(",", reference) + "," + verse);
            }    
            
        }
    public void reader()
        {
            using (StreamReader reader = new StreamReader("scriptures.csv"))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    //List<string> row = new List<string>(line.Split(','));
                    ph_refScripture.Add(line);
                    //ph_scripture.Add(row[3]);
                }
                foreach (string line in ph_refScripture)
                    Console.WriteLine(line);
            }
            
            
        }

    
}
