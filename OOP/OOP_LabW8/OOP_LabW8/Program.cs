/*Delagates C#
 *Def: It is a method which can be passed as an argument to another method.
 *Link: i. https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/delegates
 *      ii. https://www.c-sharpcorner.com/article/delegates-in-c-sharp/
 */

class Program
{
    //Step 1 : Declaring a delegate
    public delegate bool CheckSmartPhone(string smartPhoneName);
    public delegate bool CheckSmartPhoneOS(string OSName);
    static void Main(string[] args)
    {
        //Step 2 : Creating a delegate instances
        CheckSmartPhone isThisSmartPhone = new CheckSmartPhone(GetIPhoneX);

        //Step 3 : calling the methods using the delegate objects
        bool checkSmartPhone = isThisSmartPhone("IPhoneX");
        if (checkSmartPhone)
        {
            System.Console.WriteLine("It is an Apple smart phone!!!");
        } //Good2
        else
        {
            System.Console.WriteLine("It is not an Apple smart phone!!!");
        }

        //Android Phone Delegate Objects
        CheckSmartPhone isThisSmartPhone2 = new CheckSmartPhone(GetSamsungGalaxyS24);
        bool checkSmartPhone2 = isThisSmartPhone2("Samsung Galaxy S24");
        if (checkSmartPhone2)
        {
            System.Console.WriteLine("It is an Android smart phone!!!");
        }
        else
        {
            System.Console.WriteLine("It is not an Android smart phone!!!");
        }

        //Not Smart Phone
        CheckSmartPhone isThisSmartPhone3 = new CheckSmartPhone(NotSmartPhone);
        bool checkSmartPhone3 = isThisSmartPhone3("Not Smartphone");
        if (checkSmartPhone3)
        {
            System.Console.WriteLine("It is not a smart phone!!!");
        }
        else
        {
            System.Console.WriteLine("It is a smart phone!!!");
        }

        //OS
        CheckSmartPhoneOS areBothRunsOnApple = new CheckSmartPhoneOS(GetIPhoneXOS);
        CheckSmartPhoneOS onePlus8 = new CheckSmartPhoneOS(GetOnePlus8);

        areBothRunsOnApple += onePlus8;
        bool check_IOS_Devices = areBothRunsOnApple("IOS");

        if (check_IOS_Devices)
        {
            System.Console.WriteLine("Both runs on IOS!!!");
        }
        else
        {
            System.Console.WriteLine("Not all of them runs on IOS!!!");
        }                           
    }

    //Apple Phone
    private static bool GetIPhoneX(string name)
    {
        if (name == "IPhoneX")
            return true;
        else
            return false;
    }

    //Android Phone
    private static bool GetSamsungGalaxyS24(string name)
    {
        if (name == "Samsung Galaxy S24")
            return true;
        else
            return false;
    }

    //Not Phone
    private static bool NotSmartPhone(string name)
    {
        if (name == "Not Smartphone")
            return true;
        else
            return false;
    }
    

    //OS
    private static bool GetIPhoneXOS(string OS)
    {
        if (OS == "IOS")
            return true;
        else
            return false;
    }
    
    private static bool GetOnePlus8(string OS)
    {
        if (OS == "Android")
            return true;
        else
            return false;
    }

}