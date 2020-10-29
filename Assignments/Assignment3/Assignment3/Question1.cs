using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{class Customer
    {
        int CustomerID, Age, PhNumber;
        string Name, City;
        internal Customer()
        {

        }
        internal Customer(int CustomerID, string Name, int Age, int PhNumber, string City)
        {
            this.CustomerID = CustomerID;
            this.Name = Name;
            this.Age = Age;
            this.PhNumber = PhNumber;
            this.City = City;
        }
        internal void DisplayMethod()
        {
            Console.WriteLine("CustomerID:{0}\nName:{1}\nAge:{2}\nPhNumber:{3}\nCity:{4}\n", CustomerID, Name, Age,PhNumber,City);
        }
    }
    class Question1
    {
        static void Main()
        {
            Customer cus = new Customer(101, "Arul", 23, 1234567890, "Trichy");
            cus.DisplayMethod();
            Console.Read();
            
        }
    }
}
