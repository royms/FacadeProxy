using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeProxy
{
    public class FlightDAO
    {
        public List<string> Tickets { get; set; }
        public List<string> Filghts { get; set; }
        public List<string> Customers { get; set; }
        public List<string> Companies { get; set; }
        public FlightDAO()
        {
            this.Tickets = new List<string>();
            this.Filghts = new List<string>();
            this.Customers = new List<string>();
            this.Companies = new List<string>();
        }
        public void InsertTicket(string ticketName)
        {
            this.Tickets.Add(ticketName);
            Console.WriteLine("Ticket " + ticketName + " inserted to DB");
        }
        public List<string> GetTickets()
        {
            return this.Tickets;
        }
        public void InsertFlight(string flightName)
        {
            this.Filghts.Add(flightName);
            Console.WriteLine("Flight " + flightName + " inserted to DB");
        }
        public void RemoveFlight(string flightName)
        {
            this.Filghts.Remove(flightName);
            Console.WriteLine("Flight " + flightName + " removed from DB");
        }
        public void InsertCustomer(string name)
        {
            this.Customers.Add(name);
            Console.WriteLine("Customer " + name + " inserted to DB");
        }
        public void InsertCompany(string name)
        {
            this.Companies.Add(name);
            Console.WriteLine("Company " + name + " inserted to DB");
        }
    }
}
