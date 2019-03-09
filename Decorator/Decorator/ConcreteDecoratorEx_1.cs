using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class ConcreteDecoratorEx_1: AbstractDecortator
    {
        public void doJob() {
            base.doJob();
            Console.WriteLine("I am explicitly from Ex_1");
        }
    }
}
