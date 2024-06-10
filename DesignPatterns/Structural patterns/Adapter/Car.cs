using DesignPatterns.Behavioral_patterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_patterns.Adapter
{
    internal class Car : ITransport
    {
        public void Drive()
        {
            Console.WriteLine("Using Car");
        }
    }
}
