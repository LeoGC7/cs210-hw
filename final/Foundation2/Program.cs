using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Random St", "Sample", "ID", "USA");
        Address address2 = new Address("456 Random St", "São Paulo", "SP", "Brazil");

        Customer customer1 = new Customer("Fulano Smith", address1);
        Customer customer2 = new Customer("Ciclano Silva", address2);

        Product product1 = new Product("Laptop", "AB123", 1000.00, 1);
        Product product2 = new Product("Mouse", "CD456", 25.00, 2);
        Product product3 = new Product("Keyboard", "EF789", 45.00, 1);
        Product product4 = new Product("Monitor", "GH1011", 200.00, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalCost()}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalCost()}\n");

    }
}