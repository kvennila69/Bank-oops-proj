using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    internal class PaymentDetails // polimorphism - method overloading
    {
        public void ShowPaymentDetails(string cardnumber, string cardholdername,string pinnumber)
        {
            Console.WriteLine("Debit card payment details:");
            Console.WriteLine("Card Number: " + cardnumber);
            Console.WriteLine("Card Holder Name: " + cardholdername);
            Console.WriteLine("PIN Number: " + pinnumber);
        }
        public void ShowPaymentDetails(string cardnumber, string cardholdername)
        {
            Console.WriteLine("Credit card payment details:");
            Console.WriteLine("Card Number: " + cardnumber);
            Console.WriteLine("Card Holder Name: " + cardholdername);
        }

        public void ShowPaymentDetails(double cashamount)
        {
            Console.WriteLine("Cash payment details:");
            Console.WriteLine("Payment made in cash.");
        }
    }
}
