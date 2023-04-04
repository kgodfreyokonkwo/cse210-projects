using System;
using System.Collections.Generic;
public class SiteDetails
{
    private string _clinicName = "";
    private string _officerName = "";
    private string _clinicAddress = "";
    private string _geoCoordinate = "";

    public SiteDetails(int forecastDuration, string drugName, int treatmentDays, 
    int numberPatients, int drugDailyUnit, string patientWeightRange, int cartonSize, string clinicName, string officerName, string clinicAddress, string geoCordinate)
    {
        _clinicName = clinicName;
        _officerName = officerName;
        _clinicAddress = clinicAddress;
        _geoCoordinate = geoCordinate;
    }



    public string GetClinicName()
    {
        return _clinicName;
    }
    public void SetClinicName(string clinicName)
    {
        _clinicName = clinicName;
    }
    public string GetOfficerName()
    {
        return _officerName;
    }
    public void SetOfficerName(string officerName)
    {
        _officerName = officerName;
    }
    public string GetClinicAddress()
    {
        return _clinicAddress;
    }
    public void SetClinicAddress(string clinicAddress)
    {
        _clinicAddress = clinicAddress;
    }
    public string GetGeoCordinate()
    {
        return _geoCoordinate;
    }
    public void SetGeoCordinate(string geoCordinate)
    {
        _geoCoordinate = geoCordinate;
    }


    public void HospitalDetails()
    {
        decimal totalNo = 0;
        Console.Write($"Hospital Name: {_clinicName}");
        Console.Write($"Hospital Address: {_clinicAddress}");
        Console.Write($"Hospital Geocordinate: {_geoCoordinate}");
        Console.Write($"Total Number of Patients forecasted for: {totalNo}");
    }







	
}