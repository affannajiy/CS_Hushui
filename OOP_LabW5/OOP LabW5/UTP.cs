public class UTP
{
    //Name, Dept, Course, Intake, CGPA
    public string Name { get; set; }
    public string Dept { get; set; }
    public string Course { get; set; }
    public string Intake { get; set; }
    public double CGPA { get; set; }

    //Constructor
    public UTP(string name, string dept, string course, string intake, double cgpa)
    {
        Name = name;
        Dept = dept;
        Course = course;
        Intake = intake;
        CGPA = cgpa;
    }
}