using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Question3
    {
        static void Main()
        {
            Console.WriteLine("Enter the Value of N");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            
            for (int i=2; i < n; i++)
            {
                if(i%2 != 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine(sum);
            Console.Read();

        }
    }
}
