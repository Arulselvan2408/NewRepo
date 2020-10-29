using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Question5
    {
        //static void Main()
        //{
            //Console.WriteLine("Enter the number");
            //int Num = Convert.ToInt32(Console.ReadLine());
           // string Number = Convert.ToString(Num);
           // Console.WriteLine("Reversed Digits:{0}", Number.reverse());
           // Console.Read();

        //}
        static void Main()
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number with Reversed Digits:");
            while (num != 0)
            {
                int rem = num % 10;
                num = num / 10;
                Console.Write(rem);
            }
            Console.Read();
        }
    }
}
