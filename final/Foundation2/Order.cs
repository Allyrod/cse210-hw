using System;
using System.Collections.Generic;
public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double FinalTotalCost()
    {
        double total = 0;
        foreach ( var product in _products)
        {
            total += product.TotalCost();
            return total;
        }

        if (_customer.LivesInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;      
       
    }

   
   public string PackingLabel()
   {
        string label = "Packing Label: \n";

        foreach (var product in _products)
        {
            label += $"{product.ProductName} ( ID: {product.ProductId})\n";
        }

        return label;
   }
   
   
   public string ShippingLabel()
    {
        return $"Shipping Label for {_customer.Name}:\n{_customer.Address.GetFullAddress()}";
    }
}