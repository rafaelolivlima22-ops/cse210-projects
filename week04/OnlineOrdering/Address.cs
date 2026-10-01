using System;

class Address

{
    string _streetAddress;

    string _city;

    string _state;

    string _country;

    public Address(string streetAddress, string city, string state, string country)
    {
        this._streetAddress = streetAddress;
        this._city = city;
        this._state = state;
        this._country = country;
    }

    public bool IsInUSA()
    {
        return _country == "USA";
    }

    public string GetFullAddress()
    {
        return $"{_streetAddress}\n {_city}, {_state} \n{_country}";
    
    }

    
}