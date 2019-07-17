using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeProxy
{
    public class CustomerProxy : ClientProxy, ICustomer
    {
        public CustomerProxy() : base()
        {
        }
        public void BuyTicket(string ticketName)
        {
            this.FSF.BuyTicket(ticketName);
        }
        public void ShowMyTickets()
        {
            this.FSF.ShowMyTickets();
        }
    }
}
