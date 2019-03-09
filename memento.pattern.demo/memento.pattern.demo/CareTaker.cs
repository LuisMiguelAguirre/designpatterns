using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memento.pattern.demo
{
    class CareTaker
    {
        private Memento _memento;

        public void SaveMemento(Memento m) {
            _memento = m;
        }

        public Memento RetrieveMemento() {
            return _memento;
        }
    }
}
