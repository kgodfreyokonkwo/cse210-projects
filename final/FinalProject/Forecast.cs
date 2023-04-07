public class Forecast : Medicine
{
    //Declear a new list to hold the forecast data
    public static List<Medicine> _MedicineForecastList = new List<Medicine>();
    
    //Define the constructors
    public Forecast (string drugName, double treatmentDays, double numberPatients, double drugUnit, double forecastDuration) :
    base(drugName, treatmentDays, numberPatients, drugUnit, forecastDuration)
    {

    }


    public Forecast()
    {
    }

   


    //The forecast method menue
    public void ForecastDrug()
    {
        int drugSelection = 0;


        while(drugSelection != 5) 
        {
            //Allow user to select what drug to forecast for
            Console.WriteLine("  1. Forecast for INH");
            Console.WriteLine("  2. Forecast for TLD");
            Console.WriteLine("  3. Forecast for NVP");
            Console.WriteLine("  4. Forecast for Cotrim");
            Console.WriteLine("  5. Back to Main menu");
            Console.Write("Select a drug choice to be forecasted from the menu: ");

            drugSelection = int.Parse(Console.ReadLine());
            
            //Manage users selection    
            if (drugSelection == 1)
            {
                int weightRangeSelection = 0;

                DrugINH drugINH = new DrugINH();
                drugINH.SetDrugName("Isoniazid (INH)");

                Console.Write("Enter the duration of the forecast in months ");
                drugINH.SetForecastDuration(int.Parse(Console.ReadLine()));

                //Allow the user to select the weight range of the patient, whose drug need is to be forecasted for 
                Console.WriteLine();
                Console.WriteLine("Menu Options:");
                Console.WriteLine("  1. INH (1 - 30kg body weight)");
                Console.WriteLine("  2. INH (31 - 60kg body weight)");
                Console.WriteLine("  3. INH (61 - 90kg body weight)");

                Console.Write("Select an body weight option from the menu: ");

                weightRangeSelection = int.Parse(Console.ReadLine());
                Console.WriteLine();


                if (weightRangeSelection == 1)
                {
                    Console.Write("Enter the total number of patients in this category: ");
                    drugINH.SetNumberPatients(int.Parse(Console.ReadLine()));
                
                    Console.Write("Enter the number of tablets of INH taken in treatment days: ");
                    drugINH.SetDrugUnit(int.Parse(Console.ReadLine()));

                    Console.Write("Enter the treatment frequency in days: ");
                    drugINH.SetTreatmentDays(int.Parse(Console.ReadLine()));

                    drugINH.forecastOutput();
                    _MedicineForecastList.Add(drugINH);  
                    
                }

                if (weightRangeSelection == 2)
                {
                    Console.Write("Enter the total number of patients in this category: ");
                    drugINH.SetNumberPatients(int.Parse(Console.ReadLine()));
                
                    Console.Write("Enter the number of tablets of INH taken in treatment days: ");
                    drugINH.SetDrugUnit(int.Parse(Console.ReadLine()));

                    Console.Write("Enter the treatment frequency in days: ");
                    drugINH.SetTreatmentDays(int.Parse(Console.ReadLine()));

                    drugINH.forecastOutput();
                    _MedicineForecastList.Add(drugINH);
                }

                if (weightRangeSelection == 3)
                {
                    Console.Write("Enter the total number of patients in this category: ");
                    drugINH.SetNumberPatients(int.Parse(Console.ReadLine()));
                
                    Console.Write("Enter the number of tablets of INH taken in treatment days: ");
                    drugINH.SetDrugUnit(int.Parse(Console.ReadLine()));

                    Console.Write("Enter the treatment frequency in days: ");
                    drugINH.SetTreatmentDays(int.Parse(Console.ReadLine()));

                    drugINH.forecastOutput();
                    _MedicineForecastList.Add(drugINH);
                }         
            }

            if (drugSelection == 2)
            {
                int weightRangeSelection = 0;

                DrugTLD drugTLD = new DrugTLD();
                drugTLD.SetDrugName("Tenofovir3 (TLD)");

                Console.Write("Enter the duration of the forecast in months ");
                drugTLD.SetForecastDuration(int.Parse(Console.ReadLine()));

                //Allow the user to select which drug to work on
                Console.WriteLine();
                Console.WriteLine("Menu Options:");
                Console.WriteLine("  1. TLD (1 - 30kg body weight)");
                Console.WriteLine("  2. TLD (31 - 60kg body weight)");
                Console.WriteLine("  3. TLD (61 - 90kg body weight)");

                Console.Write("Select an body weight option from the menu: ");

                weightRangeSelection = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (weightRangeSelection == 1)
                {
                    Console.Write("Enter the total number of patients in this category: ");
                    drugTLD.SetNumberPatients(int.Parse(Console.ReadLine()));
                
                    Console.Write("Enter the number of tablets of TLD taken in treatment days: ");
                    drugTLD.SetDrugUnit(int.Parse(Console.ReadLine()));

                    Console.Write("Enter the treatment frequency in days: ");
                    drugTLD.SetTreatmentDays(int.Parse(Console.ReadLine()));

                    drugTLD.forecastOutput();
                    _MedicineForecastList.Add(drugTLD);
                    
                }

                if (weightRangeSelection == 2)
                {
                    Console.Write("Enter the total number of patients in this category: ");
                    drugTLD.SetNumberPatients(int.Parse(Console.ReadLine()));
                
                    Console.Write("Enter the number of tablets of TLD taken in treatment days: ");
                    drugTLD.SetDrugUnit(int.Parse(Console.ReadLine()));

                    Console.Write("Enter the treatment frequency in days: ");
                    drugTLD.SetTreatmentDays(int.Parse(Console.ReadLine()));

                    drugTLD.forecastOutput();
                    _MedicineForecastList.Add(drugTLD);
                }

                if (weightRangeSelection == 3)
                {
                    Console.Write("Enter the total number of patients in this category: ");
                    drugTLD.SetNumberPatients(int.Parse(Console.ReadLine()));
                
                    Console.Write("Enter the number of tablets of TLD taken in treatment days: ");
                    drugTLD.SetDrugUnit(int.Parse(Console.ReadLine()));

                    Console.Write("Enter the treatment frequency in days: ");
                    drugTLD.SetTreatmentDays(int.Parse(Console.ReadLine()));

                    drugTLD.forecastOutput();
                    _MedicineForecastList.Add(drugTLD);
                }         
            }

            if (drugSelection == 3)
            {
                int weightRangeSelection = 0;

                DrugNVP drugNVP = new DrugNVP();
                drugNVP.SetDrugName("Nevirapine (NVP)");

                Console.Write("Enter the duration of the forecast in months ");
                drugNVP.SetForecastDuration(int.Parse(Console.ReadLine()));

                //Allow the user to select the weight range of the patient, whose drug need is to be forecasted for 
                Console.WriteLine();
                Console.WriteLine("Menu Options:");
                Console.WriteLine("  1. 1 - 30kg body weight");
                Console.WriteLine("  2. 31 - 60kg body weight");
                Console.WriteLine("  3. 61 - 90kg body weight");

                Console.Write("Select an body weight option from the menu: ");

                weightRangeSelection = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (weightRangeSelection == 1)
                {
                    Console.Write("Enter the total number of patients in this category: ");
                    drugNVP.SetNumberPatients(int.Parse(Console.ReadLine()));
                
                    Console.Write("Enter the number of millitire of NVP taken in treatment days: ");
                    drugNVP.SetDrugUnit(int.Parse(Console.ReadLine()));

                    Console.Write("Enter the treatment frequency in days: ");
                    drugNVP.SetTreatmentDays(int.Parse(Console.ReadLine()));

                    drugNVP.forecastOutput();
                    _MedicineForecastList.Add(drugNVP);
                    
                }

                if (weightRangeSelection == 2)
                {
                    Console.Write("Enter the total number of patients in this category: ");
                    drugNVP.SetNumberPatients(int.Parse(Console.ReadLine()));
                
                    Console.Write("Enter the number of millitire of NVP taken in treatment days: ");
                    drugNVP.SetDrugUnit(int.Parse(Console.ReadLine()));

                    Console.Write("Enter the treatment frequency in days: ");
                    drugNVP.SetTreatmentDays(int.Parse(Console.ReadLine()));

                    drugNVP.forecastOutput();
                    _MedicineForecastList.Add(drugNVP);
                }

                if (weightRangeSelection == 3)
                {
                    Console.Write("Enter the total number of patients in this category: ");
                    drugNVP.SetNumberPatients(int.Parse(Console.ReadLine()));
                
                    Console.Write("Enter the number of millitire of NVP taken in treatment days: ");
                    drugNVP.SetDrugUnit(int.Parse(Console.ReadLine()));

                    Console.Write("Enter the treatment frequency in days: ");
                    drugNVP.SetTreatmentDays(int.Parse(Console.ReadLine()));

                    drugNVP.forecastOutput();
                    _MedicineForecastList.Add(drugNVP);
                }           
            }

            if (drugSelection == 4)
            {
                int weightRangeSelection = 0;

                DrugCotrim drugCotrim = new DrugCotrim();
                drugCotrim.SetDrugName("Cotrimoxazole (Cotrim)");

                Console.Write("Enter the duration of the forecast in months ");
                drugCotrim.SetForecastDuration(int.Parse(Console.ReadLine()));

                //Allow the user to select the weight range of the patient, whose drug need is to be forecasted for 
                Console.WriteLine();
                Console.WriteLine("Menu Options:");
                Console.WriteLine("  1. 1 - 30kg body weight");
                Console.WriteLine("  2. 31 - 60kg body weight");
                Console.WriteLine("  3. 61 - 90kg body weight");

                Console.Write("Select an body weight option from the menu: ");

                weightRangeSelection = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (weightRangeSelection == 1)
                {
                    Console.Write("Enter the total number of patients in this category: ");
                    drugCotrim.SetNumberPatients(int.Parse(Console.ReadLine()));
                
                    Console.Write("Enter the number of Caplets of Cotrim taken in treatment days: ");
                    drugCotrim.SetDrugUnit(int.Parse(Console.ReadLine()));

                    Console.Write("Enter the treatment frequency in days: ");
                    drugCotrim.SetTreatmentDays(int.Parse(Console.ReadLine()));

                    drugCotrim.forecastOutput();
                    _MedicineForecastList.Add(drugCotrim);
                }

                if (weightRangeSelection == 2)
                {
                    Console.Write("Enter the total number of patients in this category: ");
                    drugCotrim.SetNumberPatients(int.Parse(Console.ReadLine()));
                
                    Console.Write("Enter the number of Caplets of Cotrim taken in treatment days: ");
                    drugCotrim.SetDrugUnit(int.Parse(Console.ReadLine()));

                    Console.Write("Enter the treatment frequency in days: ");
                    drugCotrim.SetTreatmentDays(int.Parse(Console.ReadLine()));

                    drugCotrim.forecastOutput();
                    _MedicineForecastList.Add(drugCotrim);
                }

                if (weightRangeSelection == 3)
                {
                    Console.Write("Enter the total number of patients in this category: ");
                    drugCotrim.SetNumberPatients(int.Parse(Console.ReadLine()));
                
                    Console.Write("Enter the number of Caplets of Cotrim taken in treatment days: ");
                    drugCotrim.SetDrugUnit(int.Parse(Console.ReadLine()));

                    Console.Write("Enter the treatment frequency in days: ");
                    drugCotrim.SetTreatmentDays(int.Parse(Console.ReadLine()));

                    drugCotrim.forecastOutput();
                    _MedicineForecastList.Add(drugCotrim);
                }        
            }
        }
    }
    public override double CartonEstimation()
    {
        throw new NotImplementedException();
    }
    public override double ConsumptionRate()
    {
        throw new NotImplementedException();
    }
    public override string forecastOutput()
    {
        throw new NotImplementedException();
    }
    
}