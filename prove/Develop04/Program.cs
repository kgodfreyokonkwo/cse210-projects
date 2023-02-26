using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what is your first name? ");
        string first = Console.ReadLine();

        //provide customized response to user, asking for option selection
        Console.WriteLine();
        Console.WriteLine($"Hi {first}, You are welcome to your mindfuness exercising App ");
        Console.WriteLine();
        Console.WriteLine("Menu options");
        
        int userSelection = 0;
            
        //If user accepts to proceed, loop through options. only execute when user selects
        // 1,2,3,4, or 5.
        while (userSelection != 5)
        {
            Console.WriteLine("What would you want to do? Select options below 1-5. ");
            Console.WriteLine("1. Breathing Exercise");
            Console.WriteLine("2. Reflection Exercise");
            Console.WriteLine("3. Listing Exercise");
            Console.WriteLine("4. Fitness reporting Exercise");
            Console.WriteLine("5. Quit");
            Console.WriteLine();
                
            userSelection = int.Parse(Console.ReadLine());

            if (userSelection == 1)
            {
                BreatheExercise breathe1 = new BreatheExercise();
                breathe1.SetName("Breathing Exercise");
                breathe1.SetDescription("This activity will help you relax by walking you through breathing in and out");
                breathe1.SetEndingText("I hope the Breathing exercise helped you relax");
                
                Console.WriteLine(breathe1.WelcomeMsgInstruction());
                Console.Write("How Long in seconds will you like to do this exercise? ");

                int duration = int.Parse(Console.ReadLine());                
                Console.WriteLine(breathe1.StartBreathExercise(duration));
            }

            else if (userSelection == 2)
            {
                //display what is written in the journal
                ReflectionExercise reflect1 = new ReflectionExercise();
                reflect1.SetName("Reflection Exercise");
                reflect1.SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflect1.SetEndingText("I hope the Reflection exercise helped you focus");
                
                Console.WriteLine(reflect1.WelcomeMsgInstruction());
                Console.Write("How Long in seconds will you like to do this exercise? ");
                int duration = int.Parse(Console.ReadLine());  
                
                reflect1._firstPrompt.Add("Think of a time when you stood up for someone else ");
                reflect1._firstPrompt.Add("Think of a time when you did something really difficult ");
                reflect1._firstPrompt.Add("Think of a time when you helped someone in nee ");
                reflect1._firstPrompt.Add("Think of a time when you did something truly selfless ");

                reflect1.DisplayPrompt();       

                reflect1._followUpPrompt.Add("Why was this experience meaningful to you? ");
                reflect1._followUpPrompt.Add("Have you ever done anything like this before?");
                reflect1._followUpPrompt.Add("How did you get started? ");
                reflect1._followUpPrompt.Add("How did you feel when it was complete? ");

                Console.WriteLine(reflect1.StartReflectionExercise(duration));
   
            }

            else if (userSelection == 3)
            {
                //display what is written in the journal
                ListingExercise listing1 = new ListingExercise();
            }

            else if (userSelection == 4)
            {
                //display what is written in the journal
                FitnesExercise fitnes1 = new FitnesExercise();
            }
            else if (userSelection == 5)
            {
                //display what is written in the journal
                Console.WriteLine("Thank you for participating. I hope you enjoyed your experience? ");
                System.Environment.Exit(1);
            }
            Console.WriteLine("Invalid selection made. Please select from 1-5" );
            Console.WriteLine();
        }
        

        //exercise1.pauseExercise();
        //exercise1.DisplayAnimation();
        //Console.WriteLine(exercise1.ConclusionMsg());


    }
}
