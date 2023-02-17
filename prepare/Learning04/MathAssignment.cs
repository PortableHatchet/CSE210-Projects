using System;

public class MathAssignment : Assignment
{
    private string ph_textbookSection;
    private string ph_problems;

    public MathAssignment(string name, string topic, string section, string problems)
        : base(name, topic)
    {
        ph_textbookSection = section;
        ph_problems = problems;
    }

    public string getHomeworkList()
    {
        return $"Section {ph_textbookSection} Problems {ph_problems}";
    }
}