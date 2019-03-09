using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command.pattern.demo
{
    class MyUndoCommand: ICommand   
    {
        private Receiver receiver;
        public MyUndoCommand(Receiver recv)
        {
            receiver = recv;
        }

        public void Do()
        {
            receiver.performUndo();
        }
    }
}
