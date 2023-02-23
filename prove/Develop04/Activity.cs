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

}