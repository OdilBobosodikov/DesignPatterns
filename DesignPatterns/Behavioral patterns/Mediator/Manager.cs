using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_patterns.Mediator
{
    internal class Manager : Mediator
    {
        public Colleague Customer { get; set; }
        public Colleague Programmer { get; set; }
        public Colleague HR { get; set; }
        public override void Send(string msg, Colleague colleague)
        {
            if (HR.Equals(colleague))
            {
                HR.Notify(msg);
            }
            else if (Programmer.Equals(colleague))
            {
                Programmer.Notify(msg);
            }
            else if (Customer.Equals(colleague))
            {
                Customer.Notify(msg);
            }
        }
    }
}
