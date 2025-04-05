using System;

public class Program
{
    static void Main(string[] args)
    {

        // Create Address object for the customer
        Address customerAddress = new Address("Nukan te Wa, Betio", "Tarawa", "Gilbert Islands", "Kiribati");

        // Create Customer object with address
        Customer customer = new Customer("Mokata Tiira", customerAddress);

        // Create Product object
        Product myproduct = new Product("Phone Cover", "P123", 39.15, 3);

        


        // Display customer information
        Console.WriteLine($"\nCustomer: {customer.CustomerName}");
        Console.WriteLine($"Address:\n{customer.CustomerAddress.GetFullAddress()}");
        Console.WriteLine($"Lives in USA: {customer.LivesInUSA()}");


        // Display product information
        Console.WriteLine($"\nProduct: {myproduct.ProductName}");
        Console.WriteLine($"Product ID: {myproduct.Id}");
        Console.WriteLine($"Price per unit: {myproduct.Price}");
        Console.WriteLine($"Quantity: {myproduct.Quantity}");
        Console.WriteLine($"Total cost: {myproduct.GetTotalCost()}");

        Console.WriteLine();
    }
}




