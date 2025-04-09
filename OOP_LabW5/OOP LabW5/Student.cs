public class Student
{
    public string Name { get; set; }
    public int ID { get; set; }

    private double gpa;
    public double GPA
    {
        get { return gpa; }
        private set
        {
            if (value >= 0.0 || value <= 4.0)
            {
                gpa = value;
            }
            else
            {
                Console.WriteLine("GPA must be between 0.0 and 4.0");
            }
        }
    }

    //Initialize
    public Student(string name, int id)
    {
        Name = name;
        ID = id;
    }

    //Update GPA
    public void UpdateGPA(double gpa)
    {
        GPA = gpa;
    }

    //Display
    public void Display()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"ID: {ID}");
        Console.WriteLine($"GPA: {GPA}");
    }
}