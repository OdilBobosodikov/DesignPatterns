using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_patterns.Decorator
{
    internal abstract class Pizza
    {
        public string Name { get; protected set; }

        public Pizza(string name)
        {
            Name = name;
        }

        public abstract int GetCost();
    }
}
