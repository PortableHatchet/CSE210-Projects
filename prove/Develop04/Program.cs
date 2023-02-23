//Porter Hatch
//Feb 23 2023

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");
        int ph_userInput = -1;
        
        while (ph_userInput != 4) 
        {
            Console.WriteLine("Please choose an activity to do:");
            Console.WriteLine("1. Breathing Activity \n2. Reflecting Activity\n3. Listing Activity\n4. Quit");
            
            ph_userInput = Convert.ToInt32(Console.ReadLine());
            if (ph_userInput == 1)
            {
                BreathingActivity newBreath = new BreathingActivity("Porter Hatch", "this is a description", "30");
                newBreath.GetActiveName();
                newBreath.GetActiveDesc();
                newBreath.GetActiveTime();
                newBreath.RunBreath(30);
            }
            else if (ph_userInput == 2)
            {
                //Reflection Activity
                ReflectActivity newReflect = new ReflectActivity("Porter Hatch", "this is a description", "30");
                newReflect.GetActiveName();
                newReflect.GetActiveDesc();
                newReflect.GetActiveTime();
                newReflect.RunReflect(30);
            }
            else if (ph_userInput == 3)
            {
                //Listing Activity
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