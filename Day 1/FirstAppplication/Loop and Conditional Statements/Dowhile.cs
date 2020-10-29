using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_and_Conditional_Statements
{
    class Dowhile
    {static void Main()
        {
            int InitialValue = 1, EndValue;
            Console.WriteLine("enter the End value");
            EndValue = Convert.ToInt32(Console.ReadLine());
            while(InitialValue>EndValue)
            {
                Console.WriteLine("Inside While");
            }
            Console.WriteLine("---------------");
            do
            {
                Console.WriteLine("initialvalue:{0}", InitialValue);
                InitialValue++;
            }
            while (InitialValue > EndValue);
            Console.ReadLine();
        }
    }
}
