using System;

public class Activity
{
    private string ph_name;
    private string ph_description;
    private string ph_duration;
    private int ph_time;

    public Activity(string name, string description, string duration)
    {
        ph_name = name;
        ph_description = description;
        ph_duration = duration;
    }
    public int GetTime(string duration)
    {
        ph_time = Convert.ToInt32(duration);
        return ph_time;
    }
    public string GetActiveName()
    {
        return ph_name;
    }
    public string GetActiveDesc()
    {
        return ph_description;
    }
    public string GetActiveTime()
    {
        return ph_duration;
    }

}