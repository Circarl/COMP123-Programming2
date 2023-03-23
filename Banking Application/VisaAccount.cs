using Banking_Application;
using System;

class VisaAccount : Account
{
    //fields
    private static double _INTEREST_RATE = 0.1995;
    private double _creditLimit;
    //    -$ INTEREST_RATE 		: double
    //- credilLimit	: double

    //Properties

    //Methods
    public VisaAccount(double balance, double creditLimit = 1200) : base("VS-", balance)
        => (_creditLimit) = (creditLimit);
    public void DoPayment(double amount, Person person)
        => Deposit(amount, person);
    public void DoPurchase(double amount, Person person)
    {
        if (!holders.Contains(person))
        {
            throw new AccountException("Person is not associated with this account");
        }

        if (!person.IsAuthenticated)
        {
            throw new AccountException("Person is not logged in");
        }

        if (Balance - amount < -_creditLimit)
        {
            throw new AccountException("Purchase will exceed the credit limit");
        }

        Deposit(-amount, person);
    }
    public override void PrepareMonthlyReport()
    {
        double interest = LowestBalance * (_INTEREST_RATE / 12);
        Balance -= interest;
        transactions.Clear();
    }
    //+ «constructor» VisaAccount(balance : double, creditLimit : double)
    //+ DoPayment(amount: double, person Person) : : void
    //+ DoPurchase(amount: double, person Person) : : void
    //+ PrepareMonthlyReport() : : void
}

