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
    private readonly string value;
    
    public SerialNumber(string value)
    {
        if (Validate(value))
            throw new ArgumentException("value");
        this.value = value;
    }

    private bool Validate(string value)
    {
        return string.IsNullOrWhiteSpace(value) || !value.StartsWith("W") || value.Length != 15;
    }

    public override bool Equals(object obj)
    {
        return obj is SerialNumber number &&
               value == number.value;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(value);
    }

}

public class ProductionYear{
    private readonly int value;

    public ProductionYear(int value)
    {
        if (Validate(value))
            throw new ArgumentException("value");
        this.value = value;
    }

    public override bool Equals(object obj)
    {
        return obj is ProductionYear year &&
               value == year.value;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(value);
    }

    private bool Validate(int value)
    {
        return value > DateTime.Now.Year || value < 1900;
    }
}