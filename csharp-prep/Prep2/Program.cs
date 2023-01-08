using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your score? ");
        String response = Console.ReadLine();
        int score = int.Parse(response);
        int D1 = score % 10;

        string letter = "";
        string sign = "";

        if (score >= 90)
        {   
            letter = "A";
        }
        else if (score >= 80)
        {
            letter = "B";
        }
        else if (score >= 70)
        {
            letter = "C";
        }
        else if (score >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (letter == "A" || letter == "B" || letter == "C" || letter == "D")
        {
            if (D1 >= 7 || score ==100)
            {
                sign = "+";
            }
            else if (D1 <= 3 && score !=100)
            {
                sign = "-";
            }
        else
        {
            sign = "";
        }

        }
        Console.WriteLine($"Your grade is: {sign}{letter}");

        if (letter == "A" || letter == "B" || letter == "C" || letter == "D")
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You failed, better luck next time!");
        }
    }
}