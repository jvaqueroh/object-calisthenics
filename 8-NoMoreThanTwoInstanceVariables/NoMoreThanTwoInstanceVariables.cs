using System.Collections.Generic;

public class OldName
{
    public string First { get; private set; }
    public string Middle { get; private set; }
    public string Last { get; private set; }
}

public class Name
{
    public string Surname { get; private set; }
    public GivenNames Given { get; private set; }
}

public class GivenNames
{
    public List<string> names { get; private set; }
}