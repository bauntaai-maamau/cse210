using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Create a Product object
        Product myProduct = new Product("Laptop", "P123", 1000, 10);

        // Access and modify properties
        Console.WriteLine("\nBefore update:");
        myProduct.DisplayProductInfo();

        // Update the price and quantity using properties
        myProduct.Price = 900;  // Updating price
        myProduct.Quantity = 12;  // Updating quantity

        Console.WriteLine("\nAfter update:");
        myProduct.DisplayProductInfo();

        Console.WriteLine();
    }
}
