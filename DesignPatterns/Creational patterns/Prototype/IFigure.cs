using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_patterns.Prototype
{
    internal interface IFigure
    {
        IFigure Clone();
        void GetInfo();
    }
}
