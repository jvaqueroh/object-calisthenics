using System;

public class DoNotAbbreviate
{
    public void SomeUseCase(Person firstPerson, Person secondPerson)
    {
        int ageComparisonResult = firstPerson.Compare(secondPerson);
        PrintOrdered(firstPerson, secondPerson, ageComparisonResult);
    }

    private static void PrintOrdered(Person person1, Person person2, int ageComparisonResult)
    {
        if (ageComparisonResult > 0)
        {
            Print(person1, person2);
        }
        else
        {
            Print(person2, person1);
        }
    }

    private static void Print(Person person1, Person person2)
    {
        Console.WriteLine(person1);
        Console.WriteLine(person2);
    }
}

public class Age
{
    public int Years { get; private set; }

    public int Compare(Age other){
        return this.Years - other.Years;
    }
}

public class Person
{
    public string Name { get; private set; }
    public string Surname { get; private set; }
    public Age Age { get; private set; }
    //properties omited

    private Person(string pName, string pSurname, Age pAge)
    {
        this.Name = pName;
        this.Surname = pSurname;
        this.Age = pAge;
    }

    public static Person Create(string name, string surname)
    {
        if (name == null || surname == null)
            return null;

        return new Person(name, surname, null);
    }

    public static Person Create(string name, string surname, Age age)
    {
        if (age == null)
            return null;

        var person = Person.Create(name, surname);
        if (person != null)
            person.Age = age;

        return person;
    }

    public int Compare(Person otherPerson)
    {
        return Age.Compare(otherPerson.Age);
    }
}