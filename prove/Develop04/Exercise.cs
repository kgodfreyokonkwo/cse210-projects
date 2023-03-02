using System;
using System.Collections.Generic;


public class Exercise 
{
    //Declare the variables and attributes for this class
    //use access modifiers to restrict access to these
    private string _activityName = "";
    private string _activityDescription = "";
    private int _intendedDuration;
    private string _endingText = "";


    //Constructor
    public Exercise()
    {

    }

    //Constructor
    public Exercise(string activityName, string activityDescription, string endingText, int intendedDuration)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
        _endingText = endingText;
        _intendedDuration = intendedDuration;

    }

    //declare the setters and getter for the _activityName string
    public string GetName()
    {
        return _activityName;
    }
    public void SetName(string activityName)
    {
        _activityName = activityName;
    }

    //declare the setters and getters for the _activitydescription string
    public string GetDescription()
    {
        return _activityDescription;
    }
    public void SetDescription(string activityDescription)
    {
        _activityDescription = activityDescription;
    }

    //declare the setter and getter for the _intendedDuration int
    public int GetIntendedDuration()
    {
        return _intendedDuration;
    }

    public void SetIntendedDuration(int intendedDuration)
    {
        _intendedDuration = intendedDuration;
    }

    //declare the setter and getter for the _endingText string
    public string GetEndingText()
    {
        return _endingText;
    }
    public void SetEndingText(string endingText)
    {
        _endingText = endingText;
    }


    //Method for the welcome message
    public string WelcomeMsgInstruction()
    {
        return $"Welcome to the {_activityName}. \n{_activityDescription}. Clear your mind and focus on your {_activityName} \n";
    }
    
   
    //Method for the farewell message after each exercise
    public string ConclusionMsg()
    {
        return $"\nYou have completed the {_activityName}. {_endingText}. ";
    }
  

    //Metjhod to pause exercise when needed
    public void pauseExercise()
    {
        Console.WriteLine("Get ready.");
        Thread.Sleep(500);
        Console.WriteLine();

    }

    //Count down timer method
    public void CountDownTimer()
    {
        
        for (int i = 10; i < 1; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            if (i > 9)
            {
                Console.Write("\b\b \b\b");
                
            }Console.Write("\b \b");
            
        }
        
    }
    //Display animation method
    public void DisplayAnimation()
    {
        List<string> animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");

        foreach (string symbol in animationString)
        {
            Console.Write(symbol);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }


}