public class Product
{
    public string _name;
    public string _productID;
    public decimal _price;
    public int _quantity;

    public Product(string name, string productID, decimal price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public decimal _totalCost()
    {
        return _price * _quantity;
    }
}