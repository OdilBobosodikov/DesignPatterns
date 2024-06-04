using DesignPatterns.Behavioral_patterns.Strategy;

namespace DesignPatterns.Behavioral_patterns.Observer
{
    internal class Broker : Observer.IObserver
    {
        public string Name { get; private set; }
        private readonly IObservable observable;

        //Since we change stock value in Update() we can't assign readonly modificator
        private StockInfo stock;

        public Broker(string name, StockInfo stock)
        {
            Name = name;
        }
        public void Update(StockInfo stockInfo)
        {
            stock = stockInfo;
            Trade();
        }

        public void Trade()
        {
            if (stock is not null)
            {
                if (stock.USD >= 50)
                {
                    Console.WriteLine($"{Name} sells all USD actives: USD = {stock.USD}");
                }
                else
                {
                    Console.WriteLine($"{Name} buys USD actives: USD = {stock.USD}");
                }

                if (stock.EUR >= 50)
                {
                    Console.WriteLine($"{Name} sells all EUR actives: EUR = {stock.USD}");
                }
                else
                {
                    Console.WriteLine($"{Name} buys EUR actives: EUR = {stock.USD}");
                }
            }
        }

        public void StopTrade()
        {
            observable.DeleteObserver(this);
            stock = null;
        }
    }
}
