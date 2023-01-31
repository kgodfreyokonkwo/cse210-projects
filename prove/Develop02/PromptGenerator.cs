using System;
using System.IO;

public class PromptGenerator
{
    // questions that would serve as prompts, and eventually stored as a list to prompt responses from user
    public string _question1 = "What was the spiritual or temporal highlight of the day? ";
    public string _question2 = "What was your major challenge for the day?";
    public string _question3 = "How where you able to overcome the major challenge of the day? ";
    public string _question4 = "How did you experience the influence of the Savior in your life today? ";
    public string _question5 = "What about today will you do differently next time? ";

    // creat a list of questions called _questions
    public List<string> _question = new List<string>();

    // Select and display a random prompt question
    public string SelectQuestion()
    {
        var random = new Random();
        return _question[random.Next(_question.Count)];
    }
    
}