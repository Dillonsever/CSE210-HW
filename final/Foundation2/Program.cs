using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("321 Elm St", "Toronto", "ON", "Canada");

        Customer customer1 = new Customer("John Smith", address1);
        Customer customer2 = new Customer("Jane Hansen", address2);

        Product product1 = new Product("Laptop", "P1", 800, 1);
        Product product2 = new Product("Mouse", "P2", 25, 2);
        Product product3 = new Product("Keyboard", "P3", 50, 1);

        Product product4 = new Product("Headphones", "P4", 100, 1);
        Product product5 = new Product("Monitor", "P5", 200, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        DisplayOrderDetails(order1);
        Console.WriteLine();
        DisplayOrderDetails(order2);
    }

    static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.GetTotalPrice():0.00}");
    }
}
