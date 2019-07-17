using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeProxy
{
    public class CompanyProxy : ClientProxy, ICompany
    {
        public CompanyProxy() : base()
        {

        }
        public void CancelFlight(string name)
        {
            this.FSF.CancelFlight(name);
        }

        public void CreateFlight(string name)
        {
            this.FSF.CreateFlight(name);
        }
    }
}
