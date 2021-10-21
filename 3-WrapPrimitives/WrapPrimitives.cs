using System;

public class WrapPrimitives{
    public void CreateAVehicle(){
        var newVehicle = new Vehicle(
            new SerialNumber("A123"), 
            new ProductionYear(1890));
    } 
}

public class Vehicle{
    public SerialNumber SerialNumber { get; private set; }
    public ProductionYear ProductionYear { get; private set; }

    public Vehicle(SerialNumber serialNumber, ProductionYear productionYear)
    {
        SerialNumber = serialNumber;
        ProductionYear = productionYear;
    }
}

public class SerialNumber{
    public SerialNumber(string value)
    {
        if (Validate(value))
            throw new ArgumentException("value");
    }

    private bool Validate(string value)
    {
        return string.IsNullOrWhiteSpace(value) || !value.StartsWith("W") || value.Length != 15;
    }

    public string Value { get; }
}

public class ProductionYear{
    public ProductionYear(int value)
    {
        if (Validate(value))
            throw new ArgumentException("value");
    }

    private bool Validate(int value)
    {
        return value > DateTime.Now.Year || value < 1900;
    }
}