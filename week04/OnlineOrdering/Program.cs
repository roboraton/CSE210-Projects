using System;

class Program
{
    static void Main(string[] args)
    {

        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Alice Johnson", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "L1001", 1200.50f, 1));
        order1.AddProduct(new Product("Wireless Mouse", "M2001", 25.99f, 2));

        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Bob Smith", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Gaming Console", "C3001", 499.99f, 1));
        order2.AddProduct(new Product("Extra Controller", "C3002", 59.99f, 2));
        order2.AddProduct(new Product("Game Headset", "H1001", 89.99f, 1));




        Console.WriteLine("\nORDER 1");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():0.00}");

        Console.WriteLine("\nORDER 2");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():0.00}\n");

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}