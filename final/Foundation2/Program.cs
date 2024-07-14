using System;

public class Program
{
    public static void Main()
    {
        // Create a list of customers
        List<Customer> customers = new List<Customer>();

        // Create products
        Product product1 = new Product("Computer Mouse", 506, 10, 2);
        Product product2 = new Product("Computer Keyboard", 304, 15, 1);
        Product product3 = new Product("Hair Dryer", 103, 35, 1);
        Product product4 = new Product("Curling Iron", 203, 25, 1);

        // Create a sample address
        Address address1 = new Address("123 Main St", "Anahiem", "CA", "USA");
        Customer customer1 = new Customer("Robert Adams", address1);
        customers.Add(customer1);
        

        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");     
        Customer customer2 = new Customer("Stephanie Myer", address2);
        customers.Add(customer2);


         // Create a list of orders
        List<Order> orders = new List<Order>();
        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        // Add products to the order
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Calculate total cost of the order
        double totalCost1 = order1.FinalTotalCost();
        double totalCost2 = order2.FinalTotalCost();

        // Print packing label and shipping label
        Console.WriteLine($"Order 1 for {customer1.Name}:");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Total Cost: ${totalCost1}");

        Console.WriteLine();

        Console.WriteLine($"Order 1 for {customer2.Name}:");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"Total Cost: ${totalCost2}");
    }
}
