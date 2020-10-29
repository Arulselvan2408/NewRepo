using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_and_Conditional_Statements
{
    class SwitchCaseEg
    {static void Main()
        {
            /*
             * int Num;
            Console.WriteLine("Enter the Number");
            Num = Convert.ToInt32(Console.ReadLine());

            switch (Num)
            {
                case 1:
                    Console.WriteLine("monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid Number");
                    break;
            }
            */
            Console.WriteLine("Enter the value of input1 and Input2");
            int input1 = Convert.ToInt32(Console.ReadLine());
            int input2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Operation to be Performed");
            string operation = Console.ReadLine();
            int result;
            float division;

            switch(operation)
            {
                case "+":
                    result = input1 + input2;
                    Console.WriteLine("addition={0}", result);
                break;
                case "-":
                    result = input1 - input2;
                    Console.WriteLine("subtraction={0}", result);
                break;
                case "*":
                    result = input1 * input2;
                    Console.WriteLine("multiplication={0}", result);
                    break;
                case "/":
                    division= input1 / input2;
                    Console.WriteLine("Division={0}", division);
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;

            }
            Console.Read();
        }
    }
}
