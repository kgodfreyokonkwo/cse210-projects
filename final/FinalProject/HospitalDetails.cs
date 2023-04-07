using System;
using System.Collections.Generic;
public class HospitalDetails
{
    //Define variables and instantiate to default
    public List<string> _SiteDetails = new List<string>();
    private string _clinicName = "";
    private string _officerName = "";
    private string _clinicAddress = "";
    private string _geoCoordinate = "";

    //Define constructor
    public HospitalDetails (string clinicName, string officerName, string clinicAddress, string geoCoordinate)
    {
        _clinicName = clinicName;
        _officerName = officerName;
        _clinicAddress = clinicAddress;
        _geoCoordinate = geoCoordinate;
    }

    public HospitalDetails ()
    {

        
    }

    //Outline the getters and setters
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
    public void SetGeoCordinate(string geoCoordinate)
    {
        _geoCoordinate = geoCoordinate;
    }

    //A method to display hospital details
    public string DisplayDetails()
    {
        return $"Hospital Name: {_clinicName}\nHospital Address: {_clinicAddress}\nHospital Geocordinate: {_geoCoordinate}\nName of Forecasting Officer: {_officerName}";

    }











}