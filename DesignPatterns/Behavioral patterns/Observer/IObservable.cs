﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_patterns.Strategy
{
    internal interface IObservable
    {
        void RegisterObserver(Observer.IObserver observer);
        void DeleteObserver(Observer.IObserver observer);
        void NotifyObservers();
    }
}
