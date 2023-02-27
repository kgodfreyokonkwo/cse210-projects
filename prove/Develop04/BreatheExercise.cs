using System;
using System.Collections.Generic;

public class BreatheExercise : Exercise
{
    public BreatheExercise()
    {
        
    }
    //Constructor, showing inheritance of class members from the base class
    public BreatheExercise(string activityName, string activityDescription, 
    int intendedDuration, string endingText) : base(activityName, activityDescription, endingText, intendedDuration)
    {

        
    }

    //Method to initiate and terminate the breathe exercise
    public string StartBreathExercise(int intendedDuration)
    {
        DateTime currentTime = DateTime.Now;
        
        DateTime futureTime = currentTime.AddSeconds(intendedDuration);
        pauseExercise();
        Console.WriteLine("Hit enter ");
            
        int countB = 0;
        while (DateTime.Now < futureTime)
        {
            DisplayAnimation();
            Console.WriteLine("Breathe in..");
            Console.WriteLine();      

            DisplayAnimation();
            Console.WriteLine("Now breathe out.." );
            Console.WriteLine();

            countB = countB + 2;

        }
        Console.WriteLine(ConclusionMsg());
        Console.Write($"You completed this Breathing exercise {countB} times in {intendedDuration} seconds. ");
        return Console.ReadLine();
        
    }
}