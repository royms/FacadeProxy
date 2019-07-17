using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeProxy
{
    public class FlightSystemFacade : IAdmin, ICompany, ICustomer
    {
        public FlightDAO FlightDB { get; set; }
        public FlightSystemFacade()
        {
            this.FlightDB = new FlightDAO();
        }
        public void CreateCustomer(string name)
        {
            this.FlightDB.InsertCustomer(name);
        }
        public void CreateCompany(string name)
        {
            this.FlightDB.InsertCompany(name);
        }
        public void CreateFlight(string name)
        {
            this.FlightDB.InsertFlight(name);
        }
        public void CancelFlight(string name)
        {
            this.FlightDB.RemoveFlight(name);
        }
        public void BuyTicket(string name)
        {
            this.FlightDB.InsertTicket(name);
        }
        public void ShowMyTickets()
        {
            Console.WriteLine("My tickets: " + this.FlightDB.GetTickets().ToString());
        }
    }
}
