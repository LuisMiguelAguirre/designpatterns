using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aggregate
{
    public class Science: ISubject
    {
        private LinkedList<string> subjects;

        public Science()
        {
            subjects = new LinkedList<string>();
            subjects.AddLast("Math");
            subjects.AddLast("Comp. Sc.");
            subjects.AddLast("Physics");
        }



        public iterator.IIterator CreateIterator()
        {
            return new ScienceIterator(subjects);
        }
    }
}
