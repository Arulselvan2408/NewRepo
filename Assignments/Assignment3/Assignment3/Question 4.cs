using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class methodoverloading
    {
        internal void Swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After Swapping: a={0} and b={1}", a,b);
        }
        internal void Swap(string c, string d)
        {
            string temp = c;
            c = d;
            d = temp;
            Console.WriteLine("After Swapping: c={0} and d={1}", c, d);
        }
    }

   
    class Question_4
    {
        static void Main()
        {
            methodoverloading obj = new methodoverloading();
            Console.WriteLine("enter the value of a and b");
            int a = Convert.ToInt32(Console.ReadLine());
            int b= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter c and d");
            string c = Console.ReadLine();
            string d = Console.ReadLine();
            obj.Swap(a, b);
            obj.Swap(c, d);
            Console.Read();

        }
    }
}
