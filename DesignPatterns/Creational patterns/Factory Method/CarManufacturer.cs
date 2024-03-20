using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_patterns.Factory_Method
{
    internal class CarManufacturer : Manufacturer
    {
        public CarManufacturer(string companyName) : base(companyName)
        {
            
        }
        public override Vehicle Manufacture()
        {
            return new Car(CompanyName);
        }
    }
}
