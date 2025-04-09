using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWeek4
{
    internal class TransactionList
    {
        private List<Transaction> transactions; //array: DatType[] arrayName, transactions is an array object
        private int numTransactions;

        //constructor,
        //1) no return type
        //2) name same as the class
        public TransactionList()
        {
            transactions = new List<Transaction>();
        }

        //constructor
        public TransactionList(int num)
        {
            transactions = new List<Transaction>();
        }

        //operation
        public void Init(int size) { transactions = new List<Transaction>(); }

        public void Add(Transaction transaction) // add an object to an array
        {
            transactions.Add(transaction);
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
