using System;

class Product
{
    
       private string _name;

       private string _productId;

        private decimal _price;

        private int _quantity;

        
       
      public Product(string name, string productId,
      decimal price, int quantity)

    {
        this._name = name;
        this._productId = productId;
        this._price = price;
        this._quantity = quantity;
    }      

    public decimal GetTotalCost()
    {
        return _price * _quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _productId;
    }

}

  