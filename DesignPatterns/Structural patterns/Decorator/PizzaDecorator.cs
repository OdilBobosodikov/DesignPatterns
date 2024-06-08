using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_patterns.Decorator
{
    internal abstract class PizzaDecorator : Pizza
    {
        protected Pizza pizza;
        public PizzaDecorator(string n, Pizza pizza) : base(n)
        {
            this.pizza = pizza;
        }
    }
}
