using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeProxy
{
    public class ProxyFactory
    {
        public ClientProxy CreateProxy(string username, string password)
        {
            if (username.Equals("admin") && password.Equals("123"))
                return new AdminProxy();
            if (username.Equals("customer") && password.Equals("123"))
                return new CustomerProxy();
            if (username.Equals("company") && password.Equals("123"))
                return new CompanyProxy();

            throw new ArgumentException($"Cannot login with this credentials!");
        }
    }
}
