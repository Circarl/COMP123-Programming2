class Program
{
    class Pets
    {
        public string Name { get; }
        private string Owner { get; set; }
        public int Age { get; }
        public string Description { get; }
        private bool IsHouseTrained { get; set; }

        public Pets(string name, int age, string description)
        {
            this.Name = name;
            this.Age = age;
            this.Description = description;

            this.Owner = "No Owner";
            this.IsHouseTrained = false;
        }

        public override string ToString()
        {
            return $"\nName: {Name}" +
                $"\nOwner: {Owner}" +
                $"\nAge: {Age}" +
                $"\nDescription: {Description}" +
                $"\nHouse Trained: {IsHouseTrained}";

        }
        public void Train()
        {
            IsHouseTrained = true;
        }
        public void SetOwner(string newOwner)
        {
            this.Owner = newOwner;
        }
        public string InputOwner()
        {
            return Owner;
        }
    }
    static void Main(string[] args)
    {
        Pets pet = new Pets("Johnny", 5, "Gorilla");
        Pets pet2 = new Pets("Rosita", 2, "Pig");
        Pets pet3 = new Pets("Buster", 4, "Koala");
        Pets pet4 = new Pets("Ash", 3, "Hedgehog");
        List<Pets> Pet_List = new List<Pets>() { pet, pet2, pet3, pet4 };

        pet.SetOwner("Carl");
        pet3.SetOwner("Carl");
        pet2.Train();
        pet.Train();

        foreach (Pets i in Pet_List)
        {
            Console.WriteLine(i);
        }
        string inputOwner = " ";
        Console.Write("\n~ Find Owner\nEnter Name of Owner: ");
        inputOwner = Console.ReadLine();
        Console.WriteLine("\n+++++++++++++++++++++++++");

        foreach (Pets i in Pet_List)
        {
            if (i.InputOwner() == inputOwner)
            {
                Console.WriteLine(i);
            }
        }
    }
}