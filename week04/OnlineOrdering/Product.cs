using System;

class Product
{
    
       string name;

       string productId;

        decimal price;

        int quantity;

        
       
      public Product(string name, string productId,
      decimal price, int quantity)

    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }      

    public decimal GetTotalCost()
    {
        return price * quantity;
    }

    public string GetName()
    {
        return name;
    }

    public string GetProductId()
    {
        return productId;
    }


    
  
    
    


}

  