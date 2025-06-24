/*
Name: 'Affan Najiy Bin Rusdi
Student ID: 22010453
*/
namespace ADS_LinkedList
{
    public class LinkedList
    {
        private Node head;

        //Insert at Start
        public void InsertAtStart(int value)
        {
            Node newNode = new Node(value);
            newNode.Next = head;
            head = newNode;
            Console.WriteLine($"Inserted {value} at the start of the linked list.");
        }

        //Insert at End
        public void InsertAtEnd(int value)
        {
            Node newNode = new Node(value);
            
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node pointer = head;
                while (pointer.Next != null)
                {
                    pointer = pointer.Next;
                }
                pointer.Next = newNode;
            }
            Console.WriteLine($"Inserted {value} at the end of the linked list.");
        }

        //Insert in Middle
        public void InsertInMiddle(int value, int position)
        {
            Node pointer = head;

            while (pointer != null && pointer.Data != position)
            {
                pointer = pointer.Next;
            }

            if (pointer != null)
            {
                Node newNode = new Node(value);
                newNode.Next = pointer.Next;
                pointer.Next = newNode;
                Console.WriteLine($"Inserted {value} at position {position} in the linked list.");
            }
            else
            {
                Console.WriteLine($"Position {position} not found in the linked list.");
            }
        }

        //Delete at Start
        public void DeleteAtStart()
        {
            if (head == null)
            {
                Console.WriteLine("The linked list is empty.");
                return; //Exit the method if the linked list is empty
            }
            
            Node temporary = head;
            head = head.Next;
            Console.WriteLine($"Deleted {temporary.Data} from the start of the linked list.");
        }
        
        //Delete at End
        public void DeleteAtEnd()
        {
            if (head == null)
            {
                Console.WriteLine("The linked list is empty.");
                return; //Exit the method if the linked list is empty
            }
            
            if (head.Next == null)
            {
                head = null;
                Console.WriteLine("Deleted the last node from the linked list.");
                return; //Exit the method if there is only one node in the linked list
            }
            
            Node pointer = head;
            while (pointer.Next.Next != null) //Pointer Next's Next is not null
            {
                pointer = pointer.Next;
            }
            pointer.Next = null;
            Console.WriteLine("Deleted the last node from the linked list.");
        }

        //Delete Specific Node
        public void DeleteByValue(int value)
        {
            if (head == null)
            {
                Console.WriteLine("The linked list is empty.");
                return; //Exit the method if the linked list is empty
            }
            
            if (head.Data == value)
            {
                DeleteAtStart();
                return; //Exit the method if the value to delete is the first node in the linked list
            }
            
            Node pointer = head;
            while (pointer.Next != null && pointer.Next.Data != value)
            {
                pointer = pointer.Next;
            }

            if (pointer.Next != null)
            {
                pointer.Next = pointer.Next.Next;
                Console.WriteLine($"Deleted {value} from the linked list.");
            }
            else
            {
                Console.WriteLine($"Value {value} not found in the linked list.");
            }
        }

        //Search Node
        public void Search(int value)
        {
            Node pointer = head;
            int position = 0;
            
            while (pointer != null)
            {
                if (pointer.Data == value)
                {
                    Console.WriteLine($"Value {value} found in the linked list.");
                    return; //Exit the method if the value is found
                }
                pointer = pointer.Next;
                position++;
            }
            Console.WriteLine($"Value {value} not found in the linked list.");
        }

        //Display List
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("The linked list is empty.");
                return; //Exit the method if the linked list is empty
            }
            
            Node pointer = head;
            Console.WriteLine("Linked List: ");
            while (pointer != null)
            {
                Console.Write(pointer.Data + " -> ");
                pointer = pointer.Next;
            }
            Console.WriteLine("NULL");
        }
    }
}
