using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class Creditcard:IPayment
    {
        public string CardNumber { get; set; }
        public string Cvv { get; set; }
        public string Cardholdername { get; set; }
      
        public void ProcessPayment(double amount)
        {
            Console.WriteLine( $"The cardholder name is: {Cardholdername}" + $"The amount is: {amount}");
        }

    }
}
