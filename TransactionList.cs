using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class TransactionList
{
    //data
    private Transaction[] transactions; // transaction is an array object
    private int numTransaction;

    //operation
    public void init(int num) { transactions = new Transaction[num]; }
    public void Add(Transaction transaction)
    {
        transactions[numTransaction] = transaction;
    }
    public void Display()
    {
        for (int i = 0; i < numTransaction; i++)
        {
            Console.WriteLine(transactions[i].ToString());
        }
    }
}