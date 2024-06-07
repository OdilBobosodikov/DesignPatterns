using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID.S
{
    internal class Phone
    {
        public string Model { get; }
        public double Price { get; }

        public Phone(string model, double price)
        {
            Model = model;
            Price = price;
        }
    }
}
