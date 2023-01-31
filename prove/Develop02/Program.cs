using System;
using System.IO; 

partial class Program
{
    static void Main(string[] args)
    {
        // Open and set the Journal class as current to introduce the overide feature
        Journal currentJournal = new Journal();
       
        // Request for user's name
        Console.Write("what is your first name? ");
        string first = Console.ReadLine();

        //provide customized response to user, asking for option selection
        Console.WriteLine();
        Console.WriteLine($" Hi {first}, You are welcome to your personal Journal App ");
        Console.Write("Would you like to continue to the main menu? Y/N: ");
        String start = Console.ReadLine();

        // reference the promptGenerator class which returns a random question/prompt for the user
        PromptGenerator userPrompt = new PromptGenerator();
        userPrompt._question.Add(userPrompt._question1);
        userPrompt._question.Add(userPrompt._question2);
        userPrompt._question.Add(userPrompt._question3);
        userPrompt._question.Add(userPrompt._question4);
        userPrompt._question.Add(userPrompt._question5);


        //Display options to proceed if user agrees to
        if (start == "Y")
        {
            int userSelection = 0;
            

            //If user accepts to proceed, loop through options. only execute when user selects
            // 1,2,3,4, or 5.
            while (userSelection != 5)
            {

                Console.WriteLine("What would you want to do? Select options below ");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");
                
                userSelection = int.Parse(Console.ReadLine());

                if (userSelection == 1)
                {
                    //get a recent entry
                    Entry currentEntry = new Entry();

                    currentEntry._question = userPrompt.SelectQuestion();
                    Console.WriteLine(currentEntry._question);

                    // User response
                    currentEntry._response = Console.ReadLine();

                    //write entry in journal
                    currentJournal._entries.Add(currentEntry);
                }

                else if (userSelection == 2)
                {
                    //display what is written in the journal
                    currentJournal.DisplayJournal();
                }

                else if (userSelection == 3)
                {
                    //Load the existing journal and its content with an option for user to choose which to open
                    currentJournal = new Journal();
                    Console.Write("Which file would you like the open? ");
                    currentJournal._fileName = Console.ReadLine();
                    currentJournal.LoadFile();
                }

                else if (userSelection == 4)
                {
                    //Save current journal
                    currentJournal.SaveFile();
                    Console.WriteLine("Your file has been saved");
                }
            }
        }

        //if user selects No, terminate the program with a goodbye message
        else
        {
            Console.WriteLine("See you next time");
            System.Environment.Exit(1);
        }

    }
}