using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_patterns.Abstract_Factory
{
    internal class Hero
    {
        private readonly Weapon weapon;
        private readonly Movement movement;

        public Hero(HeroFactory heroFactory)
        {
            weapon = heroFactory.CreateWeapon();
            movement = heroFactory.CreateMovement(); 
        }

        public void Move()
        {
            movement.Move();
        }

        public void Hit()
        {
            weapon.Hit();
        }
    }
}
