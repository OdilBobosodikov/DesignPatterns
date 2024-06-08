using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_patterns.Chain_of_responsobility
{
    internal class Receiver
    {
        public bool BankTransfer { get; }
        public bool CashTransfer { get; }
        public bool PaymeTransfer { get; }

        public Receiver(bool bankTransfer, bool cashTransfer, bool paymeTransfer)
        {
            BankTransfer = bankTransfer;
            CashTransfer = cashTransfer;
            PaymeTransfer = paymeTransfer;
        }
    }
}
