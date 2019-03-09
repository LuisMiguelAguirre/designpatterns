using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command.pattern.demo
{
    class Receiver
    {
        public void performUndo() { Console.WriteLine("Executing-MyUndoCommand"); }
        public void performRedo() { Console.WriteLine("Executing-MyRedoCommand"); }
    }
}
