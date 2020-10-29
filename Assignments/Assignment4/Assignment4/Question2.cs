using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Employee
    {
        protected int Empid;
        protected string Empname;
        protected float Salaryperhour;
        internal Employee(int Empid, string Empname, float Salaryperhour)
        {
            this.Empid = Empid;
            this.Empname = Empname;
            this.Salaryperhour = Salaryperhour;
        }
      
    }
    class ParttimeEmployee:Employee
    {
        int Hoursofworking;
        internal ParttimeEmployee(int Empid, string Empname, float Salaryperhour, int Hoursofworking):base(Empid,Empname, Salaryperhour)
        {
            this.Hoursofworking = Hoursofworking;
        }
        internal float calculatesalary()
        {
            return Salaryperhour * Hoursofworking;
        }
       internal  void Display()
        {
            Console.WriteLine("Empid: {0}\nEmpname: {1}\nSalary per Hour: {2}\nTotalSalary: {3}", Empid, Empname, Salaryperhour, calculatesalary());
        }
    }
    
    class Question2
    {
        static void Main()
        {
            ParttimeEmployee parttimeEmployee = new ParttimeEmployee(101,"Arul",449.99f,9);
            parttimeEmployee.Display();
            Console.Read();
        }
    }
}
