using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_patterns.State
{
    internal class GasWaterState : IWaterState
    {
        void IWaterState.Freeze(Water water)
        {
            Console.WriteLine("Steam's become water");
            water.State = new LiquidWaterState();
        }

        void IWaterState.Heat(Water water)
        {
            Console.WriteLine("Steam stays steam");
        }
    }
}
