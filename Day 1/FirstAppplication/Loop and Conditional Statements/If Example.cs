using System;

namespace Loop_and_Conditional_Statements
{
    class If_Example
    {
        static void Main()
        {
            int Num1, Num2, Num3;
            Console.WriteLine("Enter Num1");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Num2");
            Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Num3");
            Num3 = Convert.ToInt32(Console.ReadLine());
        if (Num1>Num2 && Num1>Num3)
            {
                Console.WriteLine("Num1 is greatest");
            }
        else if (Num2 > Num1 && Num2 > Num3)
            {
                Console.WriteLine("Num2 is greatest");
            }
        else
            {
                Console.WriteLine("Num3 is greatest");
            }
            Console.ReadLine();
         }
       
    }
}
