using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    interface Icar
    {
        string Brake();
        string Engine();

    }
    class Benz : Icar
    {
        public string Brake()
        {
            return "BenzBrake";
        }

        public string Engine()
        {
            return "BenzEngine";
        }
        internal void BenzFunctionality()
        {
            Console.WriteLine("Brake: {0}\nEngine: {1}", Brake(), Engine());
        }
    }
    class Toyoto : Icar
    {
        public string Brake()
        {
            return "ToyotoBrake";
        }

        public string Engine()
        {
            return "ToyotoEngine";
        }
        internal void ToyotoFunctionality()
        {
            Console.WriteLine("Brake: {0}\nEngine :{1}", Brake(), Engine());
        }
       

    }
    
    class Question_3
    {
        static void Main()
        {
            Benz benz = new Benz();
            benz.BenzFunctionality();
            Toyoto toyoto = new Toyoto();
            toyoto.ToyotoFunctionality();
            Console.Read();
        }

    }
}
