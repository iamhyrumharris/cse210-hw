public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool IsUSCustomer()
    {
        return _address.IsUSShipping();
    }

    public string GetAddress()
    {
        return _address.ShippingAddress();
    }

    public string GetName()
    {
        return _name;
    }
}