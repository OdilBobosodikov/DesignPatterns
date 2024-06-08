using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_patterns.Memento
{
    internal class HeroMemento
    {
        public int Lives { get; }
        public int Ammo { get; }

        public HeroMemento(int lives, int ammo) 
        {
            Lives = lives;
            Ammo = ammo;
        }

    }
}
