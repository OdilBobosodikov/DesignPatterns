using DesignPatterns.Behavioral_patterns.Strategy;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_patterns.Observer
{
    internal class Bank : Observer.IObserver
    {
        public string Name { get; private set;  }

        private readonly IObservable observable;
        private StockInfo stockInfo;

        public Bank(string name, IObservable observable, StockInfo stockInfo)
        {
            Name = name;
            this.observable = observable;
            this.stockInfo = stockInfo;

            this.observable.RegisterObserver(this);
        }

        public Bank(string name, StockInfo stockInfo)
        {
            Name = name;
            this.stockInfo = stockInfo;
        }

        public void Update(StockInfo stockInfo)
        {
            this.stockInfo = stockInfo;
            Trade();
        }

        public void Trade()
        {
            if (stockInfo is not null)
            {
                if (stockInfo.USD >= 50)
                {
                    Console.WriteLine($"{Name} sells all USD actives: USD = {stockInfo.USD}");
                }
                else
                {
                    Console.WriteLine($"{Name} buys USD actives: USD = {stockInfo.USD}");
                }

                if (stockInfo.EUR >= 50)
                {
                    Console.WriteLine($"{Name} sells all EUR actives: EUR = {stockInfo.USD}");
                }
                else
                {
                    Console.WriteLine($"{Name} buys EUR actives: EUR = {stockInfo.USD}");
                }
            }
        }

        public void StopTrade()
        {
            observable.DeleteObserver(this);
            stockInfo = null;
        }
    }
}
