using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state.pattern.demo
{
    class On: RemoteControl
    {
        public override void pressSwitch(TV context)
        {
            Console.WriteLine("I am On. Going to be Off now");
            context.state = new Off();
        }
    }
}
