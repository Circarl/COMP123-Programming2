using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10_EventDemo
{
    class Student : IComparable
    {
        public string Name { get; set; }
        public int NumberOfCourses { get; set; }
        public double Gpa { get; set; }
        public override string ToString()
            => $"{Name} ({Gpa:f2}) {NumberOfCourses}course(s)";

        public static List<Student> GetStudents()
            => new List<Student>
            {
                new Student{ Name = "Sathi Akter", NumberOfCourses= 5, Gpa = 3.8 },
                new Student{ Name = "Daniel Ross", NumberOfCourses= 2, Gpa = 3.9 },
                new Student{ Name = "Reueben Cserepka", NumberOfCourses= 3, Gpa = 4.0 },
                new Student{ Name = "Devansh Shah", NumberOfCourses= 4, Gpa = 4.1 },
                new Student{ Name = "Ming Zheng", NumberOfCourses= 6, Gpa = 3.9 },
                new Student{ Name = "Sanjib Saha", NumberOfCourses= 5, Gpa = 4.0 }
            };

        public override int GetHashCode()
        {
            return NumberOfCourses.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return NumberOfCourses == (obj as Student).NumberOfCourses;
        }
        //necessary to do comparison
        public int CompareTo(object obj)
        {
            return Gpa.CompareTo((obj as Student).Gpa );
        }
    }
    internal class CollectionDemo
    {
        public static void ListDemo()
        {
            List<Student> students = Student.GetStudents();

            //add a new item to the list collection
            Student hao = new Student { Name = "Hao", NumberOfCourses = 5, Gpa = 4.1 };
            students.Add(hao);
            students.Insert(1, hao);

            //adding multiple items
            students.AddRange(new Student[]
            {
                new Student{ Name = "Sahasan", NumberOfCourses= 5, Gpa = 4.1 },
                new Student{ Name = "Deigo", NumberOfCourses= 6, Gpa = 4.2 }
            });
            //sort
            students.Sort();
            //iterating the list
            foreach (var stud in students)
            {
                Console.WriteLine(stud);
            }
        }
        public static void HashSetDemo()
        {
            //HashSet is a collection that contains
            //only unique items
            //initialising the student collection
            HashSet<Student> students = new HashSet<Student>();
            foreach (Student student in Student.GetStudents())
            {
                students.Add(student);
            }

            //add a new item to the set collection
            Student hao = new Student { Name = "Hao", NumberOfCourses = 5, Gpa = 4.1 };
            students.Add(hao);

            //add an existing item to the set collection
            students.Add(hao);

            //iterating the hashset
            foreach (var stud in students)
            {
                Console.WriteLine(stud);
            }
        }

        public static void DictionaryDemo()
        {
            // a collection of key-value pairs
            //can be consider it to be a lookup table
            Dictionary<string, Student> students = new Dictionary<string, Student>
            {
                { "sathi", new Student{ Name = "Sathi Akter", NumberOfCourses= 5, Gpa = 3.8 } },
                { "daniel", new Student{ Name = "Daniel Ross", NumberOfCourses= 6, Gpa = 3.9 } },
                { "reuben", new Student{ Name = "Reueben Cserepka", NumberOfCourses= 5, Gpa = 4.0 } },
                { "devansh", new Student{ Name = "Devansh Shah", NumberOfCourses= 5, Gpa = 4.1 } },
                { "ming", new Student{ Name = "Ming Zheng", NumberOfCourses= 6, Gpa = 3.9 } },
                { "sanjib", new Student{ Name = "Sanjib Saha", NumberOfCourses= 5, Gpa = 4.0 } }
            };

            //three possible iterations:
            //keys
            //values
            //pairs
            Console.WriteLine("\nKeys");
            foreach (var key in students.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine("\nValues");
            foreach (var value in students.Values)
            {
                Console.WriteLine(value);
            }


            //swapping the values of sathi and sanjib
            Student temp = students["sathi"];
            students["sathi"] = students["sanjib"];
            students["sanjib"] = temp;
            
            Console.WriteLine("\nPairs");
            foreach (var pair in students)
            {
                    Console.WriteLine(pair);
            }

            Console.WriteLine("\nFilter");
            foreach (var pair in students)
            {
                if (pair.Key.StartsWith("s"))
                    Console.WriteLine(pair.Value);
            }
        }
    }
}
