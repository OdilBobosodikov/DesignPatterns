using DesignPatterns.SOLID.O.CookStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID.O.CooktTmplate
{
    internal class CookTemplate
    {
        public string Name { get; set; }
        public CookTemplate(string name)
        {
            this.Name = name;
        }

        public void MakeDinner(IEnumerable<MealBase> order)
        {
            foreach (MealBase meal in order)
            {
                Console.WriteLine("\nStart new dish: ");
                meal.Process(Name);
            }
        }
    }
}
