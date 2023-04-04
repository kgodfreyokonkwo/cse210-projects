public class DrugINH : Medicine
{
    private float _tabletsPerPack = 100;
    public DrugINH (int forecastDuration, string drugName, int treatmentDays, 
    int numberPatients, int drugDailyUnit, string patientWeightRange, int cartonSize) :
    base(forecastDuration, drugName, treatmentDays, numberPatients, drugDailyUnit, patientWeightRange, cartonSize)
    {

    }

    public override decimal ConsumptionRate()
    {
        Console.Write("Enter the number of tablets of INH taken in a day: ");
        int _drugDailyUnit = int.Parse(Console.ReadLine());

        // Calculate the number of packs per day
        double packsPerDay = (double)_drugDailyUnit / _tabletsPerPack;

        // Display the result to the user

        return (decimal)packsPerDay;

    }

	
}