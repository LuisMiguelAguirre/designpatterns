using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Observer1: IObserver
    {

        public void update(int i)
        {
            Console.WriteLine("Observer1: myValue in Subject is now: "+i);    
        }
    }
}
