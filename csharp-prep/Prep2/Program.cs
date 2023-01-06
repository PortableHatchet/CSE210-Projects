// Porter Hatch 
// Jan 6 2022
// Practice
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string ph_grade = Console.ReadLine();
        int ph_grade_percentage = int.Parse(ph_grade);
        
        string ph_letter = "";

        if (ph_grade_percentage >= 90)
        {
            ph_letter = "A";
        }
        else if (ph_grade_percentage >= 80)
        {
            ph_letter = "B";
        }
        else if (ph_grade_percentage >= 70)
        {
            ph_letter = "C";
        }
        else if (ph_grade_percentage >= 60)
        {
            ph_letter = "D";
        }
        else 
        {
            ph_letter = "F";
        }
        Console.WriteLine($"Your grade is: {ph_letter}");

        if (ph_grade_percentage >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}