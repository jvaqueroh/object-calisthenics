using System;
using System.Runtime.Serialization;

public class Poliymorfism
{
    public int CalculateVolume(Model3D model)
    {
        if (model.Type == "sphere")
            return CalculateSphereVolume(model);
        else if (model.Type == "cube")
            return CalculateCubeVolume(model);
        else if (model.Type == "cylinder")
            return CalculateCylinderVolume(model);
        else
            throw new UnknownModelException(model.Type);
    }

    private int CalculateCylinderVolume(Model3D model)
    {
        throw new NotImplementedException();
    }

    private int CalculateCubeVolume(Model3D model)
    {
        throw new NotImplementedException();
    }

    private int CalculateSphereVolume(Model3D model)
    {
        throw new NotImplementedException();
    }
}

public class Model3D
{
    public string Type { get; internal set; }
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
