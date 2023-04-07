public class DrugCotrim : Medicine
{
    //declear and instantiate the perculiar variables
    private double _capletsPerPack = 1000;
    private double _cartonSize = 30;

    //define the constructor
    public DrugCotrim ()
    {

    }
    public DrugCotrim (string drugName, double treatmentDays, double numberPatients, double drugUnit, double forecastDuration) :
    base(drugName, treatmentDays, numberPatients, drugUnit, forecastDuration)
    {

    }


    //An override method to calculate the rate of consumption of medicines
    public override double ConsumptionRate()
    {
        double dailyUnit = GetDrugUnit() / GetTreatmentDays();
        // Calculate the number of packs per day
        double packsPerDay = dailyUnit / _capletsPerPack;

        // Display the result to the user

        return packsPerDay;

    }
    //An override method to estimate the quantity of drug required by 1 patient in carton
    public override double CartonEstimation()
    {
        Forecast forecast = new Forecast();
        double packsForForecastDuration = PackMonthEstimation() * GetForecastDuration();
    
        double cartonNo = packsForForecastDuration / _cartonSize;

        return cartonNo;

    }
    //An override method to diplay forecast output
    public override string forecastOutput()
    {
        Forecast forecast = new Forecast();
        return $"{GetDrugName()} : for {GetNumberPatients():N0}patients : requires {CartonsRequired().ToString("F2")}cartons : for {GetForecastDuration()}months";
    }
	
}