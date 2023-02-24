//Porter Hatch
//Feb 23 2023

using System;

public class ListingActivity : Activity
{
    private static readonly string[] ph_listingList = {
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"
    };
    public ListingActivity(string name, string description, string duration) : base(name, description, duration)
    {}

    public void RunListing()
    {
        int ph_time = GetTime(GetActiveTime());

        Console.WriteLine($"Welcome to the {GetActiveName()}");
        Console.WriteLine(GetActiveDesc());
        DisplayAnimation(4);

        Console.WriteLine("");
        GetPrompt(ph_listingList);
        Console.WriteLine("Take a few secons to ponder:");
        Console.WriteLine("");
        
        DisplayAnimation(5);
        DateTime ph_startTime = DateTime.Now;
        DateTime ph_futureTime = ph_startTime.AddSeconds(ph_time);
        
        DateTime ph_currentTime = DateTime.Now;
        
        while(ph_currentTime < ph_futureTime)
        {
            ph_currentTime = DateTime.Now;
            Console.ReadLine();
        }
        Console.WriteLine("");
        Console.WriteLine($"You just finished {ph_time} seconds of the {GetActiveName()}");
        Console.WriteLine("");
        
    }
    

}