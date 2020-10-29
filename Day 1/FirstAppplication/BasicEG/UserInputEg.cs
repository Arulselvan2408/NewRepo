using System;
using System.Runtime.Remoting.Services;

namespace BasicEG
{
    class UserInputEg
    {
        static void Main()
        {
            string Name, City;
                int Age;
            Console.WriteLine("Enter your name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Your City");
            City = Console.ReadLine();
            Console.WriteLine("Enter your Age");
            Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("---------");
            Console.WriteLine("Name:{0}|| city:{1}|| age{2}", Name, City, Age);
            Console.Read();
        }
    }
}
