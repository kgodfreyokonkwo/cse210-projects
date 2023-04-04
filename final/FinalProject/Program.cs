using System;

class Program
{
    static void Main(string[] args)
    {
    int userSelection = 0; 

    //While the user continue to use the APP,  
    while(userSelection != 6) 
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to Medice Forecasting Application"); 
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Enter Hospital & personnel details");
        Console.WriteLine("  2. Forecast for Medicine");
        Console.WriteLine("  3. Save result");
        Console.WriteLine("  4. Load result");
        Console.WriteLine("  5. Quit");
        Console.Write("Select an option from the menu: ");

        //Declare and instantiate a variable to hold the user's further choice
        userSelection = int.Parse(Console.ReadLine());
        Console.WriteLine();
        
        if(userSelection == 1)
        {

        }
        if(userSelection == 2)
        {

        }
        if(userSelection == 3)
        {

        }
        if(userSelection == 4)
        {

        }
        if(userSelection == 5)
        {

        }
    }
    }
}