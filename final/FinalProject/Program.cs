using System;

class Program
{    
    static void Main(string[] args)
    {
        int userSelection = 0;
        

        //While the user continue to use the APP,  
        while(userSelection != 5) 
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to Medicine Forecasting Application"); 
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Forecast for Medicine");
            Console.WriteLine("  2. Save Forecast report");
            Console.WriteLine("  3. End");
            Console.Write("Select an option from the menu: ");

            //Declare and instantiate a variable to hold the user's further choice
            userSelection = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            if(userSelection == 1)
            {
                Forecast forecast = new Forecast();
                forecast.ForecastDrug();

            }
            else if(userSelection == 2)
            {
                SaveForecastResult();       
            }

            else if(userSelection == 3)
            {
                //display a good bye message
                Console.WriteLine("Thank you for using the forecasting App. ");
                System.Environment.Exit(1);
            }
            else
            {
                //handle an invalid selection
                Console.WriteLine("Invalid selection made. Please select from 1-5" );
            
            }
            Console.WriteLine();
            
        }
    }
   
    //A method to request for hospital information and display same
    public static string DisplayDetails()
    {
        HospitalDetails hospitalDetails = new HospitalDetails();

        Console.Write("What is the hospital name? ");
        hospitalDetails.SetClinicName(Console.ReadLine());

        Console.Write("What is your Hospital address? ");
        hospitalDetails.SetClinicAddress(Console.ReadLine());

        Console.Write("What is the name of the forecasting officer? ");
        hospitalDetails.SetOfficerName(Console.ReadLine());

        Console.Write("What is the Geo-coordinates of your facility ");
        hospitalDetails.SetGeoCordinate(Console.ReadLine());

        hospitalDetails.DisplayDetails();
        return $"Hospital Name: {hospitalDetails.GetClinicName()}\nHospital Address: {hospitalDetails.GetClinicAddress()}\nHospital Geocordinate: {hospitalDetails.GetGeoCordinate()}\nName of Forecasting Officer: {hospitalDetails.GetOfficerName()}";

    }
    //A method to request for hospital information and save forecast report
    public static void SaveForecastResult() 
    {
        Console.WriteLine("What file name would you like to save your forecast result to? "); 
        string fileName = Console.ReadLine();

        using(StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine("This is your forecast report");
            
            outputFile.WriteLine(DisplayDetails());

            foreach(Medicine medicine in Forecast._MedicineForecastList)
            {
                outputFile.WriteLine($"{medicine.forecastOutput()}");
                
            }            
        }
    }
    
}