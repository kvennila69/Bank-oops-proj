using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    internal class Car:Vehicle //inheritance
    {
        public string Model { get; set; }

        public void ShowModel()
        {
            Console.WriteLine($"The model of the car is: {Model}");
        }
    }
}
