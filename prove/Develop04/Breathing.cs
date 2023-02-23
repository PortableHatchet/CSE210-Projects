using System;

public class BreathingActivity : Activity
{
    private int ph_time;
    public BreathingActivity(string name, string description, string duration) : base(name, description, duration)
    {}

    public int GetTime(string duration)
    {
        ph_time = Convert.ToInt32(duration);
        return ph_time;
    }
    public void RunBreath(int duration)
    {
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);

        while (true)
        {
            
            Console.WriteLine("Breath in ....");

            Thread.Sleep(5000);
            DateTime currentTime = DateTime.Now;

            if (currentTime >= futureTime)
            {
                break;
            }

            Console.WriteLine("Breath out ....");
            Thread.Sleep(5000);
        }
    }
    
}