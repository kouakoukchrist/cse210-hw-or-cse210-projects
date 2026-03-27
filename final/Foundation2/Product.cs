using System;

public class Product
{
    private string _productName;
    private string _productId;
    private double _pricePerUnit;
    private int _quantity;

 public Product(string productName, string productId, double Unitprice, int quantity)

    {
       _productName = productName;
       _productId = productId;
       _pricePerUnit =  Unitprice;
       _quantity =  quantity;
    }

 public string GetProductName()
    {
        return _productName;
    }

 public string GetProductId()
    {
        return _productId;
    }

 public double GetPricePerUnite()
    {
        return _pricePerUnit;
    }

 public int GetQuantity()
    {
        return _quantity;
    }

 public double GetTotalCost()
    {
        return _pricePerUnit * _quantity;
    }
}