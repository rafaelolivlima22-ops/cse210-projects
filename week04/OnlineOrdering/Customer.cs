using System;

class Customer
{
    string _name;

     Address _address;

    public Customer(string name, Address address)
    {
        this._name = name;
        this._address = address;
    }

    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    public string GetName()
    {
        return _name;
    }

    public string GetFormatAddress()
    {
        return _address.GetFullAddress();
    }
    
        
    
}