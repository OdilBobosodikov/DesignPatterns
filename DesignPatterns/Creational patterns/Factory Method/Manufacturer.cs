using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_patterns.Factory_Method
{
    abstract public class Manufacturer
    {
        public string CompanyName { get; }

        public Manufacturer(string companyName)
        {
            CompanyName = companyName;
        }

        abstract public Vehicle Manufacture();
    }
}
