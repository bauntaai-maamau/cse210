using System;

public class Customer
{
    private string _customerName;
    public class Address;



    // Public properties to control access to the private fields
    public string CustomerName
    {
        get { return _customerName; }
        set { _customerName = value; }
    }



    public Customer(string customer)
    {
        _customerName = customer;
    }
}