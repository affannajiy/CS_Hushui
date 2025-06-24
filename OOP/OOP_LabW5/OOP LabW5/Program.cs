using OOP_LabW5;
namespace OOP_LabW5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //1: Calculate Circle Area Class
            Console.WriteLine("+++Task 1+++");
            CircleCalculator calc = new CircleCalculator();
            double radius = 5;

            Console.WriteLine($"Circle Area: {calc.CalculateArea(radius)}");
            Console.Write("\n");

            //2: UTP Class
            Console.WriteLine("+++Task 2+++");
            UTP utp = new UTP("'Affan Najiy", "Computer Science", "C#", " May 2023", 4.0);
            Console.WriteLine($"Student Name: {utp.Name}");
            Console.WriteLine($"Department: {utp.Dept}"); 
            Console.WriteLine($"Course: {utp.Course}");
            Console.WriteLine($"Intake: {utp.Intake}");
            Console.WriteLine($"CGPA: {utp.CGPA}");
            Console.Write("\n");

            //3: Person Class
            Console.WriteLine("+++Task 3+++");
            Person person = new Person("Affan", "Najiy", 100);
            person.Display();
            Console.Write("\n");

            //4: Student Class
            Console.WriteLine("+++Task 4+++");
            Student student = new Student("Affan", 22010453);
            student.UpdateGPA(4.0);
            student.Display();
            Console.Write("\n");

            //5: Shape Class
            Console.WriteLine("+++Task 5+++");
            Shape circle = new Circle(5); //(radius)
            Console.WriteLine($"Circle Area: {circle.CalculateArea()}");

            Shape rectangle = new Rectangle(5, 10); //(width, height)
            Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");
            Console.Write("\n");
        }
    }
}