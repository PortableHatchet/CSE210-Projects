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

    public void RunListing(int time)
    {
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        //RandomPrompt ph_newPrompt = new RandomPrompt();
        GetPrompt(ph_listingList);
        Console.WriteLine("");
        Console.WriteLine("Take a few secons to ponder:");
        DisplayAnimation(5);
        DateTime ph_startTime = DateTime.Now;
        DateTime ph_futureTime = ph_startTime.AddSeconds(time);
        
        DateTime ph_currentTime = DateTime.Now;
        
        while(ph_currentTime < ph_futureTime)
        {
            ph_currentTime = DateTime.Now;
            Console.ReadLine();
        }
        Console.WriteLine($"You just finished {time} seconds of the Listing Activity");
        DisplayAnimation(5);
    }
    

}