using Banking_Application;

static class Bank
{
    //fields
    static List<Account> accounts;
    static List<Person> persons;

    //properties


    //methods
    static Bank()
    {
        Initialize();
    }
    private static void CreatePersons() 
    {
        persons = new List<Person>(){
        new Person("Narendra", "1234-5678"),
        new Person("Ilia", "2345-6789"),
        new Person("Tom", "3456-7890"),
        new Person("Syed", "4567-8901"),
        new Person("Arben", "5678-9012"),
        new Person("Patrick", "6789-0123"),
        new Person("Yin", "7890-1234"),
        new Person("Hao", "8901-2345"),
        new Person("Jake", "9012-3456")
        };
    }
    private static void CreateAccounts()
    {
        accounts = new List<Account>{
            new VisaAccount(700),              //VS-100000
            new VisaAccount(550, -500),     //VS-100001
            new SavingsAccount(5000),        //SV-100002
            new SavingsAccount(),            //SV-100003
            new CheckingAccount(2000),      //CK-100004
            new CheckingAccount(1500, true) //CK-100005
        };
    }
    public static void Initialize()
    {
        CreatePersons();
        CreateAccounts();
        accounts[0].AddUser(persons[0]);
        accounts[0].AddUser(persons[1]);
        accounts[0].AddUser(persons[2]);

        accounts[1].AddUser(persons[3]);
        accounts[1].AddUser(persons[4]);
        accounts[1].AddUser(persons[2]);

        accounts[2].AddUser(persons[0]);
        accounts[2].AddUser(persons[5]);
        accounts[2].AddUser(persons[6]);

        accounts[3].AddUser(persons[5]);
        accounts[3].AddUser(persons[6]);

        accounts[4].AddUser(persons[5]);
        accounts[4].AddUser(persons[7]);
        accounts[4].AddUser(persons[8]);

        accounts[5].AddUser(persons[5]);
        accounts[5].AddUser(persons[6]);

    }
    public static void PrintAccounts()
    {
        foreach (Account account in accounts)
        {
            Console.WriteLine(account);
        }
    }
    public static void SaveAccounts(string filename) //save all accounts in the accounts collection to a text file in json format.
    {
        //add json format
    }
    public static void PrintPersons()
    {
        foreach (Person person in persons)
        {
            Console.WriteLine(person);
        }
    }
    public static Person GetPerson(string name)
    {
        foreach (Person person in persons)
        {
            if (person.Name == name)
                return person;
        }
        throw new AccountException($"Person with name '{name}' not found");
    }
    public static Account GetAccount(string number)
    {
        foreach (Account account in accounts)
        {
            if (account.Number == number)
                return account;
        }
        throw new AccountException($"Account with number '{number}' not found.");
    }


}