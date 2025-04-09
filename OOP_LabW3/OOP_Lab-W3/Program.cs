// See https://aka.ms/new-console-template for more 
/* Example: a = 1, b = -7, c = 10,
   Root: 2, 5 */
Console.Write("Enter a: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter b: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter c: ");
double c = Convert.ToDouble(Console.ReadLine());

double x1, x2;
x1 = (-b - (Math.Sqrt(Math.Pow(b, 2) - (4 * a * c)))) / 2 * a;
x2 = (-b + (Math.Sqrt(Math.Pow(b, 2) - (4 * a * c)))) / 2 * a;

Console.WriteLine("Root 1: " + x1);
Console.WriteLine("Root 2: " + x2);