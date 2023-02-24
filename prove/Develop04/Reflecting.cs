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
    public void RunReflect() 
    {
        int ph_time = GetTime(GetActiveTime());
        //RandomPrompt ph_rand = new RandomPrompt();

        Console.WriteLine($"Welcome to the {GetActiveName()}.");
        Console.WriteLine(GetActiveDesc());
        Console.WriteLine("");
        DisplayAnimation(5);
        GetPrompt(ph_ponderList);
        Console.WriteLine("");
        DisplayAnimation(5);

        DateTime ph_startTime = DateTime.Now;
        DateTime ph_futureTime = ph_startTime.AddSeconds(ph_time);
        while (true)
        {
            DateTime ph_currentTime = DateTime.Now;

            if (ph_currentTime >= ph_futureTime)
            {
                break;
            }
    
            GetPrompt(ph_reflectList);
            Console.WriteLine("");
            DisplayAnimation(5);
        }
        Console.WriteLine("");
        Console.WriteLine($"You completed {ph_time} seconds of the {GetActiveName()}.");
        Console.WriteLine("");
    }
}