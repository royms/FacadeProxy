using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientProxy customer = (new ProxyFactory()).CreateProxy("customer", "123");
            customer.FSF.BuyTicket("ticket1");

            ClientProxy admin = (new ProxyFactory()).CreateProxy("admin", "123");
            admin.FSF.CreateCustomer("customer1");

            ClientProxy company = (new ProxyFactory()).CreateProxy("company", "123");
            company.FSF.CreateFlight("flight1");

            customer.FSF.ShowMyTickets();
        }
    }
}
