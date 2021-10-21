using System;

public class WrapPrimitives{
    public void CreateAVehicle(){
        var newVehicle = new Vehicle("A123", 1890);
    }
}

public class Vehicle{
    public string SerialNumber { get; private set; }
    public int ProductionYear { get; private set; }

    public Vehicle(string serialNumber, int productionYear)
    {
        if(string.IsNullOrWhiteSpace(serialNumber) || !serialNumber.StartsWith("W") || serialNumber.Length != 15)
            throw new ArgumentException("serialNumber");
        if(productionYear > DateTime.Now.Year || productionYear < 1900)
            throw new ArgumentException("productionYear");
        
        SerialNumber = serialNumber;
        ProductionYear = productionYear;
    }
}