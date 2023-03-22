using Microsoft.VisualBasic;

class Person
{
    //Fields
    private string _Password;
    public readonly string SIN;

    //Properties
    public  bool IsAuthenticated { get; private set; }
    public  string Name { get; private set; }
    //constructor
    public Person(string name, string sin)
        => (Name, SIN) = (name,sin);
    //Methods
    public void Login (string password) {

        if (password != "admin123") //password set
        {
           //throw new AccountException("Invalid password.");
        }
        IsAuthenticated = true;
    }
    public void Logout()
    {
        IsAuthenticated = false;
    }
    public override string ToString()
        => $"{Name} {(IsAuthenticated ? "is authenticated" : "is not authenticated")}";

}
struct Transaction
{
    //properties
    public string AccountNumber { get; }
    public double Amount { get; }
    public double EndBalance { get; }
    public Person Originator { get; }
    public DateTime Time { get; }

    //methods
    public Transaction(string accountNumber, double amount, double endBalance, Person person, DateTime time)
        => (AccountNumber, Amount, EndBalance, Originator, Time) = (accountNumber, amount, endBalance, person, time);

    public override string ToString()
        => $"{Time.ToShortTimeString()} {Originator.Name} {Amount:C2} {EndBalance:C2}"; //include withdraw or deposit in the output
}

class AccountException : Exception
{
    //fields
    public const string ACCOUNT_DOES_NOT_EXIST = "Account does not exist";
    public const string CREDIT_LIMIT_HAS_BEEN_EXCEEDED = "Credit limit has been exceeded";
    public const string NAME_NOT_ASSOCIATED_WITH_ACCOUNT = "Name not associated with account";
    public const string NO_OVERDRAFT = "No overdraft";
    public const string PASSWORD_INCORRECT = "Incorrect Password";
    public const string USER_DOES_NOT_EXIST = "User dont exist.";
    public const string USER_NOT_LOGGED_IN = "User not logged in.";
    //Properties

    //Methods
    public AccountException() : base()
    { 
    
    }
    public AccountException(string reason) : base()
    {

    }

}

