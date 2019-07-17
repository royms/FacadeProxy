using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeProxy
{
    public class AdminProxy : ClientProxy, IAdmin
    {
        public AdminProxy() : base()
        {

        }
        public void CreateCompany(string name)
        {
            this.FSF.CreateCompany(name);
        }

        public void CreateCustomer(string name)
        {
            this.CreateCustomer(name);
        }
    }
}
