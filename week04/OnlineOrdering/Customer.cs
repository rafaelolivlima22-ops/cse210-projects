using System;

class Customer
{
    string name;

     Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public bool IsInUSA()
    {
        return address.IsInUSA();
    }

    public string GetName()
    {
        return name;
    }

    public string GetFormatAddress()
    {
        return address.GetFullAddress();
    }
    
        
    
}