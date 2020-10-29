using System;


namespace BasicEG
{
    class AdditionEg
    {
        static void Main()
        {
            int Num1 = 20, Num2 = 15, result, Substract;
            result = Num1 + Num2;
            Substract = Num1 - Num2;
            Console.WriteLine("Addition: {0}", result);
            Console.WriteLine("Subtraction:{0}", Substract);
            Console.ReadKey();
        }
    }
}
