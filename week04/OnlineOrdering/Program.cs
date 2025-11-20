using System;

class Program
{
    static void Main(string[] args)
    {
        
        Customer customer1 = new Customer("Lee Jarris", new Address("3001 Lions Trail", "Farmington", "NM", "USA"));
        Customer customer2 = new Customer("Hyrum Jarris", new Address("504 e 18", "Soccoro", "NM", "USA"));


        List<Product> products1 = new List<Product>
        {
            new Product("Laptop", "A123", 999.99m, 1),
            new Product("Mouse", "B456", 25.50m, 2),
            new Product("keyboard", "K500", 20.00m, 1)
        };
        List<Product> products2 = new List<Product>
        {
            new Product("Tablet", "C789", 499.99m, 2),
            new Product("Headphones", "D012", 89.99m, 2),
            new Product("tablet pen", "T100", 89.99m, 2)
        };


        Order order1 = new Order(products1, customer1);

        Console.WriteLine("Packing Label:");
        order1.PackingLabelCreation();
        Console.WriteLine("\nShipping Label:");
        order1.ShippingLabelCreation();
        Console.WriteLine($"Total Price: ${order1.TotalPriceCalc()}");

        
        
        Order order2 = new Order(products2, customer2);

        Console.WriteLine("\nPacking Label:");
        order2.PackingLabelCreation();
        Console.WriteLine("\nShipping Label:");
        order2.ShippingLabelCreation();
        Console.WriteLine($"Total Price: ${order2.TotalPriceCalc()}");
    }
}