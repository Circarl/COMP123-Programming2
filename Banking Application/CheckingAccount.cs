using Banking_Application;
class CheckingAccount : Account
{
    private static readonly double COST_PER_TRANSACTION = 0.05;
    private static readonly double INTEREST_RATE = 0.005;
    private bool hasOverdraft;

    public CheckingAccount(double balance = 0, bool hasOverdraft = false) : base("CK-", balance)
    {
        this.hasOverdraft = hasOverdraft;
    }

    // Methods
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
            throw new AccountException("This person is not logged in.");
        }

        if (amount > Balance && !hasOverdraft)
        {
            throw new AccountException("Cannot withdraw more than the available balance.");
        }

        base.Deposit(-amount, person);
    }
    public override void PrepareMonthlyReport()
    {
        double serviceCharge = transactions.Count * COST_PER_TRANSACTION;
        double interest = (Balance * INTEREST_RATE) / 12;
        Balance += interest - serviceCharge;
        transactions.Clear();
    }
}

