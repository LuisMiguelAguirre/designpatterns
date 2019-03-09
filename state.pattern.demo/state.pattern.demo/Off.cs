using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state.pattern.demo
{
    class Off: RemoteControl
    {

        public override void pressSwitch(TV context)
        {
            Console.WriteLine("I am off. Going to be On now");
            context.state = new On();
        }
    }
}
