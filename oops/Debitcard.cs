using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class Debitcard: IPayment
    {
        public string CardNumber { get; set; }
        public string CardHolderName { get; set; }
       
      
        public void ProcessPayment(double amount)
        {
            Console.WriteLine( $"The cardholder name is: {CardHolderName}" + $"The amount is: {amount}");
        }
    }
}
