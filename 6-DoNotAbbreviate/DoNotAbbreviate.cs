using System;

public class DoNotAbbreviate
{
    public Person CreatePWithNameSurname(string pName, string pSurname)
    {
        if (pName != null && pSurname != null)
            return new Person(pName, pSurname, null);
        else
            return null;
    }

    public Person CreatePWithNameSurnameAge(string pName, string pSurname, Age pAge)
    {
        if (pName != null && pSurname != null && pAge != null)
            return new Person(pName, pSurname, pAge);
        else
            return null;
    }

    public int CheckOlderAndPrint(Person p1, Person p2)
    {
        var r = p1.Age.Years - p2.Age.Years;
        if (r > 0)
        {
            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
        else
        {
            Console.WriteLine(p2);
            Console.WriteLine(p1);
        }

        return r;
    }
}

public class Age
{
    public int Years { get; private set; }
}

public class Person
{
    public string Name { get; private set; }
    public string Surname { get; private set; }
    public Age Age { get; private set; }

    public Person(string pName, string pSurname, Age pAge)
    {
        this.Name = pName;
        this.Surname = pSurname;
        this.Age = pAge;
    }
}