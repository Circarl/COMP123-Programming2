using Banking_Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


abstract class Account
{
    //        Fields
    //private static int CURRENT_NUMBER;
    protected readonly List<Transaction> transactions = new List<Transaction>();
    protected readonly List<Person> holders = new List<Person>();
    public readonly string Number;
    private static int _LAST_NUMBER = 0;
    //-$ CURRENT_NUMBER : int
    //# transactions : List<Transaction>
    //# holders : List<Person>
    //+ «readonly» Number : string

    //          Properties
    public double Balance { get; protected set; }
    public double LowestBalance { get; protected set; }
    //+ «property protected setter» Balance : double
    //+ «property protected setter» LowestBalance : double

    //      Methods
    public Account(string type, double balance)
    {
        Balance = balance;
        LowestBalance = balance;
        Number = type + _LAST_NUMBER.ToString();
        _LAST_NUMBER++;
    }
    public void AddUser(Person person) 
    {
        holders.Add(person);
    }

    public void Deposit(double amount, Person person)
    {
        Balance += amount;
        if (Balance < LowestBalance) { LowestBalance = Balance; }
        Transaction transact = new Transaction(Number, amount, Balance, person, DateTime.Now);
        transactions.Add(transact);
    }
    public bool IsHolder(string name) {
        foreach (Person person in holders)
        {
            if (person.Name == name)
            {
                return true;
            }
        }
        return false;
    }
    public abstract void PrepareMonthlyReport();
    public override string ToString()
    {
        string result = $"Account Number: {Number}\nUsers:\n";
        foreach (Person person in holders)
        {
            result += $"{person.Name}\n";
        }
        result += $"Balance: {Balance}\nTransactions:\n";
        foreach (Transaction transaction in transactions)
        {
            result += $"{transaction}\n";
        }
        return result;
    }
    //+ ToString() : string
    //a.Declare and initialise a string variable to store the return value and add the following to it:
    //b.Add the AccountNumber to the result value
    //c.Adds the names of each of the users of the account
    //d.Adds the Balance
    //e.	Adds all the transactions

}
