using System;

public class BreathingActivity : Activity
{
    private string countdownMessage;
    public BreathingActivity(string ph_message, string name, string description, string duration) : base(name, description, duration)
    {
        countdownMessage = ph_message; 
    }
    public string GetMessage()
    {
        return countdownMessage;
    }
}