using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Question6
    {
        static void Main()
        {
            int[] Matrix = new int[10] { 1, 5, 3, 6, 2, 3, 9, 4, 3, 6 };
            Console.WriteLine("Enter the Element");
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i=0; i<Matrix.Length; i++)
            {
                if (n== Matrix[i])
                {
                    count = count + 1;
                }  
            }
            Console.WriteLine("frequency={0}", count);
            Console.Read();

        }
    }
}
