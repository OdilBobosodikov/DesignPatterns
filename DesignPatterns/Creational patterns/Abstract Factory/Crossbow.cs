using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_patterns.Abstract_Factory
{
    internal class Crossbow : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Shoot the arrow");
        }
    }
}
