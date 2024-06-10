using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID.O.CookStrategy
{
    internal class MashPotato : IMeal
    {
        public void Process(string name)
        {
            Console.WriteLine($"{name} peals potato");
            Console.WriteLine($"{name} boils potato");
            Console.WriteLine($"{name} mashes potato");
            Console.WriteLine($"{name} seasons potato");
            Console.WriteLine($"{name} serves dish");
        }
    }
}
