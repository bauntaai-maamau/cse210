using System;

public class Customer
{
    private string _customerName;
    public Address CustomerAddress { get; set; }



    // Public properties to control access to the private fields
    public string CustomerName
    {
        get { return _customerName; }
        set { _customerName = value; }
    }



    public Customer(string customername, Address address)
    {
        _customerName = customername;
        CustomerAddress = address;
    }



    // Method to check if the customer lives in the USA
    public bool LivesInUSA()
    {
        return CustomerAddress.IsInUSA(); // Call IsInUSA method from the Address class
    }

}