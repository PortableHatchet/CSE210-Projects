using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        int guess = -1;
        
        
        while (guess != magicNumber)
        {
            Console.WriteLine("What is the magic number? ");
            guess = int.Parse(Console.ReadLine());
            if (guess == magicNumber)
            {
                Console.WriteLine("Congratulations! You guessed it correctly.");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }
        }
    }
}