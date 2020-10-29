// Header File in .Net we call this as Namespace
using System;

namespace BasicEG
{
    class HelloWorldEg
    {
        static void Main()
        {
            // to print in console Window
            Console.WriteLine("Hello World!");
            // Print your Name
            string Myname = "Arulselvan", FatherName = "Balasubramanian";
                Console.WriteLine("Myname:"+Myname);
            Console.WriteLine("-----------");
            //place holder
            Console.WriteLine("Place Holder");
            Console.WriteLine("Myname:{0}", Myname);
            Console.WriteLine("Myname:{0} {1}", Myname, FatherName);

            // to read from console Window
            Console.Read();
        }
    }
}
