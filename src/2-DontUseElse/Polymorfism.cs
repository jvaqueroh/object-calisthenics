using System;
using System.Runtime.Serialization;

public class Poliymorfism
{
    public void SomeComplexMethod(Model3D model)
    {
        // some code here
        // ...
        var volume = model.CalculateVolume();
        // more code here
        // ...
    }
}

public abstract class Model3D
{
    public abstract int CalculateVolume();
}

public class Sphere:Model3D{
    public override int CalculateVolume()
    {
        throw new NotImplementedException();
    }
}
public class Cylinder:Model3D{
    public override int CalculateVolume()
    {
        throw new NotImplementedException();
    }
}
public class Cube:Model3D{
    public override int CalculateVolume()
    {
        throw new NotImplementedException();
    }
}

[Serializable]
internal class UnknownModelException : Exception
{
    public UnknownModelException()
    {
    }

    public UnknownModelException(string message) : base(message)
    {
    }

    public UnknownModelException(string message, Exception innerException) : base(message, innerException)
    {
    }

    protected UnknownModelException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
