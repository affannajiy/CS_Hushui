//Base Class
public abstract class Shape
{
    //Virtual Method
    public abstract double CalculateArea();
}

//Derived Circle Class
public class Circle : Shape
{
    public double Radius { get; set; }
    
    //Constructor
    public Circle(double radius)
    {
        Radius = radius;
    }

    //Override
    public override double CalculateArea() 
    {
        return Math.PI * Math.Pow(Radius, 2); 
    }

}

//Derived Rectangle Class
public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    //Constructor
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    //Override
    public override double CalculateArea()
    {
        return Width * Height;
    }
}