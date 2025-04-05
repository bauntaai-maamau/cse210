using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Create a few sample addresses
        var address1 = new Address("123 Main St", "Los Angeles", "CA", "USA");
        var address2 = new Address("456 Oak Rd", "Toronto", "ON", "Canada");

        // Create customers with their respective addresses
        var customer1 = new Customer("John Doe", address1);
        var customer2 = new Customer("Jane Smith", address2);

        // Create a list of products for each order
        var products1 = new List<Product>
        {
            new Product("Laptop", "P101", 1200.00, 1),
            new Product("Mouse", "P102", 25.00, 2)
        };
        var products2 = new List<Product>
        {
            new Product("Smartphone", "P201", 700.00, 1),
            new Product("Headphones", "P202", 100.00, 2)
        };

        // Create orders for each customer
        var order1 = new Order(customer1, products1);
        var order2 = new Order(customer2, products2);

        // Display the results for the first order
        Console.WriteLine($"\nOrder 1");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine(order1.GetTotalBreakdown());

        Console.WriteLine("--------------------------------------------\n");

        // Display the results for the second order
        Console.WriteLine($"Order 2");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine(order2.GetTotalBreakdown());
    }
}



