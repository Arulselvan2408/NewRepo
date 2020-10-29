using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Question2
    {
        static void Main()
        {
            Console.WriteLine("Enter the Student Name");
            String Name = Console.ReadLine();
            Console.WriteLine("Enter the Age");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter theSchool Name");
            string School = Console.ReadLine();

            Console.WriteLine("Name: {0}\nAge: {1}\nSchool:{2}", Name, Age, School);
            Console.Read();
        }
    }
}
