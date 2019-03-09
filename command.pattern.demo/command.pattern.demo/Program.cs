using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command.pattern.demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Command Pattern Demo***");
            Receiver intendenreceiver = new Receiver();
            MyUndoCommand unCmd = new MyUndoCommand(intendenreceiver);
            MyRedoCommand reCmd = new MyRedoCommand(intendenreceiver);
            
            Invoke inv = new Invoke();
            inv.ExecuteCommand(unCmd);
            inv.ExecuteCommand(reCmd);

            Console.ReadLine();
        }
    }
}
