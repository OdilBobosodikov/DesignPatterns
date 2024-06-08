using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_patterns.Memento
{
    internal class Memento
    {
        public Stack<HeroMemento> HeroSavings { get; set; }

        public Memento(Stack<HeroMemento> heroMementos)
        {
            HeroSavings = heroMementos;
        }
    }
}
