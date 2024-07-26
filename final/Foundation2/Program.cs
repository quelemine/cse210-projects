using System;

class Program
{
    static void Main()
    {
        // Create addresses
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create products
        Product product1 = new Product("Laptop", "L123", 1200, 1);
        Product product2 = new Product("Mouse", "M456", 25, 2);
        Product product3 = new Product("Keyboard", "K789", 45, 1);

        // Create orders
        List<Product> productsOrder1 = new List<Product> { product1, product2 };
        List<Product> productsOrder2 = new List<Product> { product3 };

        Order order1 = new Order(productsOrder1, customer1);
        Order order2 = new Order(productsOrder2, customer2);

        // Display results
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.CalculateTotalCost());

        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order2.CalculateTotalCost());
    }
}