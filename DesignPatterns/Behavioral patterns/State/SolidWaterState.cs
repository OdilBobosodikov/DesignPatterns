using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_patterns.State
{
    internal class SolidWaterState : IWaterState
    {
        public void Freeze(Water water)
        {
            Console.WriteLine("Ice stays ice");
        }

        public void Heat(Water water)
        {
            Console.WriteLine("Ice's become water");
            water.State = new LiquidWaterState();
        }
    }
}
