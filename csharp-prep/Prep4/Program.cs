using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbersList = new List<int>();
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a list of numbers. Type 0 when finished. ");
            userNumber = int.Parse(Console.ReadLine());
            numbersList.Add(userNumber);
        }
        foreach (int item in numbersList)
        {
            Console.WriteLine(item);
        }
        int sum = 0;
        sum = numbersList.Sum();
        Console.WriteLine($"The sum is: {sum}");

        float average = 0;
        average = ((float)sum) / numbersList.Count;
        Console.WriteLine($"The average is: {average}");

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