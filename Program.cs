// See https://aka.ms/new-console-template for more information
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many transaction today?");
        string numStr = Console.ReadLine();
        int num = Int32.Parse(numStr); //cast from string to integer


        TransactionList transactionList = new TransactionList();
        transactionList.init(num);
        for (int i = 0; i < num; i++)
        {
            // creating an object (variable of a certain class type)
            Transaction transaction;
            transaction = new Transaction();

            transaction.setDate(new DateTime(2008, 6, 1));
            transaction.setVal(-10.5f);
            transactionList.Add(transaction);

            Console.WriteLine("transaction value is " + transaction.getVal() + " at time " + transaction.getDate());
        }
        transactionList.Display();
    }

}
