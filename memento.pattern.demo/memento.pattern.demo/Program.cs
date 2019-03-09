using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memento.pattern.demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Memento Pattern Demo***");
            Originator o = new Originator();
            o.setState("First state");

            //Holding old state
            CareTaker c = new CareTaker();
            c.SaveMemento(o.OriginatorMemento());

            //Changin state
            o.setState("Second state");

            //Restore saved state
            o.Revert(c.RetrieveMemento());

            Console.ReadLine();

        }
    }
}
