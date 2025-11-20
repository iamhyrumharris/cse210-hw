public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    private decimal _totalPrice;
    private bool _isUSAddress;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
        _isUSAddress = DomesticShipping();
        _totalPrice = TotalPriceCalc();
    }

    public decimal TotalPriceCalc()
    {
        foreach (Product product in _products)
        {
            _totalPrice += product._totalCost();
        }
        if (!_isUSAddress)
        {
            _totalPrice += 35;
        }
        else
        {
            _totalPrice += 5;
        }
        return _totalPrice;
    }

    public void PackingLabelCreation()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine($"Item: {product._name} - ID: {product._productID}");
        }
    }

    public void ShippingLabelCreation()
    {
        Console.WriteLine($"{_customer.GetName()}");
        Console.WriteLine($"{_customer.GetAddress()}");
    }

    public bool DomesticShipping()
    {
        return _customer.IsUSCustomer();
    }

}