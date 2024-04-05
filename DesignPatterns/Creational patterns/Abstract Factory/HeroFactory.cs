using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_patterns.Abstract_Factory
{
    abstract internal class HeroFactory
    {
        public abstract Weapon CreateWeapon();
        public abstract Movement CreateMovement();
    }
}
