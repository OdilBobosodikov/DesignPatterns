using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_patterns.Memento
{
    internal class Hero
    {
        private int lives;
        private int ammo;
        private Memento history = new Memento(new Stack<HeroMemento>());

        public Hero(int lives, int ammo)
        {
            this.lives = lives;
            this.ammo = ammo;
        }

        public void PrintStatus()
        {
            Console.WriteLine($"{lives} lives\n{ammo} bullets");
        }

        public void Shoot()
        {
            if (ammo > 0)
            {
                ammo--;
                Console.WriteLine($"we shot an ammo!\nNow we have {ammo} bullets!");
            }
            else
            {
                Console.WriteLine("No ammo left");
            }
        }

        public void GetDammage()
        {
            lives -= 1;
            if (lives <= 0)
            {
                Console.WriteLine("Hero died. Move back to last save");
                RestoreMemento();
            }
            else
            {
                Console.WriteLine($"Damage taken. {lives} lives left!");
            }
        }

        public void SaveMemento()
        {
            history.HeroSavings.Push(new HeroMemento(lives, ammo));
            Console.WriteLine("Saved");
        }

        public void RestoreMemento()
        {
            HeroMemento heroMemento = history.HeroSavings.Pop();
            ammo = heroMemento.Ammo;
            lives = heroMemento.Lives;

            Console.WriteLine("Saving restored!");
            PrintStatus();
        }
    }
}
