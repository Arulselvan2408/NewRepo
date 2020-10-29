using System;

namespace Loop_and_Conditional_Statements
{
    class ForloopEg
    {
        static void Main()
        {
            int table, n;
            Console.WriteLine(" Enter the table to be Printed");
                table = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Number");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i=1; i<=n; i++)
            {
                Console.WriteLine("{0}*{1}={2}", table, i, i * table);

            }
            Console.ReadLine();
        }
    }
}
