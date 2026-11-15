using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // inheritance
            /*Car car = new Car();
            car.Speed = "120 km/h";
            car.Model = "Sedan";

            car.Showspeed();
            car.ShowModel();*/

            // polymorphism

            /* PaymentDetails paymentDetails = new PaymentDetails();
             paymentDetails.ShowPaymentDetails("1234-5678-9012-3456", "John Doe", "1234");
             paymentDetails.ShowPaymentDetails("9876-5432-1098-7654", "Jane Smith");
             paymentDetails.ShowPaymentDetails(100.0);*/

            // abstraction

            Creditcard creditcard = new Creditcard();
            creditcard.CardNumber = "1234-5678-9012-3456";
            creditcard.Cvv = "123";
            creditcard.Cardholdername = "John Doe";
            creditcard.ProcessPayment(100.0);
            Debitcard debitcard = new Debitcard();
            debitcard.CardNumber = "9876-5432-1098-7654";
            debitcard.CardHolderName = "Jane Smith";
            debitcard.ProcessPayment(200.0);
            UPI upi = new UPI();
            upi.Upiid = "john.doe@upi"; 
            upi.ProcessPayment(300.0);

            Console.ReadLine();
        }
    }
}
