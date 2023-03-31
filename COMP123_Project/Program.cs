using System.Data;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace Assignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            string choice;
            do
            {
                Console.Clear();
                DisplayMenu();
                Console.Write("\nEnter the number of your choice: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine($"\nTotal Sum is: {CalculateSum(5)}");
                        break;
                    case "2":
                        Console.WriteLine($"\nTotal Average is: {CalculateAverage(5):f2}");
                        break;
                    case "3":
                        //DisplayIntArray(numbers);
                        break;
                    case "4":
                        //DisplayStringArray(poem);
                        break;
                    case "5":
                        //DisplayIntArray(CreateIntArray());
                        break;
                    case "6":
                        Console.WriteLine("\nThank you! Have a nice day!\nAny key to exit...");
                        break;
                    default:
                        Console.WriteLine("\nInvalid input.\nEnter from 1 - 5, 6 for exit.");
                        break;
                }
                if (choice != "6")
                    Console.Write("\nAny key - back to Main Menu... ");
                Console.ReadKey();
            } while (choice != "6");

        }
        public static void DisplayMenu()
        {
            Console.WriteLine("=== Student Record Management System ===\n");
            Console.WriteLine("1.) Add New Student");
            Console.WriteLine("2.) Display All Students");
            Console.WriteLine("3.) Search Student");
            Console.WriteLine("4.) Delete Student");
            Console.WriteLine("5.) Display Summary");
            Console.WriteLine("6.) Exit");
        }
        public static int CalculateSum(int x)
        {
            Console.Clear();
            int count = x;
            int i = 0;
            int totalSum = 0;
            int[] number = new int[count];
            do
            {
                Console.Write("Enter Integer: ");
                number[i] = Convert.ToInt32(Console.ReadLine());
                totalSum += number[i];
                count--;
            } while (count != 0);

            return totalSum;

        }
        static double CalculateAverage(int x)
        {
            Console.Clear();
            double average = 0.00f;
            int count = x;
            int countSum = x;
            int i = 0;
            double totalSum = 0.00f;
            double[] number = new double[count];

            do
            {
                Console.Write("Enter Integer: ");
                number[i] = Convert.ToDouble(Console.ReadLine());
                totalSum += number[i];
                count--;
            } while (count != 0);
            average = totalSum / countSum;

            return average;
        }
        static void DisplayIntArray(int[] arrayIntList)
        {
            Console.Clear();
            for (int i = 0; i < arrayIntList.Length; i++)
                Console.Write($"{arrayIntList[i]} ");
        }

        static void DisplayStringArray(string[] arrayStringList)
        {
            Console.Clear();
            for (int i = 0; i < arrayStringList.Length; i++)
                Console.Write($"{arrayStringList[i]} ");

        }

        static int[] CreateIntArray()
        {
            Console.Clear();
            int arrayLength;

            Console.Write("Enter length of array: ");
            arrayLength = Convert.ToInt32(Console.ReadLine());
            int[] newIntArray = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write($"Enter value of array {i + 1}: ");
                newIntArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            return newIntArray;
        }

    }
}