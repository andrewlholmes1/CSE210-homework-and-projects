using System;

class Program
{
    static void Main(string[] args)
    {
        // Program.cs

        Address addr1 = new Address("123 Elm St", "Springfield", "IL", "USA");
        Customer cust1 = new Customer("Alice Johnson", addr1);
        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Notebook", "N123", 3.50, 4));
        order1.AddProduct(new Product("Pen", "P456", 1.25, 10));

        Address addr2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        Customer cust2 = new Customer("Bob Smith", addr2);
        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Stapler", "S789", 7.99, 1));
        order2.AddProduct(new Product("Paper", "P321", 2.99, 5));

        DisplayOrder(order1);
        Console.WriteLine();
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.GetTotalCost():0.00}");
    }
}