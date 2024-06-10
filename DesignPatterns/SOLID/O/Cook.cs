using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID.I
{
    internal class Cook
    {

        //Bad architecture
        public string Name { get; set; }
        public Cook(string name)
        {
            Name = name;
        }

        public void MakeDinner()
        {
            Console.WriteLine($"{Name} peals potato");
            Console.WriteLine($"{Name} boils potato");
            Console.WriteLine($"{Name} mashes potato");
            Console.WriteLine($"{Name} seasons potato");
            Console.WriteLine($"{Name} serves dish");
        }


        //To achieve Open/Close principle we can use:

        //Strategy pattern or Template method


    }
}
