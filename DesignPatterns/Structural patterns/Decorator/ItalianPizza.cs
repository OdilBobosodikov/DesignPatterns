using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_patterns.Decorator
{
    internal class ItalianPizza : Pizza
    {
        public ItalianPizza() : base("Italian pizza")
        {
        }

        public override int GetCost()
        {
            return 10;
        }
    }
}
