//Porter Hatch
//Feb 23 2023

using System;

public class ReflectActivity : Activity
{
    private static readonly string[] ph_ponderList = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
        };
    private static readonly string[] ph_reflectList = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
        };

    //Constructor for ReflectActivity
    public ReflectActivity(string name, string description, string duration) : base(name, description, duration)
    {}
    
    // Runs the reflecting activity. 
    // Asks a random question and then follow up questions to ponder every 10 seconds until the alotted time is finished
    public void RunReflect(int time)
    {
        Random ph_rand = new Random();

        Console.WriteLine("Welcome to the Reflecting Activity.");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        int ph_ponderQuestion = ph_rand.Next(0, ph_ponderList.Length);
        Console.WriteLine(ph_ponderList[ph_ponderQuestion]);

        DateTime ph_startTime = DateTime.Now;
        DateTime ph_futureTime = ph_startTime.AddSeconds(time);
        
        

        while (true)
        {
            DateTime ph_currentTime = DateTime.Now;

            if (ph_currentTime >= ph_futureTime)
            {
                break;
            }
            int r_question = ph_rand.Next(0, ph_reflectList.Length);
            Console.WriteLine(ph_reflectList[r_question]);
            Thread.Sleep(10000);
        }
    }
}