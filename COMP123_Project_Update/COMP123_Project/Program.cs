using System.Data;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using Newtonsoft.Json;

namespace Group3_Project
{
    class Program
    {
        static List<Student> student = new List<Student>();
        static string filePath = "students.json";
        static void Main(string[] args)
        {
            string choice;
            

            //retrieving stored data from the file
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                student = JsonConvert.DeserializeObject<List<Student>>(json);
            }
            do
            {
                Console.Clear();
                DisplayMenu();
                Console.Write("\nEnter the number of your choice: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddStudent();
                        break;
                    case "2":
                        Console.Clear();
                        DisplayAllStudents();
                        break;
                    case "3":
                        SearchStudent();
                        break;
                    case "4":
                        DeleteStudent();
                        break;
                    case "5":
                        DisplaySummary();
                        break;
                    case "6":
                        Console.WriteLine("\nThank you! Have a nice day!\nPress any key to exit...");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("\nInvalid input.\nEnter from 1 - 5, 6 for exit.");
                        break;
                }
            } while (choice != "6");

        }
        //main menu user will interact with
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
        static void AddStudent()
        {
            Console.Clear();
            Console.WriteLine("+++ Add Student: +++\n");

            Console.Write("Enter Student Name: ");
            string studentName = Console.ReadLine();

            Console.Write("Enter Student ID: ");
            int studentID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student GPA: ");
            double studentGPA = Convert.ToDouble(Console.ReadLine());

            Student newStudent = new Student(studentName, studentID, studentGPA);
            student.Add(newStudent);

            Console.WriteLine($"\nStudent Added: {newStudent}\nPress any key to continue...");
            Console.ReadKey();

            // Serialize the list of students to JSON format
            string json = JsonConvert.SerializeObject(student);

            // Write the JSON data to the file
            File.WriteAllText(filePath, json);
        }
        static void DisplayAllStudents()
        {
            Console.WriteLine("+++ All Students: +++\n");

            if (student.Count == 0)
            {
                Console.WriteLine("No students found.\nPress any key to continue...");
            }
            else
            {
                foreach (var stud in student)
                {
                    Console.WriteLine(stud);
                }
                Console.WriteLine("Press any key to continue...");
            }
            Console.ReadKey();
        }
        static void SearchStudent()
        {
            Console.Clear();
            Console.WriteLine("+++ Search Student: +++\n");

            Console.WriteLine("Search by 1.) ID or 2.) Name (Please enter 1 or 2): ");
            int searchOption = Convert.ToInt32(Console.ReadLine());

                //created switch case for searching student with ID or Name
                switch (searchOption)
                {
                    case 1:
                        Console.Write("Enter Student ID: ");
                        int studentID = Convert.ToInt32(Console.ReadLine());

                        Student studentFound = null;
                        foreach (var id in student)
                        {
                            if (id.StudentID == studentID)
                            {
                                studentFound = id;
                                break;
                            }
                        }

                        if (studentFound == null)
                        {
                            Console.WriteLine("\nStudent not found.\nPress any key to continue...");
                        }
                        else
                        {
                            Console.WriteLine($"\nStudent Found: {studentFound}\nPress any key to continue...");
                        }
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Write("Enter Student Name: ");
                        string studentName = Console.ReadLine();

                        Student studentNameFound = null;
                        foreach (var id in student)
                        {
                            if (id.StudentName == studentName)
                            {
                                studentNameFound = id;
                                break;
                            }
                        }

                        if (studentNameFound == null)
                        {
                            Console.WriteLine("\nStudent not found.\nPress any key to continue...");
                        }
                        else
                        {
                            Console.WriteLine($"\nStudent Found: {studentNameFound}\nPress any key to continue...");
                        }
                        Console.ReadKey();
                        break;
                }
        }
        static void DeleteStudent()
        {
            Console.Clear();
            Console.WriteLine("+++ Delete Student: +++\n");

            Console.Write("Enter Student ID: ");
            int studentID = Convert.ToInt32(Console.ReadLine());

            Student studentFound = null;
            foreach (var id in student)
            {
                if (id.StudentID == studentID)
                {
                    studentFound = id;
                    break;
                }
            }

            if (studentFound == null)
            {
                Console.WriteLine("Student not found.\nPress any key to continue...");
            }
            else
            {
                student.Remove(studentFound);
                Console.WriteLine($"\nStudent Deleted: {studentFound}\nPress any key to continue...");
            }
            // Serialize the list of students to JSON format
            string json = JsonConvert.SerializeObject(student);

            // Write the JSON data to the file
            File.WriteAllText(filePath, json);
            Console.ReadKey();
        }

        static void DisplaySummary()
        {
            Console.Clear();
            Console.WriteLine("+++ Summary of Students: +++\n");

            Console.WriteLine($"Total number of students: {student.Count}");
            Console.WriteLine($"Average GPA: {student.Average(student => student.GPA):F2}");
            Console.WriteLine($"Highest GPA: {student.Max(student => student.GPA):F2}");
            Console.WriteLine($"Lowest GPA: {student.Min(student => student.GPA):F2}");

            Console.WriteLine("\nPress any key to continue...");

            // Serialize the list of students to JSON format
            string json = JsonConvert.SerializeObject(student);

            // Write the JSON data to the file
            File.WriteAllText(filePath, json);
            Console.ReadKey();
            Console.ReadKey();
        }

    }
}