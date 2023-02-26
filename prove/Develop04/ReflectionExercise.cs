using System;
using System.Collections.Generic;

public class ReflectionExercise : Exercise
{
    // questions that would serve as prompts, and eventually stored as a list to prompt responses from user
    private string _prompt1 = "";
    private string _prompt2 = "";
    private string _prompt3 = "";
    private string _prompt4 = "";
    private string _followUpPrompt1 = "";
    private string _followUpPrompt2 = "";
    private string _followUpPrompt3 = "";
    private string _followUpPrompt4 = "";


    // creat a list of questions called _questions
    public List<string> _firstPrompt = new List<string>();
    public List<string> _followUpPrompt = new List<string>();


    // Select and display a random prompt question
    public ReflectionExercise()
    {

    }
    public ReflectionExercise(string activityName, string activityDescription, 
    int intendedDuration, string endingText, string prompt1, string prompt2, string prompt3, string prompt4, 
    string followUpPrompt1, string followUpPrompt2, string followUpPrompt3, string followUpPrompt4) : base(activityName, activityDescription, endingText, intendedDuration)
    {
        _prompt1 = prompt1;
        _prompt2 = prompt2;
        _prompt3 = prompt3;
        _prompt4 = prompt4;
        _followUpPrompt1 = followUpPrompt1;
        _followUpPrompt2 = followUpPrompt2;
        _followUpPrompt3 = followUpPrompt3;
        _followUpPrompt4 = followUpPrompt4;
    }
    public void DisplayPrompt()
    {
        var random = new Random();
        Console.WriteLine(_firstPrompt[random.Next(_firstPrompt.Count)]);
    }
    public void DisplayFollowUpPrompt()
    {
        var random = new Random();
        Console.WriteLine(_followUpPrompt[random.Next(_followUpPrompt.Count)]);
    }
    
    public string StartReflectionExercise(int intendedDuration)
    {
        DateTime currentTime = DateTime.Now;
        
        DateTime futureTime = currentTime.AddSeconds(intendedDuration);
        //pauseExercise();
        
        int countB = 0;
        while (DateTime.Now < futureTime)
        {
            DisplayAnimation();
            DisplayPrompt();
            Console.Clear();
            DisplayFollowUpPrompt();
            Console.ReadLine();
            Console.Clear();
            Console.ReadLine();
            
            countB = countB + 2;

        }
        Console.WriteLine(ConclusionMsg());
        Console.Write($"You completed this Breathing exercise {countB} times in {intendedDuration} seconds. ");
        return Console.ReadLine();
        
    }
}

   
