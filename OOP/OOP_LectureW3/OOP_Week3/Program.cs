// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        //Creating an Object (Variable of a certain Class Type)
        //new = 
        //we need to ENCAPSULATE
        Transaction transaction = new Transaction();

        transaction.setDate(new DateTime(2008, 6, 1, 9, 16, 37));
        transaction.setVal(10.5f);

        Console.WriteLine("Transaction Value: " + transaction.getVal() + " ,Time " + transaction.getDate().ToString());
    }
}