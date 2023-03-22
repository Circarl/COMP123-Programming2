using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Banking_Application;
class SavingsAccount : Account
{
    //fields
    private static double COST_PER_TRANSACTION = 0.05;
    private static double INTEREST_RATE = 0.015;
    //properties

    //methods
    public SavingsAccount(double balance = 0, bool hasOverDraft = false) : base("SV-", balance)
    {

    }
    public new void Deposit(double amount, Person person)
    {
        if (person.IsAuthenticated)
        {
            base.Deposit(amount, person);
        }
    }
    public void Withdraw(double amount, Person person)
    {
        if (!IsHolder(person.Name))
        {
            throw new AccountException("This person is not associated with this account.");
        }

    }
}
