using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeProxy
{
    public class ClientProxy
    {
        public FlightSystemFacade FSF { get; set; }

        public ClientProxy()
        {
            if (this.FSF == null)
            {
                this.FSF = new FlightSystemFacade();
            }
        }
    }
}
