using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_patterns.Factory_Method
{
    internal class Truck : Vehicle
    {
        public Truck(string manufacturerName) : base(manufacturerName)
        { }

        public override string ToString() 
        {
            return $"this is truck: {ManufacturerName}";
        }
    }
}
