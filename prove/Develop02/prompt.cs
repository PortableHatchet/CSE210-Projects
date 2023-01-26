
public class Prompt
{
    private static readonly string[] promptList = {
            "How was your day today? ", 
            "What was the most interesting interaction you had today? ",
            "What is something new that you learned today? ", 
            "What opportunities did you take to serve other today? ",
            "What is something that happened today that made you feel grateful? "
            };
            
    public static string getPrompt()
    {
        Random rand = new Random();
        int prompt = rand.Next(0, promptList.Length);
        return promptList[prompt];
    }
}
