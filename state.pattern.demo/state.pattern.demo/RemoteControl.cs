using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state.pattern.demo
{
    abstract class RemoteControl
    {
        public abstract void pressSwitch(TV context);
    }
}
