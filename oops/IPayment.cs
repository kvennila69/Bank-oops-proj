using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public interface IPayment
    {
        void ProcessPayment(double amount); //abstraction
    }
}
