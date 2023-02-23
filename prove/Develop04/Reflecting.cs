using System;

public class ReflectActivity : Activity
{
    private static readonly string[] ponderList = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
        };
    private static readonly string[] reflectList = {
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

    public ReflectActivity(string name, string description, string duration) : base(name, description, duration)
    {}

    public void RunReflect(int time)
    {
        Random rand = new Random();

        Console.WriteLine("Welcome to the Reflecting Activity.");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        int p_question = rand.Next(0, ponderList.Length);
        Console.WriteLine(ponderList[p_question]);

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(time);
        
        

        while (true)
        {
            DateTime currentTime = DateTime.Now;

            if (currentTime >= futureTime)
            {
                break;
            }
            int r_question = rand.Next(0, reflectList.Length);
            Console.WriteLine(reflectList[r_question]);
            Thread.Sleep(10000);
        }
    }
}