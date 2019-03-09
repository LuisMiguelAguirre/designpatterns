using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iterator;

namespace aggregate
{
    class ScienceIterator: IIterator
    {
        private LinkedList<string> subjects;
        private int position;

        public ScienceIterator(LinkedList<string> subjects)
        {
            this.subjects = subjects;
        }

        public void first()
        {
            position = 0;
        }

        public string Next()
        {
            return subjects.ElementAt(position++);
        }

        public bool IsDone()
        {
            return position >= subjects.Count;
        }

        public string CurrentItem()
        {
            return subjects.ElementAt(position);
        }
    }
}
