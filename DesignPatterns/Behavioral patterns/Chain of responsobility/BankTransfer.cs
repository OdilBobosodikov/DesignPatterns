namespace DesignPatterns.Behavioral_patterns.Chain_of_responsobility
{
    internal class BankTransfer : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.BankTransfer)
            {
                Console.WriteLine("Handle bank operation!");
            }

            if(paymentHandler is not null)
            {
                paymentHandler.Handle(receiver);
            }
        }
    }
}