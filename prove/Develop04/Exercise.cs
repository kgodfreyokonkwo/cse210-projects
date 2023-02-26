using System;
using System.Collections.Generic;


public class Exercise 
{
    private string _activityName = "";
    private string _activityDescription = "";
    private int _intendedDuration;
    private string _endingText = "";



    public Exercise()
    {

    }

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


    public string WelcomeMsgInstruction()
    {
        return $"Welcome to the {_activityName}. \n{_activityDescription}. Clear your mind and focus on your {_activityName}";
    }
    public string ConclusionMsg()
    {
        return $"You have completed the {_activityName}. {_endingText}. ";
    }
  


    public void pauseExercise()
    {
        Console.WriteLine("Get ready.");
        Thread.Sleep(5000);
        Console.WriteLine();

    }

    public decimal CountDownTimer()
    {
        return 0;
    }
    public void DisplayAnimation()
    {

        for (int i = 0; i < 10; i++)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
        
    }



	
}