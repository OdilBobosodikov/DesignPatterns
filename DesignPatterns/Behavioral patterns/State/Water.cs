using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_patterns.State
{
    internal class Water
    {
        public IWaterState State { get; set; }

        public Water(IWaterState state)
        {
            State = state;
        }

        public Water()
        {
            State = new LiquidWaterState();
        }

        public void Heat()
        {
            State.Heat(this);
        }

        public void Freeze()
        {
            State.Freeze(this);
        }
    }
}
