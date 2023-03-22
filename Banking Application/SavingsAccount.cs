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
        if (IsHolder(person.Name))
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

        if (!person.IsAuthenticated)
        {
            throw new AccountException("This person is not authenticated.");
        }

        if (amount > Balance)
        {
            throw new AccountException("Insufficient funds.");
        }

        base.Deposit(-amount, person);

    }
    public override void PrepareMonthlyReport()
    {
        double serviceCharge = transactions.Count * COST_PER_TRANSACTION;
        double interest = LowestBalance * INTEREST_RATE / 12;
        Balance += interest - serviceCharge;
        transactions.Clear();
    }
}
