using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a list for the userNumbers to go into 
        List<int> numbersList = new List<int>();
        int userNumber = -1;
        while (userNumber != 0)
        {
            // Add numbers to list
            Console.Write("Enter a list of numbers. Type 0 when finished. ");
            userNumber = int.Parse(Console.ReadLine());
            numbersList.Add(userNumber);
        }
        foreach (int item in numbersList)
        {
            Console.WriteLine(item);
        }
        // Sum the numbers
        int sum = 0;
        sum = numbersList.Sum();
        Console.WriteLine($"The sum is: {sum}");

        // Average the numbers in the list
        float average = 0;
        average = ((float)sum) / numbersList.Count;
        Console.WriteLine($"The average is: {average}");

        // Find largest number in the list
        int largestNum = numbersList[0];
        foreach (int number in numbersList)
        {
            if (number > largestNum)
            {
                largestNum = number;
            }
        }
        Console.WriteLine($"The largest number is: {largestNum}");
    }
  
        

        
}