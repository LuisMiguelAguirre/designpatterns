using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state.pattern.demo
{
    class TV
    {
        public RemoteControl state { get; set; }

        public TV(RemoteControl state)
        {
            this.state = state;
        }

        public void pressButton() {
            state.pressSwitch(this);
        }


    }
}
