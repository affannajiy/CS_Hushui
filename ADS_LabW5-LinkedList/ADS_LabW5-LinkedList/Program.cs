using System;

/*
Name: 'Affan Najiy Bin Rusdi
Student ID: 22010453
*/
namespace ADS_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            int choice, value, position;

            Console.WriteLine("----Linked List Program----");

            do
            {   
                //Menu
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Insert at Start");
                Console.WriteLine("2. Insert at End");
                Console.WriteLine("3. Insert in Middle");
                Console.WriteLine("4. Delete at Start");
                Console.WriteLine("5. Delete at End");
                Console.WriteLine("6. Delete Specific Node");
                Console.WriteLine("7. Search Node");
                Console.WriteLine("8. Display List");
                Console.WriteLine("9. Exit");

                Console.Write("\nEnter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the value to be inserted: ");
                        value = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtStart(value);
                        break;
                    case 2:
                        Console.Write("Enter the value to be inserted: ");
                        value = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtEnd(value);
                        break;
                    case 3:
                        Console.Write("Enter the value to be inserted: ");
                        value = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the position: ");
                        position = Convert.ToInt32(Console.ReadLine());
                        list.InsertInMiddle(value, position);
                        break;
                    case 4:
                        list.DeleteAtStart();
                        break;
                    case 5:
                        list.DeleteAtEnd();
                        break;
                    case 6:
                        Console.Write("Enter the value to be deleted: ");
                        value = Convert.ToInt32(Console.ReadLine());
                        list.DeleteByValue(value);
                        break;
                    case 7:
                        Console.Write("Enter the value to be searched: ");
                        value = Convert.ToInt32(Console.ReadLine());
                        list.Search(value);
                        break;
                    case 8:
                        list.Display();
                        break;
                    case 9:
                        Console.WriteLine("Exiting the program...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            } while (choice != 9);
        }
    }
}