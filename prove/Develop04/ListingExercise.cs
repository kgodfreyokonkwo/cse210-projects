using System;
using System.Collections.Generic;

public class ListingExercise : Exercise
{
    //declere variables that will hold the listing prompt quesitons
    private string _listingPrompt1 = "";
    private string _listingPrompt2 = "";
    private string _listingPrompt3 = "";
    private string _listingPrompt4 = "";
    private string _listingPrompt5 = "";



    //Create a list of the listing prompt quesitons
    public List<string> _ListPrompt = new List<string>();
    public List<string> _followUpListPrompt = new List<string>();



    //Constructor
    public ListingExercise()
    
    {

    }
    //Constructor, showing inheritance of class members from the base class
    public ListingExercise(string activityName, string activityDescription, 
    int intendedDuration, string endingText, string listingPrompt1, string listingPrompt2, 
    string listingPrompt3, string listingPrompt4, string listingPrompt5) 
    : base(activityName, activityDescription, endingText, intendedDuration)
    {
        _listingPrompt1 = listingPrompt1;
        _listingPrompt2 = listingPrompt2;
        _listingPrompt3 = listingPrompt3;
        _listingPrompt4 = listingPrompt4;
        _listingPrompt5 = listingPrompt5;

    }
    //Display the prompt quesion
    public void DisplayListPrompt()
    {
        var random = new Random();
        Console.WriteLine(_ListPrompt[random.Next(_ListPrompt.Count)]);
    }
    
    //Method to introduce and run the listing exercise
    public string StartListingExercise(int intendedDuration)
    {
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(intendedDuration);

        pauseExercise();
        DisplayAnimation();
        Console.WriteLine("Consider the following prompt....");
       
                    
        int countL = 0;
        DisplayListPrompt();
        Console.WriteLine("please Hit enter to continue");

        while (DateTime.Now < futureTime)
        {  
            Console.ReadKey();
            if (Console.ReadKey(true).Key == ConsoleKey.Enter)
            {
                DisplayAnimation();
                DisplayFollowUpListPrompt();
            }
            
            countL = countL + 1;
        }
        Console.WriteLine(ConclusionMsg());
        Console.Write($"You completed this Listing exercise {countL} times in {intendedDuration} seconds. ");
        return Console.ReadLine();
        
    }
    //Display the follow up prompts
    public void DisplayFollowUpListPrompt()
    {
        string lQuestion = "";
        Random random = new Random();
        HashSet<string> listQuestions = new HashSet<string>();
        while (listQuestions.Count > 4)
        {
            Console.WriteLine();

        }
        lQuestion = _ListPrompt[random.Next(_ListPrompt.Count)];
        Console.WriteLine(lQuestion);
        Console.ReadKey();
        
    }
}