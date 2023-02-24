//Porter Hatch
//Feb 23 2023

using System;

public class BreathingActivity : Activity
{
    //Constructor for BreathingActivity
    public BreathingActivity(string name, string description, string duration) : base(name, description, duration)
    {}

    // Runs the breathing activity
    // Shows "breath in..." for 4 seconds then "breath out..." for 4 seconds until the alotted time is finished
    public void RunBreath()
    {
        int ph_time = GetTime(GetActiveTime());
        Console.WriteLine($"Welcome to the {GetActiveName()}");
        Console.WriteLine(GetActiveDesc());
        DisplayAnimation(3);

        DateTime ph_startTime = DateTime.Now;
        DateTime ph_futureTime = ph_startTime.AddSeconds(ph_time);

        while (true)
        {
            DateTime ph_currentTime = DateTime.Now;
            if (ph_currentTime >= ph_futureTime)
            {
                break;
            }
            Console.WriteLine("Breath in ....");
            DisplayAnimation(2);
            Console.WriteLine("Breath out ....");
            DisplayAnimation(2);
        }
        Console.WriteLine("");
        Console.WriteLine($"You have completed {ph_time} seconds of the {GetActiveName()}");
        Console.WriteLine("");
    }
    
}