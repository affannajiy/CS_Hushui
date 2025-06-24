public class SalesTransaction
{
    public string salespersonName { get; set; }
    public double transactionVal { get; set; }
    public DateTime Date { get; set; }

    //Constructor
    public SalesTransaction(string name, double value, DateTime date)
    {
        salespersonName = name;
        transactionVal = value;
        Date = date;
    }
}

public class Sales
{
    private List<SalesTransaction> transactions = new List<SalesTransaction>();

    //Method to Add Transaction
    public void Addtransaction(SalesTransaction transaction)
    {
        transactions.Add(transaction);
    }

    //Method to Calc Sum
    public double Sum()
    {
        double sum = 0;
        foreach (var transaction in transactions)
        {
            sum += transaction.transactionVal;
        }
        return sum;
    }
}