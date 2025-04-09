public class Person
{
    //FirstName, LastName, Age
    public string FName { get; set; }
    public string LName { get; set; }
    public int Age { get; set; }

    //Constructor
    public Person(string fName, string lName, int age)
    {
        FName = fName;
        LName = lName;
        Age = age;
    }

    //Display
    public void Display()
    {
        Console.WriteLine($"Full Name: {FName} {LName}");
        Console.WriteLine($"Age: {Age}");
    }
}