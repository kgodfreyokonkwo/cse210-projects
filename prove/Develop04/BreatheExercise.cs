using System;
using System.Collections.Generic;

public class BreatheExercise : Exercise
{
    public BreatheExercise()
    {
        
    }
    public BreatheExercise(string activityName, string activityDescription, 
    int intendedDuration, string endingText) : base(activityName, activityDescription, endingText, intendedDuration)
    {

        
    }

    public string StartBreathExercise(int intendedDuration)
    {
        DateTime currentTime = DateTime.Now;
        
        DateTime futureTime = currentTime.AddSeconds(intendedDuration);
        pauseExercise();
        
        int countB = 0;
        while (DateTime.Now < futureTime)
        {
            DisplayAnimation();
            Console.WriteLine();
            Console.WriteLine("Breathe in..");
            Console.WriteLine();
            Thread.Sleep(1000);       

            DisplayAnimation();
            Console.WriteLine();
            Console.WriteLine("Now breathe out.." );
            Console.WriteLine();
            Thread.Sleep(1000);

            countB = countB + 2;

        }
        Console.WriteLine(ConclusionMsg());
        Console.Write($"You completed this Breathing exercise {countB} times in {intendedDuration} seconds. ");
        return Console.ReadLine();
        
    }
}