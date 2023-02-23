//Porter Hatch
//Feb 23 2023

using System;

public class BreathingActivity : Activity
{
    //Constructor for BreathingActivity
    public BreathingActivity(string name, string description, string duration) : base(name, description, duration)
    {}

    // Runs the breathing activity
    // Shows "breath in..." for 5 seconds then "breath out..." for 5 seconds until the alotted time is finished
    public void RunBreath(int time)
    {
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        
        DateTime ph_startTime = DateTime.Now;
        DateTime ph_futureTime = ph_startTime.AddSeconds(time);

        while (true)
        {
            
            Console.WriteLine("Breath in ....");

            Thread.Sleep(5000);
            DateTime ph_currentTime = DateTime.Now;

            if (ph_currentTime >= ph_futureTime)
            {
                break;
            }

            Console.WriteLine("Breath out ....");
            Thread.Sleep(5000);
        }
    }
    
}