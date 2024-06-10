using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_patterns.Adapter
{
    internal class Horse : IAnimal
    {
        public void Move()
        {
            Console.WriteLine("Using Horse");
        }
    }
}
