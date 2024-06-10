using DesignPatterns.SOLID.O.CooktTmplate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID.O.CookTmplate
{
    internal class SaladMeal : MealBase
    {
        public override void Cook()
        {
            Console.WriteLine($"{name} cuts them into pieces");
            Console.WriteLine($"{name} adds them into bowl");
            Console.WriteLine($"{name} seasons salad");

        }

        public override void Prepare()
        {
            Console.WriteLine($"{name} washes vegetables");
        }

        public override void Serve()
        {
            Console.WriteLine($"{name} serves dish");
        }
    }
}
