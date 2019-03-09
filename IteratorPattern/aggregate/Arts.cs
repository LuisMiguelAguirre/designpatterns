using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iterator;

namespace aggregate
{
    public class Arts: ISubject
    {
        private string[] subjects;

        public Arts()
        {
            subjects = new string[2];
            subjects[0]= "Bengali";
            subjects[1]= "English";
        }

        public IIterator CreateIterator()
        {
            return new ArtsIterator(subjects);
        }
    }
}
