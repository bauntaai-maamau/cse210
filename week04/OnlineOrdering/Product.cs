using System;

public class Product
{
    private string _product;
    private string _id;
    private int _price;
    private int _quantity;



    // Public properties to control access to the private fields
    public string ProductName
    {
        get { return _product; }
        set { _product = value; }
    }

    public string Id
    {
        get { return _id; }
        set { _id = value; }
    }

    public int Price
    {
        get { return _price; }
        set { _price = value; }
    }

    public int Quantity
    {
        get { return _quantity; }
        set { _quantity = value; }
    }



    public Product(string product, string id, int price, int quantity)
    {
        _product = product;
        _id = id;
        _price = price;
        _quantity = quantity;
    }


    // A method to display the product's details
    public void DisplayProductInfo()
    {
        Console.WriteLine($"Product: {_product}");
        Console.WriteLine($"ID: {_id}");
        Console.WriteLine($"Price: {_price}");
        Console.WriteLine($"Quantity: {_quantity}");
    }
}


    

    


    

