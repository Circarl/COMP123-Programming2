namespace Group3_Project
{
    class Student
    {
        // Properties
        public string StudentName { get; set; }
        public int StudentID { get; set; }
        public double GPA { get; set; }

        // Constructor
        public Student(string studentName, int studentID, double gpa)
        {
            StudentName = studentName;
            StudentID = studentID;
            GPA = gpa;
        }

        public override string ToString()
        {
            return $"{StudentName,-10} ID# {StudentID,-10} GPA:{GPA,-10:F2}";
        }
    }
}
