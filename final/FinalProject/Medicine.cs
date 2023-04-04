using System.Collections.Generic;
public abstract class Medicine 
{
   
    private int _forecastDuration = 0;
    private string _drugName = "";
    private int _treatmentDays = 0;
    private int _numberPatients = 0;
    private int _drugDailyUnit = 0;
    private string _patientWeightRange = "";
    private int _cartonSize = 0;
    

    public Medicine (int forecastDuration, string drugName, int treatmentDays, 
    int numberPatients, int drugDailyUnit, string patientWeightRange, int cartonSize)
    {
        _forecastDuration = forecastDuration;
        _drugName = drugName;
        _treatmentDays = treatmentDays;
        _numberPatients = numberPatients;
        _drugDailyUnit = drugDailyUnit;
        _patientWeightRange = patientWeightRange;
        _cartonSize = cartonSize;
    }


    public int GetForecastDuration()
    {
        return _forecastDuration;
    }
    public void SetForecastDuration(int forecastDuration)
    {
        _forecastDuration = forecastDuration;
    }
    public string GetDrugName()
    {
        return _drugName;
    }
    public void SetDrugName(string drugName)
    {
        _drugName = drugName;
    }
    public int GetTreatementDays()
    {
        return _treatmentDays;
    }
    public void SetTreatmentDays(int treatmentDays)
    {
        _treatmentDays = treatmentDays;
    }
    public int GetNumberPatients()
    {
        return _numberPatients;
    }
    public void SetNumberPatients(int numberPatients)
    {
        _numberPatients = numberPatients;
    }
    public int GetDrugDailyUnint()
    {
        return _drugDailyUnit;
    }
    public void SetDrugDailyUnit(int drugDailyUnit)
    {
        _drugDailyUnit = drugDailyUnit;
    }
    public string GetPatientWeightRange()
    {
        return _patientWeightRange;
    }
    public void SetPatientWeightRange(string patientWeightRange)
    {
        _patientWeightRange = patientWeightRange;
    }
    public int GetCartonSize()
    {
        return _cartonSize;
    }
    public void SetCartonSize(int cartonSize)
    {
        _cartonSize = cartonSize;
    }





    public abstract decimal ConsumptionRate();

    public decimal PackMonthEstimation()
    {
        Console.Write("Enter the duration of treatment in days: ");
        int _treatmentDays = int.Parse(Console.ReadLine());

        // Calculate the total number of packs needed
        double packsPerMonth = (double)(ConsumptionRate() * _treatmentDays);

        return (decimal)packsPerMonth;        

    }

    public decimal CartonEstimation()
    {
        double packsForForecastDuration = (double)(PackMonthEstimation() * _forecastDuration);

        double cartonNo = packsForForecastDuration / _cartonSize;

        return (decimal)cartonNo;

    }
  
    public decimal TotalNoPatient()
    {
        return -1;
    }


    public string forecastOutput()
    {
        return $"A total of {CartonEstimation} cartons of {GetDrugName} will be required for {GetPatientWeightRange} for the period of {GetForecastDuration} months ";
    }
}