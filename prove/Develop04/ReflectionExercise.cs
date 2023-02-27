using System;
using System.Collections.Generic;

public class ReflectionExercise : Exercise
{
    //declaration of prompt variable that will hold the prompt questions
    private string _prompt1 = "";
    private string _prompt2 = "";
    private string _prompt3 = "";
    private string _prompt4 = "";
    private string _followUpPrompt1 = "";
    private string _followUpPrompt2 = "";
    private string _followUpPrompt3 = "";
    private string _followUpPrompt4 = "";
    private string _followUpPrompt5 = "";
    private string _followUpPrompt6 = "";
    private string _followUpPrompt7 = "";


    //Create a list of the prompt questions and the follow up quesions
    public List<string> _firstPrompt = new List<string>();
    public List<string> _followUpPrompt = new List<string>();


    //Constructor
    public ReflectionExercise()
    {

    }
    
    //Constructor, showing inheritance of class members from the base class
    public ReflectionExercise(string activityName, string activityDescription, 
    int intendedDuration, string endingText, string prompt1, string prompt2, string prompt3, string prompt4, 
    string followUpPrompt1, string followUpPrompt2, string followUpPrompt3, string followUpPrompt4, string followUpPrompt5, 
    string followUpPrompt6, string followUpPrompt7) 
    : base(activityName, activityDescription, endingText, intendedDuration)
    {
        _prompt1 = prompt1;
        _prompt2 = prompt2;
        _prompt3 = prompt3;
        _prompt4 = prompt4;
        _followUpPrompt1 = followUpPrompt1;
        _followUpPrompt2 = followUpPrompt2;
        _followUpPrompt3 = followUpPrompt3;
        _followUpPrompt4 = followUpPrompt4;
        _followUpPrompt5 = followUpPrompt5;
        _followUpPrompt6 = followUpPrompt6;
        _followUpPrompt7 = followUpPrompt7;
    }
    
    //Method to display the prompt questions at random
    public void DisplayPrompt()
    {
        var random = new Random();
        Console.WriteLine(_firstPrompt[random.Next(_firstPrompt.Count)]);
    }
    
    //Method to display the prompt follow up quesitons and instructions
    public void DisplayFollowUpPrompt()
    {
        string fQuestion = "";
        Random random = new Random();
        HashSet<string> questions = new HashSet<string>();
        while (questions.Count > 4)
        {
            Console.WriteLine();

        }
        fQuestion = _followUpPrompt[random.Next(_followUpPrompt.Count)];
        Console.WriteLine(fQuestion);
        Console.ReadKey();
        
    }
    
    //Method to initiate and run the relection activity
    public string StartReflectionExercise(int intendedDuration)
    {
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(intendedDuration);

        pauseExercise();
        DisplayAnimation();
        Console.WriteLine("Consider the following prompt.. ");
        int i = 0;      
                    
        int countR = 0;
        DisplayPrompt();

        while (DateTime.Now < futureTime)
        {  
            
            string f = _followUpPrompt[i];
            countR = countR + 1;
            if (i >= _followUpPrompt.Count )
            {
                DisplayPrompt();
            }
            DisplayFollowUpPrompt();
            Console.ReadLine();

        }
        Console.WriteLine(ConclusionMsg());
        Console.Write($"You completed this Reflection exercise {countR} times in {intendedDuration} seconds. ");
        return Console.ReadLine();
        
    }
}

   
