using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Practice
    {
        static void Main()
        {
            Console.WriteLine("Enter the student Name");
            string StuName = Console.ReadLine();
            Console.WriteLine("enter the student ID");
            int studentid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("studentid name: {0}\n stuID: {1}", StuName, studentid);
            Console.Read();

          

        }
    }
}
