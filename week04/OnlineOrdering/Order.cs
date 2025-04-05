using System;


public class Order
{
    private List<Product> _products;
    public Customer _customer { get; set; }
    private double _shippingCost;

    // Public properties to control access to the private fields
    public List<Product> Products
    {
        get { return _products; }
        set { _products = value; }
    }

    // Property to get and set the shipping cost
    public double ShippingCost
    {
        get { return _shippingCost; }
        set { _shippingCost = value; }
    }

    // Constructor to initialize the order with a customer and a list of products
    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
        _shippingCost = customer.LivesInUSA() ? 5 : 35;  // Determine shipping cost based on USA or not
    }


    // Method to generate the packing label (product name and product ID)
    public string PackingLabel()
    {
        string label = "\nPacking Label\n";
        foreach (var product in _products)
        {
            label += $"Product: {product.ProductName} | Product ID: {product.Id} | Price: {product.Price} | Quantity: {product.Quantity}\n";
        }
        return label.Trim();  // Trim extra space or newlines
    }



    // Method to generate the shipping label (customer's name and full address)
    public string ShippingLabel()
    {
        return $"\nShipping Label\nName: {_customer.CustomerName}\nAddress:\n{_customer.CustomerAddress.GetFullAddress()}\n";
    }



    // Method to get the total breakdown (product cost + shipping cost)
    public string GetTotalBreakdown()
    {
        double productTotal = 0;
        foreach (var product in _products)
        {
            productTotal += product.GetTotalCost();  // Get total cost of each product (Price * Quantity)
        }

        // Returning the detailed breakdown of the total as a string
        return $"Total Products Cost: ${productTotal}\nShipping Cost: ${_shippingCost}\nTotal Cost: ${productTotal + _shippingCost}\n";
    }
}

