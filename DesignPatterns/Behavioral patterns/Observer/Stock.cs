using DesignPatterns.Behavioral_patterns.Observer;
using DesignPatterns.Behavioral_patterns.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_patterns
{
    internal class Stock : IObservable
    {
        private readonly StockInfo StockInfo;
        public List<IObserver> Observers { get; private set; }

        public Stock(StockInfo stockInfo, List<IObserver> observers)
        {
            StockInfo = stockInfo;
            Observers = observers;
        }

        public Stock(StockInfo stockInfo)
        {
            StockInfo = stockInfo;
        }

        public void DeleteObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in Observers)
            {
                observer.Update(StockInfo);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void MarketChanges()
        {
            Random random = new Random();
            StockInfo.EUR = random.Next(20, 80) * random.NextDouble();
            StockInfo.USD = random.Next(20, 80) * random.NextDouble();
        }
    }
}
