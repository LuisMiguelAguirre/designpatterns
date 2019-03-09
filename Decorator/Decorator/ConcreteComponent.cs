using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class ConcreteComponent: Component
    {

        public override void doJob()
        {
            Console.WriteLine("I am from Concrete Component -I am closed for modification.");
        }
    }
}
