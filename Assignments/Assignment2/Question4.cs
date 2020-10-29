using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Question4
    {
        static void Main()
        {
            Console.WriteLine("Enter the number");
            int Num = Convert.ToInt32(Console.ReadLine());
            string Number = Convert.ToString(Num);
            Console.WriteLine("Number of Digits:{0}", Number.Length);
            Console.Read();
                
        }
    }
}
