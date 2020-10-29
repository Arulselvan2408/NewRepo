using System;


namespace Loop_and_Conditional_Statements
{
    class AreaCalculation
    {
        static void Main()
        {
            int Side, Length, Breadth;
            Console.WriteLine("Enter the side of Square");
            Side = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the length of the Rectangle");
            Length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Breadth of the Rectangle");
            Breadth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Area of square={0}", Side * Side);
            Console.WriteLine("Areaof Rectangle={0}", Length * Breadth);
            Console.Read();

        }

    }
}
