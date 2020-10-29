using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    class Student
    {
        public int StuId { get; set; }
        public string StuName { get; set; }
        public DateTime DOB { get; set; }
        public Student(int StuId, string StuName, DateTime DOB)
        {
            this.StuId = StuId;
            this.StuName = StuName;
            this.DOB = DOB;
        }
    }
    class Course
    {
        public int Courseid { get; set; }
        public string CourseName { get; set; }
        public int Duration { get; set; }
        public int Fees { get; set; }
        public Course(int Courseid, string CourseName, int Duration, int Fees)
        {
            this.Courseid = Courseid;
            this.CourseName = CourseName;
            this.Duration = Duration;
            this.Fees = Fees;
        }
    }
    class info
    {
        public static void DisplayStudent(Student student)
        {
            Console.WriteLine("Student ID: {0} ||Student Name: {1}||Student DOB: {2}", student.StuId, student.StuName, student.DOB);
        }
        public static void DisplayCourse(Course course)
        {
            Console.WriteLine("CourseID: {0}||Course Name: {1}|| Duration:{2}||Fees: {3}",course.Courseid, course.CourseName, course.Duration, course.Fees);
        }
    }
    class Question1
    {
        static void Main()
        {
            Console.WriteLine("Enter the Total Number of Student");
            int size = Convert.ToInt32(Console.ReadLine());
            Student[] stuArr = new Student[size];
            for(int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter the Student Name");
                string StuName = Console.ReadLine();
                Console.WriteLine("Enter the Student Id");
                int StuId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Date of Birth");
                DateTime DOB = Convert.ToDateTime(Console.ReadLine());
                stuArr[i] = new Student(StuId, StuName, DOB);
                info.DisplayStudent(stuArr[i]);
            }

            Console.WriteLine("Enter the Total Number of Courses");
            int Len = Convert.ToInt32(Console.ReadLine());
            Course[] CourseArr = new Course[Len];
            for (int i = 0; i < Len; i++)
            {
                Console.WriteLine("Enter the Course name");
                string CourseName = Console.ReadLine();
                Console.WriteLine("Enter Course ID, Duration And Fees");
                int CourseID = Convert.ToInt32(Console.ReadLine());
                int Duration = Convert.ToInt32(Console.ReadLine());
                int Fees = Convert.ToInt32(Console.ReadLine());
                CourseArr[i] = new Course(CourseID, CourseName, Duration, Fees);
                info.DisplayCourse(CourseArr[i]);
            }
            Console.Read();
        }
    }
}
