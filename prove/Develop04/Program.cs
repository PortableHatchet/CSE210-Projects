//Porter Hatch
//Feb 23 2023

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");
        
        string timeInput = "0";
        int ph_userInput = -1;
        
        while (ph_userInput != 4) 
        {
            Console.WriteLine("Please choose an activity to do:");
            Console.WriteLine("1. Breathing Activity \n2. Reflecting Activity\n3. Listing Activity\n4. Quit");
            
            ph_userInput = Convert.ToInt32(Console.ReadLine());
            if (ph_userInput == 1)
            {
                Console.WriteLine("How many seconds would you like to spend on this activity? ");
                timeInput = Console.ReadLine();
                
                BreathingActivity newBreath = new BreathingActivity("Breathing Activity",
                "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",
                timeInput);
                
                newBreath.RunBreath();
            }
            else if (ph_userInput == 2)
            {
                //Reflection Activity
                Console.WriteLine("How many seconds would you like to spend on this activity? ");
                timeInput = Console.ReadLine();

                ReflectActivity newReflect = new ReflectActivity("Reflect Activity", 
                "This activity will help you reflect on times in your life" +
                " when you have shown strength and resilience." + 
                "This will help you recognize the power you have and how you can use it in other aspects of your life.", 
                timeInput);

                newReflect.RunReflect();
            }
            else if (ph_userInput == 3)
            {
                //Listing Activity
                Console.WriteLine("How many seconds would you like to spend on this activity? ");
                timeInput = Console.ReadLine();
                
                ListingActivity newList = new ListingActivity("Listing Activity",
                "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 
                timeInput);
                
                newList.RunListing();
            }
            else if(ph_userInput == 4)
            {
                break;
            }
            else 
            {
                Console.WriteLine("Sorry that is an incorrect input");
            }
        }
        

    }
}