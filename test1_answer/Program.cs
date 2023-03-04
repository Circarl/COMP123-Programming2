using System;

class Program
{
    static void Main(string[] args)
    {
        int leapYear;
        while (true)
        {
            Console.Write("Enter a year (0000-9999): ");
            if (int.TryParse(Console.ReadLine(), out year) && year >= 0 && year <= 9999)
            {
                break;
            }
            Console.WriteLine("Invalid year! Please enter again.");
        }

        if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
        {
            Console.WriteLine("Leap Year");
        }
        else
        {
            Console.WriteLine("Not a Leap Year");
        }

        Console.ReadLine();
    }
}
