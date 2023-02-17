using System;

class Program
{
    static void Main(string[] args)
    {
        //Assignment newAssign = new Assignment("Samuel Bennet", "Multiplication");
        //Console.WriteLine(newAssign.GetSummary());

        //MathAssignment newMA = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        //Console.WriteLine(newMA.GetSummary());
        //Console.WriteLine(newMA.getHomeworkList());

        WritingAssignment newWA = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(newWA.GetSummary());
        Console.WriteLine(newWA.GetWritingInformation());


    }
}