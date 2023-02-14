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
    //Writes the inputed scripture to a csv to be pulled from later
    public void writer(List<string> reference, string verse)
        {
            using (StreamWriter writer = new StreamWriter("scriptures.csv", true))
            {
                writer.WriteLine(string.Join(",", reference) + "," + verse);
            }      
        }

    //Reads a csv into a list to pick from in the main loop
    public string reader()
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
                int ph_number = 1;
                foreach (string line in ph_refScripture)
                {
                    Console.WriteLine($"{ph_number}. {line}");
                    ph_number++;
                }
                Console.WriteLine("Pick a scripture");
                string userInput = Console.ReadLine();
                int choice;
                int.TryParse(userInput, out choice);

                Console.WriteLine(ph_refScripture[choice - 1]);
                return ph_refScripture[choice - 1];
            }
            
        }

    
}
