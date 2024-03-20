using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_patterns.Factory_Method
{
    internal class TruckManufacturer : Manufacturer
    {
        public TruckManufacturer(string companyName) : base(companyName)
        {
        }
        public override Vehicle Manufacture()
        {
            return new Truck(CompanyName);
        }
    }
}
