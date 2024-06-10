using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_patterns.Facade
{
    internal class CLR
    {
        public void Execute()
        {
            Console.WriteLine("Run program");
        }

        public void Finish()
        {
            Console.WriteLine("Finish run");
        }
    }
}
