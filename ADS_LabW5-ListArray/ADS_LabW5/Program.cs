using System;

/*
Name        : 'Affan Najiy Bin Rusdi
Student ID  : 22010453
*/
namespace ADS_ListArray
{
    class Program
    {
        //Use Static variables and array (share between methods)
        static int[] arr;
        static int size = 0;
        static int maxLength;

        //Main
        static void Main(string[] args)
        {
            Console.WriteLine("----List Array Program----");
            Console.Write("Enter the maximum length of the array: ");
            maxLength = Convert.ToInt32(Console.ReadLine());
            arr = new int[maxLength];

            //Menu
            int choice;
            do
            {
                Console.WriteLine("\nMain Menu");
                Console.WriteLine("1. Insert an element");
                Console.WriteLine("2. Delete an element");
                Console.WriteLine("3. Find element at position");
                Console.WriteLine("4. Find the index of an element");
                Console.WriteLine("5. Empty the array");
                Console.WriteLine("6. Display the array");
                Console.WriteLine("7. Exit");
                Console.Write("\nEnter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                //Options (switch)
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the element to insert: ");
                        int element = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the position to insert the element: ");
                        int insertposition = Convert.ToInt32(Console.ReadLine());
                        InsertElement(element, insertposition);
                        break;
                    case 2:
                        Console.Write("Enter the position of the element to delete: ");
                        int deleteposition = Convert.ToInt32(Console.ReadLine());
                        DeleteElement(deleteposition);
                        break;
                    case 3:
                        Console.Write("Enter the position of the element to find: ");
                        int findposition = Convert.ToInt32(Console.ReadLine());
                        FindElement(findposition);
                        break;
                    case 4:
                        Console.Write("Enter the element to find the index: ");
                        int findelement = Convert.ToInt32(Console.ReadLine());
                        FindIndex(findelement);
                        break;
                    case 5:
                        EmptyArray();
                        break;
                    case 6:
                        DisplayArray();
                        break;
                    case 7:
                        Console.WriteLine("Exiting the program...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            } while (choice != 7);
        }

        //Insert Method
        static void InsertElement(int element, int insertposition)
        {
            if (size == maxLength)
            {
                Console.WriteLine("Overflow. Array is full ;)");
            }
            else if (insertposition >= 0 && insertposition <= size)
            {
                for (int i = size; i > insertposition; i--)
                {
                    arr[i + 1] = arr[i];
                }
                arr[insertposition] = element;
                size++;
                Console.WriteLine("Element inserted successfully.");
            }
            else
            {
                Console.WriteLine("Invalid position. Element not inserted.");
            }
        }

        //Delete Method
        static void DeleteElement(int deleteposition)
        {
            if (size == 0)
            {
                Console.WriteLine("Underflow. Array is empty ;)");
            }
            else if (deleteposition >= 0 && deleteposition < size)
            {
                for (int j = deleteposition; j < size - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }
                size--;
                Console.WriteLine("Element deleted successfully.");
            }
            else
            {
                Console.WriteLine("Invalid position. Element not deleted.");
            }
        }

        //FindElement Method
        static void FindElement(int findposition)
        {
            if (findposition >= 0 && findposition < size)
            {
                Console.WriteLine($"Element at position {findposition}: {arr[findposition]}"); 
                //Parking Lot Method
            }
            else
            {
                Console.WriteLine("Invalid position. Element not found.");
            }
        }

        //FindIndex Method
        static void FindIndex(int findelement)
        {
            int index = Array.IndexOf(arr, findelement);
            if (index != -1)
            {
                Console.WriteLine($"Index of element {findelement}: {index}");
            }
            else
            {
                Console.WriteLine($"Element {findelement} not found in the array.");
            }
        }

        //EmptyArray Method
        static void EmptyArray()
        {
            size = 0;
            Console.WriteLine("Array has been emptied.");
        }

        //DisplayArray Method
        static void DisplayArray()
        {
            if (size == 0)
            {
                Console.WriteLine("Array is empty.");
            }
            else
            {
                Console.WriteLine("Array elements:");
                for (int k = 0; k < size; k++)
                {
                    Console.Write($"[{arr[k]}]" + " ");
                }
                Console.WriteLine();
            }
        }
    }
}