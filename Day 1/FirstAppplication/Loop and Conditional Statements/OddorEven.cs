using System;


namespace Loop_and_Conditional_Statements
{
    class OddorEven
    {
        static void Main()
        {
            int Number;
            Console.WriteLine("Enter the number");
            Number = Convert.ToInt32(Console.ReadLine());
            if (Number % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
            Console.Read();
        }
    }
}