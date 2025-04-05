using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Create Address
        Address address = new Address("123 Elm St", "Springfield", "IL", "USA");

        // Create Customer
        Customer customer = new Customer("John Doe", address);

        // Create Products
        Product product1 = new Product("Laptop", "P001", 799.99, 1);
        Product product2 = new Product("Headphones", "P002", 49.99, 2);

        // Create a list of products
        List<Product> products = new List<Product> { product1, product2 };

        // Create Order
        Order order = new Order(customer, products);

        // Display the Packing Label
        Console.WriteLine();
        Console.WriteLine(order.PackingLabel());

        // Display the Shipping Label
        Console.WriteLine(order.ShippingLabel());

        // Display the Total Breakdown
        Console.WriteLine(order.GetTotalBreakdown());

        Console.WriteLine("\n--------------------------------------------\n");
    }
}


