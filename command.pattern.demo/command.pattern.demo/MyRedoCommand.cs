using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command.pattern.demo
{
    class MyRedoCommand: ICommand
    {
        private Receiver receiver;
        public MyRedoCommand(Receiver recv)
        {
            receiver = recv;
        }

        public void Do()
        {
            receiver.performRedo();
        }
    }
}
