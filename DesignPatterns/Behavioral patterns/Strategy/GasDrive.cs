using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_patterns.Strategy
{
    internal class GasDrive : IDrivable
    {
        public void Drive()
        {
            Console.WriteLine("Drive on gas");
        }
    }
}
