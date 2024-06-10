using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DesignPatterns.SOLID.O.CookStrategy
{
    internal class Salad : IMeal
    {
        public void Process(string name)
        {
            Console.WriteLine($"{name} washes vegetables");
            Console.WriteLine($"{name} cuts them into pieces");
            Console.WriteLine($"{name} adds them into bowl");
            Console.WriteLine($"{name} seasons salad");
            Console.WriteLine($"{name} serves dish");
        }
    }
}
