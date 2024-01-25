public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public char Gender { get; set; }

    // Constructor that takes a name argument
    public Person(string name)
    {
        Name = name;
    }

    // You might have other properties and methods relevant to a Person here
}
