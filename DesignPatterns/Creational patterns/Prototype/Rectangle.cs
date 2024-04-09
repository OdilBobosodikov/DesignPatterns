using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_patterns.Prototype
{
    internal class Rectangle : IFigure
    {
        private readonly int height;
        private readonly int width;
        
        public Rectangle(int height, int width) 
        {
            this.height = height;
            this.width = width;
        }
        public IFigure Clone()
        {
            return new Rectangle(this.height, this.width);
        }

        public void GetInfo()
        {
            Console.WriteLine($"Rectangle with {height} height with {width} width");
        }
    }
}
