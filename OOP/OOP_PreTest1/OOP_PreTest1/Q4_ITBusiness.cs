public class ITCompany
{
    public string companyName { get; set; }
    public string CEOName { get; set; }

    public virtual void Register() { }
    public virtual void Close() { }
}

/*
 * Polymorphism
 * Defining a method in the base class and then overriding it in the derived class
*/

public class ITProduct : ITCompany
{
    public override void Register()
    {
        Console.WriteLine("Registering IT Product Company");
    }

    public override void Close()
    {
        Console.WriteLine("Closing IT Product Company");
    }
}

public class ITService : ITCompany
{
    public override void Register()
    {
        Console.WriteLine("Registering IT Service Company");
    }

    public override void Close()
    {
        Console.WriteLine("Closing IT Service Company");
    }
}

/*
# Polymorphism Demo
ITCompany company = new ITProduct();
company.Register(); //Call ITProduct Register
company = new ITService();
company.Register(); //Call ITService Register
*/