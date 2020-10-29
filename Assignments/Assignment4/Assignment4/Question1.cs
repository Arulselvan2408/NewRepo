using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    abstract class Student
    {
        internal string Name= "Arul";
        internal int StudentID= 1005;
        internal int Grade;
        public abstract Boolean IsPassed(int Grade);
    }
    class Undergraduate : Student
    {
        public override bool IsPassed(int Grade)
        {
            if (Grade > 70)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
    class Graduate : Student
    {
        public override bool IsPassed(int Grade)
        {
            if (Grade > 80)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        
           
    }
    class Question1
    {
        static void Main()
        {
            Undergraduate undergraduate = new Undergraduate();
            Console.WriteLine("Enter the Name and ID");
            undergraduate.Name = Console.ReadLine();
            undergraduate.StudentID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks");
            undergraduate.Grade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name: {0},ID: {1}, Marks: {2}, Result: {3}", undergraduate.Name, undergraduate.StudentID, undergraduate.Grade, undergraduate.IsPassed(undergraduate.Grade));
            
            Graduate graduate = new Graduate();
            Console.WriteLine("Enter the Name and ID");
            graduate.Name = Console.ReadLine();
            graduate.StudentID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks");
            graduate.Grade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name: {0},ID: {1}, Marks: {2}, Result: {3}", graduate.Name, graduate.StudentID, graduate.Grade, graduate.IsPassed(graduate.Grade));
            Console.Read();
        }
    }
}
