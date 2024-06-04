using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_patterns.Command
{
    internal class Microwave
    {
        public async Task Heat(int sec, CancellationToken cancellation)
        {
            await Console.Out.WriteLineAsync("Start heating!");
            await Task.Delay(sec * 1000, cancellation);
            StopCooking();
        }

        public void StopCooking()
        {
            Console.WriteLine("Beep Beep Beep!");
        }
    }
}
