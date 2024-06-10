using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID.O.CooktTmplate
{
    internal class PotatoMeal : MealBase
    {
        public override void Cook()
        {
            Console.WriteLine($"{name} mashes potato");
            Console.WriteLine($"{name} seasons potato");
        }

        public override void Prepare()
        {
            Console.WriteLine($"{name} peals potato");
            Console.WriteLine($"{name} boils potato");
        }

        public override void Serve()
        {
            Console.WriteLine($"{name} serves dish");
        }
    }
}
