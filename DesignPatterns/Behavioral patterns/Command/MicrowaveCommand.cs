using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_patterns.Command
{
    internal class MicrowaveCommand : ICommand
    {
        private readonly Microwave microwave;
        private readonly int time;
        private readonly CancellationTokenSource cancellationTokenSource;


        public MicrowaveCommand(Microwave microwave, int time, CancellationTokenSource cancellationTokenSource)
        {
            this.microwave = microwave;
            this.time = time;
            this.cancellationTokenSource = cancellationTokenSource;
        }

        public void Undo()
        {
            cancellationTokenSource.Cancel();
            microwave.StopCooking();
        }

        void ICommand.Execute()
        {
            microwave.Heat(time, cancellationTokenSource.Token);
        }
    }
}
