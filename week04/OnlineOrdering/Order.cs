using System.Collections.Generic;

class Order

{
    
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        this._products = products;
        this._customer = customer;
    }

    public decimal GetTotalCost()
    {
        decimal totalCost = 0;

        foreach (Product product in _products)
        {
            totalCost += product.GetTotalCost();
        }

        if (_customer.IsInUSA())
        {
            totalCost = totalCost + 5;

        }

        else
        {
            totalCost = totalCost + 35;
        }

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";

        foreach (Product product in _products)
        {
            packingLabel += product.GetName() + " - " + product.GetProductId() + "\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()

    {
       return _customer.GetName() + "\n" + _customer.GetFormatAddress();
    }

}