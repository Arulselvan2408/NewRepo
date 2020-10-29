using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class TicketsNumberException : Exception
    {
        public TicketsNumberException(string Ex) : base(Ex)
        {

        }
    }
    class Passanger
    {
        internal string Name;
        int Age;
        internal Passanger(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
        public void TicketBooking(int Numberoftickets)
        {
            try
            {
                if (Numberoftickets>2)
                {
                    throw new TicketsNumberException("cannot book more than 2 tickets");
                }
                else
                {
                    Console.WriteLine("Tickets Booked Sucessfully");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    class Testclass
    {
        static void Main()
        {
            Passanger passanger = new Passanger("Arul", 23);
            Console.WriteLine("Enter the number of tickets to be booked");
            int NumberofTickets = Convert.ToInt32(Console.ReadLine());
            passanger.TicketBooking(NumberofTickets);
            Console.Read();

        }

    }
    class Question1
    {
       
    }
}
