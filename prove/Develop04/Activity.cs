//Porter Hatch
//Feb 23 2023

using System;

public class Activity
{
    private string ph_name;
    private string ph_description;
    private string ph_duration;
    private int ph_time;

    // Constructor for Activities
    public Activity(string name, string description, string duration)
    {
        ph_name = name;
        ph_description = description;
        ph_duration = duration;
    }
    //Parses the duration into an integer for the time parameter in the other activity methods
    public int GetTime(string duration)
    {
        ph_time = Convert.ToInt32(duration);
        return ph_time;
    }
    // Gets the activity name to be printed in the terminal
    public string GetActiveName()
    {
        return ph_name;
    }

    // Gets the activity description to be printed in the terminal

    public string GetActiveDesc()
    {
        return ph_description;
    }

    // Gets the activity  to be printed in the terminal

    public string GetActiveTime()
    {
        return ph_duration;
    }
    public void DisplayAnimation(int time)
    {
        DateTime ph_currentTime = DateTime.Now;
        DateTime ph_startTime = DateTime.Now;
        DateTime ph_futureTime = ph_startTime.AddSeconds(time);
        while (ph_currentTime < ph_futureTime)
        {
            ph_currentTime = DateTime.Now;
            
            Console.Write("");
            Thread.Sleep(250);
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("-"); // Replace it with the - character
            Thread.Sleep(250);
            Console.Write(">");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\b \b");
            Console.Write("\b \b");
            Console.Write("\b \b"); // Erase the + character
        }
    }
    public void GetPrompt(string[] list)
    {
        Random ph_rand = new Random();
        int ph_question = ph_rand.Next(0, list.Length);
        Console.WriteLine(list[ph_question]);
    }

}