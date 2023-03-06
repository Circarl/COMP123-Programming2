class Car
{
    private string color;
    private int year;
    private string model;
    private bool isDrivable;
    private double price;

    public Car(string model, string color, int year, double price, bool isDrivable = true)
    {
        this.model = model;
        this.color = color;
        this.year = year;
        this.price = price;
        this.isDrivable = isDrivable;
    }
    public override string ToString()
    {
        //Condition? Consequent : alternative
        return $"{model} ({color}) manufactured in {year} - with a price of {price:C2},{(isDrivable == true ? " is drivable" : " not drivable")}";
    }
    //        In your main method write the code to do the following:
    //1. Create at least four cars and print them.Remember to call the constructor with 4 or 5
    //parameters
    static void Main(string[] args)
    {
        Console.WriteLine("Created 4 Cars: ");
        Car object1 = new Car("Toyota", "Red", 1992, 4500, false);
        Car object2 = new Car("Honda", "Silver", 2002, 6500, true);
        Car object3 = new Car("Chevrolet", "Black", 1989, 8500, false);
        Car object4 = new Car("Volkswagen", "Bronze", 1999, 4500, true);
        Console.WriteLine(object1);
        Console.WriteLine(object2);
        Console.WriteLine(object3);
        Console.WriteLine(object4);

    }
}