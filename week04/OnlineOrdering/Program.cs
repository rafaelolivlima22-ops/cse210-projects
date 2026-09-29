using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        /*First order with products and customer*/

          Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");

    Customer customer1 = new Customer("John Doe", address1);

    List<Product> products = new List<Product>
    {
        new Product("Widget", "W123", 19.99m, 2),
        new Product("Gadget", "G456", 29.99m, 1),
        new Product("Thingamajig", "T789", 9.99m, 5)
    };

   Order order1 = new Order(products, customer1);


    /*Second order with different products and customer*/

   Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");

    Customer customer2 = new Customer("Jane Smith", address2);
       
    List<Product> products2 = new List<Product>
    {
        new Product("Doohickey", "D321", 14.99m, 3),
        new Product("Whatchamacallit", "W654", 24.99m, 2)
    };

    Order order2 = new Order(products2, customer2);


    List<Order> orders = new List<Order> { order1, order2 };

    foreach (Order order in orders)
    {
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine($"Total Cost: ${order.GetTotalCost():0.00}");
        Console.WriteLine();
    }
       
}
}