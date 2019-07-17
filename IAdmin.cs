using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeProxy
{
    public interface IAdmin
    {
        void CreateCustomer(string name);
        void CreateCompany(string name);
    }
}
