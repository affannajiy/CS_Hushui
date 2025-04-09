// See https://aka.ms/new-console-template for more information
// Below was added but the code was more simpler
namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //INTRO
            Console.Write("Hej! "); //write without new line
            Console.WriteLine("I like pizza!"); //write with new line
            Console.WriteLine("It's really good!");
            //Console.Beep(); //Loud Ahh Beep

            //"This is a comment" ahh
            /*
             * this
             * is
             * a multiline
             * comment ahh
             */

            Console.WriteLine("\t'Affan"); //tab for indent
            Console.WriteLine("'Af\bfan"); //backspace

            //VARIABLES
            int x; //declaration
            x = 123; //initialisation
            int y = 321; //declare + initial
            int z = x + y;
            int age = 19; //whole numbers
            double height = 170.5; //decimals
            bool alive = true; //bool: True or False
            char symbol = '$'; //single quotes for characters
            String name = "'Affan"; //string

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine("Hello " + name);
            Console.WriteLine("Your age is " + age);
            Console.WriteLine("Your height is " + height + "cm");
            Console.WriteLine("Are you alive? " + alive);
            Console.WriteLine("Your symbol: " + symbol);

            String userName = symbol + name;
            Console.WriteLine("Your username: " + userName);

            //CONSTANTS
            const double pi = 3.142; //constants cannot be changed value
            Console.WriteLine(pi);

            //TYPE CASTING = convert value to a different data type
            //               user inputs are strings

            double a = 3.14;
            int b = Convert.ToInt32(a); //convert to Integer

            Console.WriteLine(b);
            Console.WriteLine(a.GetType()); // to get Data Type

            int c = 123;
            double d = Convert.ToDouble(c); // will not add .0

            Console.WriteLine(d);

            int e = 321;
            String f = Convert.ToString(e); //now cannot use for math

            Console.WriteLine(f.GetType()); //now 321 a string
            Console.WriteLine(f);

            String g = "$";
            char h = Convert.ToChar(g);

            Console.WriteLine(h);
            Console.WriteLine(h.GetType());

            String i = "true";
            bool j = Convert.ToBoolean(i);

            Console.WriteLine(j);

            //INPUT
            Console.WriteLine("What's your name?");
            String myname = Console.ReadLine();

            Console.WriteLine("What's your age?");
            int myage = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello "+ myname);
            Console.WriteLine("You are " + age + " year(s) old");

            Console.ReadKey(); //program will end until key is hit
        }
    }
}