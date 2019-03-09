using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class ConcreteDecoratorEx_2: AbstractDecortator
    {
        public void doJob() {

            Console.WriteLine("");
            Console.WriteLine("***START Ex-2***");
            base.doJob();
            Console.WriteLine("Explicitly From DecoratorEx_2");
            Console.WriteLine("***END. EX-2***");

                
        }
    }
}
