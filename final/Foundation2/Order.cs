using System;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

public Order(Customer customer)
    {
        _customer = customer;
    }


public void AddProduct(Product product)
    {
        _products.Add(product);
    }

public double GetTotalPrice()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        if(_customer.IsInUs())
        {
            total += 5;
        }

        else
        {
            total += 35;
        }
        return total;
     }

public string GetPackingLabel()
    {
        string label = "";

        foreach(Product product in _products)
        {
            label += $"Product Name: {product.GetProductName()}, ID: {product.GetProductId()}\n";
        }
        return label;
    }

public string GetShippingLabel()
    {
        return $"Customer Name: {_customer.GetName()} \nCustomer Address: {_customer.GetAddress().GetFullAddress()}";
    }
}