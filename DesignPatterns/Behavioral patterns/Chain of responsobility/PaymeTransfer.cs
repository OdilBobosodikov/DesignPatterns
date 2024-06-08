namespace DesignPatterns.Behavioral_patterns.Chain_of_responsobility
{
    internal class PaymeTransfer : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.PaymeTransfer)
            {
                Console.WriteLine("Handle payme operation!");
            }

            if (paymentHandler is not null)
            {
                paymentHandler.Handle(receiver);
            }
        }
    }
}