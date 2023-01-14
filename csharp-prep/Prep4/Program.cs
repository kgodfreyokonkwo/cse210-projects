using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        
        // define the list and store as a variable
        List<int> scores = new List<int>();

        int userScore = -1;
        //Use the while loop to assign scores to the list based on individual response
        while (userScore!= 0)
        {
            Console.Write("Enter your score? Type 0 when finished ");
            
            //conver default response nature from string to int
            string response = Console.ReadLine();
            userScore = int.Parse(response);

            //use an if statement to add responses order than 0 to the list
            if (userScore != 0)
            {
                scores.Add(userScore);
            }

        }

        int total_score = 0;
        
        
        // loop through the list to total all the scores
        foreach (int score in scores)
        {
            total_score = scores.Sum();            
        }

        Console.WriteLine($"Your total score is {total_score}");  
              
        float average = ((float)total_score) / scores.Count;

        Console.WriteLine($"Your Average score is {average}%");  


        //call the sum feature and define them
        int max = scores[0];
        int i = scores.Count - 1;
        int min = scores[i];     

        foreach (int score in scores)
        {
            if (score > max)
            {
                max = score;
            }
            if (score < min)
            {
                min = score;
            }
        }
        Console.WriteLine($"The maximum score is {max}%");
        Console.WriteLine($"The minimum score is {min}%");
    }
}