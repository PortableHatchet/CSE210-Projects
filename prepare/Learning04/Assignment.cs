using System;

public class Assignment
{
    private string ph_studentName;
    private string ph_topic;
    public Assignment(string name, string topic)
    {
        ph_studentName = name;
        ph_topic = topic;
    }
    public string GetSummary()
    {
        return ph_studentName + " - " + ph_topic;
    }
    public string GetStudentName()
    {
        return ph_studentName;
    }
}