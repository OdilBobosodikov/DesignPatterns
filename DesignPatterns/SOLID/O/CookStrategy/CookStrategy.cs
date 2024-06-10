using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID.O.CookStrategy
{
    internal class CookStrategy
    {
        public string Name { get; set; }
        public CookStrategy(string name)
        {
            Name = name;
        }

        public void MakeDinner(IEnumerable<IMeal> order)
        {
            foreach (IMeal meal in order)
            {
                Console.WriteLine("\nStart new dish: ");
                meal.Process(Name);
            }
        }
    }
}
