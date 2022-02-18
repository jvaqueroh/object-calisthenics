using System;
using System.Collections.Generic;
using System.Linq;

public class Order
{
    public ProductsList Products { get; private set; }
    public Address ShipmentAddress { get; private set; }
    public Customer Customer { get; private set; }

    public void AddProduct(Product newProduct)
    {
        Products.Add(newProduct);
        UpdateInvoice();
    }

    private void UpdateInvoice()
    {
        throw new NotImplementedException();
    }
}

public class ProductsList
{
    private List<Product> products = new List<Product>();

    public void Add(Product newProduct)
    {
        Product product = products
            .Where(product => 
                product.SerialNumber.Equals(newProduct.SerialNumber))
            .SingleOrDefault();

        if (product != null)
            product.AddUnits(newProduct.Quantity);
        else
            products.Add(newProduct);
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