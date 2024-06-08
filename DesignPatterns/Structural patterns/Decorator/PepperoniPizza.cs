using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_patterns.Decorator
{
    internal class PepperoniPizza : PizzaDecorator
    {
        public PepperoniPizza(Pizza pizza)
            : base(pizza.Name + ", with pepperoni", pizza)
        { }
        public override int GetCost()
        {
            return pizza.GetCost() + 5;
        }
    }
}
