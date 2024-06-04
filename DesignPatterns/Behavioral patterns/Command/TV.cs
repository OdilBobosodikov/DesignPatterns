using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_patterns.Command
{
    internal class TV
    {
        public void On()
        {
            Console.WriteLine("TV is ON");
        }

        public void Off() 
        {
            Console.WriteLine("TV is Off");
        }
    }
}
