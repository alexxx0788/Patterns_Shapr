using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer.structure
{
    interface IObservable
    {
        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }
}
