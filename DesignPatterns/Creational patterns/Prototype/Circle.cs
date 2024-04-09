using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_patterns.Prototype
{
    internal class Circle : IFigure
    {
        private readonly int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public IFigure Clone()
        {
            return new Circle(radius);
        }

        public void GetInfo()
        {
            Console.WriteLine($"Circle with {radius} radius");
        }
    }
}
