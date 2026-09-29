using System;

class Address

{
    string streetAddress;

    string city;

    string state;

    string country;

    public Address(string streetAddress, string city, string state, string country)
    {
        this.streetAddress = streetAddress;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    public bool IsInUSA()
    {
        return country == "USA";
    }

    public string GetFullAddress()
    {
        return $"{streetAddress}\n {city}, {state} \n{country}";
    
    }

    
}