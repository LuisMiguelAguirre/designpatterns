using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command.pattern.demo
{
    class Invoke
    {
        ICommand cmd;
        public void ExecuteCommand(ICommand cmd) {
            this.cmd = cmd;
            cmd.Do();
        }
    }
}
