using System;

public class Activity
{
    private string ph_name;
    private string ph_description;
    private string ph_duration;

    public Activity(string name, string description, string duration)
    {
        ph_name = name;
        ph_description = description;
        ph_duration = duration;
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