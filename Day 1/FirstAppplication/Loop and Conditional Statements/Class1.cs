using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Loop_and_Conditional_Statements
{
    class Class1
    {
        static void Main()
        {
            Console.WriteLine("Enter the value of Num1 and Num2");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            int Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Operation to be Performed");
            string Operation = Console.ReadLine();
           
            switch(Operation)
            {
                case "+":
                   
                    Console.WriteLine("Addition:{0}",Num1 + Num2);
                break;
                case "-":
                    Console.WriteLine("subtraction{0}:", Num1 - Num2);
                break;
                case "*":
                    Console.WriteLine("Multiplication: {0}", Num1 * Num2);
                    break;
                case "/":
                    Console.WriteLine("division:{0}", Num1 / Num2);
                    break;
                default:
                    Console.WriteLine("Invalid Operation");
                    break;

            }

            Console.Read();
        }
    }
}
