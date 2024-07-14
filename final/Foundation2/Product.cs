using System;

public class Product
{
    private string _productname;
    private int _productid;
    private double _priceperunit;
    private int _quantity;

    public string ProductName
    {   
        get { return _productname; }
        set { _productname = value; }
    }

    public int ProductId
    {
        get { return _productid; }
        set { _productid = value; }
    }

    public double PricePerUnit
    {
        get { return _priceperunit; }
        set { _priceperunit = value; }
    }

    public int Quantity
    {
        get { return _quantity; }
        set { _quantity = value; }
    }

    public Product(string productname, int productid, double priceperunit, int quantity)
    {
        _productname = productname;
        _productid = productid;
        _priceperunit = priceperunit;
        _quantity = quantity;
    }

    public double TotalCost()
    {
        return _priceperunit * _quantity;
    }
}
