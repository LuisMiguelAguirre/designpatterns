using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Observer2: IObserver
    {
        public void update(int i)
        {
            Console.WriteLine("Observer2: observes ->myValue is changed in Subject to :" + i);
        }
    }
}
