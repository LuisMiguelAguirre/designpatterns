using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Subject:ISubject
    {
        List<IObserver> observerList = new List<IObserver>();
        private int flag;

        public int Flag{
            get {
                return flag;
            }
            set {
                flag = value;
                notifyObservers(flag);
            }
        }

        public void register(IObserver o)
        {
            observerList.Add(o);
        }

        public void unregister(IObserver o)
        {
            observerList.Remove(o);
        }

        public void notifyObservers(int flag)
        {
            observerList.ForEach((IObserver o) => { o.update(flag); });
        }


        
       
        


    }
}
