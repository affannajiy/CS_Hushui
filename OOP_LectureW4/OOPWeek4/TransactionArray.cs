using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWeek4
{
    internal class TransactionArray
    {
        //data
        private Transaction[] transactions; //array: DatType[] arrayName, transactions is an array object
        private int numTransactions;

        //constructor,
        //1) no return type
        //2) name same as the class
        public TransactionArray()
        {
            transactions = new Transaction[10];
        }

        //constructor
        public TransactionArray(int num)
        {
            transactions = new Transaction[num];
        }

        //operation
        public void Init(int size) { transactions = new Transaction[size]; }

        public void Add(Transaction transaction) // add an object to an array
        {
            transactions[numTransactions] = transaction;
            numTransactions++;
        }

        public void Display()
        { 
            for (int i = 0; i < numTransactions; i++) //for loop
            {
                Console.WriteLine(transactions[i].ToString());
            }
        }
    }
}