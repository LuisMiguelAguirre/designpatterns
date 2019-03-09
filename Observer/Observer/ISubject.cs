using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    interface ISubject
    {
        void register(IObserver o);
        void unregister(IObserver o);
        void notifyObservers(int i);
    }
}
