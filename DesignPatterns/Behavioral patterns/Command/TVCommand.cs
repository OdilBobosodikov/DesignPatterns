using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_patterns.Command
{
    internal class TVCommand : ICommand
    {
        private readonly TV tv;

        public TVCommand(TV tv)
        {
            this.tv = tv;
        }

        public void Execute()
        {
            tv.On();
        }

        public void Undo()
        {
            tv.Off();
        }
    }
}
