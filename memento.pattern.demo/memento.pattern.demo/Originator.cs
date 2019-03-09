using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memento.pattern.demo
{
    class Originator
    {
        private string state;
        Memento m;

        public void setState(string state) {
            this.state = state;
            Console.WriteLine("State at present: {0}", state);
        }

        public Memento OriginatorMemento() {
            m = new Memento(state);
            return m;
        }

        public void Revert(Memento memento) {
            Console.WriteLine("Restoring to previous state...");
            state = memento.getState();
            Console.WriteLine("State at present: {0}", state);
        }

    }
}
