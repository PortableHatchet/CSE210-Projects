using System;

public class WritingAssignment : Assignment
{
    private string ph_title;

    public WritingAssignment(string name, string topic, string title)
    : base(name, topic)
    {
        ph_title = title;
    }
    public string GetWritingInformation()
    {
        string studentName = GetStudentName();
        return $"{ph_title} by {studentName}";
    }

}