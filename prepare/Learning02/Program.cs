//Porter Hatch 
//Jan 17 2023

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        
        Job job1 = new Job();
        job1.ph_company = "Microsoft";
        job1.ph_jobTitle = "Software Engineer";
        job1.ph_startYear = "2019";
        job1.ph_endYear = "2020";

        Console.WriteLine(job1.ph_company);
       
    }
}