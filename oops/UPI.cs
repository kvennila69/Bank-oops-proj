using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class UPI: IPayment
    {
        public string Upiid { get; set; }
       

        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"The UPI id is: {Upiid}" + $"The amount is: {amount}");
        }
    }

}
