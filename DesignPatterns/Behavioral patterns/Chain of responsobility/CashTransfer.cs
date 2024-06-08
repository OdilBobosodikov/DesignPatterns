namespace DesignPatterns.Behavioral_patterns.Chain_of_responsobility
{
    internal class CashTransfer : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.CashTransfer)
            {
                Console.WriteLine("Handle cash operation!");
            }

            if (paymentHandler is not null)
            {
                paymentHandler.Handle(receiver);
            }
        }
    }
}