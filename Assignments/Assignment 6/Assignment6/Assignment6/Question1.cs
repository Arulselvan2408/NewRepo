using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Services;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{  
    class Question1
    {
        static void Main()
        {
            int AvailableTickets = 300;
            string TrainName = "Cheran Express";
            int TrainNumber = 123456;
            int opt;

           
            do
            {
                Console.WriteLine("welcome to Ticket Booking");
                Console.WriteLine("Press 1 to see the AvailableTickets\nPress 2 to Book tickets\nPress 3 to exit");
                opt = Convert.ToInt32(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        {
                            Console.WriteLine("TrainName: {0}, AvailableTickets: {1}", TrainName, AvailableTickets);
                            
                    break;
                        }
                    case 2:
                        {
                            
                            Console.WriteLine("Please Enter the Number of Tickets to be Booked");
                            int NoofTickets = Convert.ToInt32(Console.ReadLine());
                            try
                            {
                                if (NoofTickets > 2)
                                {
                                    Console.WriteLine("Sorry! you cannot book more than 2 tickets");
                                }
                                if (NoofTickets == 0)
                                {
                                    Console.WriteLine("Sorry you cannot book Zero Tickets");
                                }
                                else if (NoofTickets == 1)
                                {
                                    Console.WriteLine("Enter the PassengerName1");
                                    string passengerName1 = Console.ReadLine();
                                    Console.WriteLine("Your Ticket has been Booked");
                                    Console.WriteLine("Name: {0}", passengerName1);
                                    Console.WriteLine("TrainNumber: {0}", TrainNumber);
                                    AvailableTickets = AvailableTickets - 1;
                                }
                                  
                                else
                                {
                                    Console.WriteLine("Enter the PassengerName1");
                                    string passengerName1 = Console.ReadLine();
                                    Console.WriteLine("Enter the PassengerName2");
                                    string passengerName2 = Console.ReadLine();
                                    Console.WriteLine("Your Ticket has been Booked");
                                    Console.WriteLine("Passenger1: {0}\nPassenger2: {1}", passengerName1, passengerName2);
                                    Console.WriteLine("TrainNumber: {0}", TrainNumber);
                                    AvailableTickets = AvailableTickets - 2;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Thank You! Please Visit Again");
                    break;
                        }
                    default:
                        {
                            Console.WriteLine("Please enter the Valid Input");
                    break;
                        }
                }
            } while (opt != 3);
            Console.Read();
            
        }
    }
}
