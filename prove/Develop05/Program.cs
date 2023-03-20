using System;
using System.Collections.Generic;
public partial class Program
{

    static void Main(string[] args)
    {
        //Declare and instatiate a variable to hold users selection             
        int userSelection = 0; 

        //While the user continue to use the APP,  
        while(userSelection != 6) 
        {
            Console.WriteLine();
            Console.WriteLine($"You have {GoalsMenu.currentScore} points."); 
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select an option from the menu: ");

            //Declare and instantiate a variable to hold the user's further choice
            userSelection = int.Parse(Console.ReadLine());
            Console.WriteLine();

            

            if(userSelection == 1)
            {
                CreatNewGoal();
            }
            if(userSelection == 2)
            {
                GoalsMenu.ListGoals();
            }
            if(userSelection == 3)
            {
                GoalsMenu.SaveGoals();
            }
            if(userSelection == 4)
            {
                GoalsMenu.LoadGoals();
            }
            if(userSelection == 5)
            {
                GoalsMenu.RecordEvent();
            }
        }
    }  
    public static void CreatNewGoal() 
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalChoice = Console.ReadLine();
        
        Console.Write("What is the name of your goal? ");
        string goalNameResponse = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string goalDescriptResponse = Console.ReadLine();
        
        if(goalChoice == "1")
        {
            SimpleGoals simpleGoals = new SimpleGoals();
            simpleGoals.SetName(goalNameResponse);
            simpleGoals.SetDescription(goalDescriptResponse);
            simpleGoals.CreateGoal();
        }
        if(goalChoice == "2")
{
            EternalGoals eternalGoals = new EternalGoals();
            eternalGoals.SetName(goalNameResponse);
            eternalGoals.SetDescription(goalDescriptResponse);
            eternalGoals.CreateGoal();         
        }
        else if(goalChoice == "3")
        {
            CheckListGoals checkListGoals = new CheckListGoals();
            checkListGoals.SetName(goalNameResponse);
            checkListGoals.SetDescription(goalDescriptResponse);
            checkListGoals.CreateGoal();
        } 
    }
}