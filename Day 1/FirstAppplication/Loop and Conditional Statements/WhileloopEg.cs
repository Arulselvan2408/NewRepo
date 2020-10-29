using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_and_Conditional_Statements
{
    class WhileloopEg
    {
        static void Main()
        {
        int IntialValue=0, EndValue;
            Console.WriteLine("enter the End value");
            EndValue = Convert.ToInt32(Console.ReadLine());
        while(IntialValue<=EndValue)
            {
                IntialValue++;
                if(IntialValue%2==0)
                {
                    Console.WriteLine("{0} is even", IntialValue);
                }
                Console.ReadLine();
            }


        }

    }
}
