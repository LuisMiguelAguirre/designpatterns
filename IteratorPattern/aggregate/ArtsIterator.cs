using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iterator;

namespace aggregate
{
    class ArtsIterator: IIterator
    {
        private string[] subjects;
        private int position;
        public ArtsIterator(string[] subjects)
        {
            this.subjects = subjects;
            position = 0;
        }

        public void first()
        {
            position = 0;
        }

        public string Next()
        {
            return subjects[position++];
        }

        public bool IsDone()
        {
            return position >= subjects.Length;
        }

        public string CurrentItem()
        {
            throw new NotImplementedException();
        }
    }
}
