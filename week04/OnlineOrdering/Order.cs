using System.Collections.Generic;

class Order

{
    
    List<Product> products;
    Customer customer;

    public Order(List<Product> products, Customer customer)
    {
        this.products = products;
        this.customer = customer;
    }

    public decimal GetTotalCost()
    {
        decimal totalCost = 0;

        foreach (Product product in products)
        {
            totalCost += product.GetTotalCost();
        }

        if (customer.IsInUSA())
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

        foreach (Product product in products)
        {
            packingLabel += product.GetName() + " - " + product.GetProductId() + "\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()

    {
       return customer.GetName() + "\n" + customer.GetFormatAddress();
    }

}