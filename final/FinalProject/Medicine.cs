using System;
using System.Collections.Generic;
public abstract class Medicine 
{  
    //Declear variables
    private string _drugName = "";
    private double _treatmentDays;
    private double _numberPatients;
    private double _drugUnit;
    private double _forecastDuration;

    //Define the constructors
    public Medicine (string drugName, double treatmentDays, 
    double numberPatients, double drugUnit, double forecastDuration)
    {
        _drugName = drugName;
        _treatmentDays = treatmentDays;
        _numberPatients = numberPatients;
        _drugUnit = drugUnit;
        _forecastDuration = forecastDuration;
    }

    public Medicine ()
    {

    }

    //define the setters and getters
    public string GetDrugName()
    {
        return _drugName;
    }
    public void SetDrugName(string drugName)
    {
        _drugName = drugName;
    }
    public double GetTreatmentDays()
    {
        return _treatmentDays;
    }
    public void SetTreatmentDays(double treatmentDays)
    {
        _treatmentDays = treatmentDays;
    }
    public double GetNumberPatients()
    {
        return _numberPatients;
    }
    public void SetNumberPatients(int numberPatients)
    {
        _numberPatients = numberPatients;
    }
    public double GetDrugUnit()
    {
        return _drugUnit;
    }
    public void SetDrugUnit(int drugUnit)
    {
        _drugUnit = drugUnit;
    }
    public double GetForecastDuration()
    {
        return _forecastDuration;
    }
    public void SetForecastDuration(double forecastDuration)
    {
        _forecastDuration = forecastDuration;
    }




    //An abstract method to calculate the rate of consumption of medicines
    public abstract double ConsumptionRate();

    
    //A method to calculate the number of packs of medicine that will be required in a month
    public double PackMonthEstimation()
    {
        // Calculate the total number of packs needed
        double packsPerMonth = ConsumptionRate() * 30;

        return packsPerMonth;        

    }

    //An abstract method to estimate the quantity of drug required by 1 patient in carton
    public abstract double CartonEstimation();


    //A method to convert drug quantities to carton
    public double CartonsRequired()
    {
        double cartonsRequired = CartonEstimation() * (double)_numberPatients;

        return cartonsRequired;
    }

    //An abstract method to diplay forecast output
    public abstract string forecastOutput();
}