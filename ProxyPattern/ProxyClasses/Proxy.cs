using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OriginalClasses;

namespace ProxyClasses
{
    public class Proxy:Subject
    {
        ConcreteSubject cs;
        public override void doSomeWork()
        {
            Console.WriteLine("Proxy call happening now");

            if (cs == null)
            {
                cs = new ConcreteSubject();
            }

            cs.doSomeWork();
        }


    }
}
