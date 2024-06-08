using DesignPatterns.Behavioral_patterns.Chain_of_responsobility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_patterns
{
    internal abstract class PaymentHandler
    {
        public PaymentHandler? paymentHandler { get; set; }
        public abstract void Handle(Receiver receiver);
    }
}
