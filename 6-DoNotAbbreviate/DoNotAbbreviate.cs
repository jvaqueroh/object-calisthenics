using System;

public class DoNotAbbreviate
{
    public Person CreatePersonWithNameAndSurname(string personName, string personSurname)
    {
        if (personName != null && personSurname != null)
            return new Person(personName, personSurname, null);
        else
            return null;
    }

    public Person CreatePersonWithNameSurnameAndAge(string personName, string personSurname, Age personAge)
    {
        if (personName != null && personSurname != null && personAge != null)
            return new Person(personName, personSurname, personAge);
        else
            return null;
    }

    public int CheckWhoIsOlderAndPrintOrdered(Person person1, Person person2)
    {
        var result = person1.Age.Years - person2.Age.Years;
        if (result > 0)
        {
            Console.WriteLine(person1);
            Console.WriteLine(person2);
        }
        else
        {
            Console.WriteLine(person2);
            Console.WriteLine(person1);
        }

        return result;
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

    public Person(string personName, string personSurname, Age personAge)
    {
        this.Name = personName;
        this.Surname = personSurname;
        this.Age = personAge;
    }
}