using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_patterns.Mediator
{
    internal class HRColleague : Colleague
    {
        public HRColleague(Mediator mediator) : base(mediator) 
        {
            
        }
        public override void Notify(string message)
        {
            Console.WriteLine("Message from HR: " + message);
        }
    }
}
