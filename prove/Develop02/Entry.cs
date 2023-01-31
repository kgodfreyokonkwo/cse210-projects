using System;
using System.IO;

public class Entry
{

    // Get the current date time, using the DateTime.Now function
    DateTime theCurrentTime = DateTime.Now;
   
    //reference the prompt questions
    public string _question;
    //reference the response and save as a string
    public string _response;
     // Display the prompt for the user to answer

       
    public object dateDisplay { get; internal set; }


    public void DisplayEntry()

    {

        //Write and display the time, question and response
        Console.WriteLine($"{theCurrentTime.ToLongDateString()} - {_question} - {_response}");
    }
}