using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_patterns.Decorator
{
    internal class CheesePizza : PizzaDecorator
    {
        public CheesePizza(Pizza pizza) : base(pizza.Name + " with extra cheese", pizza)
        {
            
        }
        public override int GetCost()
        {
            return pizza.GetCost() + 3;
        }
    }
}
