using System;
using System.Collections.Generic;
using System.Linq;

public class Order
{
    public List<Product> Products { get; private set; }
    public Address ShipmentAddress { get; private set; }
    public Customer Customer { get; private set; }

    public void AddProduct(Product newProduct)
    {
        Product product = Products
            .Where(product => product.SerialNumber.Equals(newProduct.SerialNumber))
            .SingleOrDefault();

        if (product == null)
            product.AddUnits(1);
        else
            Products.Add(newProduct);
    }
}

public class Customer
{
}

public class Address
{
}

public class Product
{
    public string SerialNumber { get; private set; }
    public int Quantity { get; private set; }

    public void AddUnits(int units)
    {
        Quantity += units;
    }
}