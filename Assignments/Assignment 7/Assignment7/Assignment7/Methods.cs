using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    interface IuserInterface
    {
        void ShowFirstScreen();
        void ShowStudentScreen();
        void ShowAdminScreen();
        void ShowallStudentsScreen();
        void ShowStudentregistrationscreen();
        void IntroducenewCourseScreen();
        void ShowAllCourseScreen();

    }
    class Methods:IuserInterface
    {
        public void ShowFirstScreen()
        {
            Desktop:
            Console.WriteLine("Welcome to Student Management System");
            Console.WriteLine("tell us who you are:\n 1. Student\n 2. Admin");
            Console.WriteLine("Enter your Choice (1 or 2)");
            Console.WriteLine("to Exit press 3");
            int scanner = Convert.ToInt32(Console.ReadLine());
            switch (scanner)
            {
                case 1:
                    ShowStudentScreen();
                    goto Desktop;
                case 2:
                    ShowAdminScreen();
                    goto Desktop;
                default:
                    Console.WriteLine("Thank You");
                    break;
            }
        }
        public void ShowStudentScreen()
        {
            Console.WriteLine("Welcome to Student Screen");
            Console.WriteLine("To Display all Courses: Press 1");
            Console.WriteLine("For Registration: press 2");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    ShowAllCourseScreen();
                    break;
                case 2:
                    ShowStudentregistrationscreen();
                    break;
                default:
                    Console.WriteLine("Please Enter the valid Option");
                    break;

            }
        }
        public void ShowAdminScreen()
        {
            Console.WriteLine("Welcome to Student Management System");
            Console.WriteLine("To add New Course to list Press 1\n To see all the student list press 2");
            int opt = Convert.ToInt32(Console.ReadLine());
            switch (opt)
            {
                case 1:
                    IntroducenewCourseScreen();
                    break;
                case 2:
                    ShowallStudentsScreen();
                    break;
                default:
                    Console.WriteLine("Please Enter the valid option");
                    break;
            }
        }
        public void ShowallStudentsScreen()
        {
            Info info = new Info();
            info.DisplayStudent();
        }
        public void ShowAllCourseScreen()
        {
            Info info = new Info();
            info.DisplayCourse();
        }
        public void ShowStudentregistrationscreen()
        {
            var con = App.GetConnection();

            Console.WriteLine("Enter the StudentId");
            int Sid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the StudentName");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter DOB");
            string Dob = Console.ReadLine();

            var cmd = new SqlCommand("StuReg", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", Sid);
            cmd.Parameters.AddWithValue("@name", Name);
            cmd.Parameters.AddWithValue("@Dob", Dob);
            int i = cmd.ExecuteNonQuery();
            Console.WriteLine("Rows Affected: {0}", i);
            Console.WriteLine("thank you for Registering");
        }
        public void IntroducenewCourseScreen()
        {
            var con = App.GetConnection();
            Console.WriteLine("Enter the CourseId");
            int Cid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the CourseName");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter Duration");
            int Duration = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Fee amount");
            int Fee = Convert.ToInt32(Console.ReadLine());
            var cmd = new SqlCommand("AddCourse", con);
            cmd.Parameters.AddWithValue("@id", Cid);
            cmd.Parameters.AddWithValue("@name", Name);
            cmd.Parameters.AddWithValue("@duration", Duration);
            cmd.Parameters.AddWithValue("@fees", Fee);
            int i = cmd.ExecuteNonQuery();
            Console.WriteLine("Rows Affected: {0}", i);
            Console.WriteLine("New Course has been added to the List");



        }
    }
}
