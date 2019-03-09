using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iterator;

namespace aggregate
{
    public interface ISubject
    {
        IIterator CreateIterator();
    }
}
