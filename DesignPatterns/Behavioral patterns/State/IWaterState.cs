using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_patterns.State
{
    internal interface IWaterState
    {
        void Heat(Water water);
        void Freeze(Water water);
    }
}
