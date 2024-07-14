using System;

 public class Address

{
    private string _street;
    private string _city;
    private string _stateorprovince;
    private string _country;

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

    public string State
    {
        get { return _stateorprovince; }
        set { _stateorprovince = value; }
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
        _stateorprovince = stateorprovince;
        _country = country;
    }

    public bool IsInUSA()
    {
        return _country.ToLower() == "usa" || _country.ToLower() == "united states";
    }


     // Method to return the address as a formatted string
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_stateorprovince}\n{_country}";
    }
}


