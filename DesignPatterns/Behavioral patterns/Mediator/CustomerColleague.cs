using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_patterns.Mediator
{
    internal class CustomerColleague : Colleague
    {

        public CustomerColleague(Mediator mediator) : base (mediator) 
        {
            
        }

        public override void Notify(string message)
        {
            Console.WriteLine("Message from customer: " + message);
        }
    }
}
