// Porter Hatch 
// Jan 24 2023
using System;
using System.IO;
using System.Collections.Generic; 

public class Journal 
    {
        public List<List<string>> ph_journalEntries {get; set;}
        public Journal()
        {
             ph_journalEntries = new List<List<string>>();
        }
        public void writer()
        {
            using (StreamWriter writer = new StreamWriter("journal.csv"))
            {
            foreach (List<string> row in ph_journalEntries)
                {
                    writer.WriteLine(string.Join(",", row));
                }
            }
        }
        public void reader()
        {
            using (StreamReader reader = new StreamReader("journal.csv"))
            {
                while (!reader.EndOfStream)
                {
                string line = reader.ReadLine();
                List<string> row = new List<string>(line.Split(','));
                ph_journalEntries.Add(row);
                }

            }
        }


       
       
    }