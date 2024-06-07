using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_patterns.State
{
    internal class LiquidWaterState : IWaterState
    {
        public void Freeze(Water water)
        {
            Console.WriteLine("Water's become ice");
            water.State = new SolidWaterState();
        }

        public void Heat(Water water)
        {
            Console.WriteLine("Water's become steam");
            water.State = new GasWaterState();
        }
    }
}
