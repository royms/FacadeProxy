using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeProxy
{
    public interface ICompany
    {
        void CreateFlight(string name);
        void CancelFlight(string name);
    }
}
