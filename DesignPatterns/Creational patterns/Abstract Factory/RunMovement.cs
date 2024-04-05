using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_patterns.Abstract_Factory
{
    internal class RunMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Run!");
        }
    }
}
