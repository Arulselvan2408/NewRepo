using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Question1
    {
        static void Main()
        {
            Console.WriteLine("Enter the last Natural Number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i=n; i>0; i--)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
