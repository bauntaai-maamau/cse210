using System;

public class Address
{
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;



    // Public properties to control access to the private fields
    public string Street
    {
        get { return _street; }
        set { _street = value; }
    }

    public string City
    {
        get { return _city; }
        set { _city = value; }
    }

    public string StateOrProvince
    {
        get { return _stateOrProvince; }
        set { _stateOrProvince = value; }
    }

    public string Country
    {
        get { return _country; }
        set { _country = value; }
    }



    public Address(string street, string city, string stateorprovince, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvince = stateorprovince;
        _country = country;
    }




    // Method to check if the address is in the USA
    public bool IsInUSA()
    {
        return Country.ToLower() == "usa" || Country.ToLower() == "united states";
    }


    // Method to return the full address
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_stateOrProvince}\n{_country}";
    }

}